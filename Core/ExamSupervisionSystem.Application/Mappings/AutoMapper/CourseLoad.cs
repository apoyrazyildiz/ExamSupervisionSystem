namespace ExamSupervisionSystem.Application.Mappings.AutoMapper
{
    public class CourseLoad
    {
        public int CourseId { get; set; } // Dersin kimliği

        public string CourseName { get; set; } // Dersin adı

        public int CourseCredit { get; set; } // Dersin kredisi

        public int StudentsEnrolled { get; set; } // Dersi alan öğrenci sayısı
    }
}