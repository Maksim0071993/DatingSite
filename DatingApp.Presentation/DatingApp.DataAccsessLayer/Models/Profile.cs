using DatingApp.Common;
using System;
using System.Collections.Generic;

#nullable disable

namespace DatingApp.DataAccessLayer.Models
{
    public partial class Profile
    {
        public Profile()
        {
            ChatRecepients = new HashSet<Chat>();
            ChatSenders = new HashSet<Chat>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Sex Sex { get; set; }
        public Orientations? Orientation { get; set; }
        public string AboutMe { get; set; }
        public int? CityId { get; set; }
        public string DataImage { get; set; }

        public virtual LookupValue City { get; set; }
        public virtual RegistrationUser IdNavigation { get; set; }
        public virtual ICollection<Chat> ChatRecepients { get; set; }
        public virtual ICollection<Chat> ChatSenders { get; set; }
    }
}
