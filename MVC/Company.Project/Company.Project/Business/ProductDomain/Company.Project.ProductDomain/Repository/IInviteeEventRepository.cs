using Company.Project.ProductDomain.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Company.Project.ProductDomain.Repository
{
    public interface IInviteeEventRepository
    {
        public IEnumerable<InviteeEvent> GetAll();
        public void Create(InviteeEvent item);
        public int total(int id);
        public void Update(InviteeEvent obj);
        public IEnumerable<InviteeEvent> GetById(int id);
        public InviteeEvent GetEachInviteeById(int id);
        public IEnumerable<InviteeEvent> EventListByEmail(string email);

    }
}
