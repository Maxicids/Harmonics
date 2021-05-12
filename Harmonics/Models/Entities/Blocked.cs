using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Harmonics.Models.Entities
{
    [Table("Blocked")]
    public partial class Blocked : Model
    {
        public int id { get; set; }

        public int user_id { get; set; }

        public DateTime blocked_at { get; set; }

        public DateTime blocked_for { get; set; }

        public int? reason { get; set; }

        public virtual ReportContent ReportContent { get; set; }

        public virtual User User { get; set; }
    }
}
