using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Transidentity
    {
        public int Recipientid { get; set; }
        public int Userid { get; set; }
        public string Recipientname { get; set; }
        public string Type { get; set; }
        public string Value { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }

        public virtual Users User { get; set; }
    }
}
