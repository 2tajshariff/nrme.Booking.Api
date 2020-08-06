using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Immunisations
    {
        public Immunisations()
        {
            Nirmessages = new HashSet<Nirmessages>();
        }

        public int Recordid { get; set; }
        public int Recordstatus { get; set; }
        public int Internalid { get; set; }
        public int Notgivenhere { get; set; }
        public int Userid { get; set; }
        public int Administeredby { get; set; }
        public DateTime? Givendate { get; set; }
        public string Vaccinename { get; set; }
        public int Vaccineid { get; set; }
        public string Batchnumber { get; set; }
        public int Sequence { get; set; }
        public int Consentcode { get; set; }
        public int Sitecode { get; set; }
        public int Route { get; set; }
        public string Comment { get; set; }
        public int Vivas { get; set; }
        public DateTime? Vivasprinted { get; set; }
        public int Acir { get; set; }
        public DateTime? Acirtransmitted { get; set; }
        public string Influenza { get; set; }
        public int Influenzasent { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }
        public int? Orderedbylocationid { get; set; }
        public int? Administeredbylocationid { get; set; }
        public int? VisitId { get; set; }
        public int VisitUpdated { get; set; }
        public DateTime? Expirydate { get; set; }
        public int? Aefi { get; set; }
        public int? Aefitype { get; set; }
        public int Status { get; set; }
        public DateTime? DateDue { get; set; }
        public int? RefusalId { get; set; }
        public int? IxType { get; set; }
        public int? IxCode { get; set; }

        public virtual Patients Internal { get; set; }
        public virtual Users User { get; set; }
        public virtual Visits Visit { get; set; }
        public virtual ICollection<Nirmessages> Nirmessages { get; set; }
    }
}
