using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Bloodloss
    {
        public Bloodloss()
        {
            Pregnancies = new HashSet<Pregnancies>();
        }

        public int Bloodlosscode { get; set; }
        public string Bloodlosstext { get; set; }

        public virtual ICollection<Pregnancies> Pregnancies { get; set; }
    }
}
