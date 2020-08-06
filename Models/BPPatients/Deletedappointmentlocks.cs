using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Deletedappointmentlocks
    {
        public int Recordid { get; set; }
        public DateTime Appointmentdate { get; set; }
        public int Appointmenttime { get; set; }
        public int Userid { get; set; }
        public string Computer { get; set; }
        public int Deletedby { get; set; }
        public DateTime Deleteddate { get; set; }

        public virtual Users DeletedbyNavigation { get; set; }
        public virtual Users User { get; set; }
    }
}
