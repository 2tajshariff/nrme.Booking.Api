using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class BatchService
    {
        public int Batchid { get; set; }
        public int Serviceid { get; set; }
        public string Claimserviceid { get; set; }
        public int BatchServicePaid { get; set; }
        public int ExplanationCode { get; set; }
        public int BatchServiceStatus { get; set; }
    }
}
