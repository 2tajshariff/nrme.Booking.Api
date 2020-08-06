using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Obsgyndetail
    {
        public int Recordid { get; set; }
        public int Recordstatus { get; set; }
        public int Internalid { get; set; }
        public DateTime? Lastpapdate { get; set; }
        public int Lastpapresult { get; set; }
        public int Nopap { get; set; }
        public int Breastfeeding { get; set; }
        public int Gravidityknown { get; set; }
        public int? Gravidity { get; set; }
        public int? Parity { get; set; }
        public int? Miscarriages { get; set; }
        public int? Terminations { get; set; }
        public DateTime? Actuallmp { get; set; }
        public DateTime? Nominallmp { get; set; }
        public int Cyclelength { get; set; }
        public DateTime? Edcbydate { get; set; }
        public DateTime? Edcbyscan { get; set; }
        public int Pregnancyid { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }
        public int Optout { get; set; }
        public string Optoutreason { get; set; }
        public int MammogramStatus { get; set; }
        public DateTime? LastMammogramDate { get; set; }
        public int MammogramResult { get; set; }

        public virtual Patients Internal { get; set; }
    }
}
