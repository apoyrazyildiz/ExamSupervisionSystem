using ExamSupervisionSystem.Domain.Abstracts;

namespace ExamSupervisionSystem.Domain.Entities;

public class User : EntityBase<Guid>
{
    public int UserId { get; set; } // Kullanýcýnýn kimliði

    public string UserName { get; set; } // Kullanýcý adý

    public string Password { get; set; } // Kullanýcý þifresi (þifrelenmiþ hali)

    public string FullName { get; set; } // Kullanýcýnýn tam adý

    public string Email { get; set; } // Kullanýcýnýn e-posta adresi

    public DateTime RegistrationDate { get; set; } // Kullanýcýnýn kayýt tarihi

    public List<UserRole> Roles { get; set; } // Kullanýcýnýn rolleri
    public object LastName { get; internal set; }
    public object FirstName { get; internal set; }
    public int BirthYear { get; set; }
}