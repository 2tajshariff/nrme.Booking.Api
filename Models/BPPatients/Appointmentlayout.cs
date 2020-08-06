using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Appointmentlayout
    {
        public int Layoutid { get; set; }
        public int Recordstatus { get; set; }
        public string Layoutname { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }
        public int Locationid { get; set; }
    }
}
