using DatingApp.DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingApp.DataAccessLayer.Repositories.Interfaces
{
    public interface IProfileRepository
    {
        void Add(Profile _profile);
        public List<Profile> Get(Func<Profile, bool> func);
        public List<Profile> GetAll();
        public IQueryable<Profile> Get();
    }
}
