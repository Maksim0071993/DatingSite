using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingApp.DataAccessLayer.Repositories.Interfaces
{
    public interface IUnitOfWork
    {
        IRegistrationRepository Registration { get; }
        IProfileRepository Profile { get; }
        IChatRepository Chat { get; }
        ILookupTypeRepository LookupType { get; }
        ILookupValueRepository LookupValue { get; }
        
        void Save();
    }
}
