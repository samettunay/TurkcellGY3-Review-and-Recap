using System.ComponentModel.DataAnnotations;

namespace CourseApp.Mvc.Models
{
    public class UserLoginViewModel
    {
        [Required(ErrorMessage = "Kullancı adı boş olamaz")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Şifre boş geçilemez")]
        [DataType(DataType.Password)]
        public string Password { get; set; } 
    }
}
