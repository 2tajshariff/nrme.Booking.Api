using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Pensiontype
    {
        public Pensiontype()
        {
            Patients = new HashSet<Patients>();
        }

        public int Pensioncode { get; set; }
        public string Pensiontype1 { get; set; }

        public virtual ICollection<Patients> Patients { get; set; }
    }
}
