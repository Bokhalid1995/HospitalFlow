using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitaFlow.Core.Entities.Lookups
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // Navigation
        public ICollection<Doctor> Doctors { get; set; }
    }
}
