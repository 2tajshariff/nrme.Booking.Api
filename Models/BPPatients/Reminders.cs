using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Reminders
    {
        public Reminders()
        {
            Reminderssent = new HashSet<Reminderssent>();
        }

        public int Reminderid { get; set; }
        public int Recordstatus { get; set; }
        public int Reminderstatus { get; set; }
        public int Batchid { get; set; }
        public int Internalid { get; set; }
        public int Userid { get; set; }
        public int Reminderreasonid { get; set; }
        public string Reasontext { get; set; }
        public DateTime Reminderdue { get; set; }
        public int Remindercode { get; set; }
        public int Interval { get; set; }
        public int Intervalcode { get; set; }
        public int Appointmentid { get; set; }
        public string Statustext { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }
        public int? Locationid { get; set; }
        public int? Previoususerid { get; set; }
        public string Comments { get; set; }
        public int Visitid { get; set; }

        public virtual Reminderbatch Batch { get; set; }
        public virtual Patients Internal { get; set; }
        public virtual Reminderreasons Reminderreason { get; set; }
        public virtual Users User { get; set; }
        public virtual ICollection<Reminderssent> Reminderssent { get; set; }
    }
}
