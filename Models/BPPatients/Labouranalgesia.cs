using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Labouranalgesia
    {
        public Labouranalgesia()
        {
            Pregnancies = new HashSet<Pregnancies>();
        }

        public int Analgesiacode { get; set; }
        public string Analgesiatext { get; set; }

        public virtual ICollection<Pregnancies> Pregnancies { get; set; }
    }
}
