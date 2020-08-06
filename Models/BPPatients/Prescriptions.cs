using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Prescriptions
    {
        public Prescriptions()
        {
            Scriptitems = new HashSet<Scriptitems>();
        }

        public int Scriptid { get; set; }
        public int Internalid { get; set; }
        public int Userid { get; set; }
        public int Locationid { get; set; }
        public int Recordstatus { get; set; }
        public DateTime Scriptdate { get; set; }
        public int Restrictioncode { get; set; }
        public int Allowsubstitution { get; set; }
        public int Authority { get; set; }
        public string Authoritynumber { get; set; }
        public string Approvalnumber { get; set; }
        public int Previousauthority { get; set; }
        public int Sendtopatient { get; set; }
        public int Printstatus { get; set; }
        public DateTime? Printdate { get; set; }
        public string Ctg { get; set; }
        public string Scid { get; set; }
        public DateTime? Deletiondate { get; set; }
        public string Deletionreason { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }
        public int? VisitId { get; set; }
        public string EStatus { get; set; }

        public virtual Patients Internal { get; set; }
        public virtual Users User { get; set; }
        public virtual Visits Visit { get; set; }
        public virtual ICollection<Scriptitems> Scriptitems { get; set; }
    }
}
