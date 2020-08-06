using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Requestformatdetail
    {
        public int Recordid { get; set; }
        public int Requestformat { get; set; }
        public string Elementname { get; set; }
        public int Elementtop { get; set; }
        public int Elementleft { get; set; }
        public int Elementwidth { get; set; }
        public int Elementheight { get; set; }

        public virtual Requestformats RequestformatNavigation { get; set; }
    }
}
