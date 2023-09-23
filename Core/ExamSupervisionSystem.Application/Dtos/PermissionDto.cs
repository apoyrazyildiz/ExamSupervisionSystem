namespace ExamSupervisionSystem.Application.Dtos
{
    public class PermissionDto
    {
        public int PermissionId { get; set; } // İzin kimliği

        public string PermissionName { get; set; } // İzin adı

        public string Description { get; set; } // İzin hakkında açıklama
    }
}