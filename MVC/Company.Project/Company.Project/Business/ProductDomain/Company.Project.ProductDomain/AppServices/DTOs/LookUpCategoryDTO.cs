using Company.Project.Core.AppServices;
using System;
using System.Collections.Generic;
using System.Text;
namespace Company.Project.ProductDomain.AppServices.DTOs
{
    public class LookUpCategoryDTO : DtoBase
    {
        //public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
