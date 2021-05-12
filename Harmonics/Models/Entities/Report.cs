namespace Harmonics.Models.Entities
{
    public partial class Report : Model
    {
        public int id { get; set; }

        public int user_id { get; set; }

        public int sender_id { get; set; }

        public int? reason { get; set; }

        public virtual ReportContent ReportContent { get; set; }

        public virtual User User { get; set; }

        public virtual User User1 { get; set; }
    }
}
