using System.Collections.Generic;
using System.Data.Entity;
using Harmonics.Models.Entities;

namespace Harmonics.Models.Repository
{
    public class SettingsRepository : IRepository<Setting>
    {
        private readonly MessengerModel messengerModel;
        
        public SettingsRepository(MessengerModel messengerModel)
        {
            this.messengerModel = messengerModel;
        }
            
        public IEnumerable<Setting> GetAll()
        {
            return messengerModel.Settings;
        }

        public Setting Get(int id)
        {
            return messengerModel.Settings.Find(id);
        }
        public void Create(Setting item)
        {
            messengerModel.Settings.Add(item);
        }

        public void Update(Setting item)
        {
            messengerModel.Entry(item).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            var setting = messengerModel.Settings.Find(id);
            if (setting != null)
            {
                messengerModel.Settings.Remove(setting);
            }
        }
    }
}