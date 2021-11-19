
using DatingApp.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingApp.BusinesLogic.BusinessModel
{
    public class ProfileModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Sex Sex { get; set; }
        public Orientations? Orientation { get; set; }
        public string AboutMe { get; set; }
        public int? RegistrationUsersId { get; set; }
        public string City { get; set; }
        public int CityId { get; set; }
        public int Id { get; set; }
        public string DataImage { get; set; }

        public virtual RegistrationModel IdNavigation { get; set; }
        public virtual ICollection<ChatModel> ChatRecepients { get; set; }
        public virtual ICollection<ChatModel> ChatSenders { get; set; }
    }
}
