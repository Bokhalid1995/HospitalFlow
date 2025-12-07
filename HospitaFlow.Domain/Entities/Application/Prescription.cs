using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitaFlow.Core.Entities.Lookups;

namespace HospitaFlow.Core.Entities.Application
{
    public class Prescription
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }

        public int VisitId { get; set; }
        public Visit Visit { get; set; }

        public ICollection<PrescriptionItem> Items { get; set; }
    }
}
