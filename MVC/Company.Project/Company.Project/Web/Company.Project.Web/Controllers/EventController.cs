using AutoMapper;
using Company.Project.Core.ValueObjects;
using Company.Project.ProductDomain.AppServices;
using Company.Project.ProductDomain.AppServices.DTOs;
using Company.Project.Web.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Company.Project.Web.Controllers
{
    public class EventController : Controller
    {
        private IMapper _mapper;
        private readonly ILogger<EventController> _logger;

        private readonly IBookReadingEventAppService _events;


        public EventController(ILogger<EventController> logger, IBookReadingEventAppService events, IMapper mapper)
        {
            _mapper = mapper;
            _events = events;
            _logger = logger;
        }

        // GET: EventController
        public IActionResult Index()
        {
            OperationResult<IEnumerable<BookReadingEventDTO>> eventDTOlist = _events.GetAll();
            IEnumerable<BookReadingEventDTO> eventsdto = eventDTOlist.Data.ToList();
            List<BookReadingEventModel> eventModellist = new List<BookReadingEventModel>();
            eventModellist = _mapper.Map<IEnumerable<BookReadingEventDTO>, List<BookReadingEventModel>>(eventsdto);

            return View(eventModellist);
        }


        // GET: EventController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EventController/Create
        public IActionResult CreateEvent()
        {
            var eventmodel = new BookReadingEventModel();
            ViewBag.StartTime = GetStartTime();
            ViewBag.Type = GetUserType();
            return View(eventmodel);
        }

        //create post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateEventPost(BookReadingEventModel model)
        {
            BookReadingEventModel eventModel = model;
            BookReadingEventDTO modelDTO = _mapper.Map<BookReadingEventModel, BookReadingEventDTO>(eventModel);
            var createEvent = _events.Create(modelDTO);
            var eventCreate = createEvent.Data;
            var eventModelList = _mapper.Map<BookReadingEventDTO, BookReadingEventModel>(eventCreate);
            var invitee = model.EventInvitee;
            foreach (var item in invitee.Split(','))
            {

                InviteeEventModel eventInvitees = new InviteeEventModel();
                eventInvitees.EventId = eventCreate.Id;
                eventInvitees.Email = item;
                InviteeEventDTO inviteeDTO = _mapper.Map<InviteeEventModel, InviteeEventDTO>(eventInvitees);
                _events.AddInviteeByMail(inviteeDTO);
            }
            return RedirectToAction("CreateEvent");
        }

        // GET: EventController/Delete/5
        public IActionResult Delete(int Id)
        {
            var eventDTO = _events.GetById(Id);
            BookReadingEventDTO eventDTOId = eventDTO.Data;
            BookReadingEventModel eventModelId = _mapper.Map<BookReadingEventDTO, BookReadingEventModel>(eventDTOId);
            var eventInvitee = _events.EventInvitee(Id);
            var invitees = eventInvitee.Data.ToList();
            var eventInviteeMap = _mapper.Map<IEnumerable<InviteeEventDTO>, IEnumerable<InviteeEventModel>>(invitees);
            string inviteeString = "";
            foreach (var item in eventInviteeMap)
            {
                inviteeString += item.Email;
                inviteeString += ',';
            }
            eventModelId.EventInvitee = inviteeString;
            ViewBag.StartTime = GetStartTime();
            ViewBag.Type = GetUserType();
            eventModelId.startTimeNav = eventModelId.StartTime;
            eventModelId.dateNav = eventModelId.Date.ToString("yyyy-MM-dd");
            return View(eventModelId);

        }

        // POST: EventController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(BookReadingEventModel model)
        {
            var eventDTOmap = _mapper.Map<BookReadingEventModel, BookReadingEventDTO>(model);
            var eventDTODelete = _events.DeletePost(eventDTOmap);
            var eventDTO = eventDTODelete.Data;
            var eventDTOmodelmap = _mapper.Map<BookReadingEventDTO, BookReadingEventModel>(eventDTO);

            var inviteesDTO = _events.GetInviteeById(eventDTOmodelmap.Id);
            var invitees = _mapper.Map<IEnumerable<InviteeEventDTO>, IEnumerable<InviteeEventModel>>(inviteesDTO);
            foreach (var invited in invitees)
            {
                var invitedIn = _mapper.Map<InviteeEventModel, InviteeEventDTO>(invited);
                _events.GetInviteeUpdate(invitedIn);
            }

            return RedirectToAction("Index");
        }

        public IActionResult Update(int Id)
        {
            var eventDTO = _events.GetById(Id);
            BookReadingEventDTO eventDTOId = eventDTO.Data;
            BookReadingEventModel eventmodelId = _mapper.Map<BookReadingEventDTO, BookReadingEventModel>(eventDTOId);
            var eventInvitee = _events.EventInvitee(Id);
            var invitees = eventInvitee.Data.ToList();
            var eventinviteeMap = _mapper.Map<IEnumerable<InviteeEventDTO>, IEnumerable<InviteeEventModel>>(invitees);
            string inviteeString = "";
            foreach (var item in eventinviteeMap)
            {
                inviteeString += item.Email;
                inviteeString += ',';
            }
            eventmodelId.EventInvitee = inviteeString;
            ViewBag.StartTime = GetStartTime();
            ViewBag.Type = GetUserType();
            return View(eventmodelId);

        }

        //update post
        public IActionResult UpdatePost(BookReadingEventModel model)
        {
            BookReadingEventModel eventModel = model;
            BookReadingEventDTO modelDTO = _mapper.Map<BookReadingEventModel, BookReadingEventDTO>(eventModel);
            var createEvent = _events.Update(modelDTO);
            var eventCreate = createEvent.Data;
            var eventModelList = _mapper.Map<BookReadingEventDTO, BookReadingEventModel>(eventCreate);
            var invitee = model.EventInvitee;
            var allInviteesDTO = _events.GetInviteeById(eventModelList.Id);
            var allInvitees = _mapper.Map<IEnumerable<InviteeEventDTO>, IEnumerable<InviteeEventModel>>(allInviteesDTO);

            foreach (var element in invitee.Split(','))
            {
                InviteeEventModel eventInvitees = new InviteeEventModel();
                eventInvitees.EventId = eventModelList.Id;
                eventInvitees.Email = element;
                InviteeEventDTO inviteeDTO = _mapper.Map<InviteeEventModel, InviteeEventDTO>(eventInvitees);
                _events.AddInviteeByMail(inviteeDTO);
            }
            return RedirectToAction("Index");
        }

        public IActionResult ViewEvent(int id)
        {
            var eventDTO = _events.GetById(id);
            BookReadingEventDTO eventDTOId = eventDTO.Data;
            BookReadingEventModel eventModelId = _mapper.Map<BookReadingEventDTO, BookReadingEventModel>(eventDTOId);
            eventModelId.numberOfInvitee = _events.TotalInvitee(id);
            return View(eventModelId);
        }

        public IActionResult InvitedEvent()
        {
            var mail = HttpContext.Session.GetString("Email");
            var eventlistdto = _events.EventsByMail(mail);
            var eventlist = eventlistdto.Data.ToList();
            var eventlistviewmodel = _mapper.Map<IEnumerable<InviteeEventDTO>, IEnumerable<InviteeEventModel>>(eventlist);
            List<BookReadingEventModel> events = new List<BookReadingEventModel>();
            foreach (var item in eventlistviewmodel)
            {
                var operationeventDTO = _events.GetById(item.EventId);
                var eventdto = operationeventDTO.Data;
                var mainevent = _mapper.Map<BookReadingEventDTO, BookReadingEventModel>(eventdto);
                events.Add(mainevent);
            }
            return View(events);
        }

        private List<SelectListItem> GetUserType()
        {
            var eventTypeDTO = _events.EventType();
            var eventUserType = eventTypeDTO.Data.ToList();
            var eventViewUserType = _mapper.Map<IEnumerable<LookUpDTO>, List<LookUpModel>>(eventUserType);

            var listUserType = new List<SelectListItem>();
            listUserType = eventViewUserType.Select(fn => new SelectListItem()
            {
                Value = fn.Id.ToString(),
                Text = fn.Name

            }).ToList();

            var defItem = new SelectListItem()
            {
                Value = "",
                Text = "--------Select Item--------"
            };
            listUserType.Insert(0, defItem);
            return listUserType;
        }

        private List<SelectListItem> GetStartTime()
        {

            var startTimeDTO = _events.StartTime();
            var eventStartTime = startTimeDTO.Data.ToList();
            var eventViewStartTime = _mapper.Map<IEnumerable<LookUpDTO>, IEnumerable<LookUpModel>>(eventStartTime);

            var listStartTime = new List<SelectListItem>();
            listStartTime = eventViewStartTime.Select(fn => new SelectListItem()
            {
                Value = fn.Id.ToString(),
                Text = fn.Name

            }).ToList();
            var defItem = new SelectListItem()
            {
                Value = "",
                Text = "--------Select Item--------"
            };
            listStartTime.Insert(0, defItem);
            return listStartTime;
        }


        // POST: EventController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EventController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EventController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        
    }
}
