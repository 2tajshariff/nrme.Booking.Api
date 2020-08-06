using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Sterilisation
    {
        public int Recordid { get; set; }
        public int Recordstatus { get; set; }
        public int Userid { get; set; }
        public int Internalid { get; set; }
        public string Packtype { get; set; }
        public string Batchnumber { get; set; }
        public DateTime Datesterilised { get; set; }
        public DateTime? Dateused { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }
    }
}
