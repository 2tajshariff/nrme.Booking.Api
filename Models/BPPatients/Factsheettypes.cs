using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Factsheettypes
    {
        public Factsheettypes()
        {
            Factsheets = new HashSet<Factsheets>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public string Parent { get; set; }

        public virtual ICollection<Factsheets> Factsheets { get; set; }
    }
}
