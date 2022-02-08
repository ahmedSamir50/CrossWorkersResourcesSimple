using FluentValidation;

namespace BookingSampleAPIs.Models.Validators
{
    public class ResourceVModelValidator : AbstractValidator<ResourceVModel>
    {
        public ResourceVModelValidator()
        {
            RuleFor(register => register.Name)
                .NotEmpty()
                .WithMessage("Resource name/ Name cannot be empty");
            RuleFor(register => register.Quantity)
                .NotNull()
                .WithMessage("Resource Available Quantity be empty");
        }
    }
}
