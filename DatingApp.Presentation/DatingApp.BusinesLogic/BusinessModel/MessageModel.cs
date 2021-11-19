using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingApp.BusinesLogic.BusinessModel
{
    public class MessageModel
    {
        public int Id { get; set; }
        public string SenderName { get; set; }
        public string RecipientName { get; set; }
        public string TextMessage { get; set; }
    }
}
