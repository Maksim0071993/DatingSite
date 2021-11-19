using DatingApp.DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DatingApp.DataAccessLayer.Repositories.Interfaces
{
    public interface ILookupTypeRepository
    {
        public void Add(LookupType lookupType);

        public List<LookupType> Get(Func<LookupType, bool> func);
        IQueryable<LookupType> Get();

        public List<LookupType> GetAll();
    }
}
