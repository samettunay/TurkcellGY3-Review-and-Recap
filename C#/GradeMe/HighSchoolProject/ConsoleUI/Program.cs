using ConsoleUI.Businnes.Concrete;
using ConsoleUI.Utilities;

TeacherManager teacherManager = new TeacherManager();
StudentManager studentManager = new StudentManager();
HomeworkManager homeworkManager = new HomeworkManager();
ClassroomManager classroomManager = new ClassroomManager(teacherManager, homeworkManager, studentManager);

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

// TODO 3: Manager işlemlerini tam anlamıyla bitir
// TODO 4: Exception işlemleri
