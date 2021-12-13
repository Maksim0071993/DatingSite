using AutoMapper;
using DatingApp.BusinesLogic.BusinessModel;
using DatingApp.BusinesLogic.Services.Interfaces;
using DatingApp.DataAccessLayer.Models;
using DatingApp.DataAccessLayer.Repositories;
using DatingApp.DataAccessLayer.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingApp.BusinesLogic.Services
{
    public class ChatService : IChatService
    {
        private readonly IUnitOfWork _unitOfWork;
        public ChatService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public void SendMessage(string  message, ProfileModel recipientId, ProfileModel senderId)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<ChatModel, Chat >());           
            var mapper = new Mapper(config);
            var messMod = new ChatModel { TextMessage = message, RecepientId = recipientId.Id, SenderId = senderId.Id };
            var chatBL = mapper.Map<Chat>(messMod);
            _unitOfWork.Chat.Add(chatBL);
            _unitOfWork.Save();
            
        }        

        public List<MessageModel> GetReceivedMesaages(int recepientId)
        {
            return _unitOfWork.Chat.Get(p => p.RecepientId == recepientId).Select(p => new MessageModel
            {
                Id = p.Id,
                SenderName = p.Sender.FirstName,
                RecipientName = p.Recepient.FirstName,
                TextMessage = p.TextMessage
            }).ToList();
        }

        public List<MessageModel> GetSendedMesaages(int senderId)
        {
            return _unitOfWork.Chat.Get(p => p.SenderId == senderId).Select(p => new MessageModel
            {
                Id = p.Id,
                SenderName = p.Sender.FirstName,
                RecipientName = p.Recepient.FirstName,
                TextMessage = p.TextMessage
            }).ToList();
        }
        //public List<ProfileModel> GetAllRecepient ()
        //{
        //    var config = new MapperConfiguration(cfg => cfg.CreateMap<DatingApp.DataAccessLayer.Models.Chat, ChatModel>());
        //    var mapper = new Mapper(config);
        //    var profileModels = _unitOfWork.Profile.GetAll().ToList();
        //    var result = profileModels.Select(p => mapper.Map<ChatModel>(p)).ToList();

        //    return result;
        //}
        
    }
}
