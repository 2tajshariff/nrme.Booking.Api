using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Labouraugmentation
    {
        public Labouraugmentation()
        {
            Pregnancies = new HashSet<Pregnancies>();
        }

        public int Augmentationcode { get; set; }
        public string Augmentationtext { get; set; }

        public virtual ICollection<Pregnancies> Pregnancies { get; set; }
    }
}
