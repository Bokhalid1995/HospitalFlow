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
    public record AddPatientFileCommand(PatientFileDto PatientFile) : IRequest<Result<PatientFile>>;

    public class AddPatientFileCommandHandler(IUnitOfWork unitOfWork , IMapper mapper ,IEmailService emailService ) : IRequestHandler<AddPatientFileCommand, Result<PatientFile>>
    {
        public async Task<Result<PatientFile>> Handle(AddPatientFileCommand request, CancellationToken cancellationToken)
        {

            var entity = mapper.Map<PatientFile>(request.PatientFile);
            await unitOfWork.PatientFiles.AddAsync(entity);
            var result = await unitOfWork.SaveChangesAsync();
            if (result == 0)
            {
                throw new BusinessException(MessagesConstants.CreateFail);
            }
            // Send welcome email
            await emailService.SendEmailAsync(entity.Email, "مرحبا بك عميلنا المميز", "تم فتح ملف خاص بك بالمستشفى بنجاح");

            return Result<PatientFile>.Done(entity, MessagesConstants.DataCreated);

        }
    }
}
