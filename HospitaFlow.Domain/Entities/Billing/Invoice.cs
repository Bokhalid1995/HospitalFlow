using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitaFlow.Core.Entities.Application;

namespace HospitaFlow.Core.Entities.Billing
{
    public class Invoice
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public int VisitId { get; set; }

        public decimal TotalAmount { get; set; }
        public decimal PaidAmount { get; set; }

        public PatientFile Patient { get; set; }
        public ICollection<InvoiceItem> Items { get; set; }
    }
}
