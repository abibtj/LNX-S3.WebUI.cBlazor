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
        public string ExamType { get; set; } // CA, First exam, Second exam, Homework, Class Activities
        public int Term { get; set; }
        public int Session { get; set; }
        public float Mark { get; set; }
    }  
}