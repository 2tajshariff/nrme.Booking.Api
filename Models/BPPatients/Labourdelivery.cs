using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Labourdelivery
    {
        public Labourdelivery()
        {
            Pregnancies = new HashSet<Pregnancies>();
        }

        public int Deliverycode { get; set; }
        public string Deliverytext { get; set; }

        public virtual ICollection<Pregnancies> Pregnancies { get; set; }
    }
}
