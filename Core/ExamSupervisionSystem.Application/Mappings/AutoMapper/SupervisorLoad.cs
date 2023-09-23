using System.Collections.Generic;

namespace ExamSupervisionSystem.Application.Mappings.AutoMapper
{
    internal class SupervisorLoad
    {
        public int SupervisorId { get; set; } // Gözetmenin kimliği

        public string SupervisorName { get; set; } // Gözetmenin adı ve soyadı

        public List<SupervisorAssignment> SupervisorAssignments { get; set; } // Gözetmenin atandığı görevler
        public object Supervisor { get; internal set; }
    }
}