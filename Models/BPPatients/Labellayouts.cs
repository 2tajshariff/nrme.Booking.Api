using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Labellayouts
    {
        public int Recordid { get; set; }
        public string Layoutname { get; set; }
        public int Nametop { get; set; }
        public int Nameleft { get; set; }
        public int Addresstop { get; set; }
        public int Addressleft { get; set; }
        public int Dobtop { get; set; }
        public int Dobleft { get; set; }
        public int Medicaretop { get; set; }
        public int Medicareleft { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }
    }
}
