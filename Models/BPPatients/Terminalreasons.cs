using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Terminalreasons
    {
        public int Id { get; set; }
        public string Terminationreason { get; set; }
        public string TerminationReasonCode { get; set; }
    }
}
