using DatingApp.DataAccessLayer.Models;
using DatingApp.DataAccessLayer.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DatingApp.DataAccessLayer.Repositories
{
    public class NewUnitOfWork : IUnitOfWork
    {
        private readonly DatingAppWinFormsContext datingAppWinFormsContext;
        private readonly IRegistrationRepository registrationRepository;
        private readonly IProfileRepository profileRepository;
        private readonly IChatRepository chatRepository;
        private readonly ILookupTypeRepository lookupTypeRepository;
        private readonly ILookupValueRepository lookupValueRepository;
        public NewUnitOfWork(
            IRegistrationRepository registrationRepository,
            IProfileRepository profileRepository,
            IChatRepository chatRepository,
            DatingAppWinFormsContext datingAppWinFormsContext,
            ILookupTypeRepository lookupTypeRepository,
            ILookupValueRepository lookupValueRepository)
        {
            this.datingAppWinFormsContext = datingAppWinFormsContext;
            this.registrationRepository = registrationRepository;
            this.profileRepository = profileRepository;
            this.chatRepository = chatRepository;
            this.lookupTypeRepository = lookupTypeRepository;
            this.lookupValueRepository = lookupValueRepository;
        }

        public IRegistrationRepository Registration
        {
            get
            {              
                return this.registrationRepository;
            }
        }

        public IProfileRepository Profile
        {
            get
            {
                return this.profileRepository;
            }
        }
        public IChatRepository Chat
        {
            get
            {
                return this.chatRepository;
            }
        }

        public ILookupTypeRepository LookupType
        {
            get
            {
                return this.lookupTypeRepository;
            }
        }
        public ILookupValueRepository LookupValue
        {
            get
            {
                return this.lookupValueRepository;
            }
        }
        public void Save()
        {
            datingAppWinFormsContext.SaveChanges();
        }
    }
}
