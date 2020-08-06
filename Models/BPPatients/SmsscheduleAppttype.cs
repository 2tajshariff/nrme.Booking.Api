using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class SmsscheduleAppttype
    {
        public int Recordid { get; set; }
        public int Appointmentcode { get; set; }
        public int Scheduleid { get; set; }

        public virtual Appointmenttypes AppointmentcodeNavigation { get; set; }
        public virtual Smsschedules Schedule { get; set; }
    }
}
