using System;

namespace S3.WebUI.cBlazor.Models
{
    public class Person : BaseEntity
    {
        public string FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string LastName { get; set; }
        public string FullName { get => FirstName + " " + MiddleName + " " + LastName; }
        public string Gender { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public bool IsSignedUp { get; set; }
        public string[] RolesArray { get; set; }
    }
}
