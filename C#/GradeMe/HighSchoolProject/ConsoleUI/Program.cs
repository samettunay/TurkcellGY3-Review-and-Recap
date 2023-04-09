using ConsoleUI.Businnes.Abstract;
using ConsoleUI.Businnes.Concrete;
using ConsoleUI.Businnes.Concrete.MenuOptions.ClassroomOptions;
using ConsoleUI.Businnes.Concrete.MenuOptions.HomeworkOptions;
using ConsoleUI.Businnes.Concrete.MenuOptions.StudentOptions;
using ConsoleUI.Businnes.Concrete.MenuOptions.TeacherOptions;
using ConsoleUI.Businnes.Utilities;
using ConsoleUI.Businnes.Utilities.Helpers;
using ConsoleUI.Businnes.ValidationRules;
using ConsoleUI.StaticData;


StudentManager studentManager = new StudentManager(new StudentValidator());
HomeworkManager homeworkManager = new HomeworkManager(new HomeworkValidator());
ClassroomManager classroomManager = new ClassroomManager(new ClassroomValidator());
TeacherManager teacherManager = new TeacherManager(studentManager, homeworkManager, classroomManager, new TeacherValidator());



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
    { MenuOptions.AddStudentInClassroom, new AddStudentInClassroomOption(classroomManager, studentManager) },
    { MenuOptions.GetStudentsInClassroom, new GetStudentsInClassroomOption(classroomManager) },
    
    //Teacher Options
    { MenuOptions.GetTeachers, new GetTeachersOption(teacherManager) },
    { MenuOptions.AddTeacher, new AddTeacherOption(teacherManager) },
    { MenuOptions.RemoveTeacher, new RemoveTeacherOption(teacherManager) },
    { MenuOptions.UpdateTeacher, new UpdateTeacherOption(teacherManager) },
    { MenuOptions.GetHomeworksOfStudent, new GetHomeworksOfStudentOption(teacherManager, studentManager) },
    { MenuOptions.AddHomeworkToAllStudentsInClassroom, new AddHomeworkToAllStudentsInClassroomOption(teacherManager, classroomManager, homeworkManager) },
    { MenuOptions.AddHomeworkToStudent, new AddHomeworkToStudentOption(teacherManager, studentManager, homeworkManager) },
    
    //Student Options
    { MenuOptions.GetStudents, new GetStudentsOption(studentManager) },
    { MenuOptions.AddStudent, new AddStudentOption(studentManager) },
    { MenuOptions.RemoveStudent, new RemoveStudentOption(studentManager) },
    { MenuOptions.UpdateStudent, new UpdateStudentOption(studentManager) },

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
        SpectreConsoleHelper.WriteLineWithColor("Geçersiz işlem!", "red");
    }

    SpectreConsoleHelper.WriteLineWithColor("\nMenüye dönmek için bir tuşa basınız...", "yellow");
    Console.ReadKey();
    Console.Clear();
}