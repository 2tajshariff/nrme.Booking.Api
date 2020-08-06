using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Unsentclaims
    {
        public int Recordid { get; set; }
        public int Recordstatus { get; set; }
        public int Internalid { get; set; }
        public int Userid { get; set; }
        public int Invoiceid { get; set; }
        public int Paymentid { get; set; }
        public int Usebpaddress { get; set; }
        public int Eft { get; set; }
        public int Failedtransmission { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }
    }
}
