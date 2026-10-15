using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace TrainingManagementSystem.Models
{
    public class Course
    {
        public string CourseCode { get; }
        public string Title { get; }
        public decimal Fee { get; }
        public int DurationDays { get; }
        public int TotalSeats { get; private set; }
        public int EnrolledCount { get; private set; }

        public Course(string CourseCode, string Title, decimal Fee, int DurationDays, int TotalSeats, int EnrolledCount)
        {
            this.CourseCode = CourseCode;
            this.Title = Title;
            this.DurationDays = DurationDays;
            this.TotalSeats = TotalSeats;
            this.EnrolledCount = EnrolledCount;

        }
        public int GetAvailableSeats()
        {
            return TotalSeats - EnrolledCount;
        }

        public void IncreaseEnrollment()
        {
            EnrolledCount++;
        }

        public void DecreaseEnrollment()
        {
            if (EnrolledCount > 0)
                EnrolledCount--;
        }
    }
}
