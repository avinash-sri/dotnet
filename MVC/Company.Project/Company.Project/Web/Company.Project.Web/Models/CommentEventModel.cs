using Company.Project.Core.WebMVC;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Company.Project.Web.Models
{
    public class CommentEventModel : ViewModel
    {
        [Required]
        public int Id { get; set; }
        public string Comments { get; set; }

        [Display(Name = "Date Time")]
        public DateTime dateTime { get; set; }

        public int EventId { get; set; }
    }
}
