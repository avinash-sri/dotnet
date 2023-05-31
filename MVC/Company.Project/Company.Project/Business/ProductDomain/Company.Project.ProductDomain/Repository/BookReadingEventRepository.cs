using Company.Project.ProductDomain.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Company.Project.ProductDomain.Repository
{
    public class BookReadingEventRepository : IBookReadingEventRepository
    {
        private readonly BookReadingEventsContext _context;
        public BookReadingEventRepository(BookReadingEventsContext context)
        {
            _context = context;
        }

        public void Create(BookReadingEvent events)
        {
            _context.BookReadingEvent.Add(events);
            _context.SaveChanges();
        }

        public IEnumerable<BookReadingEvent> GetAll()
        {
            IEnumerable<BookReadingEvent> eventlist = _context.BookReadingEvent.Include(x => x.TypeNavigation).Include(x => x.StartTimeNavigation).Where(x => x.IsDelete == 0);
            return eventlist;
        }

        public IEnumerable<BookReadingEvent> GetAllEvent()
        {
                var eventList = _context.BookReadingEvent.Include("TypeNavigation").Where(x => x.IsDelete == 0 && x.TypeNavigation.Name == "Public");
                return eventList;
        }

        public BookReadingEvent GetById(int id)
        {
            BookReadingEvent eventById = _context.BookReadingEvent.Include(x => x.TypeNavigation).Include(x => x.StartTimeNavigation).Where(x => x.IsDelete == 0 && x.Id == id).FirstOrDefault();
            return eventById;
        }

        public void Update(BookReadingEvent obj)
        {
            _context.BookReadingEvent.Update(obj);
            _context.SaveChanges();
        }
    }
}
