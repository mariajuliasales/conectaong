using System.Diagnostics;
using conectaOng.Data;
using conectaOng.Models;
using conectaOng.Models.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace conectaOng.Controllers
{
    public class OrganizationController : Controller
    {

        private readonly ApplicationDbContext dbContext;

        public OrganizationController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult Add(Guid userId)
        {
            ViewBag.UserId = userId;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddOrganizationViewModel viewModel)
        {
            Console.WriteLine($"UserId recebido: {viewModel.UserId}");
            var organization = new Organization
            {
                Name = viewModel.Name,
                CNPJ = viewModel.CNPJ,
                Categoria = viewModel.Categoria,
                Descricao = viewModel.Descricao,
                UserId = viewModel.UserId,

            };
            await dbContext.Organization.AddAsync(organization);
            await dbContext.SaveChangesAsync();

            return RedirectToAction("List", "Organization");
        }

        [HttpGet]
        public async Task<IActionResult> List(string? searchName, string? searchCategory)
        {
            var query = dbContext.Organization.AsQueryable();

            if (!string.IsNullOrWhiteSpace(searchName))
            {
                query = query.Where(o => o.Name.Contains(searchName));
            }

            if (!string.IsNullOrWhiteSpace(searchCategory))
            {
                query = query.Where(o => o.Categoria.Contains(searchCategory));
            }

            var organizations = await query.ToListAsync();
            return View(organizations);
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Edit(Guid id)
        {
            var organization = await dbContext.Organization.FindAsync(id);
            var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;

            if (organization == null || organization.UserId.ToString() != userId)
            {
                return Forbid(); // ou RedirectToAction("AccessDenied", "User");
            }

            return View(organization);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Edit(Organization model)
        {
            var organization = await dbContext.Organization.FindAsync(model.Id);
            var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;

            if (organization == null || organization.UserId.ToString() != userId)
            {
                return Forbid();
            }

            // Atualize os campos permitidos
            organization.Name = model.Name;
            organization.CNPJ = model.CNPJ;
            organization.Categoria = model.Categoria;
            organization.Descricao = model.Descricao;
            // ... outros campos

            await dbContext.SaveChangesAsync();
            return RedirectToAction("List");
        }

        [HttpPost]
        public async Task<IActionResult> Delete(Organization viewModel)
        {
            var organization = await dbContext.Organization.AsNoTracking().FirstOrDefaultAsync(x => x.Id == viewModel.Id);
            var user = await dbContext.User.AsNoTracking().FirstOrDefaultAsync(u => u.Id == viewModel.UserId);

            if (organization is not null)
            {
                dbContext.Organization.Remove(organization);

                if (user is not null)
                {
                    dbContext.User.Remove(user);
                }
                await dbContext.SaveChangesAsync();
            }

            return RedirectToAction("List", "Organization");
        }

        [HttpGet]
        public async Task<IActionResult> Details(Guid id)
        {
            var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
            bool isVolunteer = false;
            if (!string.IsNullOrEmpty(userId))
            {
                isVolunteer = await dbContext.Volunteer.AnyAsync(v => v.UserId.ToString() == userId);
            }
            ViewBag.IsVolunteer = isVolunteer;

            var organization = await dbContext.Organization
                .FirstOrDefaultAsync(o => o.Id == id);

            if (organization == null)
                return NotFound();

            // Verifica se o usuário autenticado é o dono da ONG
            bool isOwner = organization.UserId.ToString() == userId;

            if (isOwner)
            {
                var volunteers = await dbContext.Vacancy
                    .Where(v => v.OrganizationId == id)
                    .Include(v => v.Volunteer)
                    .ThenInclude(vol => vol.User)
                    .Select(v => v.Volunteer)
                    .ToListAsync();

                ViewBag.Volunteers = volunteers;
            }
            else
            {
                ViewBag.Volunteers = null;
            }

            ViewBag.IsOwner = isOwner;
            return View(organization);
        }



        [Authorize]
        public async Task<IActionResult> Volunteers(Guid id)
        {
            var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
            var organization = await dbContext.Organization
                .FirstOrDefaultAsync(o => o.Id == id);

            if (organization == null || organization.UserId.ToString() != userId)
                return Forbid();

            var volunteers = await dbContext.Vacancy
                .Where(v => v.OrganizationId == id)
                .Include(v => v.Volunteer)
                .Select(v => v.Volunteer)
                .ToListAsync();

            return View(volunteers);
        }

    }
}