﻿using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Inrvalues
    {
        public int Recordid { get; set; }
        public int Recordstatus { get; set; }
        public int Internalid { get; set; }
        public int Userid { get; set; }
        public DateTime? Recorddate { get; set; }
        public DateTime? Inrdate { get; set; }
        public string Inrvalue { get; set; }
        public string Inrdose { get; set; }
        public DateTime? Nextreview { get; set; }
        public string Comment { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }

        public virtual Patients Internal { get; set; }
        public virtual Users User { get; set; }
    }
}
