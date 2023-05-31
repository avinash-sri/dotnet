using Company.Project.Core.AppServices;
using System;
using System.Collections.Generic;
using System.Text;
namespace Company.Project.ProductDomain.AppServices.DTOs
{
    public class InviteeEventDTO : DtoBase
    {
        //public int Id { get; set; }
        public string Email { get; set; }
        public int IsDelete { get; set; }
        public int EventId { get; set; }
    }
}
