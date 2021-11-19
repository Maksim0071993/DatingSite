using DatingApp.DataAccessLayer.Models;
using DatingApp.DataAccessLayer.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DatingApp.DataAccessLayer.Repositories
{
    public class LookupTypeRepository : ILookupTypeRepository
    {
        private readonly DatingAppWinFormsContext _datingAppWinFormsContext;

        public LookupTypeRepository(DatingAppWinFormsContext datingAppWinFormsContext)
        {
            _datingAppWinFormsContext = datingAppWinFormsContext;
        }

        public void Add(LookupType lookupType)
        {
            _datingAppWinFormsContext.LookupTypes.Add(lookupType);
        }
        public List<LookupType> Get(Func<LookupType, bool> func)
        {
            var lookupType = _datingAppWinFormsContext.LookupTypes.Where(func).ToList();
            return lookupType;
        }
        public IQueryable<LookupType> Get()
        {
            return _datingAppWinFormsContext.LookupTypes.AsQueryable();
        }
        public List<LookupType> GetAll()
        {
            var lookupType = _datingAppWinFormsContext.LookupTypes.ToList();
            return lookupType;
        }
    }
}
