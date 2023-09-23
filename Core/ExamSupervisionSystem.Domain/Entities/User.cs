using ExamSupervisionSystem.Domain.Abstracts;

namespace ExamSupervisionSystem.Domain.Entities;

public class User : EntityBase<Guid>
{
    public int UserId { get; set; } // Kullan�c�n�n kimli�i

    public string UserName { get; set; } // Kullan�c� ad�

    public string Password { get; set; } // Kullan�c� �ifresi (�ifrelenmi� hali)

    public string FullName { get; set; } // Kullan�c�n�n tam ad�

    public string Email { get; set; } // Kullan�c�n�n e-posta adresi

    public DateTime RegistrationDate { get; set; } // Kullan�c�n�n kay�t tarihi

    public List<UserRole> Roles { get; set; } // Kullan�c�n�n rolleri
    public object LastName { get; internal set; }
    public object FirstName { get; internal set; }
    public int BirthYear { get; set; }
}