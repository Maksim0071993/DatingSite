using DatingApp.BusinesLogic.BusinessModel;
using DatingApp.Presentation.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DatingApp.Presentation.Services
{
    public  class ChatSelected : IChatSelected
    {
        public ChatModel Chat { get; set; }
        public ChatSelected()
        {
            Chat = new ChatModel();
        }
    }
}
