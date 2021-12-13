using AutoMapper;
using DatingApp.BusinesLogic.Services;
using DatingApp.BusinesLogic.Services.Interfaces;
using DatingApp.WebApplication.Presentation.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatingApp.WebApplication.Presentation.Controllers
{
    public class SearchController : Controller
    {
        private readonly ISearchService _searchService;
        private readonly ILookupValueService _lookupValueService;
        public SearchController(ISearchService searchService, ILookupValueService lookupValueService)
        {
            _searchService = searchService;
            _lookupValueService = lookupValueService;
        }

        public IActionResult Index()
        {
            var cities = _lookupValueService.GetByCode("City").ToArray();
            ViewBag.Cities = cities;
            return View();
        }
        [HttpPost]
        public IActionResult ResultSearch([FromForm] SearchViewModel model)
        {
            var profiles =  _searchService.SearchUserToProfile(model.FirstName, model.AgeFrom, model.AgeTo, model.CityId, model.Sex, model.Orientation);
            return View("ResultSearch", profiles.ToList());  
        }
    }
}
