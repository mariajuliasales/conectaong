using conectaOng.Data;
using conectaOng.Models;
using conectaOng.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
        public async Task<IActionResult> List()
        {
            var events = await dbContext.Event.Include(e => e.Organization).ToListAsync();
            return View(events);
        }

        // Criar evento (restrito à organização autenticada)
        [HttpGet]
        public IActionResult Add()
        {
            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Login", "Account");
            }

            return View();
        }

        // Update the type conversion for OrganizationId in the Add method
        [HttpPost]
        public async Task<IActionResult> Add(AddEventViewModel viewModel)
        {
            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Login", "Account");
            }

            var organization = await dbContext.Organization
                .FirstOrDefaultAsync(o => o.UserId.ToString() == User.Identity.Name);

            if (organization == null)
            {
                return Forbid();
            }

            var newEvent = new Event
            {
                Title = viewModel.Title,
                Description = viewModel.Description,
                Date = viewModel.Date,
                OrganizationId = organization.Id.GetHashCode()
            };

            await dbContext.Event.AddAsync(newEvent);
            await dbContext.SaveChangesAsync();

            return RedirectToAction("List");
        }

        // Editar evento (restrito à organização que criou o evento)
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var eventToEdit = await dbContext.Event.FindAsync(id);

            if (eventToEdit == null || eventToEdit.Organization.UserId.ToString() != User.Identity.Name)
            {
                return Forbid();
            }

            return View(eventToEdit);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Event viewModel)
        {
            var eventToEdit = await dbContext.Event.FindAsync(viewModel.Id);

            if (eventToEdit == null || eventToEdit.Organization.UserId.ToString() != User.Identity.Name)
            {
                return Forbid();
            }

            eventToEdit.Title = viewModel.Title;
            eventToEdit.Description = viewModel.Description;
            eventToEdit.Date = viewModel.Date;

            await dbContext.SaveChangesAsync();

            return RedirectToAction("List");
        }

        // Deletar evento (restrito à organização que criou o evento)
        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var eventToDelete = await dbContext.Event.Include(e => e.Organization)
                .FirstOrDefaultAsync(e => e.Id == id);

            if (eventToDelete == null || eventToDelete.Organization.UserId.ToString() != User.Identity.Name)
            {
                return Forbid();
            }

            dbContext.Event.Remove(eventToDelete);
            await dbContext.SaveChangesAsync();

            return RedirectToAction("List");
        }

        // Inscrever voluntário (voluntário autenticado)
        [HttpPost]
        public async Task<IActionResult> RegisterVolunteer(int eventId)
        {
            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Login", "Account");
            }

            var volunteer = await dbContext.User
                .FirstOrDefaultAsync(u => u.Id.ToString() == User.Identity.Name);

            if (volunteer == null)
            {
                return Forbid();
            }

            var eventToRegister = await dbContext.Event.FindAsync(eventId);

            if (eventToRegister == null)
            {
                return NotFound();
            }

            var newVolunteer = new Volunteer
            {
                Name = volunteer.Name,
                Email = volunteer.Email,
                EventId = eventId
            };

            await dbContext.Volunteer.AddAsync(newVolunteer);
            await dbContext.SaveChangesAsync();

            return RedirectToAction("List");
        }
    }
}