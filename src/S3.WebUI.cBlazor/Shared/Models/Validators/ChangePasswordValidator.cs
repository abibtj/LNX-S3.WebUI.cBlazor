
using System;
using System.Text.RegularExpressions;
using FluentValidation;

namespace S3.WebUI.cBlazor.Shared.Models.Validators
{
    public class ChangePasswordValidator : AbstractValidator<ChangePassword>
    {
        //string passwordValidationMessage = "";
        public ChangePasswordValidator()
        {
            RuleFor(x => x.UserId)
                .NotEmpty().WithMessage("User's Id is required.");

            RuleFor(x => x.NewPassword)
                .NotEmpty().WithMessage("Password is required.")
                .MinimumLength(6).When(y => !string.IsNullOrEmpty(y.NewPassword)).WithMessage("Password is too short. Minimum of 6 characters is allowed.")
                .MaximumLength(50).WithMessage("Password is too long. Maximum of 50 characters is allowed.")
                .Must(password => ValidatePassword(password)).When(y => !string.IsNullOrEmpty(y.NewPassword)).WithMessage("Password must contain upper case, lower case, number and symbol.");

            RuleFor(x => x.ConfirmPassword)
                .NotEmpty().WithMessage("Password confirmation is required.")
                .Equal(x => x.NewPassword).When(y => !string.IsNullOrEmpty(y.ConfirmPassword)).WithMessage("Password and Confirm Password do not match.");
        }

        private bool ValidatePassword(string password)
        {
            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasLowerChar = new Regex(@"[a-z]+");
            var hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");

            if (!hasLowerChar.IsMatch(password))
            {
                //passwordValidationMessage = "Password must contain at least one lower case letter.";
                return false;
            }

            if (!hasUpperChar.IsMatch(password))
            {
                //passwordValidationMessage = "Password must contain at least one upper case letter.";
                return false;
            }

            if (!hasNumber.IsMatch(password))
            {
                //passwordValidationMessage = "Password must contain at least one digit [0 - 9].";
                return false;
            }

            if (!hasSymbols.IsMatch(password))
            {
                //passwordValidationMessage = "Password must contain at least one symbol.";
                return false;
            }

            return true;
        }
    }
}
