using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Hientities
    {
        public Hientities()
        {
            Hiaudit = new HashSet<Hiaudit>();
            Hierrors = new HashSet<Hierrors>();
        }

        public int Entitytype { get; set; }
        public string Entityname { get; set; }

        public virtual ICollection<Hiaudit> Hiaudit { get; set; }
        public virtual ICollection<Hierrors> Hierrors { get; set; }
    }
}
