using ConsoleUI.Businnes.Concrete;
using ConsoleUI.Models;

List<Student> students = new()
{
    new Student() { Id = 1, StudentNumber = 1, FirstName = "Deneme", LastName = "Deneme2", Homeworks = new() }
};

StudentManager studentManager = new(students);
studentManager.GetAll().ForEach(s => Console.WriteLine(s.FirstName));