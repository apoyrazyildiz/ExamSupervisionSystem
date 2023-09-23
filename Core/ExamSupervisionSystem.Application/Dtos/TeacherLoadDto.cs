namespace ExamSupervisionSystem.Application.Dtos
{
    internal class TeacherLoadDto
    {
        public int TeacherId { get; set; } // Öğretmenin kimliği
        public string TeacherName { get; set; } // Öğretmenin adı ve soyadı
        public List<CourseDto> Courses { get; set; } // Öğretmenin ders yükü
        public List<SupervisorAssignmentDto> SupervisorAssignments { get; set; } // Gözetmenlik görevleri
        public object UserId { get; internal set; }
        public object UserName { get; internal set; }
        public object LoadType { get; internal set; }
    }
}