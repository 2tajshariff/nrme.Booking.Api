using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class BankingbatchPaymentparts
    {
        public int Recordid { get; set; }
        public int Recordstatus { get; set; }
        public int Batchid { get; set; }
        public int Paymentpartid { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }

        public virtual Banking Batch { get; set; }
        public virtual Paymentparts Paymentpart { get; set; }
    }
}
