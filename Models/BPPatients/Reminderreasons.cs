using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Reminderreasons
    {
        public Reminderreasons()
        {
            Reminders = new HashSet<Reminders>();
        }

        public int Reminderreasonid { get; set; }
        public int Recordstatus { get; set; }
        public int Userid { get; set; }
        public string Reasontext { get; set; }
        public int Defaultinterval { get; set; }
        public int Intervalcode { get; set; }
        public int Userinterval { get; set; }
        public int Userintervalcode { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }
        public int Remindertypeid { get; set; }
        public int Clinicallysignificant { get; set; }
        public int Displayorder { get; set; }
        public int Au { get; set; }
        public int Nz { get; set; }

        public virtual Users User { get; set; }
        public virtual ICollection<Reminders> Reminders { get; set; }
    }
}
