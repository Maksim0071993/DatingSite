using DatingApp.DataAccessLayer.Models;
using DatingApp.DataAccessLayer.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingApp.DataAccessLayer.Repositories
{
    //public class UnitOfWork : IUnitOfWork
    //{
    //    private DatingAppWinFormsContext datingAppWinFormsContext = new DatingAppWinFormsContext();
    //    private RegistrationRepository registrationRepository;
    //    private ProfileRepository profileRepository;
    //    private ChatRepository messageRepository;
        

    //    public IRegistrationRepository Registration
    //    {
    //        get
    //        {
    //            if (registrationRepository == null)
    //                registrationRepository = new RegistrationRepository(datingAppWinFormsContext);
    //            return registrationRepository;
    //        }
    //    }
    //    public IProfileRepository Profile
    //    {
    //        get
    //        {
    //            if (profileRepository == null)
    //                profileRepository = new ProfileRepository(datingAppWinFormsContext);
    //            return profileRepository;
    //        }
    //    }
    //    public IChatRepository Chat
    //    {
    //        get
    //        {
    //            if (messageRepository == null)
    //                messageRepository = new ChatRepository(datingAppWinFormsContext);
    //            return messageRepository;
    //        }
    //    }

    //    public ILookupTypeRepository LookupType => throw new NotImplementedException();

    //    public ILookupValueRepository LookupValue => throw new NotImplementedException();

    //    public void Save()
    //    {
    //        datingAppWinFormsContext.SaveChanges();
    //    }
    //}
}
