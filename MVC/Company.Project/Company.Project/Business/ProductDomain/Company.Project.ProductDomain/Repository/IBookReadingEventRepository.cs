using Company.Project.Core.Domain.Repository;
using Company.Project.ProductDomain.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Company.Project.ProductDomain.Repository
{
    public interface IBookReadingEventRepository
    {
        IEnumerable<BookReadingEvent> GetAllEvent();
        void Create(BookReadingEvent events);
        public IEnumerable<BookReadingEvent> GetAll();
        public BookReadingEvent GetById(int id);
        public void Update(BookReadingEvent obj);

    }
}
