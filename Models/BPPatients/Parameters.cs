﻿using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Parameters
    {
        public int Recordid { get; set; }
        public int Recordstatus { get; set; }
        public int Internalid { get; set; }
        public int Userid { get; set; }
        public DateTime Datadate { get; set; }
        public int Datatime { get; set; }
        public string Dataname { get; set; }
        public string Datavalue { get; set; }
        public int Datacode { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }

        public virtual Patients Internal { get; set; }
        public virtual Users User { get; set; }
    }
}
