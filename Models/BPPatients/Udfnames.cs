using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Udfnames
    {
        public Udfnames()
        {
            Udfvalues = new HashSet<Udfvalues>();
        }

        public int Udfid { get; set; }
        public int Recordstatus { get; set; }
        public string Udfname { get; set; }
        public int Udftype { get; set; }
        public int Udflength { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }

        public virtual ICollection<Udfvalues> Udfvalues { get; set; }
    }
}
