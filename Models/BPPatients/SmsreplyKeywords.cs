using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class SmsreplyKeywords
    {
        public int RecordId { get; set; }
        public int RecordStatus { get; set; }
        public string Keyword { get; set; }
        public int Type { get; set; }
        public DateTime Created { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? Updated { get; set; }
        public int? UpdatedBy { get; set; }
    }
}
