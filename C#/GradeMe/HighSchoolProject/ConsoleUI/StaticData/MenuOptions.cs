using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI.StaticData
{
    public static class MenuOptions
    {
        public const string GetTeachers = "Öğretmenleri Listele";
        public const string AddTeacher = "Yeni Öğretmen Ekle";
        public const string RemoveTeacher = "Öğretmen Sil";
        public const string UpdateTeacher = "Öğretmen Bilgilerini Güncelle";

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
        public const string GetStudentInClassroom = "Sınıfda ki öğrencileri Listele";
        public const string AddHomeworkToAllStudentsInClass = "Sınıftaki Tüm Öğrencilere Ödev Ekle";

        public const string GetHomeworks = "Ödevleri Listele";
        public const string AddHomework = "Yeni Ödev Ekle";
        public const string RemoveHomework = "Ödev Sil";
        public const string UpdateHomework = "Ödev Bilgilerini Güncelle";
    }
}
