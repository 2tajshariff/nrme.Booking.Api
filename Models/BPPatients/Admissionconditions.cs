using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Admissionconditions
    {
        public int Recordid { get; set; }
        public int Admissionid { get; set; }
        public int Recordstatus { get; set; }
        public int Conditioncode { get; set; }
        public DateTime? Conditiondate { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }
    }
}
