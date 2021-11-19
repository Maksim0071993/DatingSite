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
        public SearchController(ISearchService searchService)
        {
            _searchService = searchService;
        }

        public IActionResult Index()
        {
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
