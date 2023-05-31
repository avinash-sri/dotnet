using AutoMapper;
using Company.Project.ProductDomain.AppServices;
using Company.Project.ProductDomain.AppServices.DTOs;
using Company.Project.Web.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Company.Project.Web.Controllers
{
    public class AccountController : Controller
    {
        private IMapper _mapper;

        private readonly ILogger<AccountController> _logger;

        private readonly IUserRegistrationAppService _users;

        public AccountController(ILogger<AccountController> logger, IUserRegistrationAppService users, IMapper mapper)
        {
            _logger = logger;
            _mapper = mapper;
            _users = users;

        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult LogOut()
        {
            //TempData["Name"] = null;
            //TempData["Email"] = null;
            return RedirectToAction("Login");
        }

        public IActionResult Register(UserRegistrationModel user)
        {

            var email = user.Email;
            var password = user.Password;
            var userVerification = _users.Verify(email, password);
            var userDTO = userVerification.Data;
            var userDetails = _mapper.Map<UserRegistrationDTO, UserRegistrationModel>(userDTO);
            if (userDetails == null)
            {
                user.ErrorMessage = "Wrong Email or Password";
                return View("Login", user);
            }
            else
            {
                HttpContext.Session.SetString("Email", userDetails.Email);
                TempData["Email"] = userDetails.Email;
                TempData["Name"] = userDetails.FullName;
                return RedirectToAction("Index", "Event");
            }
        }

        public IActionResult SignUp()
        {
            return View();
        }
        //post
        public IActionResult SignUpPost(UserRegistrationModel user)
        {
            var userDTO = _mapper.Map<UserRegistrationModel, UserRegistrationDTO>(user);
            _users.Create(userDTO);
            return RedirectToAction("Login", "Account");
        }
    }
}
