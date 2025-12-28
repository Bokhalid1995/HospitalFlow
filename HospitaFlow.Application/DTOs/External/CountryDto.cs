using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitaFlow.Application.DTOs.External
{
    public class CountryDto
    {
        public string Name { get; set; } = default!;
        public string Code { get; set; } = default!;
        public string Region { get; set; } = default!;
    }
}
