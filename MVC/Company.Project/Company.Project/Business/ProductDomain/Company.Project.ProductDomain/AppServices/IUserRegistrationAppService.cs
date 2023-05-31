using Company.Project.Core.AppServices;
using Company.Project.Core.ValueObjects;
using Company.Project.ProductDomain.AppServices.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Company.Project.ProductDomain.AppServices
{
    public interface IUserRegistrationAppService : IAppService
    {
        public OperationResult<UserRegistrationDTO> Create(UserRegistrationDTO item);
        public OperationResult<UserRegistrationDTO> Verify(string email, string password);
    }
}
