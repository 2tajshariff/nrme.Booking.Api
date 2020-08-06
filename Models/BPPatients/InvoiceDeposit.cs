using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class InvoiceDeposit
    {
        public int Recordid { get; set; }
        public int Recordstatus { get; set; }
        public int Invoiceid { get; set; }
        public int Depositid { get; set; }
        public int Paymentid { get; set; }
        public int Amount { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }
    }
}
