using ExamSupervisionSystem.Application.Interfaces.Services;
using ExamSupervisionSystem.Domain.Entities;

namespace ExamSupervisionSystem.Application.Mappings.AutoMapper
{
    public class SupervisorAssignment
    {
        public int AssignmentId { get; set; } // Gözetmenlik görevinin kimliği

        public string AssignmentDescription { get; set; } // Gözetmenlik görevinin açıklaması

        public Exam Exam { get; set; } // Gözetmenlik görevinin bağlı olduğu sınav bilgisi
    }
}