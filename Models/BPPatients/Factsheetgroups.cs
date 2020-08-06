using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Factsheetgroups
    {
        public Factsheetgroups()
        {
            Factsheets = new HashSet<Factsheets>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Factsheets> Factsheets { get; set; }
    }
}
