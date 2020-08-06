using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Reminderssent
    {
        public int Recordid { get; set; }
        public int Recordstatus { get; set; }
        public int Internalid { get; set; }
        public int Userid { get; set; }
        public int Reminderid { get; set; }
        public DateTime Sentdate { get; set; }
        public int Sentby { get; set; }
        public int Sentcode { get; set; }
        public int Templateid { get; set; }
        public DateTime? Actiondate { get; set; }
        public int Actioncode { get; set; }
        public int Actionby { get; set; }
        public string Actiontext { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }
        public int? Locationid { get; set; }

        public virtual Patients Internal { get; set; }
        public virtual Reminders Reminder { get; set; }
        public virtual Users User { get; set; }
    }
}
