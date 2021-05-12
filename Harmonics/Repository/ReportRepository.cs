using System.Collections.Generic;
using System.Data.Entity;
using Harmonics.Models.Entities;

namespace Harmonics.Models.Repository
{
    public class ReportRepository : IRepository<Report>
    {
        private readonly MessengerModel messengerModel;
        
        public ReportRepository(MessengerModel messengerModel)
        {
            this.messengerModel = messengerModel;
        }
        
        public IEnumerable<Report> GetAll()
        {
            return messengerModel.Reports;
        }

        public Report Get(int id)
        {
            return messengerModel.Reports.Find(id);
        }

        public void Create(Report item)
        {
            messengerModel.Reports.Add(item);
        }

        public void Update(Report item)
        {
            messengerModel.Entry(item).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            var report = messengerModel.Reports.Find(id);
            if (report != null)
            {
                messengerModel.Reports.Remove(report);
            }
        }
    }
}