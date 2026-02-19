using Domain.Models;
using Infrastructure.Services;

var studService = new StudentService();

var studen1 = new Student
{
    FirstName = "Akram",
    LastName = "Akramov",
    BirthDate = new DateTime(2001, 02, 28),
    Address = "Street Akram"
};
var studen2 = new Student
{
    FirstName = "Akram",
    LastName = "Akramov",
    BirthDate = new DateTime(2012, 02, 28),
    Address = "Street Akram"
};

studService.AddStudent(studen1);
studService.AddStudent(studen2);

foreach (var item in studService.GetStudents())
{
    Console.WriteLine($"{item.FirstName}\t{item.LastName}\t{item.BirthDate}\t{item.Address}");
}
var updatedStudent = new Student
{
    Id = 1,
    FirstName = "Malvi",
    LastName = "Malviev",
    BirthDate = new DateTime(2005, 02, 28),
    Address = "Street Malviev",
};
studService.UpdateStudent(updatedStudent);
foreach (var item in studService.GetStudents())
{
    Console.WriteLine($"{item.FirstName}\t{item.LastName}\t{item.BirthDate}\t{item.Address}");
}
var DeleteStudent = new Student
{
    Id = 1,
    FirstName = "Malvi",
    LastName = "Malviev",
    BirthDate = new DateTime(2005, 02, 28),
    Address = "Street Malviev",
};
studService.Delete(1);
foreach (var item in studService.GetStudents())
{
    Console.WriteLine($"{item.FirstName}\t{item.LastName}\t{item.BirthDate}\t{item.Address}");
}






//Teacher parts

var teacherService = new TeacherService();

var teacher1 = new Teacher
{
    FirstName = "Akram",
    LastName = "Akramov",
    Position = "Assistent",
    ExperienceAmount = 2,
};
var teacher2 = new Teacher
{
    FirstName = "Akdod",
    LastName = "Akdodov",
    Position = "Senior",
    ExperienceAmount = 5
};

teacherService.AddTeacher(teacher1);
teacherService.AddTeacher(teacher2);
foreach (var item in teacherService.GetTeachers())
{
    Console.WriteLine($"{item.FirstName}\t{item.LastName}\t{item.Position}\t{item.ExperienceAmount}");
}



var updatedTeacher = new Teacher
{
    Id = 1,
    FirstName = "Malvi",
    LastName = "Malviev",
    Position = "Senior",
    ExperienceAmount = 5
};
teacherService.Update(updatedTeacher);
foreach (var item in teacherService.GetTeachers())
{
    Console.WriteLine($"{item.FirstName}\t{item.LastName}\t{item.Position}\t{item.ExperienceAmount}");
}

teacherService.Delete(1);
foreach (var item in teacherService.GetTeachers())
{
    Console.WriteLine($"{item.FirstName}\t{item.LastName}\t{item.Position}\t{item.ExperienceAmount}");
}







//Course parts


var courseService = new CourseService();
var course1 = new Course
{
    Title = "C#",
    Discription = "C# is a modern, object-oriented programming language .",
    Fee = 50,
    HasDiscount = true
};
var course2 = new Course
{
    Title = "ASP.NET Core",
    Discription = "ASP.NET Core is a cross-platform.",
    Fee = 75,
    HasDiscount = false
};

courseService.AddCourse(course1);
courseService.AddCourse(course2);

foreach (var item in courseService.GetCourses())
{
    Console.WriteLine($"{item.Title}\t{item.Discription}");
}

var updatedCourse = new Course
{
    Id = 1,
    Title = "C# Advanced",
    Discription = "Advanced C# topics and patterns.",
    Fee = 100,
    HasDiscount = true
};
courseService.Update(updatedCourse);

foreach (var item in courseService.GetCourses())
{
    Console.WriteLine($"{item.Title}\t{item.Discription}\t{item.Fee}\t{item.HasDiscount}");
}

courseService.Delete(1);

foreach (var item in courseService.GetCourses())
{
    Console.WriteLine($"{item.Title}\t{item.Discription}\t{item.Fee}\t{item.HasDiscount}");
}







//Post parts
var postService = new PostService();
var post1 = new Post
{
    Title = "C# Basics",
    Discription = "Learn the fundamentals of C# programming."
};
var post2 = new Post
{
    Title = "ASP.NET Core Introduction",
    Discription = "Get started with ASP.NET Core development."
};

postService.AddPost(post1);
postService.AddPost(post2);

foreach (var item in postService.GetPosts())
{
    Console.WriteLine($"{item.Title}\t{item.Discription}");
}

var updatedPost = new Post
{
    Id = 1,
    Title = "C# Advanced",
    Discription = "Explore advanced C# programming concepts."
};
postService.Update(updatedPost);

foreach (var item in postService.GetPosts())
{
    Console.WriteLine($"{item.Title}\t{item.Discription}");
}

postService.Delete(1);

foreach (var item in postService.GetPosts())
{
    Console.WriteLine($"{item.Title}\t{item.Discription}");
}




