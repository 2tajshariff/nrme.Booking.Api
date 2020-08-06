using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class BpsPrescriptions
    {
        public int InternalId { get; set; }
        public int Scriptid { get; set; }
        public DateTime ScriptDate { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public string Dose { get; set; }
        public string Frequency { get; set; }
        public string Food { get; set; }
        public string OtherDetail { get; set; }
        public string Prn { get; set; }
        public string Instructions { get; set; }
        public int Route { get; set; }
        public int Quantity { get; set; }
        public string ProductUnit { get; set; }
        public int Repeats { get; set; }
        public int RepeatInterval { get; set; }
        public string Sahcno { get; set; }
        public int UserId { get; set; }
        public int RestrictionCode { get; set; }
        public string Authority { get; set; }
        public string AuthorityNumber { get; set; }
        public string ApprovalNumber { get; set; }
        public string AllowSubstitution { get; set; }
        public string Regulation24 { get; set; }
        public string Provider { get; set; }
        public string Scid { get; set; }
        public DateTime Created { get; set; }
    }
}
