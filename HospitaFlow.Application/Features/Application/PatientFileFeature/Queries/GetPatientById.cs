using AutoMapper;
using HospitaFlow.Application.Common.Constants;
using HospitaFlow.Application.Common.Responses;
using HospitaFlow.Application.DTOs.Application.PatientFile;
using HospitaFlow.Application.Interfaces.Application;
using HospitaFlow.Core.Entities.Application;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitaFlow.Application.Features.Application.PatientFileFeature.Queries
{
    public record GetPatientById(int patientId) : IRequest<Result<PatientFileDto>>;
    public class GetPatientByIdHandler(IPatientFileRepository patientFileRepository , IMapper mapper) : IRequestHandler<GetPatientById, Result<PatientFileDto>>
    {
        public async Task<Result<PatientFileDto>> Handle(GetPatientById request, CancellationToken cancellationToken)
        {
            var result = await patientFileRepository.GetByIdAsync(request.patientId);
            if (result == null)
            {
                return Result<PatientFileDto>.Fail(MessagesConstants.NoDataWithID);
            }
            
            var data = mapper.Map<PatientFileDto>(result);
            return Result<PatientFileDto>.Done(data, MessagesConstants.DataRetrieved);
        }
    }
}
