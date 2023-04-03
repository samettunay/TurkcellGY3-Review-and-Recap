using ConsoleUI.Businnes.Concrete;
using ConsoleUI.Models;
using ConsoleUI.StaticData;
using ConsoleUI.Utilities;
using ConsoleUI.Utilities.Helpers;
using Spectre.Console;

List<Teacher> teachers = new()
{
    new () { Id = 1, FirstName = "Türkay", LastName = "ÜRKMEZ", Department = "Bilişim ve Bilgisayar" }
};

TeacherManager teacherManager = new TeacherManager(teachers);

while (true)
{
    var menu = NavigationLibrary.CreateMainMenu();

    teacherManager.ManageTeachers(menu);

    Console.ReadKey();
    Console.Clear();
}


