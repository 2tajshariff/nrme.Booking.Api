using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Feeding
    {
        public Feeding()
        {
            Pregnancies = new HashSet<Pregnancies>();
        }

        public int Feedingcode { get; set; }
        public string Feedingtext { get; set; }

        public virtual ICollection<Pregnancies> Pregnancies { get; set; }
    }
}
