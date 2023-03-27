using JuanProject.DAL;
using JuanProject.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace JuanProject.Controllers
{
    public class ChatController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public ChatController(UserManager<AppUser> userMnager)
        {
            _userManager = userMnager;
        }

        public IActionResult Chat()
        {
            ViewBag.user =_userManager.Users.ToList();
            return View();
        }
    }
}
