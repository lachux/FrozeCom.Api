using FluentValidation;
using Froze.Application.Commands;
using Froze.Application.DTOs;

namespace Froze.Application.Validators
{

    public class RegisterUserCommandValidator : AbstractValidator<RegisterUserCommand>
    {
        public RegisterUserCommandValidator()
        {
            // Validate the RegisterUserDto property within the command
            RuleFor(x => x.RegisterUserDto)
                .NotNull().WithMessage("User registration data is required")
                .SetValidator(new RegisterUserDtoValidator()); // Reuse your DTO validator
        }
    }
    public class RegisterUserDtoValidator : AbstractValidator<RegisterUserDto>
    {
        public RegisterUserDtoValidator()
        {
       

            RuleFor(x => x.FirstName)
                .NotEmpty().WithMessage("First name is required")
                .MaximumLength(100).WithMessage("First name must not exceed 100 characters");

            RuleFor(x => x.LastName)
                .NotEmpty().WithMessage("Last name is required")
                .MaximumLength(100).WithMessage("Last name must not exceed 100 characters");

            RuleFor(x => x.EmailAddress)
                .NotEmpty().WithMessage("Email is required")
                .EmailAddress().WithMessage("Invalid email format")
                .MaximumLength(255).WithMessage("Email must not exceed 255 characters");

            
        }       
    }
}