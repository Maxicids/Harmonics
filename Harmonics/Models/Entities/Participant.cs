using System.ComponentModel.DataAnnotations.Schema;

namespace Harmonics.Models.Entities
{
    public partial class Participant : Model
    {
        public int id { get; set; }

        public int chat { get; set; }

        [Column("participant")]
        public int participant1 { get; set; }

        public virtual Chat Chat1 { get; set; }

        public virtual User User { get; set; }
    }
}
