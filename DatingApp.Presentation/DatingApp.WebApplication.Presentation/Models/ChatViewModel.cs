using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatingApp.WebApplication.Presentation.Models
{
    public class ChatViewModel
    {
        public int SenderId { get; set; }
        public int RecepientId { get; set; }
        public string TextMessage { get; set; }
    }
}
