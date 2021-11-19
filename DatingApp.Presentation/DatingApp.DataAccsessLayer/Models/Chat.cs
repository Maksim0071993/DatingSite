using System;
using System.Collections.Generic;

#nullable disable

namespace DatingApp.DataAccessLayer.Models
{
    public partial class Chat
    {
        public int Id { get; set; }
        public int SenderId { get; set; }
        public int RecepientId { get; set; }
        public string TextMessage { get; set; }

        public virtual Profile Recepient { get; set; }
        public virtual Profile Sender { get; set; }
    }
}
