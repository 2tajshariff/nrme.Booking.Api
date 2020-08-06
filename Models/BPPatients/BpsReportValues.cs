using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class BpsReportValues
    {
        public int InternalId { get; set; }
        public int ReportId { get; set; }
        public DateTime? ReportDate { get; set; }
        public string ResultName { get; set; }
        public string LoincCode { get; set; }
        public int Bpcode { get; set; }
        public string ResultValue { get; set; }
        public string Units { get; set; }
        public string Range { get; set; }
        public string AbnormalFlag { get; set; }
    }
}
