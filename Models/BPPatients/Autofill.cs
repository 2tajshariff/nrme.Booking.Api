using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Autofill
    {
        public int Recordid { get; set; }
        public int Userid { get; set; }
        public string Keycombination { get; set; }
        public string Textvalue { get; set; }
        public int Usagecode { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }

        public virtual Users User { get; set; }
    }
}
