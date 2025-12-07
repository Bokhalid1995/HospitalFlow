using HospitaFlow.Application.DTOs.Application.PatientFile;
using HospitaFlow.Application.Features.Application.PatientFileFeature.Commands;
using HospitaFlow.Application.Features.Application.PatientFileFeature.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace HospitaFlow.Api.Controllers
{
    [Route("api/")]
    [ApiController]
    public class PatientFileController(ISender sender) : ControllerBase
    {
        [HttpPost("patients")]
        public async Task<IActionResult> CreatePatientFile([FromBody] PatientFileDto patientFile)
        {
           var result =  await sender.Send(new AddPatientFileCommand(patientFile));
            return Ok(result);
        }
        [HttpGet("patients")]
        public async Task<IActionResult> GetPatientFiles([FromQuery] PatientFileFilterDto patientFileFilter)
        {
            var result = await sender.Send(new GetAllPatientFiles(patientFileFilter));
            return Ok(result);
        }
         
        [HttpGet("patients/{Id}")]
        public async Task<IActionResult> GetPatientFiles( int Id)
        {
            var result = await sender.Send(new GetPatientById(Id));
            return Ok(result);
        }
        [HttpPut("patients/{Id}")]
        public async Task<IActionResult> UpdatePatientFiles(int Id , PatientFileDto patientFile)
        {
            var result = await sender.Send(new UpdatePatientFileCommand(Id , patientFile));
            return Ok(result);
        }
    }
}

