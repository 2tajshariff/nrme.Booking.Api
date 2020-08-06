using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Generatedtext
    {
        public int Recordid { get; set; }
        public int Recordstatus { get; set; }
        public int Userid { get; set; }
        public int Textcode { get; set; }
        public string Notestext { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }

        public virtual Users User { get; set; }
    }
}
