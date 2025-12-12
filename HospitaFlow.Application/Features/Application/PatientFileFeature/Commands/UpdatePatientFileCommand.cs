using AutoMapper;
using HospitaFlow.Application.Common.Exceptions;
using HospitaFlow.Application.Common.Responses;
using HospitaFlow.Application.DTOs.Application.PatientFile;
using HospitaFlow.Application.Interfaces.Application;
using HospitaFlow.Application.Interfaces.Common;
using HospitaFlow.Application.Sahred.Constants;
using HospitaFlow.Core.Entities.Application;
using MediatR;


namespace HospitaFlow.Application.Features.Application.PatientFileFeature.Commands
{
    public  record UpdatePatientFileCommand(int Id , PatientFileDto PatientFile) : IRequest<Result<PatientFile>>;
    public class UpdatePatientFileCommandHandler(IUnitOfWork unitOfWork , IMapper mapper) : IRequestHandler<UpdatePatientFileCommand, Result<PatientFile>>
    {
        public async Task<Result<PatientFile>> Handle(UpdatePatientFileCommand request, CancellationToken cancellationToken)
        {
           
            var entity = await unitOfWork.PatientFiles.GetByIdAsync(request.Id);
            if (entity == null)
            {
                 throw new NotFoundException(MessagesConstants.NoDataWithID);
            }

            mapper.Map(request.PatientFile, entity);
            unitOfWork.PatientFiles.Update(entity);

            var saved = await unitOfWork.SaveChangesAsync();
            if (saved == 0)
            {
                return Result<PatientFile>.Fail(MessagesConstants.UpdateFail);
            }
       
            return Result<PatientFile>.Done(entity , MessagesConstants.DataUpdated);
        }
    
        
    }
}
