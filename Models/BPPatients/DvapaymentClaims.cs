using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class DvapaymentClaims
    {
        public int Recordid { get; set; }
        public int Recordstatus { get; set; }
        public int? Paymentrunid { get; set; }
        public DateTime? Paymentrundate { get; set; }
        public int? Batchid { get; set; }
        public string Claimid { get; set; }
        public DateTime? Claimdate { get; set; }
        public int Amountclaimed { get; set; }
        public int Claimbenefitpaid { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }
    }
}
