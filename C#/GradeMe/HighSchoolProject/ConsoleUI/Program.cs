using ConsoleUI.Businnes.Concrete;
using ConsoleUI.Enums;
using ConsoleUI.Models;
using ConsoleUI.StaticData;
using ConsoleUI.Utilities;

List<Classroom> classrooms = new() {
    new Classroom { Id = 1, ClassNumber = 1},
};


NavigationHelper navigationHelper = new NavigationHelper(AppConstants.MenuNavigation);
ClassroomManager classroomManager = new ClassroomManager(classrooms);

List<Action> navigationActions = new()
{
    () => navigationHelper.Navigate(AppConstants.MenuNavigation),
    () => navigationHelper.Navigate(AppConstants.ClassroomNavigation),
    () => navigationHelper.Navigate(AppConstants.TeacherNavigation),
    () => navigationHelper.Navigate(AppConstants.StudentNavigation),
    () => navigationHelper.Navigate(AppConstants.HomeworkNavigation),
};

while (true)
{
    navigationHelper.StartNavigation(navigationActions);    
}

