using Company.Project.Core.AppServices;
using System;
using System.Collections.Generic;
using System.Text;
namespace Company.Project.ProductDomain.AppServices.DTOs
{
    public class LookUpDTO : DtoBase
    {
        //public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int IsDelete { get; set; }
        public int LookUpCategoryId { get; set; }
    }
}
