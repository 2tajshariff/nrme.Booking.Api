﻿using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class PaymentpartService
    {
        public int Recordid { get; set; }
        public int Recordstatus { get; set; }
        public int Paymentpartid { get; set; }
        public int Serviceid { get; set; }
        public int Amount { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }
    }
}
