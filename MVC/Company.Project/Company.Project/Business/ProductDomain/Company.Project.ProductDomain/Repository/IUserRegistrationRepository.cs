using Company.Project.ProductDomain.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Company.Project.ProductDomain.Repository
{
    public interface IUserRegistrationRepository
    {
        public void Create(UserRegistration item);
        public UserRegistration IsVerified(string email, string password);
    }
}
