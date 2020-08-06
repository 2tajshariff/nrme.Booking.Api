using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class BpsInvestigations
    {
        public int InternalId { get; set; }
        public string ProviderName { get; set; }
        public DateTime? Collected { get; set; }
        public string TestName { get; set; }
        public DateTime? Reported { get; set; }
        public int ReportTime { get; set; }
        public byte[] ReportHeader { get; set; }
        public byte[] ReportBody { get; set; }
        public string Normal { get; set; }
        public string Completed { get; set; }
        public string Confidential { get; set; }
        public DateTime? Checked { get; set; }
        public string CheckedBy { get; set; }
        public string Notation { get; set; }
        public string Action { get; set; }
        public DateTime? Actioned { get; set; }
        public string Comment { get; set; }
        public string Provider { get; set; }
        public int ReportId { get; set; }
        public int Stored { get; set; }
        public DateTime Created { get; set; }
    }
}
