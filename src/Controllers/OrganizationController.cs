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
            var cnpjLimpo = new string(viewModel.CNPJ?.Where(char.IsDigit).ToArray());

            if (!ValidarCnpj(cnpjLimpo))
            {
                ModelState.AddModelError("CNPJ", "CNPJ inválido.");
                return View(viewModel);
            }

            var organization = new Organization
            {
                Name = viewModel.Name,
                CNPJ = cnpjLimpo,
                Categoria = viewModel.Categoria,
                Descricao = viewModel.Descricao,
                UserId = viewModel.UserId,

            };
            await dbContext.Organization.AddAsync(organization);
            await dbContext.SaveChangesAsync();

            return RedirectToAction("List", "Organization");
        }

        private bool ValidarCnpj(string cnpj)
        {
            if (string.IsNullOrWhiteSpace(cnpj))
                return false;

            cnpj = new string(cnpj.Where(char.IsDigit).ToArray());

            if (cnpj.Length != 14)
                return false;

            string[] invalidos = {
                "00000000000000", "11111111111111", "22222222222222",
                "33333333333333", "44444444444444", "55555555555555",
                "66666666666666", "77777777777777", "88888888888888",
                "99999999999999"
            };
            if (invalidos.Contains(cnpj))
                return false;

            int[] multiplicador1 = { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };

            string cnpjSemDigitos = cnpj.Substring(0, 12);
            int soma = 0;

            for (int i = 0; i < 12; i++)
                soma += int.Parse(cnpjSemDigitos[i].ToString()) * multiplicador1[i];

            int resto = soma % 11;
            int digito1 = (resto < 2) ? 0 : 11 - resto;

            cnpjSemDigitos += digito1;
            soma = 0;

            for (int i = 0; i < 13; i++)
                soma += int.Parse(cnpjSemDigitos[i].ToString()) * multiplicador2[i];

            resto = soma % 11;
            int digito2 = (resto < 2) ? 0 : 11 - resto;

            string digitosCalculados = digito1.ToString() + digito2.ToString();

            return cnpj.EndsWith(digitosCalculados);
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
            var organization = await dbContext.Organization.FindAsync(id);
            if (organization == null)
            {
                return NotFound();
            }

            return View(organization);
        }

    }
}