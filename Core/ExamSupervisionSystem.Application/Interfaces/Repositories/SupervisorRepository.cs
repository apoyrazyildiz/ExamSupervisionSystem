using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSupervisionSystem.Application.Interfaces.Repositories
{
    internal class SupervisorRepository: ISupervisorRepository

    {
        private readonly ApplicationDbContext _context;

        public SupervisorRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Supervisor> GetAllSupervisors()
        {
            return _context.Supervisors.ToList();
        }

        public Supervisor GetSupervisorById(int id)
        {
            return _context.Supervisors.FirstOrDefault(supervisor => supervisor.Id == id);
        }

        public void AddSupervisor(Supervisor supervisor)
        {
            _context.Supervisors.Add(supervisor);
        }

        public void UpdateSupervisor(Supervisor supervisor)
        {
            _context.Entry(supervisor).State = EntityState.Modified;
        }

        public void DeleteSupervisor(int id)
        {
            var supervisorToDelete = _context.Supervisors.Find(id);
            if (supervisorToDelete != null)
            {
                _context.Supervisors.Remove(supervisorToDelete);
            }
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
