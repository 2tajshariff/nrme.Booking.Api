using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Banking
    {
        public Banking()
        {
            BankingbatchPaymentparts = new HashSet<BankingbatchPaymentparts>();
        }

        public int Recordid { get; set; }
        public int Recordstatus { get; set; }
        public DateTime Bankingdate { get; set; }
        public int Accountid { get; set; }
        public int Cash { get; set; }
        public int Cheque { get; set; }
        public int Credit { get; set; }
        public int Eftpos { get; set; }
        public int Total { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }

        public virtual ICollection<BankingbatchPaymentparts> BankingbatchPaymentparts { get; set; }
    }
}
