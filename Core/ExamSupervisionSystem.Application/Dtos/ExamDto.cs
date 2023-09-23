namespace ExamSupervisionSystem.Application.Dtos
{
    public class ExamDto
    {
        public int ExamId { get; set; } // Sınavın kimliği

        public string ExamName { get; set; } // Sınavın adı

        public DateTime ExamDateTime { get; set; } // Sınavın tarihi ve saati

        public string CourseName { get; set; } // Sınavın ait olduğu dersin adı
        public object Id { get; internal set; }
    }
}