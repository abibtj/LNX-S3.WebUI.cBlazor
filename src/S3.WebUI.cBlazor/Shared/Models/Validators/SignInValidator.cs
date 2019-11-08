
using System;
using System.Text.RegularExpressions;
using FluentValidation;

namespace S3.WebUI.cBlazor.Shared.Models.Validators
{
    public class SignInValidator : AbstractValidator<SignIn>
    {
        public SignInValidator()
        {
            RuleFor(x => x.Username)
                .NotEmpty().WithMessage("Username is required.");

            RuleFor(x => x.Password)
                .NotEmpty().WithMessage("Password is required.");
        }
    }
}
