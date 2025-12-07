using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitaFlow.Core.Entities.Application;

namespace HospitaFlow.Core.Entities.Lookups
{
    public class Doctor
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public int SpecializationId { get; set; }
        public int DepartmentId { get; set; }

        public string LicenseNumber { get; set; }

        // Navigation
        public Specialization Specialization { get; set; }
        public Department Department { get; set; }
        public ICollection<Appointment> Appointments { get; set; }
        public ICollection<Visit> Visits { get; set; }
    }
}
