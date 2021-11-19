using System;
using System.Collections.Generic;
using System.Text;

namespace DatingApp.BusinesLogic.BusinessModel
{
    public class LookupTypeModel
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Title { get; set; }
        public virtual ICollection<LookupValueModel> LookupValues { get; set; }
    }
}
