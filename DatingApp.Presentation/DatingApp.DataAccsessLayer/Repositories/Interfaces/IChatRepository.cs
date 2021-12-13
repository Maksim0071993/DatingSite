using DatingApp.DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingApp.DataAccessLayer.Repositories.Interfaces
{
    public interface IChatRepository
    {
        public List<Chat> Get(Func<Chat, bool> func);
        public void Add(Chat chat);
        public List<Chat> GetAll();
    }
}
