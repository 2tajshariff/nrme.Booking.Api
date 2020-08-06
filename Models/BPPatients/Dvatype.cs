using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Dvatype
    {
        public Dvatype()
        {
            Patients = new HashSet<Patients>();
        }

        public int Dvacode { get; set; }
        public string Dvatype1 { get; set; }

        public virtual ICollection<Patients> Patients { get; set; }
    }
}
