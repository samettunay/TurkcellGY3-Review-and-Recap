using CourseApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseApp.Services
{
    public class UserService : IUserService
    {
        private List<User> users;
        public UserService()
        {
            users = new List<User>()
            {
                new(){ Id = 1, Name ="Turkay", Password="123", Email="abc@xyz.com", Role="Admin", UserName = "Turko"},
                new(){ Id = 2, Name ="Samet", Password="123", Email="abc@xyz.com", Role="Editor", UserName = "Samuel"},
                new(){ Id = 3, Name ="Alperen", Password="123", Email="abc@xyz.com", Role="Client", UserName = "aalp"},
            };
        }
        public User? ValidateUser(string username, string password)
        {
            return users.SingleOrDefault(u=>u.UserName == username && u.Password == password);
        }
    }
}
