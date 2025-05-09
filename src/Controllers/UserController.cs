using System.Security.Claims;
using conectaOng.Data;
using conectaOng.Models;
using conectaOng.Models.Entities;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace conectaOng.Controllers
{
    public class UserController : Controller
    {
        private readonly ApplicationDbContext dbContext;

        public UserController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddUserViewModel viewModel)
        {
            var user = new User
            {
                Name = viewModel.Name,
                Email = viewModel.Email,
                Password = viewModel.Password
            };

            await dbContext.User.AddAsync(user);
            await dbContext.SaveChangesAsync();

            return RedirectToAction("ChooseRole", "User", new { userId = user.Id });
        }

        [HttpGet]
        public IActionResult ChooseRole(Guid userId)
        {
            ViewBag.UserId = userId;
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> List()
        {
            var user = await dbContext.User.ToListAsync();
            return View(user);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            var user = await dbContext.User.FindAsync(id);
            return View(user);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(User viewModel)
        {
            var user = await dbContext.User.FindAsync(viewModel.Id);
            if (user is not null)
            {
                user.Name = viewModel.Name;
                user.Email = viewModel.Email;
                user.Password = viewModel.Password;

                await dbContext.SaveChangesAsync();
            }

            return RedirectToAction("List", "User");
        }

        [HttpPost]
        public async Task<IActionResult> Delete(User viewModel)
        {
            var user = await dbContext.User.AsNoTracking().FirstOrDefaultAsync(x => x.Id == viewModel.Id);

            if (user is not null)
            {
                dbContext.User.Remove(user);
                await dbContext.SaveChangesAsync();
            }

            return RedirectToAction("List", "User");
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(string email, string password)
        {
            var user = await dbContext.User.FirstOrDefaultAsync(u => u.Email == email && u.Password == password);

            if (user != null)
            {
                // Criar as claims do usuário
                var claims = new List<Claim>
        {
            new Claim(ClaimTypes.Name, user.Name),
            new Claim(ClaimTypes.Email, user.Email),
            new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()) // Armazena o UserId como claim
        };

                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                // Criar o cookie de autenticação
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));

                return RedirectToAction("Index", "Home");
            }

            ViewBag.Erro = "Email ou senha inválidos.";
            return View();
        }
    }
}
