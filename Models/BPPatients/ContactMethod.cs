using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class ContactMethod
    {
        public ContactMethod()
        {
            ContactNotes = new HashSet<ContactNotes>();
            Messagestatus = new HashSet<Messagestatus>();
        }

        public int MethodCode { get; set; }
        public int RecordStatus { get; set; }
        public string Method { get; set; }
        public int Au { get; set; }
        public int Nz { get; set; }
        public DateTime Created { get; set; }

        public virtual ICollection<ContactNotes> ContactNotes { get; set; }
        public virtual ICollection<Messagestatus> Messagestatus { get; set; }
    }
}
