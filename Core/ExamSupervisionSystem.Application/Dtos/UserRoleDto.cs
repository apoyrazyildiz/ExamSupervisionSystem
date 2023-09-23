namespace ExamSupervisionSystem.Application.Dtos
{
    internal class UserRoleDto
    {
        public int Id { get; set; } // Rolün kimliği

        public string RoleName { get; set; } // Rolün adı

        public string Description { get; set; } // Rol hakkında açıklama

        public List<UserDto> Users { get; set; } // Bu role sahip kullanıcıların listesi

        public List<PermissionDto> Permissions { get; set; } // Rolün sahip olduğu izinlerin listesi

        public DateTime CreatedAt { get; set; } // Rolün oluşturulma tarihi

        public DateTime UpdatedAt { get; set; } // Rolün son güncelleme tarihi
        public object PermissionList { get; internal set; }
    }
}