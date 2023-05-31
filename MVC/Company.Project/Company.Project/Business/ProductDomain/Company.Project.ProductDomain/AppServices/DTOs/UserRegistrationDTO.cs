using Company.Project.Core.AppServices;
using System;
using System.Collections.Generic;
using System.Text;
namespace Company.Project.ProductDomain.AppServices.DTOs
{
    public class UserRegistrationDTO : DtoBase
    {
        //public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public int UserType { get; set; }
    }
}
