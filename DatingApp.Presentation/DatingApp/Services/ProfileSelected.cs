using DatingApp.BusinesLogic.BusinessModel;
using DatingApp.DataAccessLayer.Models;
using DatingApp.Presentation.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DatingApp.Presentation.Services
{
    public class ProfileSelected
    {
        public ProfileModel Profile { get; set; }
        public int RegistrationId { get; set; }
        public ProfileSelected()
        {
            Profile = new ProfileModel();
        }
    }
}
