﻿namespace ExamSupervisionSystem.Application.Interfaces.Repositories
{
    internal interface ICourseRepository
    {
        IEnumerable<Course> GetAllCourses();
    }
}