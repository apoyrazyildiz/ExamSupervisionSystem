namespace ExamSupervisionSystem.Application.Dtos
{
    internal class SupervisorDto
    {
        public int SupervisorId { get; set; } // Gözetmenin kimliği

        public string SupervisorName { get; set; } // Gözetmenin adı ve soyadı

        public string Email { get; set; } // Gözetmenin e-posta adresi

        public List<SupervisorAssignmentDto> SupervisorAssignments { get; set; } // Gözetmenin atandığı görevler
        public string? LastName { get; internal set; }
        public string? FirstName { get; internal set; }
    }
}