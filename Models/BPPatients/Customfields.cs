using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Customfields
    {
        public int Recordid { get; set; }
        public int Internalid { get; set; }
        public string Fieldname { get; set; }
        public string Fieldtype { get; set; }
        public string Defaultvalue { get; set; }
        public int Savevalue { get; set; }
        public int Usesavedvalue { get; set; }
        public string Listboxarray { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }
    }
}
