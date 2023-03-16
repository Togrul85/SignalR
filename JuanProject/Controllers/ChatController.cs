using Microsoft.AspNetCore.Mvc;

namespace JuanProject.Controllers
{
    public class ChatController : Controller
    {
        public IActionResult Chat()
        {
            return View();
        }
    }
}
