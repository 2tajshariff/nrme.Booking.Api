using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Sex
    {
        public Sex()
        {
            Patients = new HashSet<Patients>();
        }

        public int Sexcode { get; set; }
        public string Sex1 { get; set; }

        public virtual ICollection<Patients> Patients { get; set; }
    }
}
