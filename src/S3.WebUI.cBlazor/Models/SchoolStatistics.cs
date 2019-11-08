

using System.Collections.Generic;

namespace S3.WebUI.cBlazor.Models
{
    public class SchoolStatistics : BaseEntity
    {
        public string Name { get; set; }
        public string Category { get; set; } // Primary, Secondary //***TODO: an enumeration might be better
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Administrator { get; set; }
        public string AdministratorId { get; set; }
        public string Location { get; set; }
        public int NumberOfTeachers { get; set; }
        public int NumberOfClasses { get; set; }
        public int NumberOfStudents { get; set; }
    }
}