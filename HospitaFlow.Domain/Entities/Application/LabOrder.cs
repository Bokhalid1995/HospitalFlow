using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitaFlow.Core.Entities.Lookups;

namespace HospitaFlow.Core.Entities.Application
{
    public class LabOrder
    {
        public int Id { get; set; }
        public int VisitId { get; set; }
        public int LabTestId { get; set; }
        public string Status { get; set; }

        public Visit Visit { get; set; }
        public LabTest LabTest { get; set; }
    }
}
