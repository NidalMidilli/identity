using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Authenticate.Controllers
{
    public class PersonelController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToAction("Hata");
        }


        [Authorize]
        public IActionResult Security()
        {
            return RedirectToAction();
        }

        public IActionResult Hata()
        {
            return View();
        }
    }
}
