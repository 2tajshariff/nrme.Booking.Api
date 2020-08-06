using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Papresults
    {
        public Papresults()
        {
            Papsmears = new HashSet<Papsmears>();
        }

        public int Papcode { get; set; }
        public int Display { get; set; }
        public int? Termid { get; set; }
        public string Paptext { get; set; }

        public virtual ICollection<Papsmears> Papsmears { get; set; }
    }
}
