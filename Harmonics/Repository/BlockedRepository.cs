using System.Collections.Generic;
using System.Data.Entity;
using Harmonics.Models.Entities;

namespace Harmonics.Models.Repository
{
    public class BlockedRepository : IRepository<Blocked>
    {
        private readonly MessengerModel messengerModel;
        
        public BlockedRepository(MessengerModel messengerModel)
        {
            this.messengerModel = messengerModel;
        }

        public IEnumerable<Blocked> GetAll()
        {
            return messengerModel.Blockeds;
        }

        public Blocked Get(int id)
        {
            return messengerModel.Blockeds.Find(id);
        }

        public void Create(Blocked item)
        {
            messengerModel.Blockeds.Add(item);
        }

        public void Update(Blocked item)
        {
            messengerModel.Entry(item).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            var user = messengerModel.Blockeds.Find(id);
            if (user != null)
            {
                messengerModel.Blockeds.Remove(user);
            }
        }
    }
}