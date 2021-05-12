using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Harmonics.Models.Entities;
using Harmonics.Models.ServerProvider;

namespace Harmonics.Models.Repository
{
    public class UserRepository : IRepository<User>
    {
        private readonly MessengerModel messengerModel;
        
        public UserRepository(MessengerModel messengerModel)
        {
            this.messengerModel = messengerModel;
        }
        
        public IEnumerable<User> GetAll()
        {
            return messengerModel.Users;
        }

        public User Get(int id)
        {
            return messengerModel.Users.Find(id);
        }
        public User GetByLogin(string login)
        {
            return messengerModel.Users.FirstOrDefault(x => x.login == login);
        }
        public User Login(string login, string password)
        {
            var user = messengerModel.Users.FirstOrDefault(x => x.login == login);
            if (user == null) return null;
            return user;
            //return PasswordHash.ValidatePassword(user.password, password) ? user : null;
            //return messengerModel.Users.FirstOrDefault(x => x.login == login && PasswordHash.ValidatePassword(x.password, password));
        }
        public IEnumerable<User> GetAllByChatId(int chatId)
        {
            var tempParticipants =  messengerModel.Participants.
                Where(p => p.chat == chatId).Select(x => x.participant1);
            return messengerModel.Users.Where(u => tempParticipants.Contains(u.id));
        }

        public void Create(User item)
        {
            messengerModel.Users.Add(item);
        }

        public void Update(User item)
        {
            messengerModel.Entry(item).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            var user = messengerModel.Users.Find(id);
            if (user != null)
            {
                messengerModel.Users.Remove(user);
            }
        }
    }
}