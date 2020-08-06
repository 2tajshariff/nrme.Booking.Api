using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Admissions
    {
        public int Recordid { get; set; }
        public int Internalid { get; set; }
        public int Userid { get; set; }
        public int Usualgp { get; set; }
        public int Recordstatus { get; set; }
        public DateTime? Admissiondate { get; set; }
        public string Ward { get; set; }
        public string Bed { get; set; }
        public string Treatedby { get; set; }
        public string Condition { get; set; }
        public string Conditioncode { get; set; }
        public DateTime? Dischargedate { get; set; }
        public int Dischargecode { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }

        public virtual Patients Internal { get; set; }
    }
}
