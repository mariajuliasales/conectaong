using conectaOng.Data;
using conectaOng.Models;
using conectaOng.Models.Entities;
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

            return RedirectToAction("List", "User");
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
                // Aqui você poderia armazenar o usuário em sessão (exemplo simples)
                TempData["UsuarioLogado"] = user.Name;
                return RedirectToAction("Index", "Home");
            }

            ViewBag.Erro = "Email ou senha inválidos.";
            return View();
        }
    }
}
