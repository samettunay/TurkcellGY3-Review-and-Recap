using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI.StaticData
{
    public static class AppConstants
    {
        public static string ClassroomOperations = "Sınıf İşlemleri";
        public static string TeacherOperations = "Öğretmen İşlemleri";
        public static string StudentOperations = "Öğrenci İşlemleri";
        public static string HomeworkOperations = "Ödev İşlemleri";
        public static string Exit = "Çıkış";

        public static List<string> ClassroomNavigation = new List<string>()
        {
            "Sınıfları Getir",
            "Sınıf Ekle",
            "Sınıf Çıkar",
            "Sınıf Bilgilerini Güncelle",
        };

        public static List<string> StudentNavigation = new List<string>()
        {
            "Öğrencileri Getir",
            "Öğrenci Ekle",
            "Öğrenci Çıkar",
            "Öğrenci Bilgilerini Güncelle",
        };

        public static List<string> TeacherNavigation = new List<string>()
        {
            "Öğretmenleri Getir",
            "Öğretmen Ekle",
            "Öğretmen Çıkar",
            "Öğretmen Bilgilerini Güncelle",
        };

        public static List<string> HomeworkNavigation = new List<string>()
        {
            "Ödevleri Getir",
            "Ödev Ekle",
            "Ödev Çıkar",
            "Ödev Bilgilerini Güncelle",
        };
    }
}
