using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Hierrors
    {
        public int Recordid { get; set; }
        public DateTime? Errordate { get; set; }
        public int Errortime { get; set; }
        public int Userid { get; set; }
        public int Internalid { get; set; }
        public string Messageid { get; set; }
        public string Errortext { get; set; }
        public string Errorcode { get; set; }
        public int Localid { get; set; }
        public int Entitytype { get; set; }
        public string SearchName { get; set; }

        public virtual Hientities EntitytypeNavigation { get; set; }
        public virtual Patients Internal { get; set; }
        public virtual Users User { get; set; }
    }
}
