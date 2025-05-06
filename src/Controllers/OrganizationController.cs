using System.Diagnostics;
using conectaOng.Data;
using conectaOng.Models;
using conectaOng.Models.Entities;
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
        public async Task<IActionResult> Edit(Guid id)
        {
            var organization = await dbContext.Organization.FindAsync(id);

            return View(organization);

        }

        [HttpPost]
        public async Task<IActionResult> Edit(Organization viewModel)
        {
            var organization = await dbContext.Organization.FindAsync(viewModel.Id);
            if (organization is not null)
            {
                organization.Name = viewModel.Name;
                organization.CNPJ = viewModel.CNPJ;
                organization.Categoria = viewModel.Categoria;
                organization.Descricao = viewModel.Descricao;

                await dbContext.SaveChangesAsync();
            }

            return RedirectToAction("List", "Organization");
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
    }
}