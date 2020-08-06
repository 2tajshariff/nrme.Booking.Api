using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Perineum
    {
        public Perineum()
        {
            Pregnancies = new HashSet<Pregnancies>();
        }

        public int Perineumcode { get; set; }
        public string Perineumtext { get; set; }

        public virtual ICollection<Pregnancies> Pregnancies { get; set; }
    }
}
