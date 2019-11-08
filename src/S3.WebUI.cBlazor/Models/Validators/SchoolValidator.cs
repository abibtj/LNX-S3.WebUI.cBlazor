
using FluentValidation;
using System;

namespace S3.WebUI.cBlazor.Models.Validators
{
    public class SchoolValidator : AbstractValidator<School>
    {
        public SchoolValidator()
        {
            RuleFor(x => x.Name)
               .NotEmpty().WithMessage("Name is required.")
               .MinimumLength(2).WithMessage("Name is too short.")
               .MaximumLength(100).WithMessage("Name is too long. Maximum of 100 characters is allowed.");

            RuleFor(x => x.Category)
               .NotEmpty().WithMessage("Category is required.");

            RuleFor(x => x.Email)
               .NotEmpty().WithMessage("Email address is required.")
               .EmailAddress().When(y => !string.IsNullOrEmpty(y.Email)).WithMessage("Invalid email address.")
               .MaximumLength(30).WithMessage("Email address is too long. Maximum of 30 characters is allowed.");

            RuleFor(x => x.PhoneNumber)
                .NotEmpty().WithMessage("Phone number is required.")
                .MaximumLength(50).WithMessage("Phone number is too long. Maximum of 30 characters is allowed.");

            RuleFor(x => x.Address)
               .NotNull().WithMessage("School's address is required.")
               .SetValidator(new AddressValidator());
        }
    }
}
