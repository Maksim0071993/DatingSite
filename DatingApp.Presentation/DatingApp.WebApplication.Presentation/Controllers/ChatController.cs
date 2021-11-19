using DatingApp.BusinesLogic.BusinessModel;
using DatingApp.BusinesLogic.Services.Interfaces;
using DatingApp.WebApplication.Presentation.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatingApp.WebApplication.Presentation.Controllers
{
    public class ChatController : Controller
    {
        private readonly IChatService _chatService;
        public ChatController(IChatService chatService)
        {
            _chatService = chatService;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SendMessage([FromForm] ChatViewModel model)
        {
            model.SenderId = int.Parse(User.Identity.Name);
            return View();
        }

    }
}
