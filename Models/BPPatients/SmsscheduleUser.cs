using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class SmsscheduleUser
    {
        public int Recordid { get; set; }
        public int Scheduleid { get; set; }
        public int Userid { get; set; }

        public virtual Smsschedules Schedule { get; set; }
        public virtual Users User { get; set; }
    }
}
