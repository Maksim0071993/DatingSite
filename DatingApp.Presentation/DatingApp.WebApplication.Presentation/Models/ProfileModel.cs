
using DatingApp.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatingApp.WebApplication.Presentation.Models
{
    public class ProfileModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Sex Sex { get; set; }
        public Orientations Orientation { get; set; }
        public int CityId { get; set; }
        public string City { get; set; }
        public string AboutMe { get; set; }
        public byte[] DataImage { get; set; }
    }
}
