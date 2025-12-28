using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitaFlow.Application.Common.Responses
{
    public class RestCountryResponse
    {
        public Name name { get; set; } = default!;
        public string cca2 { get; set; } = default!;
        public string region { get; set; } = default!;

        public class Name
        {
            public string common { get; set; } = default!;
        }
    }

}
