using Company.Project.Core.WebMVC;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
namespace Company.Project.Web.Models
{
    public class InviteeEventModel : ViewModel
    {
        [Required]
        public int Id { get; set; }

        public string Email { get; set; }

        public int IsDelete { get; set; }

        public int EventId { get; set; }
    }
}
