
using FluentValidation;

namespace S3.WebUI.cBlazor.Models.Validators
{
    public class AddressValidator : AbstractValidator<Address>
    {
        public AddressValidator()
        {
           RuleFor(x => x.Line1)
               .NotEmpty().WithMessage("Address is required.")
               .MinimumLength(3).When(x => !(string.IsNullOrEmpty(x.Line1))).WithMessage("Address is too short.")
               .MaximumLength(100).WithMessage("Address first line is too long. Maximum of 100 characters is allowed.");

            RuleFor(x => x.Town)
               .NotEmpty().WithMessage("Town / City is required.")
                .MinimumLength(2).When(x => !(string.IsNullOrEmpty(x.Town))).WithMessage("Town / City name is too short.")
                .MaximumLength(30).WithMessage("Town / City name is too long. Maximum of 30 characters is allowed.");

            RuleFor(x => x.State)
               .NotEmpty().WithMessage("State is required.");

            RuleFor(x => x.Country)
               .NotEmpty().WithMessage("Country is required.");
        }
    }
}
