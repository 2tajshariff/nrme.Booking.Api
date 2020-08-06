using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class EasyclaimService
    {
        public int EasyclaimServiceid { get; set; }
        public int Easyclaimid { get; set; }
        public int Serviceid { get; set; }
        public string Errorcode { get; set; }
        public int? Paymentrunid { get; set; }
        public string Claimserviceid { get; set; }
        public int? Adjusted { get; set; }
        public int? Transactionstatus { get; set; }
        public string Claimid { get; set; }
        public int? Bulkbilleasyclaimid { get; set; }

        public virtual Bulkbilleasyclaims Bulkbilleasyclaim { get; set; }
        public virtual Medicareeasyclaim Easyclaim { get; set; }
        public virtual Easyclaimpaymentruns Paymentrun { get; set; }
    }
}
