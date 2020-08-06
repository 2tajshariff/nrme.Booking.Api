using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Acirbatches
    {
        public int Batchid { get; set; }
        public int Recordstatus { get; set; }
        public string Batchnumber { get; set; }
        public string Providerno { get; set; }
        public DateTime? Batchdate { get; set; }
        public int Userid { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }
    }
}
