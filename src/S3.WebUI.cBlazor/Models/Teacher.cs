using System;
using System.Collections.Generic;

namespace S3.WebUI.cBlazor.Models
{
    public class Teacher : Person
    {
        public string? Position { get; set; }
        public int? GradeLevel { get; set; }
        public int? Step { get; set; }
        public string SchoolId { get; set; }
        public virtual School School { get; set; }
        public string? AddressId { get; set; }
        public virtual TeacherAddress Address { get; set; }

        public virtual ICollection<ScoresEntryTask> ScoresEntryTasks { get; set; }
    }
}