using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Smstemplate
    {
        public int Templateid { get; set; }
        public int Recordstatus { get; set; }
        public bool Defaulttemplate { get; set; }
        public string Templatename { get; set; }
        public string Messagetext { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }
        public int Usedfor { get; set; }
        public int Editable { get; set; }
        public int AppointmentReply { get; set; }
        public string Subject { get; set; }
    }
}
