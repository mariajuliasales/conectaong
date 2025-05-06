using conectaOng.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using conectaOng.Models.Entities;
using conectaOng.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using conectaOng.Models.Enums;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;


namespace conectaOng.Controllers
{
    public class VolunteerController : Controller
    {
        private readonly ApplicationDbContext dbContext;

        public VolunteerController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext; 
        }

        public async Task<IActionResult> List()
        {
            var dados = await dbContext.Volunteer.ToListAsync();
            return View(dados);
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.SexOptions = Enum.GetValues(typeof(Sex))
            .Cast<Sex>()
            .Select(e => new SelectListItem { Value = e.ToString(), Text = e.ToString() })
            .ToList();

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddVolunteerViewModel viewModel)
        {

            var volunteer = new Volunteer
            {
                Name = viewModel.Name,
                Cpf = viewModel.Cpf,
                Sex = viewModel.Sex,
                Description = viewModel.Description,
                Email = viewModel.Email,
                Password = viewModel.Password,

            };

            await dbContext.Volunteer.AddAsync(volunteer);
            await dbContext.SaveChangesAsync();

            return RedirectToAction("List", "Volunteer");


        }

        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            var volunteer = await dbContext.Volunteer.FindAsync(id);

            if(id == null ||volunteer == null)
            {
                return NotFound();
            }

            return View(volunteer);
        }

        [HttpPost]
        public async Task<ActionResult> Edit(int? id, Volunteer viewModel)
        {
            var volunteer = await dbContext.Volunteer.FindAsync(viewModel.Id);

            if(volunteer is not null)
            {
                volunteer.Name = viewModel.Name;
                volunteer.Cpf = viewModel.Cpf;
                volunteer.Sex = viewModel.Sex;
                volunteer.Description = viewModel.Description;
                volunteer.Email = viewModel.Email;
                volunteer.Password = viewModel.Password;

                await dbContext.SaveChangesAsync();
            }

            return RedirectToAction("List", "Volunteer");

        }

        public async Task<IActionResult> Details(int? id)
        {
            var volunteer = await dbContext.Volunteer.FindAsync(id);

            return View(volunteer);

        }

        public async Task<IActionResult> Delete(int? id)
        {
            var volunteer = await dbContext.Volunteer.FindAsync(id);

            return View(volunteer);

        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(Volunteer viewModel)
        {
            var volunteer = await dbContext.Volunteer.AsNoTracking().FirstOrDefaultAsync(x => x.Id == viewModel.Id);

            if (volunteer is not null)
            {
                dbContext.Volunteer.Remove(volunteer);
                await dbContext.SaveChangesAsync();
            }

            return RedirectToAction("List", "Volunteer");

        }
    }
}
