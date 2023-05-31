using Company.Project.ProductDomain.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Company.Project.ProductDomain.Repository
{
    public interface ILookUpRepository
    {
        public IEnumerable<LookUp> GetStartTime();
        public IEnumerable<LookUp> GetEventType();
        public IEnumerable<LookUp> GetUserType();
    }
}
