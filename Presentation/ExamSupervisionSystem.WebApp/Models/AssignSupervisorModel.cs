namespace ExamSupervisionSystem.WebApp.Models
{
    public class AssignSupervisorModel
    {
        public int CourseID { get; set; }
        public int SupervisorID { get; set; }
        public object Courses { get; internal set; }
        public object Supervisors { get; internal set; }
    }
}
