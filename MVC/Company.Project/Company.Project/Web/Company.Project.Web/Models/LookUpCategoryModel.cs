using Company.Project.Core.WebMVC;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
namespace Company.Project.Web.Models
{
    public class LookUpCategoryModel : ViewModel
    {
        [Required]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
