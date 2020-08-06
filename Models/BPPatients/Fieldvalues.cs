﻿using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Fieldvalues
    {
        public int Recordid { get; set; }
        public int Internalid { get; set; }
        public int Userid { get; set; }
        public string Fieldname { get; set; }
        public DateTime Recdate { get; set; }
        public string Fieldvalue { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }
        public int? Previoususerid { get; set; }
        public int? Linkid { get; set; }
        public string Source { get; set; }

        public virtual Users User { get; set; }
    }
}
