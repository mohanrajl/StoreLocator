using System.ComponentModel.DataAnnotations;

namespace StoreLocator.Web.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Enter Your UserName")]
        public string UserName { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Enter Your Password")]        
        public string Password { get; set; }
    }
}