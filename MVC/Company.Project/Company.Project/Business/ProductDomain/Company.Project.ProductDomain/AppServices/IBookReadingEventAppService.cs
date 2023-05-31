using Company.Project.Core.AppServices;
using Company.Project.Core.ValueObjects;
using Company.Project.ProductDomain.AppServices.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Company.Project.ProductDomain.AppServices
{
    public interface IBookReadingEventAppService : IAppService
    {
        void AddInviteeByMail(InviteeEventDTO item);
        OperationResult<BookReadingEventDTO> Create(BookReadingEventDTO item);
        OperationResult<IEnumerable<BookReadingEventDTO>> GetAllEvents();
        OperationResult<IEnumerable<BookReadingEventDTO>> GetAll();
        OperationResult<IEnumerable<LookUpDTO>> StartTime();
        OperationResult<IEnumerable<LookUpDTO>> EventType();
        public OperationResult<BookReadingEventDTO> DeletePost(BookReadingEventDTO dtoitem);
        IEnumerable<InviteeEventDTO> GetInviteeById(int id);
        public void GetInviteeUpdate(InviteeEventDTO item);
        OperationResult<BookReadingEventDTO> GetById(int id);
        OperationResult<IEnumerable<InviteeEventDTO>> EventInvitee(int id);
        int TotalInvitee(int id);
        OperationResult<BookReadingEventDTO> Update(BookReadingEventDTO item);
        public OperationResult<IEnumerable<InviteeEventDTO>> EventsByMail(string mail);

    }
}
