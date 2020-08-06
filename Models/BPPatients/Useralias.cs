using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Useralias
    {
        public int Recordid { get; set; }
        public int Userid { get; set; }
        public string Aliasname { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }
        public int? Locationid { get; set; }

        public virtual Users User { get; set; }
    }
}
