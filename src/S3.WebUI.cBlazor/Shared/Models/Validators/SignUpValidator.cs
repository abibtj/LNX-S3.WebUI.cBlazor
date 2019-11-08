
using System;
using System.Text.RegularExpressions;
using FluentValidation;

namespace S3.WebUI.cBlazor.Shared.Models.Validators
{
    public class SignUpValidator : AbstractValidator<SignUp>
    {
        //string passwordValidationMessage = "";
        public SignUpValidator()
        {
            RuleFor(x => x.UserId)
                .NotEmpty().WithMessage("User's Id is required.");

            RuleFor(x => x.Username)
                .NotEmpty().WithMessage("Username is required.")
                .MinimumLength(5).When(x => !string.IsNullOrEmpty(x.Username)).WithMessage("Username is too short. Minimum of 5 characters is allowed.")
                .MaximumLength(20).WithMessage("Username is too long. Maximum of 20 characters is allowed.");

            RuleFor(x => x.Password)
               .NotEmpty().WithMessage("Password is required.")
               .MinimumLength(6).When(y => !string.IsNullOrEmpty(y.Password)).WithMessage("Password is too short. Minimum of 6 characters is allowed.")
               .MaximumLength(50).WithMessage("Password is too long. Maximum of 50 characters is allowed.")
               .Must(password => ValidatePassword(password)).When(y => !string.IsNullOrEmpty(y.Password)).WithMessage("Password must contain upper case, lower case, number and symbol.");

            RuleFor(x => x.ConfirmPassword)
                .NotEmpty().WithMessage("Password confirmation is required.")
                .Equal(x => x.Password).When(y => !string.IsNullOrEmpty(y.ConfirmPassword)).WithMessage("Password and Confirm Password do not match.");
        
            RuleFor(x => x.Roles)
               .NotEmpty().WithMessage("A minimum of one role is required.");

            RuleFor(x => x.SchoolId)
               .NotEmpty().WithMessage("School's Id is required.");
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
