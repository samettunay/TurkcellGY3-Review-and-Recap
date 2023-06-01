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
                new Teacher { Id = Guid.NewGuid(), FirstName = "Türkay", LastName = "ÜRKMEZ", Department = "Bilişim ve Bilgisayar" },
                new Teacher { Id = Guid.NewGuid(), FirstName = "Ali", LastName = "YILMAZ", Department = "Matematik" },
                new Teacher { Id = Guid.NewGuid(), FirstName = "Ayşe", LastName = "KARA", Department = "Fen Bilimleri" },
                new Teacher { Id = Guid.NewGuid(), FirstName = "Mehmet", LastName = "AKSOY", Department = "Tarih" },
                new Teacher { Id = Guid.NewGuid(), FirstName = "Fatma", LastName = "ÖZDEMİR", Department = "Türkçe" },
                new Teacher { Id = Guid.NewGuid(), FirstName = "Ahmet", LastName = "KILIÇ", Department = "İngilizce" },
                new Teacher { Id = Guid.NewGuid(), FirstName = "Zeynep", LastName = "SAVAŞ", Department = "Coğrafya" },
                new Teacher { Id = Guid.NewGuid(), FirstName = "Sema", LastName = "AKTAŞ", Department = "Beden Eğitimi" },
                new Teacher { Id = Guid.NewGuid(), FirstName = "Serkan", LastName = "GÜNEŞ", Department = "Müzik" },
                new Teacher { Id = Guid.NewGuid(), FirstName = "Sevgi", LastName = "DURSUN", Department = "Görsel Sanatlar" },
            };
        }

        public static List<Student> GetStudents()
        {
            return new List<Student>
            {
                new Student { Id = Guid.NewGuid(), FirstName = "Emre", LastName = "AKSOY", StudentNumber = 100 },
                new Student { Id = Guid.NewGuid(), FirstName = "Deniz", LastName = "YILMAZ", StudentNumber = 101 },
                new Student { Id = Guid.NewGuid(), FirstName = "Gizem", LastName = "GÜLER", StudentNumber = 102 },
                new Student { Id = Guid.NewGuid(), FirstName = "Berkan", LastName = "KAYA", StudentNumber = 103 },
                new Student { Id = Guid.NewGuid(), FirstName = "Sude", LastName = "ÖZKAN", StudentNumber = 104 },
                new Student { Id = Guid.NewGuid(), FirstName = "Cem", LastName = "ERDOĞAN", StudentNumber = 105 },
                new Student { Id = Guid.NewGuid(), FirstName = "Ebru", LastName = "AKTAŞ", StudentNumber = 106 },
                new Student { Id = Guid.NewGuid(), FirstName = "Mert", LastName = "YILDIRIM", StudentNumber = 107 },
                new Student { Id = Guid.NewGuid(), FirstName = "Pınar", LastName = "ATILGAN", StudentNumber = 108 },
                new Student { Id = Guid.NewGuid(), FirstName = "Murat", LastName = "YILMAZ", StudentNumber = 109 },
            };
        }

        public static List<Homework> GetHomeworks() 
        {
            return new List<Homework>
            {
                new Homework { Id = Guid.NewGuid(), Title = "Lise Projesi", Description = "Açıklama bla bla"},
                new Homework { Id = Guid.NewGuid(), Title = "Lise Projesi2", Description = "Açıklama bla bla2"}
            };
        }

        public static List<Classroom> GetClassrooms()
        {
            return new List<Classroom>
            {
                new Classroom { Id = Guid.NewGuid(), ClassNumber = 504, ResponsibleTeacher = new(){ Id = Guid.NewGuid(), FirstName = "TestTeacher", LastName = "Last", Department = "Computer" }, Students = new() },
            };
        }
    }
}
