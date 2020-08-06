using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Adrac
    {
        public int Recordid { get; set; }
        public int Internalid { get; set; }
        public int Userid { get; set; }
        public int Recordstatus { get; set; }
        public DateTime? Recdate { get; set; }
        public string Weight { get; set; }
        public string Drugname { get; set; }
        public int Productid { get; set; }
        public string Form { get; set; }
        public string Frequency { get; set; }
        public string Route { get; set; }
        public string Batch { get; set; }
        public string Dose { get; set; }
        public DateTime? Startdate { get; set; }
        public DateTime? Stopdate { get; set; }
        public string Indication { get; set; }
        public DateTime? Onsetdate { get; set; }
        public string Reaction { get; set; }
        public string Reacfreq { get; set; }
        public string Description { get; set; }
        public string Severity { get; set; }
        public string Treatedat { get; set; }
        public string Treatment { get; set; }
        public string Outcome { get; set; }
        public DateTime? Outdate { get; set; }
        public string Comments { get; set; }
        public string Sequelae { get; set; }
        public string Includerx { get; set; }
        public string Includepmh { get; set; }
        public string Messageid { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }

        public virtual Patients Internal { get; set; }
        public virtual Users User { get; set; }
    }
}
