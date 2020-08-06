using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Medicareeasyclaim
    {
        public Medicareeasyclaim()
        {
            EasyclaimService = new HashSet<EasyclaimService>();
        }

        public int Recordid { get; set; }
        public DateTime Transactiondate { get; set; }
        public string Transactionid { get; set; }
        public int Transactionerrorid { get; set; }
        public int Internalid { get; set; }
        public int Invoiceid { get; set; }
        public int Recordstatus { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }
        public string Transactionerror { get; set; }
        public int? Mid { get; set; }
        public int? Tid { get; set; }
        public int? Claimtype { get; set; }
        public int? Transactionresult { get; set; }
        public int? Userid { get; set; }
        public string Providerno { get; set; }

        public virtual ICollection<EasyclaimService> EasyclaimService { get; set; }
    }
}
