using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Pcehraccess
    {
        public int Recordid { get; set; }
        public DateTime Accessdate { get; set; }
        public int Accesstime { get; set; }
        public int Internalid { get; set; }
        public string Ihi { get; set; }
        public int Userid { get; set; }
        public string Hpii { get; set; }
        public string Hpio { get; set; }
        public int Service { get; set; }
        public int Result { get; set; }
        public string Hofihi { get; set; }
        public int? Locationid { get; set; }

        public virtual Locations Location { get; set; }
    }
}
