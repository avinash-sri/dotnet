using System;
using System.Collections.Generic;

namespace Company.Project.ProductDomain.Domain
{
    public partial class InviteeEvent
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public int IsDelete { get; set; }
        public int EventId { get; set; }

        public virtual BookReadingEvent Event { get; set; }
    }
}
