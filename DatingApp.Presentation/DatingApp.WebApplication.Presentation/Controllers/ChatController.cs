using AutoMapper;
using DatingApp.BusinesLogic.BusinessModel;
using DatingApp.BusinesLogic.Services.Interfaces;
using DatingApp.WebApplication.Presentation.Models;
using DatingApp.WebApplication.Presentation.SignalR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace DatingApp.WebApplication.Presentation.Controllers
{
    public class ChatController : Controller
    {
        private readonly IChatService _chatService;
        private readonly IProfileService _profileService;
        private readonly IHubContext<ChatHub> _hubContext;
        
        public ChatController(IChatService chatService, IProfileService profileService, IHubContext<ChatHub> hubContext)
        {
            _chatService = chatService;
            _profileService = profileService;
            _hubContext = hubContext;
        }

        [HttpGet]
        public IActionResult IncomingMessage()
        {
            int id = int.Parse(this.User.Identity.Name);
            
            var model = _chatService.GetReceivedMesaages(id);
            return View(model);
        }

        [HttpGet]
        public IActionResult OutgoingMessage()
        {
            int id = int.Parse(this.User.Identity.Name);
            
            var model = _chatService.GetSendedMesaages(id);
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> SendMessage()
        {
            int id = int.Parse(User.Identity.Name);
            SelectList allRecepient = new SelectList(_profileService.GetAll(), "Id", "LastName");
            ViewBag.AllRecepient = allRecepient;
            
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SendMessage([FromForm] ChatViewModel model)
        {
            int id = int.Parse(User.Identity.Name);

            await _hubContext.Clients.User(model.RecepientId.ToString()).SendAsync("Send", model.TextMessage, _profileService.GetById(model.RecepientId).FirstName);
            //await _hubContext.Clients.All.SendAsync("Send", model.TextMessage, model.RecepientId, _profileService.GetById(model.RecepientId).FirstName);
                        
            DatingApp.BusinesLogic.BusinessModel.ProfileModel sender = new DatingApp.BusinesLogic.BusinessModel.ProfileModel()
            {
                Id =  id
            };
            DatingApp.BusinesLogic.BusinessModel.ProfileModel recepient = new DatingApp.BusinesLogic.BusinessModel.ProfileModel()
            {
                Id = model.RecepientId
            };

            SelectList allRecepient = new SelectList(_profileService.GetAll(), "Id", "LastName");
            ViewBag.AllRecepient = allRecepient;
            _chatService.SendMessage(model.TextMessage, recepient, sender);

            return RedirectToAction("OutgoingMessage", "Chat");
        }

    }
}
