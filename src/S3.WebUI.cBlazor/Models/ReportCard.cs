using System.Collections.Generic;

namespace S3.WebUI.cBlazor.Models
{
    /// <summary>
    /// / Not to be stored in the database. For reports generation only
    /// </summary>
    public class ClassReport
    {
        //public string ClassName { get; set; }
        public ICollection<StudentReport> StudentReports { get; set; }
        public ScoresStat ScoresStat { get; set; }
    }

   
    public class StudentReport
    {
        public string StudentName { get; set; }
        public ICollection<TermReport> TermReports { get; set; }
    }

    public class TermReport
    {
        public string Term { get; set; }
        public ICollection<SubjectReport> SubjectReports { get; set; }
    }

    public class SubjectReport
    {
        public string Subject { get; set; }
        public float? HomeworkScore { get; set; }
        public float? ClassActivitiesScore { get; set; }
        public float? CAScore { get; set; }
        public float? FirstExamScore { get; set; }
        public float? SecondExamScore { get; set; }
        public float? WeightedScore { get; set; }
        public char? Grade { get; set; }
    }

    public class ScoresStat
    {
        public ICollection<TermStat> TermStats { get; set; }
    }
    public class TermStat
    {
        public string Term { get; set; }
        public ICollection<Stat> Stats { get; set; }
    }
    public class Stat
    {
        public string Subject { get; set; }
        public float ClassMinScore { get; set; }
        public float ClassMaxScore { get; set; }
        public float ClassAverageScore { get; set; }
    }
}
