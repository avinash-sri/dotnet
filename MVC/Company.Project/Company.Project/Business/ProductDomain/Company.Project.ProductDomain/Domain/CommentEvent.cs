using System;
using System.Collections.Generic;

namespace Company.Project.ProductDomain.Domain
{
    public partial class CommentEvent
    {
        public int Id { get; set; }
        public string Comments { get; set; }
        public DateTime DateTime { get; set; }
        public int EventId { get; set; }

        public virtual BookReadingEvent Event { get; set; }
    }
}
