using Company.Project.Core.Data.Transaction;
using Company.Project.Core.ExceptionManagement;
using Company.Project.ProductDomain.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Company.Project.ProductDomain.UoW
{
    public class BookReadingEventUnitOfWork : UnitOfWork, IBookReadingEventUnitOfWork
    {
        private readonly IServiceProvider ServiceProvider;

        public BookReadingEventUnitOfWork(BookReadingEventsContext context, IExceptionManager exceptionManager) : base(context, exceptionManager)
        {
            //ServiceProvider = serviceProvider;
        }
    }
}
