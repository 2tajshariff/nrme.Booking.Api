using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Hiaudit
    {
        public int Recordid { get; set; }
        public DateTime? Accessdate { get; set; }
        public int Accesstime { get; set; }
        public int Userid { get; set; }
        public int Internalid { get; set; }
        public string Hpii { get; set; }
        public string Hpio { get; set; }
        public string Identifier { get; set; }
        public string Operation { get; set; }
        public string Messageid { get; set; }
        public string Version { get; set; }
        public int Localid { get; set; }
        public int Entitytype { get; set; }
        public string SearchName { get; set; }

        public virtual Hientities EntitytypeNavigation { get; set; }
        public virtual Patients Internal { get; set; }
        public virtual Users User { get; set; }
    }
}
