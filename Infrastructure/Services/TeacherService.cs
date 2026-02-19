using System;
using Domain.Models;

namespace Infrastructure.Services;

public class TeacherService
{
    private List<Teacher> teachers = [];
    public List<Teacher> GetTeachers()
    {
        return teachers;
    }
    public void AddTeacher(Teacher teacher)
    {
        if (string.IsNullOrWhiteSpace(teacher.FirstName))
        {
            System.Console.WriteLine("First name is required.");
        }
        if (string.IsNullOrWhiteSpace(teacher.LastName))
        {
            System.Console.WriteLine("Last name is required.");
        }
        if (string.IsNullOrWhiteSpace(teacher.Position))
        {
            System.Console.WriteLine("Position is Assistent.");
        }
        if (teacher.ExperienceAmount < 1)
        {
            System.Console.WriteLine("Experience have to be more than 1 years.");
        }
        teachers.Add(teacher);

        Console.WriteLine("Teacher added successfully ");
    }
    public void Update(Teacher teacher)
    {
        foreach (var item in teachers)
        {
            if (item.Id == teacher.Id)
            {
                item.FirstName = teacher.FirstName;
                item.LastName = teacher.LastName;
                item.Position = teacher.Position;
                item.ExperienceAmount = teacher.ExperienceAmount;
                return;
            }
        }
    }
    public void Delete(int id)
    {
        foreach (var item in teachers)
        {
            if (item.Id == id)
            {
                teachers.Remove(item);
                return;
            }
        }
    }
}
