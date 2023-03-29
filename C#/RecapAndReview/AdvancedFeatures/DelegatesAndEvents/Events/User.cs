using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
    }

    public class UserCreatedEventArgs : EventArgs
    {
        public User User { get; set; }
        public DateTime CreatedDate { get; set; }
    }

    public class UserService
    {
        private List<User> _users = new List<User>();
        public event EventHandler<UserCreatedEventArgs> UserCreated;
        public void Create(User user)
        {
            // TODO 01: Kullanıcı oluşturuldu event'i burada fırlayacak!
            if (UserCreated != null)
            {
                UserCreatedEventArgs arg = new()
                {
                    User = user,
                    CreatedDate = DateTime.Now,
                };
                UserCreated(this, arg);
            }
        }

        public void AddUser(User user) => _users.Add(user);

        public bool IsEmpty() => _users.Count == 0;

        public void Clear() => _users.Clear();
    }
}
