using HospitaFlow.Application.DTOs.Application.PatientFile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitaFlow.Application.Features.Application.PatientFileFeature.Commands.Validations
{
    public class AddPatientFileValidator : PatientFileBaseValidator<AddPatientFileCommand>
    {
        public AddPatientFileValidator() : base(x => x.PatientFile)
        {
           
        }
    }

}
