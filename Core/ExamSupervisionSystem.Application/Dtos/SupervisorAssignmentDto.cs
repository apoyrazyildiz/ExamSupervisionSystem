namespace ExamSupervisionSystem.Application.Dtos
{
    public class SupervisorAssignmentDto
    {
        public int AssignmentId { get; set; } // Gözetmenlik görevinin kimliği

        public string AssignmentDescription { get; set; } // Gözetmenlik görevinin açıklaması

        public DateTime AssignmentDateTime { get; set; } // Gözetmenlik görevinin tarihi ve saati

        public ExamDto Exam { get; set; } // Gözetmenlik görevinin bağlı olduğu sınav bilgisi

        public int SupervisorId { get; set; } // Gözetmenin kimliği

        public string SupervisorName { get; set; } // Gözetmenin adı ve soyadı
    }
}