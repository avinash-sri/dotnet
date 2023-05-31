using Company.Project.Core.AppServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace Company.Project.ProductDomain.AppServices.DTOs
{
    public class CommentEventDTO : DtoBase
    {
        //public int Id { get; set; }
        public string Comments { get; set; }
        public DateTime DateTime { get; set; }
        public int EventId { get; set; }
    }
}
