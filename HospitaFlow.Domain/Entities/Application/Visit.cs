using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitaFlow.Core.Entities.Lookups;

namespace HospitaFlow.Core.Entities.Application
{
    public class Visit
    {
        public int Id { get; set; }
        public DateTime VisitDate { get; set; }
        public string Diagnosis { get; set; }

        public int PatientId { get; set; }
        public int DoctorId { get; set; }

        public PatientFile Patient { get; set; }
        public Doctor Doctor { get; set; }

        public ICollection<Prescription> Prescriptions { get; set; }
        public ICollection<LabOrder> LabOrders { get; set; }
    }

}
