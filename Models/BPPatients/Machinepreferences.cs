using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Machinepreferences
    {
        public int Recordid { get; set; }
        public string Computer { get; set; }
        public string Preferencename { get; set; }
        public int? Preferencevalue { get; set; }
        public string Preferencetextvalue { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }
    }
}
