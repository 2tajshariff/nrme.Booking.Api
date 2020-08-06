using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Appointmentlocks
    {
        public int Recordid { get; set; }
        public DateTime Appointmentdate { get; set; }
        public int Appointmenttime { get; set; }
        public int Userid { get; set; }
        public string Computer { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
    }
}
