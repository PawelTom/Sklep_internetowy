using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Sklep_internetowy.Models;
using System.Reflection.Metadata.Ecma335;

namespace Sklep_internetowy.Controllers
{
    public class AccountController : Controller
    {


        UserManager<AppUser> userManager {  get;  }

        SignInManager<AppUser>signInManager { get; }

        public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        public async Task<IActionResult> Register()
        {
            var user =await userManager.FindByNameAsync("TestUser");
            if(user == null)
            {
                user = new AppUser()
                {
                    UserName = "TestUser",
                    Email = "TestUser@gmail.com",
                    FirstName = "Jan",
                    LastName = "Kowalski"

                };

                var result = await userManager.CreateAsync(user, "Test123!") ;


            }


                return View();

        }

        public async Task<IActionResult> Login()
        {


            var result = await signInManager.PasswordSignInAsync("TestUser", "Test123!", false, false) ;
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
				return RedirectToAction("Index", "Cart");
			}
          
        }


		public async Task<IActionResult> Logout()
		{

            await signInManager.SignOutAsync();
			
				return RedirectToAction("Index", "Home");
			
			

		}
		public IActionResult Index()
        {
            return View();
        }
    }
}
