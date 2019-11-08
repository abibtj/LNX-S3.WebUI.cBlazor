
using FluentValidation;
using System;

namespace S3.WebUI.cBlazor.Models.Validators
{
    public class ClassValidator : AbstractValidator<Class>
    {
        public ClassValidator()
        {
            RuleFor(x => x.SchoolId)
               .NotEmpty().WithMessage("School's Id is required.");

            RuleFor(x => x.Name)
               .NotEmpty().WithMessage("Name is required.")
               .MinimumLength(2).WithMessage("Name is too short.")
               .MaximumLength(20).WithMessage("Name is too long. Maximum of 20 characters is allowed.");

            RuleFor(x => x.Category)
               .NotEmpty().WithMessage("Category is required.");
          
            RuleFor(x => x.SubjectsArray)
                 .NotEmpty().WithMessage("Supply the subjects offered in this class.");
        }
    }
}
