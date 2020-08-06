using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Messagegroups
    {
        public Messagegroups()
        {
            Messagegroupusers = new HashSet<Messagegroupusers>();
        }

        public int Messagegroupid { get; set; }
        public int Recordstatus { get; set; }
        public string Messagegroup { get; set; }

        public virtual ICollection<Messagegroupusers> Messagegroupusers { get; set; }
    }
}
