using conectaOng.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using conectaOng.Models.Entities;
using conectaOng.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using conectaOng.Models.Enums;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;


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
        public IActionResult Add(Guid userId)
        {
            var viewModel = new AddVolunteerViewModel 
            { 
                UserId = userId 
            };

            ViewBag.SexOptions = Enum.GetValues(typeof(Sex))
            .Cast<Sex>()
            .Select(e => new SelectListItem { Value = e.ToString(), Text = e.ToString() })
            .ToList();

            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Add(AddVolunteerViewModel viewModel)
        {

            var user = await dbContext.User.FindAsync(viewModel.UserId);

            if (user == null)
            {
                return NotFound(); // ou outro tratamento adequado
            }

            var volunteer = new Volunteer
            {
                Name = user.Name,
                Cpf = viewModel.Cpf,
                Sex = viewModel.Sex,
                Description = viewModel.Description,
                UserId = viewModel.UserId,
            };

            await dbContext.Volunteer.AddAsync(volunteer);
            await dbContext.SaveChangesAsync();

            return RedirectToAction("Index", "Home");

        }

        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            var volunteer = await dbContext.Volunteer
                .Include(v => v.User)
                .FirstOrDefaultAsync(v => v.Id == id);

            if (id == null ||volunteer == null)
            {
                return NotFound();
            }

            ViewBag.SexOptions = Enum.GetValues(typeof(Sex))
                .Cast<Sex>()
                .Select(e => new SelectListItem { Value = e.ToString(), Text = e.ToString() })
                .ToList();

            return View(volunteer);
        }

        [HttpPost]
        public async Task<ActionResult> Edit(Guid id, Volunteer viewModel, string userName, string email)
        {
            var volunteer = await dbContext.Volunteer.FindAsync(viewModel.Id);

            if (id == null || volunteer == null)
            {
                return NotFound();
            }

            var user = await dbContext.User.FindAsync(volunteer.UserId);

            if (user == null)
            {
                return NotFound();
            }

            volunteer.Name = userName;
            volunteer.Cpf = viewModel.Cpf;
            volunteer.Sex = viewModel.Sex;
            volunteer.Description = viewModel.Description;

            user.Name = userName;
            user.Email = email;

            await dbContext.SaveChangesAsync();

            return RedirectToAction("List", "Volunteer");

        }

        public async Task<IActionResult> Details(Guid id)
        {
            var volunteer = await dbContext.Volunteer
                .Include(v => v.User)
                .FirstOrDefaultAsync(v => v.Id == id);

            if (id == null || volunteer == null)
            {
                return NotFound();
            }

            return View(volunteer);

        }

        [HttpGet]
        public async Task<IActionResult> Delete(Guid id)
        {
            var volunteer = await dbContext.Volunteer
                .Include(v => v.User)
                .FirstOrDefaultAsync(v => v.Id == id);

            if (id == null || volunteer == null)
            {
                return NotFound();
            }

            return View(volunteer);
        }


        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id, Volunteer viewModel)
        {
            var volunteer = await dbContext.Volunteer
              .Include(v => v.User)
              .FirstOrDefaultAsync(v => v.Id == id);

            if (volunteer == null)
            {
                return NotFound();
            }

            dbContext.Volunteer.Remove(volunteer);

            if (volunteer.User != null)
            {
                dbContext.User.Remove(volunteer.User);
            }

            await dbContext.SaveChangesAsync();

            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            return RedirectToAction("Index", "Home");

        }
    }
}
