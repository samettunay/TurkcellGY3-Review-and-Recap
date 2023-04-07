using ConsoleUI.Businnes.Abstract;
using ConsoleUI.Businnes.Concrete;
using ConsoleUI.Businnes.Concrete.MenuOptions.ClassroomOptions;
using ConsoleUI.Businnes.Concrete.MenuOptions.HomeworkOptions;
using ConsoleUI.Businnes.Concrete.MenuOptions.StudentOptions;
using ConsoleUI.Businnes.Concrete.MenuOptions.TeacherOptions;
using ConsoleUI.Models;
using ConsoleUI.StaticData;
using ConsoleUI.Utilities;
using ConsoleUI.Utilities.Helpers;
using Spectre.Console;
using System.Windows.Input;

TeacherManager teacherManager = new TeacherManager();
StudentManager studentManager = new StudentManager();
HomeworkManager homeworkManager = new HomeworkManager();
ClassroomManager classroomManager = new ClassroomManager(homeworkManager, studentManager);

Dictionary<string, IMenuOption> menuOptions = new Dictionary<string, IMenuOption>
{
    //Homeworks Options
    { MenuOptions.GetHomeworks, new GetHomeworksOption(homeworkManager) },
    { MenuOptions.AddHomework, new AddHomeworkOption(homeworkManager) },
    { MenuOptions.RemoveHomework, new RemoveHomeworkOption(homeworkManager) },
    { MenuOptions.UpdateHomework, new UpdateHomeworkOption(homeworkManager) },
    
    //Classrooms Options
    { MenuOptions.GetClassrooms, new GetClassroomsOption(classroomManager) },
    { MenuOptions.AddClassroom, new AddClassroomOption(classroomManager, teacherManager)},
    { MenuOptions.RemoveClassroom, new RemoveClassroomOption(classroomManager) },
    { MenuOptions.UpdateClassroom, new UpdateClassroomOption(classroomManager, teacherManager) },
    { MenuOptions.AddStudentInClassroom, new AddStudentInClassroomOption(classroomManager) },
    { MenuOptions.AddHomeworkToAllStudentsInClassroom, new AddHomeworkToAllStudentsInClassroomOption(classroomManager) },
    { MenuOptions.GetStudentInClassroom, new GetStudentsInClassroomOption(classroomManager) },
    
    //Teacher Options
    { MenuOptions.GetTeachers, new GetTeachersOption(teacherManager) },
    { MenuOptions.AddTeacher, new AddTeacherOption(teacherManager) },
    { MenuOptions.RemoveTeacher, new RemoveTeacherOption(teacherManager) },
    { MenuOptions.UpdateTeacher, new UpdateTeacherOption(teacherManager) },
    
    //Student Options
    { MenuOptions.GetStudents, new GetStudentsOption(studentManager) },
    { MenuOptions.AddStudent, new AddStudentOption(studentManager) },
    { MenuOptions.RemoveStudent, new RemoveStudentOption(studentManager) },
    { MenuOptions.UpdateStudent, new UpdateStudentOption(studentManager) },
    { MenuOptions.GetStudentHomeworks, new GetStudentHomeworksOption(studentManager) },

};

while (true)
{
    var selectedOption = NavigationLibrary.CreateMainMenu();

    if (menuOptions.ContainsKey(selectedOption))
    {
        menuOptions[selectedOption].Execute();
    }
    else
    {
        ConsoleHelper.WriteLineWithColor("Invalid option!", "red");
    }

    Console.ReadKey();
    Console.Clear();
}

// TODO 3: Manager işlemlerini tam anlamıyla bitir
// TODO 4: Exception işlemleri
