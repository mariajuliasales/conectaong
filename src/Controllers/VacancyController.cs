using System;
using System.Threading.Tasks;
using System.Linq;
using conectaOng.Data;
using conectaOng.Models;
using conectaOng.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace conectaOng.Controllers
{
    public class VacancyController : Controller
    {
        private readonly ApplicationDbContext dbContext;

        public VacancyController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        // Listar todas as vagas
        [HttpGet]
        public async Task<IActionResult> List()
        {
            var vacancies = await dbContext.Vacancy
                .Include(v => v.Event)
                .Include(v => v.Volunteer)
                .ToListAsync();
            return View(vacancies);
        }

        // Exibir formulário de adição
        [HttpGet]
        [Authorize]
        public IActionResult Add()
        {
            return View();
        }

        // Adicionar nova vaga
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Add(AddVacancyViewModel viewModel)
        {
            if (!ModelState.IsValid || (viewModel.EventId == null && viewModel.OrganizationId == null))
            {
                ModelState.AddModelError("", "É necessário selecionar um evento ou uma ONG.");
                return View(viewModel);
            }

            var vacancy = new Vacancy
            {
                Id = Guid.NewGuid(),
                EventId = viewModel.EventId,
                OrganizationId = viewModel.OrganizationId,
                VolunteerId = viewModel.VolunteerId,
                RegisteredAt = viewModel.RegisteredAt,
                Accepted = viewModel.Accepted
            };

            await dbContext.Vacancy.AddAsync(vacancy);
            await dbContext.SaveChangesAsync();

            return RedirectToAction("List");
        }

        // Inscrição em ONG
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> RegisterVolunteer(Guid organizationId)
        {
            // Obtém o UserId do usuário autenticado
            var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
            if (string.IsNullOrEmpty(userId))
                return Forbid();

            // Busca o voluntário relacionado ao usuário autenticado
            var volunteer = await dbContext.Volunteer
                .FirstOrDefaultAsync(v => v.UserId.ToString() == userId);

            if (volunteer == null)
                return Forbid();

            // Verifica se já está inscrito
            var alreadyRegistered = await dbContext.Vacancy
                .AnyAsync(v => v.OrganizationId == organizationId && v.VolunteerId == volunteer.Id);

            if (alreadyRegistered)
            {
                TempData["Message"] = "Você já está inscrito para auxiliar esta ONG.";
                return RedirectToAction("Details", "Organization", new { id = organizationId });
            }

            // Cria a inscrição
            var vacancy = new Vacancy
            {
                Id = Guid.NewGuid(),
                OrganizationId = organizationId,
                VolunteerId = volunteer.Id,
                RegisteredAt = DateTime.UtcNow,
                Accepted = false // ou true, conforme sua lógica
            };

            await dbContext.Vacancy.AddAsync(vacancy);
            await dbContext.SaveChangesAsync();

            TempData["Message"] = "Inscrição realizada com sucesso!";
            return RedirectToAction("Details", "Organization", new { id = organizationId });
        }

        // Exibir formulário de edição
        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Edit(Guid id)
        {
            var vacancy = await dbContext.Vacancy.FindAsync(id);
            if (vacancy == null)
                return NotFound();

            var viewModel = new AddVacancyViewModel
            {
                EventId = vacancy.EventId,
                VolunteerId = vacancy.VolunteerId,
                RegisteredAt = vacancy.RegisteredAt,
                Accepted = vacancy.Accepted
            };

            ViewBag.VacancyId = vacancy.Id;
            return View(viewModel);
        }

        // Editar vaga
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Edit(Guid id, AddVacancyViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.VacancyId = id;
                return View(viewModel);
            }

            var vacancy = await dbContext.Vacancy.FindAsync(id);
            if (vacancy == null)
                return NotFound();

            vacancy.EventId = viewModel.EventId;
            vacancy.VolunteerId = viewModel.VolunteerId;
            vacancy.RegisteredAt = viewModel.RegisteredAt;
            vacancy.Accepted = viewModel.Accepted;

            await dbContext.SaveChangesAsync();
            return RedirectToAction("List");
        }

        // Deletar vaga
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Delete(Guid id)
        {
            var vacancy = await dbContext.Vacancy.FindAsync(id);
            if (vacancy == null)
                return NotFound();

            dbContext.Vacancy.Remove(vacancy);
            await dbContext.SaveChangesAsync();
            return RedirectToAction("List");
        }
    }
}