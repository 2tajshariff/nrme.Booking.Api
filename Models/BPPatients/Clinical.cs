using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Clinical
    {
        public int Internalid { get; set; }
        public int Knownallergies { get; set; }
        public int Pasthistory { get; set; }
        public int Familyhistory { get; set; }
        public int Smokingstatus { get; set; }
        public int Alcoholstatus { get; set; }
        public string Bloodgroup { get; set; }
        public int Rh { get; set; }
        public int Retired { get; set; }
        public int Maritalstatus { get; set; }
        public int Sexuality { get; set; }
        public int Elitesports { get; set; }
        public int Pacemaker { get; set; }
        public string Socialhx { get; set; }
        public string Recreation { get; set; }
        public int? Accomodation { get; set; }
        public int? Liveswith { get; set; }
        public int? Hascarer { get; set; }
        public int? Iscarer { get; set; }
        public int Webster { get; set; }
        public string Causeofdeath { get; set; }
        public int Causeofdeathcode { get; set; }
        public string Othercomment { get; set; }
        public byte[] Drnote { get; set; }
        public int Hidedrnote { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }
        public int Pcehr { get; set; }
        public DateTime? Shs { get; set; }
        public int Safeinhome { get; set; }
        public int? Acd { get; set; }
        public int? Powerofattorney { get; set; }
        public int Nir { get; set; }

        public virtual Patients Internal { get; set; }
    }
}
