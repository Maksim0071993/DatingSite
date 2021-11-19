using AutoMapper;
using DatingApp.BusinesLogic.BusinessModel;
using DatingApp.BusinesLogic.Services.Interfaces;
using DatingApp.DataAccessLayer.Models;
using DatingApp.DataAccessLayer.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DatingApp.BusinesLogic.Services
{
    public class LookupValueService : ILookupValueService
    {
        private readonly IUnitOfWork _unitOfWork;
        public LookupValueService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void Add(LookupValueModel model)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<LookupValue,LookupValueModel>());
            var mapper = new Mapper(config);
            var lookupValue = mapper.Map<DatingApp.DataAccessLayer.Models.LookupValue>(model);
            _unitOfWork.LookupValue.Add(lookupValue);
            _unitOfWork.Save();
        }

        public List<LookupValueModel> GetByCode(string code)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<LookupValue,LookupValueModel>());
            var mapper = new Mapper(config);
            var lookupType = _unitOfWork.LookupType.Get().FirstOrDefault(p => p.Code == code);
            List<LookupValueModel> result = null;
            if (lookupType != null)
            {
                result = _unitOfWork.LookupValue.Get().Where(p => p.LookupTypeId == lookupType.Id).Select(p => mapper.Map<LookupValueModel>(p)).ToList();
            }

            return result;
        }
    }
}
