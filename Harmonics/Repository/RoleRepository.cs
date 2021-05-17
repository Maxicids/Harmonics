using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Windows;
using Harmonics.Models.Entities;
using Harmonics.Models.Repository;

namespace Harmonics.Repository
{
    public class RoleRepository : IRepository<Role>
    {
        private readonly MessengerModel messengerModel;
        
        public RoleRepository(MessengerModel messengerModel)
        {
            this.messengerModel = messengerModel;
        }
        
        public IEnumerable<Role> GetAll()
        {
            return messengerModel.Roles;
        }

        public Role Get(int id)
        {
            return messengerModel.Roles.Find(id);
        }
        public Role GetUserRole()
        {
            var roleId = messengerModel.Users.Find(Convert.ToInt32( ((User) Application.Current.Properties["User"]).id));
            return messengerModel.Roles.Find(roleId);
        }

        public void Create(Role item)
        {
            messengerModel.Roles.Add(item);
        }

        public void Update(Role item)
        {
            messengerModel.Entry(item).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            var role = messengerModel.Roles.Find(id);
            if (role != null)
            {
                messengerModel.Roles.Remove(role);
            }
        }
    }
}