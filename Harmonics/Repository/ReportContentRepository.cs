using System.Collections.Generic;
using System.Data.Entity;
using Harmonics.Models.Entities;
using Harmonics.Models.Repository;

namespace Harmonics.Repository
{
    public class ReportContentRepository : IRepository<ReportContent>
    {
        private readonly MessengerModel messengerModel;

        public ReportContentRepository(MessengerModel messengerModel)
        {
            this.messengerModel = messengerModel;
        }
        
        public IEnumerable<ReportContent> GetAll()
        {
            return messengerModel.ReportContents;
        }

        public ReportContent Get(int id)
        {
            return messengerModel.ReportContents.Find(id);
        }

        public void Create(ReportContent item)
        {
            messengerModel.ReportContents.Add(item);
        }

        public void Update(ReportContent item)
        {
            messengerModel.Entry(item).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            var reportContent = messengerModel.ReportContents.Find(id);
            if (reportContent != null)
                messengerModel.ReportContents.Remove(reportContent);
        }
    }
}