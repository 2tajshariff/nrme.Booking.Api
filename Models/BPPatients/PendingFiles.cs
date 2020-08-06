using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class PendingFiles
    {
        public int Recordid { get; set; }
        public string Filename { get; set; }
        public DateTime? Filedate { get; set; }
        public string Content { get; set; }
    }
}
