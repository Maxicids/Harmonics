using System.ComponentModel.DataAnnotations;

namespace Harmonics.Models.Entities
{
    public partial class Message : Model
    {
        public int id { get; set; }

        public int from_id { get; set; }

        public int chat_id { get; set; }
        
        [Required]
        [StringLength(2000)]
        public string content { get; set; }

        public virtual Chat Chat { get; set; }
        
        public virtual User User { get; set; }
    }
}
