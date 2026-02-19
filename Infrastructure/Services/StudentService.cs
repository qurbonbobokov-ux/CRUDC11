using System;
using Domain.Models;

namespace Infrastructure.Services;

public class StudentService
{
    private List<Student> students = [];
    public List<Student> GetStudents()
    {
        return students;
    }
    public void AddStudent(Student student)
    {
        if (string.IsNullOrWhiteSpace(student.FirstName))
        {
            System.Console.WriteLine("First name is required.");
            return;
        }
        if (string.IsNullOrWhiteSpace(student.LastName))
        {
            System.Console.WriteLine("Last name is required.");
            return;
        }
        if (DateTime.Now.Year - student.BirthDate.Year < 18)
        {
            System.Console.WriteLine("Age must be greater than 18.");
            return;
        }
        if (string.IsNullOrWhiteSpace(student.Address))
        {
            System.Console.WriteLine("Address is required.");
            return;
        }
        student.Id = students.Count + 1;
        students.Add(student);

    }
    public void UpdateStudent(Student student)
    {
        foreach (var item in students)
        {
            if (item.Id == student.Id)
            {
                item.FirstName = student.FirstName;
                item.LastName = student.LastName;
                item.BirthDate = student.BirthDate;
                item.Address = student.Address;
                return;
            }
        }

    }
    public void Delete(int id)
    {
        foreach (var item in students)
        {
            if (item.Id == id)
            {
                students.Remove(item);
                return;
            }
        }

    }

}
