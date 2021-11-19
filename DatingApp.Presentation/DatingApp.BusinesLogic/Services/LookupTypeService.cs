using AutoMapper;
using DatingApp.BusinesLogic.BusinessModel;
using DatingApp.BusinesLogic.Services.Interfaces;
using DatingApp.DataAccessLayer.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DatingApp.BusinesLogic.Services
{
    public class LookupTypeService : ILookupTypeService
    {
        private readonly IUnitOfWork _unitOfWork;
        public LookupTypeService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public void Add(LookupTypeModel model)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<DatingApp.DataAccessLayer.Models.LookupType, LookupTypeModel>());
            var mapper = new Mapper(config);
            var lookupType = mapper.Map<DatingApp.DataAccessLayer.Models.LookupType>(model);
            _unitOfWork.LookupType.Add(lookupType);
            _unitOfWork.Save();
        }
        public List<LookupTypeModel> GetAll()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<DataAccessLayer.Models.LookupType, LookupTypeModel>());
            var mapper = new Mapper(config);
            var lookUpModel = _unitOfWork.LookupType.GetAll().ToList();
            var result = lookUpModel.Select(p => mapper.Map<LookupTypeModel>(p)).ToList();
            return result;
        }
    }
}
