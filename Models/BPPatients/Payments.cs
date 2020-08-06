using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Payments
    {
        public Payments()
        {
            Transactions = new HashSet<Transactions>();
        }

        public int Paymentid { get; set; }
        public int Recordstatus { get; set; }
        public int Locationid { get; set; }
        public DateTime? Paymentdate { get; set; }
        public string Reference { get; set; }
        public int Payercode { get; set; }
        public int Payerid { get; set; }
        public int Detailid { get; set; }
        public int Amount { get; set; }
        public int Prepayment { get; set; }
        public int Paymentrunnum { get; set; }
        public DateTime? Paymentrundate { get; set; }
        public string Batchnumber { get; set; }
        public string Providerno { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }
        public int Paymentcode { get; set; }
        public int Paymentlinkid { get; set; }

        public virtual ICollection<Transactions> Transactions { get; set; }
    }
}
