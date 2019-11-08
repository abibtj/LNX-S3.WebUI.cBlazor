
using FluentValidation;
using System;

namespace S3.WebUI.cBlazor.Models.Validators
{
    public class ScoresEntryTaskValidator : AbstractValidator<ScoresEntryTask>
    {
        public ScoresEntryTaskValidator()
        {
            RuleFor(x => x.SchoolId)
                   .NotEmpty().WithMessage("School's Id is required.");

            RuleFor(x => x.TeacherId)
                  .NotEmpty().WithMessage("Teacher is required.");

            RuleFor(x => x.TeacherName)
                 .MaximumLength(100).WithMessage("Teacher's name is too long, maximum of 100 characters is allowed.");

            RuleFor(x => x.ClassId)
                  .NotEmpty().WithMessage("Class is required.");

            RuleFor(x => x.ClassName)
                  .MaximumLength(20).WithMessage("Class' name is too long, maximum of 20 characters is allowed.");

            RuleFor(x => x.DueDate)
              .GreaterThanOrEqualTo(DateTime.Now).When(x => !(x.DueDate is null)).WithMessage("Invalid due date.");
        }
    }
}
