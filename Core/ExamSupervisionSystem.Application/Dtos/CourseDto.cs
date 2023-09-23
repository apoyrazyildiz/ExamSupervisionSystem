namespace ExamSupervisionSystem.Application.Dtos
{
    internal class CourseDto
    {
        public int Id { get; set; }
        public string CourseCode { get; set; }
        public string CourseName { get; set; }
        public int Credit { get; set; }
        public object CourseDisplayName { get; internal set; }
        public object CreditDisplay { get; internal set; }
        public object Description { get; internal set; }
    }
}