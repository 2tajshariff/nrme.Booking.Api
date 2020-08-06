using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Categories
    {
        public Categories()
        {
            Contacts = new HashSet<Contacts>();
            FhircategoryMapping = new HashSet<FhircategoryMapping>();
        }

        public int Categorycode { get; set; }
        public int Recordstatus { get; set; }
        public int Categorytype { get; set; }
        public string Categoryname { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }

        public virtual ICollection<Contacts> Contacts { get; set; }
        public virtual ICollection<FhircategoryMapping> FhircategoryMapping { get; set; }
    }
}
