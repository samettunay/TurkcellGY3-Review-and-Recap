using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI.StaticData
{
    public static class SchoolOperations
    {
        public static string Classrooms = "Sınıflar";
        public static string Teachers = "Öğretmenler";
        public static string Students = "Öğrenciler";
        public static string Homeworks = "Ödevler";
        public static string Exit = "Çıkış";

        public static List<string> ClassroomMenuItems = new List<string>()
        {
            MenuOptions.GetClassrooms,
            MenuOptions.AddClassroom,
            MenuOptions.RemoveClassroom,
            MenuOptions.UpdateClassroom,
            MenuOptions.AddHomeworkToAllStudentsInClassroom,
            MenuOptions.AddStudentInClassroom,
            MenuOptions.GetStudentInClassroom,
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
            "Öğretmenleri Listele",
            "Yeni Öğretmen Ekle",
            "Öğretmen Sil",
            "Öğretmen Bilgilerini Güncelle",
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
