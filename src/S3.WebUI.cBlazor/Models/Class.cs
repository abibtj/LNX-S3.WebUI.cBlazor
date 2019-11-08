using System;
using System.Collections.Generic;

namespace S3.WebUI.cBlazor.Models
{
    public class Class : BaseEntity
    {
        public string Name { get; set; }
        public string Category { get; set; } 
        public string Subjects { get; set; }
        public string[] SubjectsArray { get; set; }

        // Navigation properties
        public string SchoolId { get; set; }
        public virtual School School { get; set; }
        public string? ClassTeacherId { get; set; }
        public virtual Teacher ClassTeacher { get; set; }
        public string? AssistantTeacherId { get; set; }
        public virtual Teacher AssistantTeacher { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}
