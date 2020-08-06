using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Ethnicity
    {
        public Ethnicity()
        {
            Patientethnicity = new HashSet<Patientethnicity>();
        }

        public int Ethniccode { get; set; }
        public string Ethnictype { get; set; }
        public string Nzname { get; set; }
        public int Ascceg { get; set; }
        public int Level0 { get; set; }
        public int Level1 { get; set; }
        public int Level2 { get; set; }
        public int Level3 { get; set; }
        public int Level4 { get; set; }

        public virtual ICollection<Patientethnicity> Patientethnicity { get; set; }
    }
}
