using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Cancelledappointments
    {
        public int Appointmentid { get; set; }
        public int Cancelledby { get; set; }
        public DateTime Cancelleddate { get; set; }
        public int Cancelledtime { get; set; }
        public string Reason { get; set; }

        public virtual Users CancelledbyNavigation { get; set; }
    }
}
