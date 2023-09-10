using ExamSupervisionSystem.WebApp.Models;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Mvc;




namespace ExamSupervisionSystem.WebApp.Controllers
{
    public class SupervisorAssignmentController: Controller
    {
        private readonly ISupervisorService _supervisorService;
        private readonly ICourseService _courseService;

        public SupervisorAssignmentController(ISupervisorService supervisorService, ICourseService courseService)
        {
            _supervisorService = supervisorService;
            _courseService = courseService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var courses = _courseService.GetAllCourses();
            var supervisors = _supervisorService.GetAllSupervisors();

            var model = new AssignSupervisorModel
            {
                Courses = courses,
                Supervisors = supervisors
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult AssignSupervisor(AssignSupervisorModel model)
        {
            if (ModelState.IsValid)
            {
                // Ders ve gözetmen atamasını gerçekleştir
                var success = _courseService.AssignSupervisor(model.CourseID, model.SupervisorID);

                if (success)
                {
                    ViewBag.SuccessMessage = "Gözetmen ataması başarıyla tamamlandı!";
                }
                else
                {
                    ViewBag.ErrorMessage = "Gözetmen ataması sırasında bir hata oluştu.";
                }
            }

           
            return RedirectToAction("Index");
        }
    }
}
    }
}
