using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Workcoveritems
    {
        public int Recordid { get; set; }
        public int Internalid { get; set; }
        public int Recordstatus { get; set; }
        public int Certificateid { get; set; }
        public int Itemcode { get; set; }
        public string Itemvalue { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }

        public virtual Workcover Certificate { get; set; }
        public virtual Patients Internal { get; set; }
    }
}
