using System;

namespace S3.WebUI.cBlazor.Models
{
    public class Student : Person
    {
        public string RegNumber { get; }
        public string SubjectsStatus { get; set; }
        public string[] SubjectsArray { get; set; }
        public bool OfferingAllClassSubjects { get; set; }
        public string SchoolId { get; set; }
        public virtual School School { get; set; }
        public string? ClassId { get; set; }
        public virtual Class Class { get; set; }
        public string? ParentId { get; set; }
        public virtual Parent Parent { get; set; }
        public string? AddressId { get; set; }
        public virtual StudentAddress Address { get; set; }
    }
}
