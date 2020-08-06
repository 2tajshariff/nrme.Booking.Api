using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Tyroeftpayments
    {
        public int Recordid { get; set; }
        public int Tyroeftid { get; set; }
        public int? Paymentpartserviceid { get; set; }
        public int? Serviceid { get; set; }

        public virtual Tyroefttransactions Tyroeft { get; set; }
    }
}
