using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Vipfields
    {
        public Vipfields()
        {
            Vipdata = new HashSet<Vipdata>();
        }

        public int Fieldid { get; set; }
        public string Fieldname { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }

        public virtual ICollection<Vipdata> Vipdata { get; set; }
    }
}
