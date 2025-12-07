using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitaFlow.Core.Entities.Lookups;

namespace HospitaFlow.Core.Entities.Application
{
    public class Appointment
    {
        public int Id { get; set; }
        public DateTime AppointmentDate { get; set; }
        public string Status { get; set; } // Scheduled, Completed, Cancelled

        public int PatientId { get; set; }
        public int DoctorId { get; set; }

        // Navigation
        public PatientFile Patient { get; set; }
        public Doctor Doctor { get; set; }
    }
}
