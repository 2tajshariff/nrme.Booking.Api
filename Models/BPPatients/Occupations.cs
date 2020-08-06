using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Occupations
    {
        public Occupations()
        {
            Occupationhistory = new HashSet<Occupationhistory>();
        }

        public int Occupationcode { get; set; }
        public int Occupationtype { get; set; }
        public string Occupationname { get; set; }

        public virtual ICollection<Occupationhistory> Occupationhistory { get; set; }
    }
}
