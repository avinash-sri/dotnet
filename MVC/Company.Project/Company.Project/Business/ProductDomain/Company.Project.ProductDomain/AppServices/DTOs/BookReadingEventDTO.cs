using Company.Project.Core.AppServices;
using Company.Project.ProductDomain.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Company.Project.ProductDomain.AppServices.DTOs
{
    public class BookReadingEventDTO : DtoBase
    {
        //public int Id { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Location { get; set; }
        public string StartTime { get; set; }
        public int Type { get; set; }
        public int? DurationInHours { get; set; }
        public string Description { get; set; }
        public string OtherDetails { get; set; }
        public int IsDelete { get; set; }

        public virtual LookUp StartTimeNavigation { get; set; }
        public virtual LookUp TypeNavigation { get; set; }
        public virtual ICollection<CommentEvent> CommentEvent { get; set; }
        public virtual ICollection<InviteeEvent> InviteeEvent { get; set; }
    }
}
