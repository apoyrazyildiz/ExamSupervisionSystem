using ExamSupervisionSystem.WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using CourseSwapModel.Models;

namespace Controllers
{
    public class CourseSwapController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            // Ders takası için gerekli bilgileri kullanıcıya gösteren bir form sayfası
            return View();
        }

        [HttpPost]
        public IActionResult Swap(CourseSwapModel model)
        {
            if (ModelState.IsValid)
            {
                
                ViewBag.SuccessMessage = "Ders takası başarıyla tamamlandı!";
            }

            return View("Index", model);
        }
    }
}

