using System;
using System.Collections.Generic;
using System.Text;


using TrainingManagementSystem.Models;

namespace TrainingManagementSystem.Services;

public class CourseService
{
    private Course[] courses;

    public CourseService(Course[] courses)
    {
        this.courses = courses;
    }

    public void Display()
    {
        Console.WriteLine("--Available Courses--");
        Console.WriteLine("CourseCode | Title | Fee | DurationDays | AvailableSeats");

        foreach (Course course in courses)
        {
            Console.WriteLine(
                $"{course.CourseCode.PadRight(8)} | " +
                $"{course.Title.PadRight(12)} | " +
                $"{course.Fee:N2} | {course.DurationDays} | " +
                $"{course.GetAvailableSeats()}");
        }
    }

    public void Search(string search)
    {
        bool found = false;

        foreach (Course course in courses)
        {
            if (course.Title.Equals(
                search, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine(
                    $"{course.CourseCode} | {course.Title} | ₹{course.Fee}");
                found = true;
                break;
            }
        }

        if (!found)
            Console.WriteLine("Course Not Available");
    }

    public void Sort()
    {
        Array.Sort(courses, (a, b) => a.Fee.CompareTo(b.Fee));

        foreach (Course c in courses)
            Console.WriteLine($"{c.Title} - ₹{c.Fee}");
    }

    public void AvailableSeats()
    {
        foreach (Course course in courses)
        {
            Console.WriteLine(
                $"Available seats in {course.Title}: {course.GetAvailableSeats()}");
        }
    }
}

