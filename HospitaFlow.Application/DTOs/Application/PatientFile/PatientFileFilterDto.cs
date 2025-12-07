using HospitaFlow.Application.Common.Models;

namespace HospitaFlow.Application.DTOs.Application.PatientFile
{
    public class PatientFileFilterDto : PagingParams
    {
        
        public string FullName { get; set; } = string.Empty;
  
        public string Phone { get; set; } = string.Empty;
    }
}
