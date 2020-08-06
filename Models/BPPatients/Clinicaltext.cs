using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Clinicaltext
    {
        public int Recordid { get; set; }
        public string Itemname { get; set; }
        public int Itemcode { get; set; }
        public int Itemtype { get; set; }
        public int Objectcode { get; set; }
        public string Item1 { get; set; }
        public string Item2 { get; set; }
        public string Item3 { get; set; }
        public string Item4 { get; set; }
    }
}
