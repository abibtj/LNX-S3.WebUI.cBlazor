
using FluentValidation;
using System;

namespace S3.WebUI.cBlazor.Models.Validators
{
    public class TeacherValidator : AbstractValidator<Teacher>
    {
        public TeacherValidator()
        {
            RuleFor(x => x.FirstName)
               .NotEmpty().WithMessage("First name is required.")
               .MinimumLength(2).WithMessage("First name is too short.")
               .MaximumLength(30).WithMessage("First name is too long. Maximum of 30 characters is allowed.");

            RuleFor(x => x.MiddleName)
                .MinimumLength(2).When(y => !string.IsNullOrEmpty(y.MiddleName)).WithMessage("Middle name is too short.")
                .MaximumLength(30).WithMessage("Middle name is too long. Maximum of 30 characters is allowed.");

            RuleFor(x => x.LastName)
               .NotEmpty().WithMessage("Last name is required.")
               .MinimumLength(2).WithMessage("Last name is too short.")
               .MaximumLength(30).WithMessage("Last name is too long. Maximum of 30 characters is allowed.");

            RuleFor(x => x.Gender)
               .NotEmpty().WithMessage("Gender is required.");

            RuleFor(x => x.DateOfBirth)
               .LessThanOrEqualTo(DateTime.Now).When(x => !(x.DateOfBirth is null)).WithMessage("Invalid date of birth.");

            RuleFor(x => x.Email)
               .EmailAddress().When(y => !string.IsNullOrEmpty(y.Email)).WithMessage("Invalid email address.");

            RuleFor(x => x.SchoolId)
                  .NotEmpty().WithMessage("School is required.");

            RuleFor(x => x.Address).SetValidator(new AddressValidator());
        }
    }
}
