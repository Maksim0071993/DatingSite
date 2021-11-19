using DatingApp.BusinesLogic.BusinessModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingApp.BusinesLogic.Services.Interfaces
{
    public interface IProfileService
    {
        void CreateProfile(ProfileModel model);
        List<ProfileModel> GetAll();
        ProfileModel GetById(int id);
    }
}
