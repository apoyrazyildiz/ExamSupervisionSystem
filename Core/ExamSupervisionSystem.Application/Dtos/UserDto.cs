namespace ExamSupervisionSystem.Application.Dtos
{
    public class UserDto
    {
        public int UserId { get; set; } // Kullanıcının kimliği

        public string UserName { get; set; } // Kullanıcı adı

        public string FullName { get; set; } // Kullanıcının tam adı

        public string Email { get; set; } // Kullanıcının e-posta adresi

        public List<UserRoleDto> Role { get; set; } // Kullanıcının rolleri

        public DateTime CreatedAt { get; set; } // Kullanıcının oluşturulma tarihi

        public DateTime LastLogin { get; set; } // Kullanıcının son giriş tarihi
        public object Age { get; internal set; }
    }
}