﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSupervisionSystem.Domain.Entities
{
    internal class ExamAssigment
    {
        public int Id { get; set; }
        public int ExamId { get; set; }
        public int SupervisorId { get; set; }
    }
}
