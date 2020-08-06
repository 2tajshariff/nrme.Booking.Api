using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Reversals
    {
        public int Recordid { get; set; }
        public int Paymentid { get; set; }
        public int Serviceid { get; set; }
        public int Amount { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
    }
}
