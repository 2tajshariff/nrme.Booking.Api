using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Invoicedeletereason
    {
        public int Recordid { get; set; }
        public int Invoiceid { get; set; }
        public string Reason { get; set; }
        public DateTime? Updated { get; set; }
        public int Updatedby { get; set; }
    }
}
