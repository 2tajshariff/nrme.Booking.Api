using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Hchtiers
    {
        public Hchtiers()
        {
            Healthcarehomes = new HashSet<Healthcarehomes>();
            Patients = new HashSet<Patients>();
        }

        public int Tiercode { get; set; }
        public string Tiername { get; set; }

        public virtual ICollection<Healthcarehomes> Healthcarehomes { get; set; }
        public virtual ICollection<Patients> Patients { get; set; }
    }
}
