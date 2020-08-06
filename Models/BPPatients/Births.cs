using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Births
    {
        public int Recordid { get; set; }
        public int Recordstatus { get; set; }
        public int Pregnancyid { get; set; }
        public int Internalid { get; set; }
        public string Firstname { get; set; }
        public int Sex { get; set; }
        public string Weight { get; set; }
        public int Live { get; set; }
        public int Apgar1 { get; set; }
        public int Apgar5 { get; set; }
        public int Birthorder { get; set; }
        public int ChildId { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }

        public virtual Patients Internal { get; set; }
        public virtual Pregnancies Pregnancy { get; set; }
    }
}
