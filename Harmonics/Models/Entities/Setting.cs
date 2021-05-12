using System.Collections.Generic;

namespace Harmonics.Models.Entities
{
    public partial class Setting : Model
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Setting()
        {
            Users = new HashSet<User>();
        }

        public int id { get; set; }

        public int theme_id { get; set; }

        public int chat_font_size { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<User> Users { get; set; }
    }
}
