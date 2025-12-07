using HospitaFlow.Application.Common.Constants;

using HospitaFlow.Application.Common.Responses;
using HospitaFlow.Application.DTOs.Application.PatientFile;
using HospitaFlow.Application.Interfaces.Application;
using HospitaFlow.Core.Entities.Application;
using HospitaFlow.Core.Entities.Lookups;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitaFlow.Application.Features.Application.PatientFileFeature.Queries
{
    public record GetAllPatientFiles(PatientFileFilterDto PatientFileFilter) : IRequest<Result<PagedResult<PatientFile>>>;

    public class GetAllPatientFilesHandler(IPatientFileRepository PatientFileRepository) : IRequestHandler<GetAllPatientFiles, Result<PagedResult<PatientFile>>>
    {
        public async Task<Result<PagedResult<PatientFile>>> Handle(GetAllPatientFiles request, CancellationToken cancellationToken)
        {
            var patientFiles =  PatientFileRepository.GetFiltered(request.PatientFileFilter);
            
            var data = await PagedResult<PatientFile>.ToPagedListAsync(patientFiles, request.PatientFileFilter.PageIndex, request.PatientFileFilter.PageSize);
            return  Result<PagedResult<PatientFile>>.Done(data ,  MessagesConstants.DataRetrieved);
          
        }
    }

}
