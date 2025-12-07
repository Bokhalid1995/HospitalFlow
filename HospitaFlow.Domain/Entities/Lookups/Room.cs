using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitaFlow.Core.Entities.Lookups
{
    public class Room
    {
        public int Id { get; set; }
        public string RoomNumber { get; set; }
        public string Type { get; set; } // ICU, Private, Normal

        public ICollection<Bed> Beds { get; set; }
    }

}
