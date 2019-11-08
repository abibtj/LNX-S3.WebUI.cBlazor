using System;
using System.Collections.Generic;

namespace S3.WebUI.cBlazor.Models
{
    public class Parent : Person
    {
        public string RegNumber { get; }
        public string? AddressId { get; set; }
        public string[] StudentIds { get; set; } // List of wards
        public virtual ParentAddress Address { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}
