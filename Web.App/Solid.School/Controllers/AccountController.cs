using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Solid.School.Models;
using Solid.School.ViewModel;

namespace Solid.School.Controllers
{
    public class AccountController : Controller
    {
        private readonly SignInManager<CustomAspNetUsers> _signInManager;
        private readonly ILogger<AccountController> _logger;

        public AccountController(SignInManager<CustomAspNetUsers> signInManager, ILogger<AccountController> logger)
        {
            _signInManager = signInManager;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            var result = await _signInManager.PasswordSignInAsync(model.Username, model.Password, model.RememberMe, lockoutOnFailure: false);
            if (result.Succeeded)
            {
                _logger.LogInformation("User logged in.");
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View();
            }
        }
    }
}