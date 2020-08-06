using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Medisecure
    {
        public int Recordid { get; set; }
        public int Internalid { get; set; }
        public int Userid { get; set; }
        public int Scriptid { get; set; }
        public int Signed { get; set; }
        public DateTime? Scriptdate { get; set; }
        public string Barcode { get; set; }
        public int Returncode { get; set; }
        public DateTime Created { get; set; }
    }
}
