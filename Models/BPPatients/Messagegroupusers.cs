using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Messagegroupusers
    {
        public int Recordid { get; set; }
        public int Recordstatus { get; set; }
        public int Messagegroupid { get; set; }
        public int Userid { get; set; }

        public virtual Messagegroups Messagegroup { get; set; }
        public virtual Users User { get; set; }
    }
}
