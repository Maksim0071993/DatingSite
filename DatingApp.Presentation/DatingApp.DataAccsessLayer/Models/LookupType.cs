using System;
using System.Collections.Generic;

#nullable disable

namespace DatingApp.DataAccessLayer.Models
{
    public partial class LookupType
    {
        public LookupType()
        {
            LookupValues = new HashSet<LookupValue>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public string Title { get; set; }

        public virtual ICollection<LookupValue> LookupValues { get; set; }
    }
}
