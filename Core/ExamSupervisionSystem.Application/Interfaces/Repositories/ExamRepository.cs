using ExamSupervisionSystem.Application.Interfaces.Services;
using ExamSupervisionSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSupervisionSystem.Application.Interfaces.Repositories
{
    internal class ExamRepository : IExamRepository
    {
        private readonly ApplicationDbContext _context;

        public object EntityState { get; private set; }

        public ExamRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Exam> GetAllExams()
        {
            return _context.Exams.ToList();
        }

        public Exam GetExamById(int id)
        {
            return _context.Exams.FirstOrDefault(exam => exam.Id == id);
        }

        public void AddExam(Exam exam)
        {
            _context.Exams.Add(exam);
        }

        public void UpdateExam(Exam exam)
        {
            _context.Entry(exam).State = EntityState.Modified;
        }

        public void DeleteExam(int id)
        {
            var examToDelete = _context.Exams.Find(id);
            if (examToDelete != null)
            {
                _context.Exams.Remove(examToDelete);
            }
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
