using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Harmonics.Models.Entities;

namespace Harmonics.Models.Repository
{
    public class ChatsRepository : IRepository<Chat>
    {
        private readonly MessengerModel messengerModel;

        public ChatsRepository(MessengerModel messengerModel)
        {
            this.messengerModel = messengerModel;
        }

        public IEnumerable<Chat> GetAll()
        {
            return messengerModel.Chats;
        }

        public IEnumerable<Chat> GetAllByUserId(int id)
        {
            var tempParticipants = messengerModel.Participants.
                Where(x => x.participant1 == id).Select(x => x.chat);
            return messengerModel.Chats.Where(x => tempParticipants.Contains(x.id));
        }

        public Chat Get(int id)
        {
            return messengerModel.Chats.Find(id);
        }

        public void Create(Chat item)
        {
            messengerModel.Chats.Add(item);
        }

        public void Update(Chat item)
        {
            messengerModel.Entry(item).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            var chat = messengerModel.Chats.Find(id);
            if (chat != null)
                messengerModel.Chats.Remove(chat);
        }
    }
}