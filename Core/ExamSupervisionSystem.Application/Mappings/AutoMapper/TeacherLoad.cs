namespace ExamSupervisionSystem.Application.Mappings.AutoMapper
{
    internal class TeacherLoad
    {
        public int TeacherId { get; set; } // Öğretmenin kimliği

        public string TeacherName { get; set; } // Öğretmenin adı ve soyadı

        public List<CourseLoad> Courses { get; set; } // Öğretmenin ders yükü

        public List<SupervisorAssignment> SupervisorAssignments { get; set; } // Gözetmenlik görevleri
        public object Teacher { get; internal set; }
    }
}