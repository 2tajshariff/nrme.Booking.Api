using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Antenatalvisits
    {
        public int Recordid { get; set; }
        public int Recordstatus { get; set; }
        public int Internalid { get; set; }
        public int Userid { get; set; }
        public int? Visitid { get; set; }
        public int Pregnancyid { get; set; }
        public DateTime Visitdate { get; set; }
        public string Weight { get; set; }
        public int Systolic { get; set; }
        public int Diastolic { get; set; }
        public int Sizebydates { get; set; }
        public int Clinicalsize { get; set; }
        public int Fundusheight { get; set; }
        public int Foetalheart { get; set; }
        public int Foetalheartrate { get; set; }
        public int Movements { get; set; }
        public int Ankleoedema { get; set; }
        public string Urine { get; set; }
        public int Protein { get; set; }
        public int Glucose { get; set; }
        public int Crl { get; set; }
        public int Presentation { get; set; }
        public int Position { get; set; }
        public int Engaged { get; set; }
        public string Comment { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }

        public virtual Patients Internal { get; set; }
        public virtual Pregnancies Pregnancy { get; set; }
        public virtual Users User { get; set; }
        public virtual Visits Visit { get; set; }
    }
}
