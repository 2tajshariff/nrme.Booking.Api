using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Visittype
    {
        public Visittype()
        {
            Visits = new HashSet<Visits>();
        }

        public int Visitcode { get; set; }
        public string Visittype1 { get; set; }

        public virtual ICollection<Visits> Visits { get; set; }
    }
}
