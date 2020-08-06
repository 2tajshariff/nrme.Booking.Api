using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Labouronset
    {
        public Labouronset()
        {
            Pregnancies = new HashSet<Pregnancies>();
        }

        public int Onsetcode { get; set; }
        public string Onsettext { get; set; }

        public virtual ICollection<Pregnancies> Pregnancies { get; set; }
    }
}
