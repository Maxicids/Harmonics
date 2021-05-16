using System.Collections.Generic;
using System.Data.Entity;
using Harmonics.Models.Entities;
using Harmonics.Models.Repository;

namespace Harmonics.Repository
{
    public class ParticipantRepository : IRepository<Participant>
    {
        private readonly MessengerModel messengerModel;

        public ParticipantRepository(MessengerModel messengerModel)
        {
            this.messengerModel = messengerModel;
        }
        
        public IEnumerable<Participant> GetAll()
        {
            return messengerModel.Participants;
        }

        public Participant Get(int id)
        {
            return messengerModel.Participants.Find(id);
        }

        public void Create(Participant item)
        {
            messengerModel.Participants.Add(item);
        }

        public void Update(Participant item)
        {
            messengerModel.Entry(item).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            var participant = messengerModel.Participants.Find(id);
            if (participant != null)
                messengerModel.Participants.Remove(participant);
        }
    }
}