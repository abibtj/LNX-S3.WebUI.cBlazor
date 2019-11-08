

using System.Collections.Generic;

namespace S3.WebUI.cBlazor.Models
{
    public class School : BaseEntity
    {
        public string Name { get; set; }
        public string Category { get; set; } // Primary, Secondary //***TODO: an enumeration might be better
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string AddressId { get; set; }
        public SchoolAddress Address { get; set; }

        public virtual ICollection<Teacher> Teachers { get; set; }
        public virtual ICollection<Class> Classes { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}