using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Acupuncturevisits
    {
        public Acupuncturevisits()
        {
            Acupunctureconditions = new HashSet<Acupunctureconditions>();
        }

        public int Visitid { get; set; }
        public int Recordstatus { get; set; }
        public int Internalid { get; set; }
        public int Userid { get; set; }
        public DateTime? Acupuncturedate { get; set; }
        public int? Acupuncturetime { get; set; }
        public string Acupuncturepoints { get; set; }
        public string Pulse { get; set; }
        public string Tongue { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }

        public virtual Patients Internal { get; set; }
        public virtual Users User { get; set; }
        public virtual ICollection<Acupunctureconditions> Acupunctureconditions { get; set; }
    }
}
