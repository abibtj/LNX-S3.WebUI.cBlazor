using System;

namespace S3.WebUI.cBlazor.Models
{
    public class Address
    {
        public string Id { get; private set; }
        public string Line1 { get; set; }
        public string? Line2 { get; set; }
        public string Town { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
    }
    public class StudentAddress : Address
    {
        public string StudentId { get; set; }
        public virtual Student Student { get; set; }
    }
    public class TeacherAddress : Address
    {
        public string TeacherId { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
    public class ParentAddress : Address
    {
        public string ParentId { get; set; }
        public virtual Parent Parent { get; set; }
    }
    public class SchoolAddress : Address
    {
        public string SchoolId { get; set; }
        public virtual School School { get; set; }
    }
}
