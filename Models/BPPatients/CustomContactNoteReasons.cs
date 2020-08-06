using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class CustomContactNoteReasons
    {
        public int RecordId { get; set; }
        public int RecordStatus { get; set; }
        public int ReasonCode { get; set; }
        public string Reason { get; set; }
        public int Au { get; set; }
        public int Nz { get; set; }
        public DateTime Created { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? Updated { get; set; }
        public int? UpdatedBy { get; set; }
        public int ActiveForManual { get; set; }
    }
}
