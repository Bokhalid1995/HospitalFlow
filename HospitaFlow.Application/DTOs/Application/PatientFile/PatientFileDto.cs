namespace HospitaFlow.Application.DTOs.Application.PatientFile
{
    public class PatientFileDto
    {
        
        public string FullName { get; set; } = string.Empty;
        public DateTime BirthDate { get; set; }
        public string Gender { get; set; } = string.Empty;

        public string NationalId { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
    }
}
