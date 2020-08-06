using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Vaccinebatch
    {
        public int Recordid { get; set; }
        public int Vaccineid { get; set; }
        public string Batchnumber { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }
        public DateTime? Expirydate { get; set; }
    }
}
