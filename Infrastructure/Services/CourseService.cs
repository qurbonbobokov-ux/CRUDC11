using System;
using System.Collections.Generic;
using Domain.Models;

namespace Infrastructure.Services
{
    public class CourseService
    {
        private List<Course> courses = new List<Course>();
        public List<Course> GetCourses()
        {
            return courses;
        }
        public void AddCourse(Course course)
        {
            if (string.IsNullOrWhiteSpace(course.Title))
            {
                Console.WriteLine("Title is required.");
                return;
            }
            if (string.IsNullOrWhiteSpace(course.Discription))
            {
                Console.WriteLine("Discription is required.");
                return;
            }
            if (course.Fee <= 0)
            {
                Console.WriteLine("Fee must be greater than zero.");
                return;
            }
            courses.Add(course);
            Console.WriteLine("Course added successfully.");
        }
        public void Update(Course course)
        {
            foreach (var item in courses)
            {
                if (item.Id == course.Id)
                {
                    item.Title = course.Title;
                    item.Discription = course.Discription;
                    item.Fee = course.Fee;
                    item.HasDiscount = course.HasDiscount;
                    return;
                }
            }
        }
        public void Delete(int id)
        {
            foreach (var item in courses)
            {
                if (item.Id == id)
                {
                    courses.Remove(item);
                    return;
                }
            }
        }
    }
}