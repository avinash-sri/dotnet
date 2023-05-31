using System;
using System.Collections.Generic;

namespace Company.Project.ProductDomain.Domain
{
    public partial class LookUp
    {
        public LookUp()
        {
            BookReadingEventStartTimeNavigation = new HashSet<BookReadingEvent>();
            BookReadingEventTypeNavigation = new HashSet<BookReadingEvent>();
            UserRegistration = new HashSet<UserRegistration>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int IsDelete { get; set; }
        public int LookUpCategoryId { get; set; }

        public virtual LookUpCategory LookUpCategory { get; set; }
        public virtual ICollection<BookReadingEvent> BookReadingEventStartTimeNavigation { get; set; }
        public virtual ICollection<BookReadingEvent> BookReadingEventTypeNavigation { get; set; }
        public virtual ICollection<UserRegistration> UserRegistration { get; set; }
    }
}
