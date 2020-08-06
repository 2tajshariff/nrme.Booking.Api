using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Ereferrals
    {
        public int Recordid { get; set; }
        public int Recordstatus { get; set; }
        public int Internalid { get; set; }
        public int Userid { get; set; }
        public int Recipientid { get; set; }
        public int Documentid { get; set; }
        public int Statuscode { get; set; }
        public string Messageid { get; set; }
        public DateTime? Storeddate { get; set; }
        public DateTime? Transmitdate { get; set; }
        public int Ackcode { get; set; }
        public DateTime? Ackdate { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }
        public int? Messagingproviderid { get; set; }
        public string Details { get; set; }

        public virtual Patients Internal { get; set; }
        public virtual Messagingproviders Messagingprovider { get; set; }
        public virtual Users User { get; set; }
    }
}
