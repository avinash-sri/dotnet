using System;
using System.Collections.Generic;

namespace Company.Project.ProductDomain.Domain
{
    public partial class LookUpCategory
    {
        public LookUpCategory()
        {
            LookUp = new HashSet<LookUp>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<LookUp> LookUp { get; set; }
    }
}
