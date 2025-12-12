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
    public class UpdatePatientFileValidator : PatientFileBaseValidator<UpdatePatientFileCommand>
    {
        public UpdatePatientFileValidator() : base(x => x.PatientFile)
        {
           RuleFor(x => x.Id)
                .NotEmpty().WithMessage(MessagesConstants.IdRequired);
        }
    }

}
