using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Psidetails
    {
        public int Recordid { get; set; }
        public string Usage { get; set; }
        public string Computer { get; set; }
        public string Psipath { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }
    }
}
