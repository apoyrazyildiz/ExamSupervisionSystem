namespace ExamSupervisionSystem.Application.Dtos
{
    internal class CourseParticipantDto
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public DateTime EnrollmentDate { get; set; }
    }
}