﻿using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class PaymentRuns
    {
        public int Recordid { get; set; }
        public int Recordstatus { get; set; }
        public int Userid { get; set; }
        public int? Paymentrunnum { get; set; }
        public DateTime? Paymentrundate { get; set; }
        public int Depositamount { get; set; }
        public string Bankaccountname { get; set; }
        public string Bankaccountnum { get; set; }
        public string Bsbcode { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }
    }
}
