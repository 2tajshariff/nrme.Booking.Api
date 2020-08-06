using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Papsmears
    {
        public int Recordid { get; set; }
        public int Recordstatus { get; set; }
        public int Internalid { get; set; }
        public int Userid { get; set; }
        public DateTime Papdate { get; set; }
        public int Papcode { get; set; }
        public string Comment { get; set; }
        public int Hpv { get; set; }
        public int Endocervicalcells { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }
        public int Cst { get; set; }
        public int Hpv16 { get; set; }
        public int Hpv18 { get; set; }
        public int Hpvother { get; set; }

        public virtual Patients Internal { get; set; }
        public virtual Papresults PapcodeNavigation { get; set; }
        public virtual Users User { get; set; }
    }
}
