using DatingApp.DataAccessLayer.Models;
using DatingApp.DataAccessLayer.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DatingApp.DataAccessLayer.Repositories
{
    public class LookupValueRepository : ILookupValueRepository
    {
        private readonly DatingAppWinFormsContext _datingAppWinFormsContext;

        public LookupValueRepository(DatingAppWinFormsContext datingAppWinFormsContext)
        {
            _datingAppWinFormsContext = datingAppWinFormsContext;
        }
        public void Add(LookupValue lookupValue)
        {
            _datingAppWinFormsContext.LookupValues.Add(lookupValue);
        }
        public List<LookupValue> Get(Func<LookupValue, bool> func)
        {
            var lookupValue = _datingAppWinFormsContext.LookupValues.Where(func).ToList();
            return lookupValue;
        }

        public IQueryable<LookupValue> Get()
        {
            return _datingAppWinFormsContext.LookupValues.AsQueryable();
        }
        public List<LookupValue> GetAll()
        {
            var lookupValue = _datingAppWinFormsContext.LookupValues.ToList();
            return lookupValue;
        }
    }
}
