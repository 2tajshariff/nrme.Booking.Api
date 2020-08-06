using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Placenta
    {
        public Placenta()
        {
            Pregnancies = new HashSet<Pregnancies>();
        }

        public int Placentacode { get; set; }
        public string Placentatext { get; set; }

        public virtual ICollection<Pregnancies> Pregnancies { get; set; }
    }
}
