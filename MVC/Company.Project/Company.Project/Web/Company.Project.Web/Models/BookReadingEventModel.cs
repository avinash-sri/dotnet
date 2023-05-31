using Company.Project.Core.WebMVC;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Company.Project.Web.Models
{
    public class BookReadingEventModel : ViewModel
    {
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = " Please Enter title of the book")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Please Enter the Event Date")]
        [Display(Name = "Event Date")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "Please Enter the location")]
        public string Location { get; set; }

        [Required(ErrorMessage = "Please Enter the start time")]
        [Display(Name = "Start Time")]
        //[DataType(DataType.Time)]
        public string StartTime { get; set; }

        [Display(Name = "Type of Event")]
        public int Type { get; set; }

        public int Duration { get; set; }
        public string Description { get; set; }

        [Display(Name = "Other Details")]
        public string OtherDetails { get; set; }
        public int IsDelete { get; set; }

        [Display(Name = "Invitees Email")]
        public string EventInvitee { get; set; }

        public int numberOfInvitee { get; set; }

        public string startTimeNav { get; set; }
        public string dateNav { get; set; }
    }
}
