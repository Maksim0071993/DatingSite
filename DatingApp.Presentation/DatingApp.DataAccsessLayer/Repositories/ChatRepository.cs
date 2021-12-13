using DatingApp.DataAccessLayer.Models;
using DatingApp.DataAccessLayer.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingApp.DataAccessLayer.Repositories
{
    public class ChatRepository : IChatRepository
    {
        private readonly DatingAppWinFormsContext _datingAppWinFormsContext;

        public ChatRepository(DatingAppWinFormsContext datingAppWinFormsContext)
        {
            _datingAppWinFormsContext = datingAppWinFormsContext;
        }

        public void Add(Chat chat)
        {
            _datingAppWinFormsContext.Chats.Add(chat);
        }
        public List<Chat> Get(Func<Chat, bool> func)
        {
            var chats = _datingAppWinFormsContext.Chats.Include(p => p.Recepient).Include(p => p.Sender).Where(func).ToList();
            return chats;
        }
        public List<Chat> GetAll()
        {
            var list = _datingAppWinFormsContext.Chats.ToList();
            return list;
        }
    }
}
