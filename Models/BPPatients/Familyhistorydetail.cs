using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Familyhistorydetail
    {
        public int Recordid { get; set; }
        public int Recordstatus { get; set; }
        public int Internalid { get; set; }
        public int Relationcode { get; set; }
        public int Relationno { get; set; }
        public string Condition { get; set; }
        public int Diseasecode { get; set; }
        public string Diseasecomment { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }

        public virtual Patients Internal { get; set; }
        public virtual Relations RelationcodeNavigation { get; set; }
    }
}
