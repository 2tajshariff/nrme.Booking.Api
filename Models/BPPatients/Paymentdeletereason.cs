using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Paymentdeletereason
    {
        public int Recordid { get; set; }
        public int Paymentid { get; set; }
        public string Reason { get; set; }
        public DateTime? Updated { get; set; }
        public int Updatedby { get; set; }
    }
}
