using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Feeschedules
    {
        public int Scheduleid { get; set; }
        public int Recordstatus { get; set; }
        public string Schedulename { get; set; }
        public int Addpercent { get; set; }
        public int Percentex { get; set; }
        public int Addfixed { get; set; }
        public int Rounding { get; set; }
        public int Roundto { get; set; }
    }
}
