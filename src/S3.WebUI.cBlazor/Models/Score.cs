using System;
using System.ComponentModel.DataAnnotations;

namespace S3.WebUI.cBlazor.Models
{
    public class Score : BaseEntity
    {
        public string StudentId { get; set; }
        public string StudentName { get; set; }
        public float Mark { get; set; }
        public string ClassSubjectScoresId { get; set; }
        public virtual ClassSubjectScores ClassSubjectScores { get; set; }
    }
}
