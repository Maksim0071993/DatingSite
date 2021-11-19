using DatingApp.BusinesLogic.BusinessModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace DatingApp.BusinesLogic.Services.Interfaces
{
    public interface ILookupValueService
    {
        public void Add(LookupValueModel model);
        public List<LookupValueModel> GetByCode(string code);
    }
}
