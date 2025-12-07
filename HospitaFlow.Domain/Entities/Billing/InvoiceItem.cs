using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitaFlow.Core.Entities.Billing
{
    public class InvoiceItem
    {
        public int Id { get; set; }
        public int InvoiceId { get; set; }

        public string Name { get; set; }
        public decimal Price { get; set; }

        public Invoice Invoice { get; set; }
    }
}
