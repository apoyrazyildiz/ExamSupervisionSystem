using ExamSupervisionSystem.Application.Dtos;
using ExamSupervisionSystem.Domain.Entities;
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
        private object _supervisorRepository;
        private object _mapper;

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

        public async Task<SupervisorDto> GetSupervisorByIdAsync(int supervisorId)
        {
            if (supervisorId <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(supervisorId));
            }

            
            var supervisor = await _supervisorRepository.GetSupervisorByIdAsync(supervisorId);

            if (supervisor == null)
            {
               
                return null;
            }

            
            var supervisorDto = new SupervisorDto
            {
                SupervisorId = supervisor.SupervisorId,
                FirstName = supervisor.FirstName,
                LastName = supervisor.LastName,
                Email = supervisor.Email,
               
            };

            return supervisorDto;
        }

        public async Task<IEnumerable<SupervisorDto>> GetAllSupervisorsAsync()
        {
            var supervisors = await _supervisorRepository.GetAllSupervisorsAsync();

            
            var supervisorDtos = supervisors.Select(supervisor => new SupervisorDto
            {
                SupervisorId = supervisor.SupervisorId,
                FirstName = supervisor.FirstName,
                LastName = supervisor.LastName,
                Email = supervisor.Email,
                
            });

            return supervisorDtos; 
        }

        public async Task<int> CreateSupervisorAsync(SupervisorDto supervisorDto)
        {
            if (supervisorDto == null)
            {
                throw new ArgumentNullException(nameof(supervisorDto));
            }

            // SupervisorDto'dan Supervisor nesnesine dönüşüm yapın.
            var supervisor = new Supervisor
            {
                FirstName = supervisorDto.FirstName,
                LastName = supervisorDto.LastName,
                Email = supervisorDto.Email,
                // Diğer özellikleri burada ayarlayın.
            };

            // Yeni gözeticiyi veritabanına ekleyin. Örnek olarak, _supervisorRepository kullanıldığını varsayalım.
            _supervisorRepository.AddSupervisor(supervisor);

            // Veritabanı değişikliklerini kaydedin.
            await _unitOfWork.SaveChangesAsync();

            return supervisor.SupervisorId;
        }

        public async Task<bool> UpdateSupervisorAsync(int supervisorId, SupervisorDto supervisorDto)
        {
            if (supervisorDto == null)
            {
                throw new ArgumentNullException(nameof(supervisorDto));
            }

            
            var existingSupervisor = await _supervisorRepository.GetSupervisorByIdAsync(supervisorId);

            if (existingSupervisor == null)
            {
                return false; 
            }

            
            existingSupervisor.FirstName = supervisorDto.FirstName;
            existingSupervisor.LastName = supervisorDto.LastName;
            existingSupervisor.Email = supervisorDto.Email;
            

           
            _supervisorRepository.UpdateSupervisor(existingSupervisor);

            
            await _unitOfWork.SaveChangesAsync();

            return true;
        }

        public async Task<bool> DeleteSupervisorAsync(int supervisorId)
        {
            var existingSupervisor = await _supervisorRepository.GetSupervisorByIdAsync(supervisorId);

            if (existingSupervisor == null)
            {
                return false; 
            }

            
            _supervisorRepository.DeleteSupervisor(existingSupervisor);

            
            await _unitOfWork.SaveChangesAsync();

            return true; // 
        }

        public async Task GetByIdAsync(int supervisorId)
        {
            // Veritabanından belirli bir gözeticiyi kimliği (supervisorId) kullanarak alın.
            // Örnek olarak, _supervisorRepository veya başka bir veri erişim sınıfını kullanabilirsiniz.
            var supervisor = await _supervisorRepository.GetSupervisorByIdAsync(supervisorId);

            if (supervisor == null)
            {
                // Gözetici bulunamadı, uygun bir hata işlemi yapabilirsiniz.
                 throw new Exception("Gözetici bulunamadı");
            }

            // Gözeticiyi SupervisorDto'ya dönüştürün. AutoMapper veya benzeri bir araç kullanabilirsiniz.
            var supervisorDto = _mapper.Map<SupervisorDto>(supervisor);

            return supervisorDto;
        }
    }
}
