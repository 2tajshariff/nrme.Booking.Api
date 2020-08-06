using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Bpcommscredit
    {
        public int CreditId { get; set; }
        public int RecordStatus { get; set; }
        public string CreditKey { get; set; }
        public string CostSms { get; set; }
        public string CostBha { get; set; }
        public string Remaining { get; set; }
        public byte[] Hash { get; set; }
        public DateTime Created { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? Updated { get; set; }
        public int? UpdatedBy { get; set; }
    }
}
