using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Easyclaimpaymentruns
    {
        public Easyclaimpaymentruns()
        {
            EasyclaimService = new HashSet<EasyclaimService>();
        }

        public int Paymentrunid { get; set; }
        public int Recordstatus { get; set; }
        public string Paymentrunnum { get; set; }
        public DateTime? Paymentrundate { get; set; }
        public int Depositamount { get; set; }
        public string Bankaccountname { get; set; }
        public string Bankaccountnum { get; set; }
        public string Bsbcode { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }

        public virtual ICollection<EasyclaimService> EasyclaimService { get; set; }
    }
}
