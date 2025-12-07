using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitaFlow.Core.Entities.Application
{
    public class PatientFile
    {
        public int Id { get; set; }
        public string FullName { get; set; } = string.Empty;
        public DateTime BirthDate { get; set; }
        public string Gender { get; set; } = string.Empty;

        public string NationalId { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;

        // Navigation
        public MedicalRecord MedicalRecord { get; set; }
        public ICollection<Insurance> Insurances { get; set; }
        public ICollection<Appointment> Appointments { get; set; }
        public ICollection<Visit> Visits { get; set; }
    }
}
