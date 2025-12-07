using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitaFlow.Core.Entities.Lookups
{
  
        public class Item
        {
            public int Id { get; set; }
            public string Name { get; set; } = string.Empty;
            public string Category { get; set; } = null!;
        }
   
}
