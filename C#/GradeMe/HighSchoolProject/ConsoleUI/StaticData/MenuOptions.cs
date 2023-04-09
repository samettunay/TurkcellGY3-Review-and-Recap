using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI.StaticData
{
    public static class MenuOptions
    {
        public static string Classrooms = "Sınıf İşlemleri";
        public static string Teachers = "Öğretmen İşlemleri";
        public static string Students = "Öğrenci İşlemleri";
        public static string Homeworks = "Ödev İşlemleri";

        public const string GetTeachers = "Öğretmenleri Listele";
        public const string AddTeacher = "Yeni Öğretmen Ekle";
        public const string RemoveTeacher = "Öğretmen Sil";
        public const string UpdateTeacher = "Öğretmen Bilgilerini Güncelle";
        public const string AddHomeworkToStudent = "Öğrenciye Ödev Ekle";
        public const string GetHomeworksOfStudent = "Öğrencinin Ödevlerini Listele";

        public const string GetStudents = "Öğrencileri Listele";
        public const string AddStudent = "Yeni Öğrenci Ekle";
        public const string RemoveStudent = "Öğrenci Sil";
        public const string UpdateStudent = "Öğrenci Bilgilerini Güncelle";
        public const string GetStudentHomeworks = "Öğrencinin ödevlerini listele";

        public const string GetClassrooms = "Sınıfları Listele";
        public const string AddClassroom = "Yeni Sınıf Ekle";
        public const string RemoveClassroom = "Sınıf Sil";
        public const string UpdateClassroom = "Sınıf Bilgilerini Güncelle";
        public const string AddStudentInClassroom = "Sınıfa Öğrenci Ekle";
        public const string GetStudentsInClassroom = "Sınıfda ki öğrencileri Listele";
        public const string AddHomeworkToAllStudentsInClassroom = "Sınıftaki Tüm Öğrencilere Ödev Ekle";

        public const string GetHomeworks = "Ödevleri Listele";
        public const string AddHomework = "Yeni Ödev Ekle";
        public const string RemoveHomework = "Ödev Sil";
        public const string UpdateHomework = "Ödev Bilgilerini Güncelle";

        public static List<string> ClassroomMenuOptions = new List<string>()
        {
            GetClassrooms,
            AddClassroom,
            RemoveClassroom,
            UpdateClassroom,
            AddStudentInClassroom,
            GetStudentsInClassroom,
        };

        public static List<string> StudentMenuOptions = new List<string>()
        {
            GetStudents,
            AddStudent,
            RemoveStudent,
            UpdateStudent,
            GetStudentHomeworks,
        };

        public static List<string> TeacherMenuOptions = new List<string>()
        {
            GetTeachers,
            AddTeacher,
            RemoveTeacher,
            UpdateTeacher,
            AddHomeworkToStudent,
            GetHomeworksOfStudent,
            AddHomeworkToAllStudentsInClassroom,
        };

        public static List<string> HomeworkMenuOptions = new List<string>()
        {
            GetHomeworks,
            AddHomework,
            RemoveHomework,
            UpdateHomework,
        };
    }
}
