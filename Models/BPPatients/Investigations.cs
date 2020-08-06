using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Investigations
    {
        public Investigations()
        {
            Investigationpages = new HashSet<Investigationpages>();
            Reportvalues = new HashSet<Reportvalues>();
        }

        public int Reportid { get; set; }
        public int Recordstatus { get; set; }
        public int Internalid { get; set; }
        public int Userid { get; set; }
        public DateTime? Importdate { get; set; }
        public int Requestid { get; set; }
        public DateTime? Requestdate { get; set; }
        public string Providerreference { get; set; }
        public string Providername { get; set; }
        public int Providerid { get; set; }
        public DateTime? Collectiondate { get; set; }
        public string Testname { get; set; }
        public DateTime? Reportdate { get; set; }
        public int Reporttime { get; set; }
        public byte[] Reportheader { get; set; }
        public byte[] Reportbody { get; set; }
        public int Normalflag { get; set; }
        public int Completionflag { get; set; }
        public int Confidentialflag { get; set; }
        public DateTime? Checkdate { get; set; }
        public int Checkedby { get; set; }
        public int Notation { get; set; }
        public int Action { get; set; }
        public string Comment { get; set; }
        public int Actioned { get; set; }
        public DateTime? Actiondate { get; set; }
        public int Stored { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }
        public int? Locationid { get; set; }
        public int Origin { get; set; }

        public virtual Patients Internal { get; set; }
        public virtual ICollection<Investigationpages> Investigationpages { get; set; }
        public virtual ICollection<Reportvalues> Reportvalues { get; set; }
    }
}
