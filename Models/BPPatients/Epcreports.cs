using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Epcreports
    {
        public Epcreports()
        {
            Careplandetail = new HashSet<Careplandetail>();
            Careplangoals = new HashSet<Careplangoals>();
            Careplanproblems = new HashSet<Careplanproblems>();
            Careplantasks = new HashSet<Careplantasks>();
            Epctext = new HashSet<Epctext>();
            Epcvalues = new HashSet<Epcvalues>();
            Medreviewdetails = new HashSet<Medreviewdetails>();
        }

        public int Reportid { get; set; }
        public int Recordstatus { get; set; }
        public int Internalid { get; set; }
        public int Userid { get; set; }
        public int Stored { get; set; }
        public DateTime Reportdate { get; set; }
        public int Reporttype { get; set; }
        public int Reportsubtype { get; set; }
        public int Reportstatus { get; set; }
        public string Pagesettings { get; set; }
        public int Duration { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }

        public virtual Patients Internal { get; set; }
        public virtual Users User { get; set; }
        public virtual ICollection<Careplandetail> Careplandetail { get; set; }
        public virtual ICollection<Careplangoals> Careplangoals { get; set; }
        public virtual ICollection<Careplanproblems> Careplanproblems { get; set; }
        public virtual ICollection<Careplantasks> Careplantasks { get; set; }
        public virtual ICollection<Epctext> Epctext { get; set; }
        public virtual ICollection<Epcvalues> Epcvalues { get; set; }
        public virtual ICollection<Medreviewdetails> Medreviewdetails { get; set; }
    }
}
