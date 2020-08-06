using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Paymentparts
    {
        public Paymentparts()
        {
            BankingbatchPaymentparts = new HashSet<BankingbatchPaymentparts>();
        }

        public int Recordid { get; set; }
        public int Recordstatus { get; set; }
        public int Paymentid { get; set; }
        public int Paymenttype { get; set; }
        public int Amount { get; set; }
        public string Drawer { get; set; }
        public string Bank { get; set; }
        public string Branch { get; set; }
        public string Chequeno { get; set; }
        public int Cardtype { get; set; }
        public int Banked { get; set; }
        public int Bankbatch { get; set; }
        public DateTime? Bankdate { get; set; }
        public int Accountid { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }
        public int Paymentcode { get; set; }
        public int Adjustmentlink { get; set; }

        public virtual ICollection<BankingbatchPaymentparts> BankingbatchPaymentparts { get; set; }
    }
}
