using System;
using System.Collections.Generic;

namespace Company.Project.ProductDomain.Domain
{
    public partial class UserRegistration
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public int UserType { get; set; }

        public virtual LookUp UserTypeNavigation { get; set; }
    }
}
