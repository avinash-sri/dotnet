using Company.Project.ProductDomain.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Company.Project.ProductDomain.Repository
{
    public class UserRegistrationRepository : IUserRegistrationRepository
    {
        private readonly BookReadingEventsContext _context;
        public UserRegistrationRepository(BookReadingEventsContext context)
        {
            _context = context;
        }
        public void Create(UserRegistration item)
        {
            _context.UserRegistration.Add(item);
            _context.SaveChanges();
        }

        public UserRegistration IsVerified(string email, string password)
        {
            var eventById = _context.UserRegistration.Where(x => x.Email == email && x.Password == password).FirstOrDefault();
            return eventById;
        }
    }
}
