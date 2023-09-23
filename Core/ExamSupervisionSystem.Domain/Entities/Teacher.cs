using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSupervisionSystem.Domain.Entities
{
    public class Teacher
    {
        public int TeacherId { get; set; }
        public string TeacherName { get; set; }
        public string TeacherSurname { get; set; }
        public string TeacherBranch { get; set; }
        public string TeacherTC { get; set; }
        public int TeacherPhoneNummer { get; set; }
        public string TeacherEmail { get; set; }
        public string TeacherPassword { get; set; }
    }
}
