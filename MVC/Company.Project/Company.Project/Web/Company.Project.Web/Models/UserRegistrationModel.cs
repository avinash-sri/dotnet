using Company.Project.Core.WebMVC;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
namespace Company.Project.Web.Models
{
    public class UserRegistrationModel : ViewModel
    {
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = " Please Enter Email Id")]
        public string Email { get; set; }

        [Required(ErrorMessage = " Please Enter password")]
        public string Password { get; set; }

        [Required(ErrorMessage = " Please Enter full Name")]
        public string FullName { get; set; }

        public string ErrorMessage { get; set; }
        public int UserType { get; set; }
    }
}
