using System;
using System.ComponentModel.DataAnnotations;

namespace S3.WebUI.cBlazor.Models
{
    public class Rule : BaseEntity
    {
        public string SchoolId { get; set; }
        public string Name { get; set; }
        public decimal? CAPercentage { get; set; } // Using decimal? (instead of float) because MatNumericUpDownField (binds to decimal?) is the only available UI component which can handle data binding to numeric type
        public decimal? FirstExamPercentage { get; set; } // Only first exam is compulsory
        public decimal? SecondExamPercentage { get; set; }
        public decimal? HomeworkPercentage { get; set; }
        public decimal? ClassActivitiesPercentage { get; set; }
        public decimal? A_DistinctionCutoff { get; set; } // e.g. 85 and above
        public decimal? B_VeryGoodCutoff { get; set; } // e.g. 70 - 84
        public decimal? C_CreditCutoff { get; set; } // e.g. 55 - 69
        public decimal? P_PassCutoff { get; set; } // e.g. 50 - 54
        public decimal? F_FailCutoff { get; set; } // e.g. 0 - 49
        public bool IsDefault { get; set; }
    }
}
