using DatingApp.BusinesLogic.BusinessModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace DatingApp.BusinesLogic.Services.Interfaces
{
    public interface ILookupTypeService
    {
        public void Add(LookupTypeModel model);
        public List<LookupTypeModel> GetAll();
    }
}
