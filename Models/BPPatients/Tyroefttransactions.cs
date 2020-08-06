using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Tyroefttransactions
    {
        public Tyroefttransactions()
        {
            Tyroeftpayments = new HashSet<Tyroeftpayments>();
        }

        public int Recordid { get; set; }
        public int Recordstatus { get; set; }
        public DateTime Transactiondate { get; set; }
        public string Transactionref { get; set; }
        public string Transactionresult { get; set; }
        public string Transactionstatus { get; set; }
        public string Authno { get; set; }
        public string Transactionerror { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public int? Mid { get; set; }
        public int? Tid { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }

        public virtual ICollection<Tyroeftpayments> Tyroeftpayments { get; set; }
    }
}
