using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Requestformats
    {
        public Requestformats()
        {
            Laboratories = new HashSet<Laboratories>();
            Requestformatdetail = new HashSet<Requestformatdetail>();
        }

        public int Requestformat { get; set; }
        public int Recordstatus { get; set; }
        public string Formatname { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }

        public virtual ICollection<Laboratories> Laboratories { get; set; }
        public virtual ICollection<Requestformatdetail> Requestformatdetail { get; set; }
    }
}
