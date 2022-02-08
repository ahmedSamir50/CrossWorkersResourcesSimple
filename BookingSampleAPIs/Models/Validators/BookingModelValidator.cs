using FluentValidation;
using System;

namespace BookingSampleAPIs.Models.Validators
{
    public class BookingModelValidator : AbstractValidator<ResourceBookingVModel>
    {
        public BookingModelValidator()
        {
            RuleFor(register => register.ResIdNum)
                .NotEmpty()
                .WithMessage("Booking Should Have one Resource and cannot be empty");

            RuleFor(register => register.DateFrom)
                .NotNull()
                .WithMessage("Booking Date From : cannot be empty")
                .GreaterThanOrEqualTo(DateTime.Now)
                .WithMessage("Booking Date From : cannot be in the Past ")
                .LessThanOrEqualTo(reg=>reg.DateTo)
                .WithMessage("Booking Date From : should be before Booking To-date ");


            RuleFor(register => register.DateTo)
                .NotNull()
                .WithMessage("Booking Date To : cannot be empty")
                .GreaterThanOrEqualTo(DateTime.Now)
                .WithMessage("Booking Date To : cannot be in the Past ")
                .GreaterThanOrEqualTo(reg => reg.DateFrom)
                .WithMessage("Booking Date From : should be after Booking from-date ");
        }
    }
}
