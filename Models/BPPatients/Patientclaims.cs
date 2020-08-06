using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Patientclaims
    {
        public int Recordid { get; set; }
        public int Recordstatus { get; set; }
        public int Internalid { get; set; }
        public int Userid { get; set; }
        public int Invoiceid { get; set; }
        public int Paymentid { get; set; }
        public DateTime? Claimdate { get; set; }
        public string Claimtime { get; set; }
        public int Claimstatus { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }
        public string PmsclaimNo { get; set; }
    }
}
