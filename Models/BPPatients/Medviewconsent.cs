using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Medviewconsent
    {
        public int Recordid { get; set; }
        public int Internalid { get; set; }
        public int Userid { get; set; }
        public int Consentbefore { get; set; }
        public int Consentafter { get; set; }
        public DateTime Updated { get; set; }

        public virtual Patients Internal { get; set; }
        public virtual Users User { get; set; }
    }
}
