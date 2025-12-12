using HospitaFlow.Core.Enums;

namespace HospitaFlow.Application.DTOs.Application.PatientFile
{
    public class PatientFileDto
    {
        
        public string FullName { get; set; } = string.Empty;
        public DateTime BirthDate { get; set; }
        public GenderEnum Gender { get; set; } 
       

        public string NationalId { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
       public string Address { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;



    }
}
