using ConsoleUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI.StaticData
{
    public static class TestDataProvider
    {
        public static List<Teacher> GetTeachers()
        {
            return new List<Teacher>
            {
                new Teacher { Id = 1, FirstName = "Türkay", LastName = "ÜRKMEZ", Department = "Bilişim ve Bilgisayar" },
                new Teacher { Id = 2, FirstName = "Ali", LastName = "YILMAZ", Department = "Matematik" },
                new Teacher { Id = 3, FirstName = "Ayşe", LastName = "KARA", Department = "Fen Bilimleri" },
                new Teacher { Id = 4, FirstName = "Mehmet", LastName = "AKSOY", Department = "Tarih" },
                new Teacher { Id = 5, FirstName = "Fatma", LastName = "ÖZDEMİR", Department = "Türkçe" },
                new Teacher { Id = 6, FirstName = "Ahmet", LastName = "KILIÇ", Department = "İngilizce" },
                new Teacher { Id = 7, FirstName = "Zeynep", LastName = "SAVAŞ", Department = "Coğrafya" },
                new Teacher { Id = 8, FirstName = "Sema", LastName = "AKTAŞ", Department = "Beden Eğitimi" },
                new Teacher { Id = 9, FirstName = "Serkan", LastName = "GÜNEŞ", Department = "Müzik" },
                new Teacher { Id = 10, FirstName = "Sevgi", LastName = "DURSUN", Department = "Görsel Sanatlar" },
            };
        }

        public static List<Student> GetStudents()
        {
            return new List<Student>
            {
                new Student { Id = 1, FirstName = "Emre", LastName = "AKSOY", StudentNumber = 100 },
                new Student { Id = 2, FirstName = "Deniz", LastName = "YILMAZ", StudentNumber = 101 },
                new Student { Id = 3, FirstName = "Gizem", LastName = "GÜLER", StudentNumber = 102 },
                new Student { Id = 4, FirstName = "Berkan", LastName = "KAYA", StudentNumber = 103 },
                new Student { Id = 5, FirstName = "Sude", LastName = "ÖZKAN", StudentNumber = 104 },
                new Student { Id = 6, FirstName = "Cem", LastName = "ERDOĞAN", StudentNumber = 105 },
                new Student { Id = 7, FirstName = "Ebru", LastName = "AKTAŞ", StudentNumber = 106 },
                new Student { Id = 8, FirstName = "Mert", LastName = "YILDIRIM", StudentNumber = 107 },
                new Student { Id = 9, FirstName = "Pınar", LastName = "ATILGAN", StudentNumber = 108 },
                new Student { Id = 10, FirstName = "Murat", LastName = "YILMAZ", StudentNumber = 109 },
            };
        }

        public static List<Homework> GetHomeworks() 
        {
            return new List<Homework>
            {
                new Homework { Id = 1, Title = "Lise Projesi", Description = "Açıklama bla bla"}
            };
        }

        public static List<Classroom> GetClassrooms()
        {
            return new List<Classroom>
            {
                new Classroom { Id = 1, ClassNumber = 504, ResponsibleTeacher = new(){ Id = 978, FirstName = "TestTeacher", LastName = "Last", Department = "Computer" }, Students = new() }
            };
        }
    }
}
