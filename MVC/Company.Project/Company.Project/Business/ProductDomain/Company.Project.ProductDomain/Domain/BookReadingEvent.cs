using System;
using System.Collections.Generic;

namespace Company.Project.ProductDomain.Domain
{
    public partial class BookReadingEvent
    {
        public BookReadingEvent()
        {
            CommentEvent = new HashSet<CommentEvent>();
            InviteeEvent = new HashSet<InviteeEvent>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Location { get; set; }
        public int StartTime { get; set; }
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
