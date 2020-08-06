using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Pregnancyoutcome
    {
        public Pregnancyoutcome()
        {
            Pregnancies = new HashSet<Pregnancies>();
        }

        public int Outcomecode { get; set; }
        public string Outcometext { get; set; }

        public virtual ICollection<Pregnancies> Pregnancies { get; set; }
    }
}
