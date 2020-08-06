using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Gp2gpfields
    {
        public int RecordId { get; set; }
        public int TransferId { get; set; }
        public string Guid { get; set; }
        public int ImportType { get; set; }
        public int ImportId { get; set; }

        public virtual Gp2gp Transfer { get; set; }
    }
}
