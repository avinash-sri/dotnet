using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Company.Project.Web.Models;
using Company.Project.ProductDomain.AppServices;
using Company.Project.Core.ValueObjects;
using AutoMapper;
using Company.Project.ProductDomain.AppServices.DTOs;

namespace Company.Project.Web.Controllers
{
    public class HomeController : Controller
    {
        private IMapper _mapper;
        private readonly ILogger<HomeController> _logger;
        private readonly IBookReadingEventAppService _events;

        public HomeController(ILogger<HomeController> logger, IBookReadingEventAppService events, IMapper mapper)
        {
            _logger = logger;
            _events = events;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            OperationResult<IEnumerable<BookReadingEventDTO>> eventDTOList = _events.GetAllEvents();
            IEnumerable<BookReadingEventDTO> eventDTO = eventDTOList.Data.ToList();
            List<BookReadingEventModel> bookReadingEventModelList = new List<BookReadingEventModel>();
            bookReadingEventModelList = _mapper.Map<IEnumerable<BookReadingEventDTO>, List<BookReadingEventModel>>(eventDTO);
            return View(bookReadingEventModelList);
        }

        public IActionResult Privacy()
        {

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
