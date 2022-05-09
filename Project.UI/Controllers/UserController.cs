using Microsoft.AspNetCore.Mvc;
using Project.SERVICES.Abstract;

namespace Project.UI.Controllers
{
    public class UserController : Controller
    {
        private readonly IAppUserService _appUserService;
        private readonly IAppUserProfileService _appUserProfileService;
        public UserController(IAppUserService appUserService, IAppUserProfileService appUserProfileService)
        {
            _appUserService = appUserService;
            _appUserProfileService = appUserProfileService;
        }

        
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(int x) //I've just added parameter for not given a error. I will change after.
        {
            return View();
        }

        [HttpGet]
        public IActionResult Register() 
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(int x)
        {
            return View();
        }

        [HttpGet]
        public IActionResult ForgotMyPassword()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ForgotMyPassword(int x) 
        {
            return View();
        }
    }
}
