using System;
using System.ComponentModel.DataAnnotations;

namespace S3.WebUI.cBlazor.Models
{
    public class SchoolTask : BaseEntity
    {
        public string SchoolId { get; set; }
        public DateTime? DueDate { get; set; }
        public string? Description { get; set; }
    }
}
