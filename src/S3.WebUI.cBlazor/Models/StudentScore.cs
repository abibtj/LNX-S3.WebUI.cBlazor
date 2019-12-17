using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace S3.WebUI.cBlazor.Models
{
    public class StudentScore : BaseEntity
    {
        public string StudentId { get; set; }
        public string StudentName { get; set; }
        public string SchoolId { get; set; }
        public string ClassId { get; set; }
        public string ClassName { get; set; }
        public string Subject { get; set; }
        public string ExamType { get; set; } // CA, First Exam, Second Exam, Homework, Class Activities
        public string Term { get; set; }
        public int Session { get; set; }
        public float? Mark { get; set; } // Make mark nullable, so that zero does not get displayed in the UI control by default
        public string RuleId { get; set; } // The rule to be used to determine the weight of this score and grade obtained in this subject
    }
}