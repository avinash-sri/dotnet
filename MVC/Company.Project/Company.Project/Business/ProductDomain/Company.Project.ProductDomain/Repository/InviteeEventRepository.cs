using Company.Project.ProductDomain.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Company.Project.ProductDomain.Repository
{
    public class InviteeEventRepository : IInviteeEventRepository
    {
        private readonly BookReadingEventsContext _context;
        public InviteeEventRepository(BookReadingEventsContext context)
        {
            _context = context;
        }
        public IEnumerable<InviteeEvent> GetAll()
        {
            var eventInviteelist = _context.InviteeEvent.Where(x => x.IsDelete == 0);
            return eventInviteelist;
        }
        public void Create(InviteeEvent item)
        {
            _context.InviteeEvent.Add(item);
            _context.SaveChanges();
        }
        public int total(int id)
        {
            var totalinvitee = _context.InviteeEvent.Where(x => x.IsDelete == 0 && x.EventId == id).Count();
            return totalinvitee;
        }

        public IEnumerable<InviteeEvent> GetById(int id)
        {
            var eventInviteelist = _context.InviteeEvent.Where(x => x.IsDelete == 0 && x.EventId == id);
            return eventInviteelist;
        }

        public IEnumerable<InviteeEvent> EventListByEmail(string email)
        {
            var eventlist = _context.InviteeEvent.Include(x => x.Event).Where(x => x.IsDelete == 0 && x.Event.IsDelete == 0 && x.Email == email);
            return eventlist;
        }

        public InviteeEvent GetEachInviteeById(int id)
        {
            InviteeEvent eventInviteelist = _context.InviteeEvent.Where(x => x.IsDelete == 0 && x.Id == id).FirstOrDefault();
            return eventInviteelist;
        }

        public void Update(InviteeEvent obj)
        {
            _context.InviteeEvent.Update(obj);
            _context.SaveChanges();
        }
   
    }
}
