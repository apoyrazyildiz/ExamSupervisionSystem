namespace ExamSupervisionSystem.Application.Mappings.AutoMapper
{
    internal class CourseParticipant
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public int UserId { get; set; }
        public DateTime EnrollmentDate { get; set; }
    }
}