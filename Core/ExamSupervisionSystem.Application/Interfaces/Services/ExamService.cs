using ExamSupervisionSystem.Application.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSupervisionSystem.Application.Interfaces.Services
{
    internal class ExamService
    {
        private readonly IExamRepository _examRepository;

        public ExamService(IExamRepository examRepository)
        {
            _examRepository = examRepository;
        }

        public IEnumerable<Exam> GetAllExams()
        {
            // Tüm sınavları veritabanından al
            return _examRepository.GetAllExams();
        }

        public Exam GetExamById(int id)
        {
            // Belirli bir sınavı kimliğine göre al
            return _examRepository.GetExamById(id);
        }

        public void CreateExam(Exam exam)
        {
            // Yeni bir sınav oluştur
            _examRepository.AddExam(exam);
            _examRepository.Save();
        }

        public void UpdateExam(Exam exam)
        {
            // Bir sınavı güncelle
            _examRepository.UpdateExam(exam);
            _examRepository.Save();
        }

        public void DeleteExam(int id)
        {
            // Bir sınavı sil
            _examRepository.DeleteExam(id);
            _examRepository.Save();
        }
    }
}
