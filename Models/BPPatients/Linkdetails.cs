using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Linkdetails
    {
        public int Recordid { get; set; }
        public int Linked { get; set; }
        public int Overwrite { get; set; }
        public int Ignoreblanks { get; set; }
        public int Transferdata { get; set; }
        public int Transfervisits { get; set; }
        public int Transferimm { get; set; }
        public int Pracsoftformat { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }
    }
}
