using System.Security.Claims;
using conectaOng.Data;
using conectaOng.Models;
using conectaOng.Models.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.Blazor;

namespace conectaOng.Controllers
{
    public class EventController : Controller
    {
        private readonly ApplicationDbContext dbContext;

        public EventController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        // Listar eventos (página pública)
        [HttpGet]
        public async Task<IActionResult> List(string searchTitle = null, string searchLocation = null)
        {
            var query = dbContext.Event
                .Include(e => e.Organization)
                .Where(e => e.Date >= DateTime.Today)
                .AsQueryable();

            if (!string.IsNullOrEmpty(searchTitle))
                query = query.Where(e => e.Title.Contains(searchTitle));

            if (!string.IsNullOrEmpty(searchLocation))
                query = query.Where(e => e.Location.Contains(searchLocation));

            var events = await query.ToListAsync();

            // Lógica para ViewBag.IsOng (mantenha como já está)
            bool isOng = false;
            if (User.Identity.IsAuthenticated)
            {
                var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
                if (!string.IsNullOrEmpty(userId))
                {
                    isOng = await dbContext.Organization.AnyAsync(o => o.UserId.ToString() == userId);
                }
            }
            ViewBag.IsOng = isOng;

            return View(events);
        }

        [HttpGet]
        public async Task<IActionResult> Details(Guid id)
        {
            var evt = await dbContext.Event
                .Include(e => e.Organization)
                .FirstOrDefaultAsync(e => e.Id == id);

            if (evt == null)
                return NotFound();

            // Verifica se o usuário autenticado é o dono da ONG
            var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
            bool isOwner = evt.Organization.UserId.ToString() == userId;

            List<Volunteer> volunteers = null;
            if (isOwner)
            {
                volunteers = await dbContext.Vacancy
                    .Where(v => v.EventId == id)
                    .Include(v => v.Volunteer)
                    .ThenInclude(vol => vol.User)
                    .Select(v => v.Volunteer)
                    .ToListAsync();
            }

            ViewBag.IsOwner = isOwner;
            ViewBag.Volunteers = volunteers;

            return View(evt);
        }


        // Criar evento (restrito à organização autenticada)
        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Add()
        {
            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Login", "User");
            }

            // Obter o UserId do usuário autenticado
            var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;

            if (string.IsNullOrEmpty(userId))
            {
                return RedirectToAction("AccessDenied", "User"); // Redirecionar para a página de acesso negado
            }

            // Verificar se o usuário autenticado é uma organização
            var organization = await dbContext.Organization
                .FirstOrDefaultAsync(o => o.UserId.ToString() == userId);

            if (organization == null)
            {
                return RedirectToAction("AccessDenied", "User"); // Redirecionar para a página de acesso negado
            }

            // Passar o ID da organização para a view
            ViewBag.OrganizationId = organization.Id;
            return View();
        }


        // Update the type conversion for OrganizationId in the Add method
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Add(AddEventViewModel viewModel)
        {
            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Login", "User");
            }

            // Verificar se o ID da organização é válido
            var organization = await dbContext.Organization
                .FirstOrDefaultAsync(o => o.Id == viewModel.OrganizationId);

            if (organization == null)
            {
                return Forbid(); // Garante que o ID da organização é válido
            }

            // Criar o novo evento
            var newEvent = new Event
            {
                Title = viewModel.Title,
                Description = viewModel.Description,
                Date = viewModel.Date,
                Location = viewModel.Location,
                OrganizationId = organization.Id // Converte Guid para int usando GetHashCode()
            };

            await dbContext.Event.AddAsync(newEvent);
            await dbContext.SaveChangesAsync();

            return RedirectToAction("List");
        }

        // Editar evento (restrito à organização que criou o evento)
        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Edit(Guid id)
        {
            var eventToEdit = await dbContext.Event
                .Include(e => e.Organization)
                .FirstOrDefaultAsync(e => e.Id == id);

            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            if (eventToEdit == null || eventToEdit.Organization.UserId.ToString() != userId)
            {
                return Forbid();
            }

            // Converter o objeto Event para AddEventViewModel
            var viewModel = new AddEventViewModel
            {
                Title = eventToEdit.Title,
                Description = eventToEdit.Description,
                Date = eventToEdit.Date,
                Location = eventToEdit.Location,
                OrganizationId = eventToEdit.OrganizationId
            };

            return View(viewModel);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Edit(Event viewModel)
        {
            var eventToEdit = await dbContext.Event
                .Include(e => e.Organization)
                .FirstOrDefaultAsync(e => e.Id == viewModel.Id);

            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            if (eventToEdit == null || eventToEdit.Organization.UserId.ToString() != userId)
            {
                return Forbid(); // Garante que apenas o criador pode editar
            }

            // Atualizar os campos do evento
            eventToEdit.Title = viewModel.Title;
            eventToEdit.Description = viewModel.Description;
            eventToEdit.Date = viewModel.Date;
            eventToEdit.Location = viewModel.Location;

            await dbContext.SaveChangesAsync();

            return RedirectToAction("List");
        }

        // Deletar evento (restrito à organização que criou o evento)
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Delete(Guid id)
        {
            var eventToDelete = await dbContext.Event.Include(e => e.Organization)
                .FirstOrDefaultAsync(e => e.Id == id);

            if (eventToDelete == null || eventToDelete.Organization.UserId.ToString() != User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value)
            {
                return Forbid(); // Garante que apenas o criador pode deletar
            }

            dbContext.Event.Remove(eventToDelete);
            await dbContext.SaveChangesAsync();

            return RedirectToAction("List");
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> RegisterVolunteer(Guid eventId)
        {
            // Obtém o UserId do usuário autenticado
            var userIdString = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
            if (!Guid.TryParse(userIdString, out Guid userId))
                return Forbid();

            // Busca o voluntário relacionado ao usuário autenticado
            var volunteer = await dbContext.Volunteer.FirstOrDefaultAsync(v => v.UserId == userId);
            if (volunteer == null)
                return Forbid();

            // Verifica se já está inscrito
            var alreadyRegistered = await dbContext.Vacancy
                .AnyAsync(v => v.EventId == eventId && v.VolunteerId == volunteer.Id);

            if (alreadyRegistered)
            {
                TempData["Message"] = "Você já está inscrito neste evento.";
                return RedirectToAction("Details", new { id = eventId });
            }

            // Cria a inscrição
            var vacancy = new Vacancy
            {
                Id = Guid.NewGuid(),
                EventId = eventId,
                VolunteerId = volunteer.Id,
                RegisteredAt = DateTime.UtcNow,
                Accepted = false // ou true, conforme sua lógica
            };

            await dbContext.Vacancy.AddAsync(vacancy);
            await dbContext.SaveChangesAsync();

            TempData["Message"] = "Inscrição realizada com sucesso!";
            return RedirectToAction("Details", new { id = eventId });
        }


    }
}