
using System;

namespace S3.WebUI.cBlazor.Models
{
    public class ScoresEntryTask : SchoolTask
    {
        public string TeacherId { get; set; }
        public string TeacherName { get; set; }
        public virtual Teacher Teacher { get; set; }
        public string Subject { get; set; }
        public string ClassId { get; set; }
        public string ClassName { get; set; }
        public virtual Class Class { get; set; }
        public string RuleId { get; set; } // The rule to be used to determine the weight of this score and grade obtained in this subject
    }
}