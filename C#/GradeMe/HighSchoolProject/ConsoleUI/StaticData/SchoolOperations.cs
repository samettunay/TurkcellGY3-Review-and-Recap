using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI.StaticData
{
    public static class SchoolOperations
    {
        public static string Classrooms = "Sınıf İşlemleri";
        public static string Teachers = "Öğretmen İşlemleri";
        public static string Students = "Öğrenci İşlemleri";
        public static string Homeworks = "Ödev İşlemleri";

        public static List<string> ClassroomMenuItems = new List<string>()
        {
            MenuOptions.GetClassrooms,
            MenuOptions.AddClassroom,
            MenuOptions.RemoveClassroom,
            MenuOptions.UpdateClassroom,
            MenuOptions.AddStudentInClassroom,
            MenuOptions.GetStudentsInClassroom,
        };

        public static List<string> StudentMenuItems = new List<string>()
        {
            "Öğrencileri Listele",
            "Yeni Öğrenci Ekle",
            "Öğrenci Sil",
            "Öğrenci Bilgilerini Güncelle",
            MenuOptions.GetStudentHomeworks,
        };

        public static List<string> TeacherMenuItems = new List<string>()
        {
            MenuOptions.GetTeachers,
            MenuOptions.AddTeacher,
            MenuOptions.RemoveTeacher,
            MenuOptions.UpdateTeacher,
            MenuOptions.AddHomeworkToStudent,
            MenuOptions.GetHomeworksOfStudent,
            MenuOptions.AddHomeworkToAllStudentsInClassroom,
        };

        public static List<string> HomeworkMenuItems = new List<string>()
        {
            "Ödevleri Listele",
            "Yeni Ödev Ekle",
            "Ödev Sil",
            "Ödev Bilgilerini Güncelle",
        };
    }

}
