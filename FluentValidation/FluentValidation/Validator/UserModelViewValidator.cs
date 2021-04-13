using FluentValidation;
using FluentValidation.Models;

namespace FluentValidation.Validator
{
    public class UserModelViewValidator : AbstractValidator<UserModel>
    {
        public UserModelViewValidator()
        {
            RuleFor(r => r.Name)
                .NotEmpty().WithMessage("Enter your name");

            RuleFor(r => r.Password)
                .NotEmpty().WithMessage("Enter your password");

            RuleFor(r => r.Email)
                .NotEmpty().WithMessage("Enter email")
                .EmailAddress().WithMessage("Email is not valid");

            RuleFor(r => r.Phone)
                .NotEmpty().WithMessage("Enter your phone")
                .Length(10,11).WithMessage("Phone is not valid");

            //RuleFor(r => r.Salary)
            //    .NotEqual(0).When();
        }
    }
}