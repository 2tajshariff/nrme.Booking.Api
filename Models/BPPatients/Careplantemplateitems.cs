using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Careplantemplateitems
    {
        public int Recordid { get; set; }
        public int Templateid { get; set; }
        public int Recordstatus { get; set; }
        public int Itemcode { get; set; }
        public string Itemtext { get; set; }
        public int Dueindays { get; set; }
        public int Providercode { get; set; }
        public string Provider { get; set; }
        public int Providerid { get; set; }
        public int Detailid { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }
    }
}
