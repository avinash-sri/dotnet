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
    public class UserRegistrationAppService : AppService, IUserRegistrationAppService
    {
        private IMapper mapper;
        private IUserRegistrationUnitOfWork unitOfWork;
        private IExceptionManager exceptionManager;
        private IUserRegistrationRepository userRepository;

        public UserRegistrationAppService(IUserRegistrationRepository userRepository, IUserRegistrationUnitOfWork unitOfWork, IMapper mapper, IExceptionManager exceptionManager) : base(unitOfWork, exceptionManager)
        {
            this.mapper = mapper;
            this.unitOfWork = unitOfWork;
            this.exceptionManager = exceptionManager;
            this.userRepository = userRepository;  
        }

        public OperationResult<UserRegistrationDTO> Create(UserRegistrationDTO item)
        {
            UserRegistration user = mapper.Map<UserRegistrationDTO, UserRegistration>(item);
            OperationResult result;
            user.UserType = 28;
            userRepository.Create(user);
            result = UnitOfWork.Commit();
            item.Id = user.Id;
            return new OperationResult<UserRegistrationDTO>(item, result.IsSuccess, result.MainMessage, result.AssociatedMessages.ToList<Message>());
        }

        public OperationResult<UserRegistrationDTO> Verify(string email, string password)
        {
            var user = userRepository.IsVerified(email, password);
            OperationResult result;
            var userDto = mapper.Map<UserRegistration, UserRegistrationDTO>(user);
            result = UnitOfWork.Commit();
            return new OperationResult<UserRegistrationDTO>(userDto, result.IsSuccess, result.MainMessage, result.AssociatedMessages.ToList<Message>());
        }
    }
}
