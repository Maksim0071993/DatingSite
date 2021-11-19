using System;
using System.Collections.Generic;

#nullable disable

namespace DatingApp.DataAccessLayer.Models
{
    public partial class LookupValue
    {
        public LookupValue()
        {
            Profiles = new HashSet<Profile>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public int? LookupTypeId { get; set; }

        public virtual LookupType LookupType { get; set; }
        public virtual ICollection<Profile> Profiles { get; set; }
    }
}
