using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitaFlow.Core.Entities.Application
{
    public class Admission
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public int RoomId { get; set; }
        public int BedId { get; set; }

        public DateTime AdmissionDate { get; set; }
        public DateTime? DischargeDate { get; set; }
    }
}
