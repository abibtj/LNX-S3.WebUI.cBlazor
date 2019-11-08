
using FluentValidation;

namespace S3.WebUI.cBlazor.Models.Validators
{
    public class ClassSubjectScoresValidator : AbstractValidator<ClassSubjectScores>
    {
        public ClassSubjectScoresValidator()
        {
            //RuleFor(x => x.ClassId)
            //    .NotEmpty().WithMessage("Class's Id is required.");

            //RuleFor(x => x.ClassName)
            //    .MaximumLength(20).WithMessage("Class name is too long, maximum of 20 character is allowed.");

            //RuleFor(x => x.Subject)
            //    .MaximumLength(50).WithMessage("Class name is too long, maximum of 50 character is allowed.");

            //RuleFor(x => x.ExamType)
            //    .MaximumLength(20).WithMessage("Class name is too long, maximum of 20 character is allowed.");

            //RuleFor(x => x.Term)
            //    .NotEmpty().WithMessage("Term is required.");

            //RuleFor(x => x.Session)
            //    .NotEmpty().WithMessage("Session is required.");

            RuleFor(x => x.StudentScores)
                .NotNull().WithMessage("Student scores are required.");

            RuleForEach(x => x.StudentScores).SetValidator(new StudentScoreValidator());
        }
    }
}
