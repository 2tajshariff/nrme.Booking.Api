using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Alcohol
    {
        public int Recordid { get; set; }
        public int Recordstatus { get; set; }
        public int Internalid { get; set; }
        public int Daysperweek { get; set; }
        public int Drinksperday { get; set; }
        public int Alcoholcode { get; set; }
        public string Alcoholtext { get; set; }
        public int Pastdaysperweek { get; set; }
        public int Pastdrinksperday { get; set; }
        public int Pastalcohollevel { get; set; }
        public int Yearstarted { get; set; }
        public int Yearstopped { get; set; }
        public string Comment { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }

        public virtual Patients Internal { get; set; }
    }
}
