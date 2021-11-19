using AutoMapper;
using DatingApp.BusinesLogic.Services.Interfaces;
using DatingApp.WebApplication.Presentation.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Linq;

namespace DatingApp.WebApplication.Presentation.Controllers
{
    public class ProfileController : Controller
    {
        private readonly IProfileService _profileService;
        private readonly ILookupValueService _lookupValueService;
        public ProfileController(IProfileService profileService, ILookupValueService lookupValueService)
        {
            _lookupValueService = lookupValueService;
            _profileService = profileService;
        }

        [Route("Profile/{id}")]
        public IActionResult Index(int id)
        {
            var city = _lookupValueService.GetByCode("City").ToArray();
            SelectList cities = new SelectList(city, "CityId");
            ViewBag.city = cities;
            var profile = _profileService.GetById(id);
            //var convertResult = Convert.FromBase64String(profile.DataImage);
            //profile.DataImage = convertResult;

            var config = new MapperConfiguration(cfg => cfg.CreateMap<DatingApp.BusinesLogic.BusinessModel.ProfileModel, ProfileModel>());
            var mapper = new Mapper(config);          
            var result = mapper.Map<ProfileModel>(profile);

            return View(result);
        }
        [HttpGet]
        public ActionResult Index()
        {
            var profiles = _profileService.GetAll();  
            return View("List", profiles.ToList());
        }
        
        [HttpGet]
        public IActionResult Create()
        {
            if (User.Identity.IsAuthenticated)
            {     
                    return RedirectToAction("Index", "Chat");       
            }
            else if ()
            {

            }
            var cities = _lookupValueService.GetByCode("City").ToArray();
            ViewBag.Cities = cities;
            return View();
        }

        [HttpPost]
        public IActionResult Create([FromForm] DatingApp.BusinesLogic.BusinessModel.ProfileModel model)
        {
            if (model.DataImage != null)
            {
                byte[] imageArray = System.IO.File.ReadAllBytes(model.DataImage);
                string base64Image = Convert.ToBase64String(imageArray);
                model.DataImage = base64Image;
            }
            var config = new MapperConfiguration(cfg => cfg.CreateMap< ProfileModel, DatingApp.BusinesLogic.BusinessModel.ProfileModel>());
            var mapper = new Mapper(config);
            model.Id = int.Parse(User.Identity.Name);
            var result = mapper.Map<DatingApp.BusinesLogic.BusinessModel.ProfileModel>(model);
            //if (model.FirstName == null || model.Age == 0)
            //{
            //    ModelState.AddModelError("", "Поля 'First Name' и 'Age' должны быть заполнены");
            //    return View();
            //}
            //else
            //{
            //    _profileService.CreateProfile(model);
            //}

            return RedirectToAction("Chat", "Chat");
        }
    }
}
