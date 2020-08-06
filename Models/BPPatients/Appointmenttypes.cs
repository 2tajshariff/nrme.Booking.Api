using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Appointmenttypes
    {
        public Appointmenttypes()
        {
            SmsscheduleAppttype = new HashSet<SmsscheduleAppttype>();
        }

        public int Appointmentcode { get; set; }
        public int Recordstatus { get; set; }
        public int Listorder { get; set; }
        public int Iconindex { get; set; }
        public int Appointmentlength { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }
        public int Au { get; set; }
        public int Nz { get; set; }

        public virtual ICollection<SmsscheduleAppttype> SmsscheduleAppttype { get; set; }
    }
}
