using DatingApp.DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DatingApp.DataAccessLayer.Repositories.Interfaces
{
    public interface ILookupValueRepository
    {
        void Add(LookupValue lookupValue);
        List<LookupValue> Get(Func<LookupValue, bool> func);
        IQueryable<LookupValue> Get();
        List<LookupValue> GetAll();
    }
}
