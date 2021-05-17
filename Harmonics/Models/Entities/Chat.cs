using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Windows;

namespace Harmonics.Models.Entities
{
    public partial class Chat : Model
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Chat()
        {
            Messages = new HashSet<Message>();
            Participants = new HashSet<Participant>();
        }
        public int id { get; set; }

        [StringLength(20)]
        public string title { get; set; }

        [StringLength(200)]
        public string description { get; set; }
        
        public byte[] mainPicture { get; set; }
        
        public int creator_id { get; set; }
        
        [ForeignKey("creator_id")]
        public virtual User Creator { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public ICollection<Message> Messages { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public ICollection<Participant> Participants { get; set; }
        
    }
}
