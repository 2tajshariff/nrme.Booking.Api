using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class AntenatalResults
    {
        public int Resultid { get; set; }
        public int Internalid { get; set; }
        public int Recordstatus { get; set; }
        public int Pregnancyid { get; set; }
        public DateTime? Resultdate1 { get; set; }
        public string Hb1 { get; set; }
        public string Antibody1 { get; set; }
        public int Rubella { get; set; }
        public int Syphilis { get; set; }
        public int Cmv { get; set; }
        public int Hepatitisb { get; set; }
        public int Hepatitisc { get; set; }
        public int Hiv { get; set; }
        public string Urine { get; set; }
        public DateTime? Resultdate2 { get; set; }
        public string Hb2 { get; set; }
        public string Antibody2 { get; set; }
        public string Det { get; set; }
        public string Gtt { get; set; }
        public DateTime? Resultdate3 { get; set; }
        public string Hb3 { get; set; }
        public string Antibody3 { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }

        public virtual Patients Internal { get; set; }
    }
}
