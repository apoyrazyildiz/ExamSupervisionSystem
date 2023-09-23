using ExamSupervisionSystem.Application.Features.Queries.GetExamDetails;
using ExamSupervisionSystem.WebApp.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Controllers
{
    public class CourseSwapController : Controller
    {
        private readonly IMediator mediator;

        public CourseSwapController(
            IMediator mediator)
        {
            this.mediator = mediator;
        }
        [HttpGet]
        public IActionResult Index()
        {
            //var response = mediator.Send(new GetExamDetailsQuery());
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

