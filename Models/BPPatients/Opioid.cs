using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Opioid
    {
        public Opioid()
        {
            Opdose = new HashSet<Opdose>();
        }

        public int Opioidid { get; set; }
        public int Internalid { get; set; }
        public int Userid { get; set; }
        public int Recordstatus { get; set; }
        public DateTime? Opdate { get; set; }
        public string Drugcode { get; set; }
        public string Programno { get; set; }
        public string Month { get; set; }
        public string Year { get; set; }
        public int Givenat { get; set; }
        public string Quantity { get; set; }
        public string Instructions { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }

        public virtual Patients Internal { get; set; }
        public virtual Users User { get; set; }
        public virtual ICollection<Opdose> Opdose { get; set; }
    }
}
