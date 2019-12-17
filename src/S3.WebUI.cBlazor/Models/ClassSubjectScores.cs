using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace S3.WebUI.cBlazor.Models
{
    public class ClassSubjectScores : BaseEntity
    {
        public List<StudentScore> StudentScores { get; set; }
    }
}
