namespace ExamSupervisionSystem.Application.Mappings.AutoMapper
{
    public class UserRole
    {
        public int Id { get; set; } // Kullanıcının rol kimliği

        public string RoleName { get; set; } // Rolün adı (Örnek: "Admin", "Öğretmen", "Gözetmen", vb.)
        public object Role { get; internal set; }
    }
}