using Company.Project.ProductDomain.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Company.Project.ProductDomain.Repository
{
    public class LookUpRepository : ILookUpRepository
    {
        private readonly BookReadingEventsContext _context;
        public LookUpRepository(BookReadingEventsContext context)
        {
            _context = context;
        }
        public IEnumerable<LookUp> GetStartTime()
        {
            IEnumerable<LookUp> eventlist = _context.LookUp.Include(x => x.LookUpCategory).Where(x => x.IsDelete == 0 && x.LookUpCategory.Id == 1);
            return eventlist;
        }
        public IEnumerable<LookUp> GetEventType()
        {
            IEnumerable<LookUp> eventlist = _context.LookUp.Include(x => x.LookUpCategory).Where(x => x.IsDelete == 0 && x.LookUpCategory.Id == 2);
            return eventlist;
        }
        public IEnumerable<LookUp> GetUserType()
        {
            IEnumerable<LookUp> eventlist = _context.LookUp.Include(x => x.LookUpCategory).Where(x => x.IsDelete == 0 && x.LookUpCategory.Id == 3);
            return eventlist;
        }
    }
}
