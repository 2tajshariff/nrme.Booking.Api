using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Accident
    {
        public Accident()
        {
            Accidentdiagnosis = new HashSet<Accidentdiagnosis>();
            Accidentlink = new HashSet<Accidentlink>();
        }

        public int Recordid { get; set; }
        public int Recordstatus { get; set; }
        public int Internalid { get; set; }
        public string Claimnum { get; set; }
        public string Masterclaim { get; set; }
        public int Userid { get; set; }
        public int Insurer { get; set; }
        public string Claimnotes { get; set; }
        public string Formsession { get; set; }
        public DateTime? Accidentdate { get; set; }
        public DateTime? Consultdate { get; set; }
        public bool? Accidentinnz { get; set; }
        public int? Locationcode { get; set; }
        public int? Scenecode { get; set; }
        public string Causeofinjury { get; set; }
        public bool? Workrelated { get; set; }
        public bool? Motorvehicleroad { get; set; }
        public int? Occupationcode { get; set; }
        public int? Employmentstatus { get; set; }
        public int? Worktype { get; set; }
        public int? Sportcode { get; set; }
        public int? Activitycode { get; set; }
        public bool? Employmentgradual { get; set; }
        public bool? Treatmentinjury { get; set; }
        public string Injurynotes { get; set; }
        public DateTime? Dischargedate { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }

        public virtual Patients Internal { get; set; }
        public virtual Users User { get; set; }
        public virtual ICollection<Accidentdiagnosis> Accidentdiagnosis { get; set; }
        public virtual ICollection<Accidentlink> Accidentlink { get; set; }
    }
}
