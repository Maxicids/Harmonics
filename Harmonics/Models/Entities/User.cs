using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Harmonics.Models.Entities
{
    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            Blockeds = new HashSet<Blocked>();
            Messages = new HashSet<Message>();
            Participants = new HashSet<Participant>();
            Reports = new HashSet<Report>();
            Reports1 = new HashSet<Report>();
        }

        public int id { get; set; }

        [StringLength(20)]
        public string login { get; set; }

        [Required]
        [StringLength(255)]
        public string password { get; set; }

        public int role { get; set; }

        [StringLength(200)]
        public string description { get; set; }

        public int settings { get; set; }

        public byte[] profile_Picture { get; set; }

        public bool is_Online { get; set; }

        public bool is_Blocked { get; set; }

        public DateTime created_At { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Blocked> Blockeds { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Message> Messages { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Participant> Participants { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Report> Reports { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Report> Reports1 { get; set; }

        public virtual Role Role1 { get; set; }

        public virtual Setting Setting { get; set; }
    }
}
