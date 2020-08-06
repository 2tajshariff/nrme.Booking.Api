using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Resultbatch
    {
        public int Recordid { get; set; }
        public int Batchid { get; set; }
        public DateTime Processdate { get; set; }
        public string Labname { get; set; }
        public int Batchtype { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }
    }
}
