namespace ExamSupervisionSystem.WebApp.Controllers
{
    internal interface ICourseService
    {
        object AssignSupervisor(int courseID, int supervisorID);
        object GetAllCourses();
    }
}