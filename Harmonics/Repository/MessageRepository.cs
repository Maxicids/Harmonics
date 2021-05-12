using System.Collections.Generic;
using System.Data.Entity;
using Harmonics.Models.Entities;
using Harmonics.Models.Repository;

namespace Harmonics.Repository
{
    public class MessageRepository : IRepository<Message>
    {
        private readonly MessengerModel messengerModel;

        public MessageRepository(MessengerModel messengerModel)
        {
            this.messengerModel = messengerModel;
        }
        
        public IEnumerable<Message> GetAll()
        {
            return messengerModel.Messages;
        }

        public Message Get(int id)
        {
            return messengerModel.Messages.Find(id);
        }

        public void Create(Message item)
        {
            messengerModel.Messages.Add(item);
        }

        public void Update(Message item)
        {
            messengerModel.Entry(item).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            var message = messengerModel.Messages.Find(id);
            if (message != null)
                messengerModel.Messages.Remove(message);
        }
    }
}