using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitaFlow.Core.Entities.Lookups
{
    public class Bed
    {
        public int Id { get; set; }
        public string BedNumber { get; set; }

        public int RoomId { get; set; }
        public Room Room { get; set; }
    }
}
