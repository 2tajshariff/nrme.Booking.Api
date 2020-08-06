using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Invoicelock
    {
        public int Recordid { get; set; }
        public DateTime Lockdate { get; set; }
        public int Locktime { get; set; }
        public int Invoiceid { get; set; }
        public int Userid { get; set; }
        public string Computer { get; set; }

        public virtual Invoices Invoice { get; set; }
        public virtual Users User { get; set; }
    }
}
