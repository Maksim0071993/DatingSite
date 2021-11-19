using System;
using System.Collections.Generic;

#nullable disable

namespace DatingApp.DataAccessLayer.Models
{
    public partial class Image
    {
        public int Id { get; set; }
        public byte[] ImageData { get; set; }
        public int? ProfileId { get; set; }

        public virtual Profile Profile { get; set; }
    }
}
