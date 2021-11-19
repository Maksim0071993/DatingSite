using DatingApp.BusinesLogic.BusinessModel;
using DatingApp.DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingApp.BusinesLogic.Services.Interfaces
{
    public interface IChatService
    {
        public void SendMessage(string message, ProfileModel recipientId, ProfileModel senderId);
        public List<MessageModel> GetReceivedMesaages(int recepientId);

        public List<MessageModel> GetSendedMesaages(int senderId);
    }
}
