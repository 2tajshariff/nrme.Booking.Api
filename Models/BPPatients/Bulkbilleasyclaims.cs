using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Bulkbilleasyclaims
    {
        public Bulkbilleasyclaims()
        {
            EasyclaimService = new HashSet<EasyclaimService>();
        }

        public int Recordid { get; set; }
        public string Claimid { get; set; }
        public int Claimbenefitpaid { get; set; }
        public int Claimchargeamount { get; set; }
        public DateTime Dateoftransmission { get; set; }
        public string Servicingprovidernum { get; set; }
        public string Payeeprovidernum { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }

        public virtual ICollection<EasyclaimService> EasyclaimService { get; set; }
    }
}
