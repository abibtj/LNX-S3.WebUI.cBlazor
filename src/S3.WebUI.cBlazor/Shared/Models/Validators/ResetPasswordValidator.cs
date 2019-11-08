
using System;
using System.Text.RegularExpressions;
using FluentValidation;

namespace S3.WebUI.cBlazor.Shared.Models.Validators
{
    public class ResetPasswordValidator : AbstractValidator<ResetPassword>
    {
        public ResetPasswordValidator()
        {
            RuleFor(x => x.UserId)
                .NotEmpty().WithMessage("User's Id is required.");

            RuleFor(x => x.Password)
                .NotEmpty().WithMessage("Password is required.")
                .MinimumLength(6).When(y => !string.IsNullOrEmpty(y.Password)).WithMessage("Password is too short. Minimum of 6 characters is allowed.")
                .MaximumLength(50).WithMessage("Password is too long. Maximum of 50 characters is allowed.")
                .Must(password => ValidatePassword(password)).When(y => !string.IsNullOrEmpty(y.Password)).WithMessage("Password must contain upper case, lower case, number and symbol.");

            RuleFor(x => x.ConfirmPassword)
                .NotEmpty().WithMessage("Password confirmation is required.")
                .Equal(x => x.Password).When(y => !string.IsNullOrEmpty(y.ConfirmPassword)).WithMessage("Password and Confirm Password do not match.");
        }

        private bool ValidatePassword(string password)
        {
            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasLowerChar = new Regex(@"[a-z]+");
            var hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");

            if (!hasLowerChar.IsMatch(password))
            {
                return false;
            }

            if (!hasUpperChar.IsMatch(password))
            {
                return false;
            }

            if (!hasNumber.IsMatch(password))
            {
                return false;
            }

            if (!hasSymbols.IsMatch(password))
            {
                return false;
            }

            return true;
        }
    }
}
