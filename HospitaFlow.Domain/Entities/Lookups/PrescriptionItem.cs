using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitaFlow.Core.Entities.Application;

namespace HospitaFlow.Core.Entities.Lookups
{


    public class PrescriptionItem
    {
        public int Id { get; set; }
        public int PrescriptionId { get; set; }

        public int MedicineId { get; set; }
        public string Dosage { get; set; }
        public string Duration { get; set; }

        // Navigation
        public Prescription Prescription { get; set; }
        //public Medicine Medicine { get; set; }
    }

}
