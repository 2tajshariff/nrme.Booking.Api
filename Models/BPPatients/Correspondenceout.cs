using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Correspondenceout
    {
        public Correspondenceout()
        {
            Medrefercorrespondence = new HashSet<Medrefercorrespondence>();
        }

        public int Recordid { get; set; }
        public int Recordstatus { get; set; }
        public int Stored { get; set; }
        public int Internalid { get; set; }
        public int Userid { get; set; }
        public string Sendername { get; set; }
        public DateTime? Correspondencedate { get; set; }
        public int Statuscode { get; set; }
        public int Contactid { get; set; }
        public string Contactname { get; set; }
        public string Subject { get; set; }
        public string Comment { get; set; }
        public string Pagesettings { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }
        public DateTime? Checkdate { get; set; }
        public int Checkedby { get; set; }
        public int Action { get; set; }
        public int Actioned { get; set; }
        public DateTime? Actiondate { get; set; }
        public string Category { get; set; }
        public int Confidentialflag { get; set; }
        public string Userreference { get; set; }
        public int Notation { get; set; }
        public int? Locationid { get; set; }
        public int Origin { get; set; }

        public virtual Patients Internal { get; set; }
        public virtual Users User { get; set; }
        public virtual ICollection<Medrefercorrespondence> Medrefercorrespondence { get; set; }
    }
}
