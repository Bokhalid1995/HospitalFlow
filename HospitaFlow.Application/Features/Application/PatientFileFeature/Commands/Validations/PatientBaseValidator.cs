using FluentValidation;
using HospitaFlow.Application.DTOs.Application.PatientFile;
using HospitaFlow.Application.Sahred.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitaFlow.Application.Features.Application.PatientFileFeature.Commands.Validations
{
    public abstract class PatientFileBaseValidator<T> : AbstractValidator<T> where T : class
    {
        protected PatientFileBaseValidator(Func<T, PatientFileDto> getDto)
        {
            RuleFor(x => getDto(x).FullName)
                .NotEmpty().WithMessage(MessagesConstants.Required)
                .MaximumLength(20).WithMessage(MessagesConstants.MaxLengthExceeded);

            RuleFor(x => getDto(x).Phone)
                .NotEmpty().WithMessage(MessagesConstants.Required)
                .Matches(@"^[0-9]{10}$").WithMessage(MessagesConstants.InvalidPhone);


            RuleFor(x => getDto(x).Email)
                .NotEmpty().WithMessage(MessagesConstants.Required)
                .EmailAddress().WithMessage(MessagesConstants.InvalidEmail);


            RuleFor(x => getDto(x).City)
                .NotEmpty().WithMessage(MessagesConstants.Required);

            RuleFor(x => getDto(x).NationalId)
                .NotEmpty().WithMessage(MessagesConstants.Required)
                .Matches(@"^[0-9]{14}$").WithMessage(MessagesConstants.InvalidNationalId);

            RuleFor(x => getDto(x).Gender)
                .IsInEnum().WithMessage(MessagesConstants.InvalidGender);
        }
    }
}
