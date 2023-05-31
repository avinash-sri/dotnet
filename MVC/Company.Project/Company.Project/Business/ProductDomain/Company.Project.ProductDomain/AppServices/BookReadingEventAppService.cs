using AutoMapper;
using Company.Project.Core.AppServices;
using Company.Project.Core.ExceptionManagement;
using Company.Project.Core.ValueObjects;
using Company.Project.ProductDomain.AppServices.DTOs;
using Company.Project.ProductDomain.Domain;
using Company.Project.ProductDomain.Repository;
using Company.Project.ProductDomain.UoW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Company.Project.ProductDomain.AppServices
{
    public class BookReadingEventAppService : AppService, IBookReadingEventAppService
    {
        private IMapper mapper;
        //private IApplicationUnitOfWork unitOfWork;
        //private IExceptionManager exceptionManager;
        private IBookReadingEventRepository eventRepository;
        private IInviteeEventRepository inviteeEventRepository;
        private ILookUpRepository lookupRepository;

        public BookReadingEventAppService(IProductUnitOfWork unitOfWork, IBookReadingEventRepository eventRepository, IInviteeEventRepository inviteeEventRepository, ILookUpRepository lookupRepository, IMapper mapper, IExceptionManager exceptionManager) : base(unitOfWork, exceptionManager)
        {
            this.mapper = mapper;
            //this.unitOfWork = unitOfWork;
            //this.exceptionManager = exceptionManager;
            this.eventRepository = eventRepository;
            this.inviteeEventRepository = inviteeEventRepository;
            this.lookupRepository = lookupRepository;
        }

        public void AddInviteeByMail(InviteeEventDTO item)
        {
            InviteeEvent invites = mapper.Map<InviteeEventDTO, InviteeEvent>(item);
            invites.IsDelete = 0;
            inviteeEventRepository.Create(invites);
            UnitOfWork.Commit();
            item.Id = invites.Id;
        }

        public OperationResult<BookReadingEventDTO> Create(BookReadingEventDTO item)
        {
            BookReadingEvent events = mapper.Map<BookReadingEventDTO, BookReadingEvent>(item);

            events.IsDelete = 0;

            // events.CreatedOnDate = DateTimeOffset.Now; 

            OperationResult result;
            eventRepository.Create(events);
            result = UnitOfWork.Commit();
            item.Id = events.Id;

            return new OperationResult<BookReadingEventDTO>(item, result.IsSuccess, result.MainMessage, result.AssociatedMessages.ToList<Message>());
        }

        //post delete, making
        public OperationResult<BookReadingEventDTO> DeletePost(BookReadingEventDTO dtoitem)
        {            
                var delevents = mapper.Map<BookReadingEventDTO, BookReadingEvent>(dtoitem);
                var eventById = eventRepository.GetById(delevents.Id);
                eventById.Id = delevents.Id;
                eventById.IsDelete = 1;
                OperationResult result;
                eventRepository.Update(eventById);
                result = UnitOfWork.Commit();
                return new OperationResult<BookReadingEventDTO>(dtoitem, result.IsSuccess, result.MainMessage, result.AssociatedMessages.ToList<Message>());
            
        }

        public OperationResult<IEnumerable<InviteeEventDTO>> EventInvitee(int id)
        {
            var invitee = inviteeEventRepository.GetById(id);
            var eventinviteeDTOList = mapper.Map<IEnumerable<InviteeEvent>, IEnumerable<InviteeEventDTO>>(invitee);
            Message message = new Message(string.Empty, "Return Successfully");
            return new OperationResult<IEnumerable<InviteeEventDTO>>(eventinviteeDTOList, true, message);
        }

        public OperationResult<IEnumerable<InviteeEventDTO>> EventsByMail(string mail)
        {
            var inviteeDomain = inviteeEventRepository.EventListByEmail(mail);
            var inviteeDto = mapper.Map<IEnumerable<InviteeEvent>, IEnumerable<InviteeEventDTO>>(inviteeDomain);
            Message message = new Message(string.Empty, "Return Successfully");
            return new OperationResult<IEnumerable<InviteeEventDTO>>(inviteeDto, true, message);
        }

        public OperationResult<IEnumerable<LookUpDTO>> EventType()
        {
            var startTimeList = lookupRepository.GetEventType();
            List<LookUpDTO> lookupTOList = new List<LookUpDTO>();
            lookupTOList = mapper.Map<IEnumerable<LookUp>, List<LookUpDTO>>(startTimeList);
            Message message = new Message(string.Empty, "Return Successfully");
            return new OperationResult<IEnumerable<LookUpDTO>>(lookupTOList, true, message);
        }

        public OperationResult<IEnumerable<BookReadingEventDTO>> GetAll()
        {
            // Want to put EventDto.StartTime = Event.StartTimeNevigation.Name

            IEnumerable<BookReadingEvent> eventtList = eventRepository.GetAll();
            List<BookReadingEventDTO> eventDTOList = new List<BookReadingEventDTO>();
            eventDTOList = mapper.Map<IEnumerable<BookReadingEvent>, List<BookReadingEventDTO>>(eventtList);
            foreach (var item in eventtList)
            {
                foreach (var itemDTO in eventDTOList)
                {
                    if (item.Id == itemDTO.Id)
                    {
                        itemDTO.StartTime = item.StartTimeNavigation.Name;
                    }

                }
            }
            Message message = new Message(string.Empty, "Return Successfully");
            return new OperationResult<IEnumerable<BookReadingEventDTO>>(eventDTOList, true, message);
        }

        public OperationResult<IEnumerable<BookReadingEventDTO>> GetAllEvents()
        {
            IEnumerable<BookReadingEvent> bookReadingEventList = eventRepository.GetAllEvent();
            List<BookReadingEventDTO> bookReadingEventDTOList = new List<BookReadingEventDTO>();
            bookReadingEventDTOList = mapper.Map<IEnumerable<BookReadingEvent>, List<BookReadingEventDTO>>(bookReadingEventList);
            Message message = new Message(string.Empty, "Return Successfully");
            return new OperationResult<IEnumerable<BookReadingEventDTO>>(bookReadingEventDTOList, true, message);
        }

        public OperationResult<BookReadingEventDTO> GetById(int id)
        {
            BookReadingEvent eventById = eventRepository.GetById(id);
            BookReadingEventDTO eventdto = new BookReadingEventDTO();
            eventdto = mapper.Map<BookReadingEvent, BookReadingEventDTO>(eventById);
            eventdto.StartTime = eventById.StartTimeNavigation.Name;
            Message message = new Message(string.Empty, "Return Successfully");
            return new OperationResult<BookReadingEventDTO>(eventdto, true, message);
        }

        public IEnumerable<InviteeEventDTO> GetInviteeById(int id)
        {
            var invitee = inviteeEventRepository.GetById(id);
            var invitees = mapper.Map<IEnumerable<InviteeEvent>, IEnumerable<InviteeEventDTO>>(invitee);
            return invitees;
        }

        public void GetInviteeUpdate(InviteeEventDTO item)
        {
            var flag = mapper.Map<InviteeEventDTO, InviteeEvent>(item);
            var updateinvitee = inviteeEventRepository.GetEachInviteeById(flag.Id);
            updateinvitee.Id = flag.Id;
            updateinvitee.IsDelete = 1;
            inviteeEventRepository.Update(updateinvitee);
        }

        public OperationResult<IEnumerable<LookUpDTO>> StartTime()
        {
            var startTimeList = lookupRepository.GetStartTime();
            List<LookUpDTO> lookupTOList = new List<LookUpDTO>();
            lookupTOList = mapper.Map<IEnumerable<LookUp>, List<LookUpDTO>>(startTimeList);
            Message message = new Message(string.Empty, "Return Successfully");
            return new OperationResult<IEnumerable<LookUpDTO>>(lookupTOList, true, message);
        }

        public int TotalInvitee(int id)
        {
            var total = inviteeEventRepository.total(id);
            return total;
        }

        public OperationResult<BookReadingEventDTO> Update(BookReadingEventDTO item)
        {
            BookReadingEvent events = mapper.Map<BookReadingEventDTO, BookReadingEvent>(item);
            int id = events.Id;
            var eventupdate = eventRepository.GetById(id);
            eventupdate.Id = events.Id;
            eventupdate.Title = events.Title;
            eventupdate.Date = events.Date;
            eventupdate.Location = events.Location;
            eventupdate.StartTime = events.StartTime;
            eventupdate.Type = events.Type;
            eventupdate.DurationInHours = events.DurationInHours;
            eventupdate.Description = events.Description;
            eventupdate.OtherDetails = events.OtherDetails;
            eventupdate.IsDelete = 0;
            // eventupdate.UpdateOnDate = DateTimeOffset.Now;
            OperationResult result;
            eventRepository.Update(eventupdate);
            result = UnitOfWork.Commit();

            item.Id = events.Id;
            return new OperationResult<BookReadingEventDTO>(item, result.IsSuccess, result.MainMessage, result.AssociatedMessages.ToList<Message>());
        }
    }
}
