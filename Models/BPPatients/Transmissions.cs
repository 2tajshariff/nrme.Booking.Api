using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Transmissions
    {
        public int Recordid { get; set; }
        public int Internalid { get; set; }
        public int Userid { get; set; }
        public int Recipientid { get; set; }
        public int Recordstatus { get; set; }
        public int Displaycode { get; set; }
        public string Controlid { get; set; }
        public DateTime? Storeddate { get; set; }
        public DateTime? Transmitdate { get; set; }
        public string Content { get; set; }
        public int Ackcode { get; set; }
        public DateTime? Ackdate { get; set; }
        public string Response { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }

        public virtual Patients Internal { get; set; }
        public virtual Users User { get; set; }
    }
}
