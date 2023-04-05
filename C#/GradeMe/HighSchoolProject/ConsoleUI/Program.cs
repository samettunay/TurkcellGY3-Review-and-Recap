using ConsoleUI.Businnes.Concrete;
using ConsoleUI.Utilities;

TeacherManager teacherManager = new TeacherManager();
StudentManager studentManager = new StudentManager();
HomeworkManager homeworkManager = new HomeworkManager();
ClassroomManager classroomManager = new ClassroomManager(teacherManager);

while (true)
{
    var menu = NavigationLibrary.CreateMainMenu();

    teacherManager.ManageTeachers(menu);
    studentManager.ManageStudents(menu);
    homeworkManager.ManageHomeworks(menu);
    classroomManager.ManageClassrooms(menu);

    Console.ReadKey();
    Console.Clear();
}


