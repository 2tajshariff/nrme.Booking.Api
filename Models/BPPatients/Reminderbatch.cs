using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Reminderbatch
    {
        public Reminderbatch()
        {
            Reminders = new HashSet<Reminders>();
        }

        public int Batchid { get; set; }
        public DateTime Sentdate { get; set; }
        public int Senttime { get; set; }
        public int Sentby { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }

        public virtual ICollection<Reminders> Reminders { get; set; }
    }
}
