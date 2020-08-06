using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Practice
    {
        public int Practiceid { get; set; }
        public int Recordstatus { get; set; }
        public string Practicename { get; set; }
        public string Hpio { get; set; }
        public string Abn { get; set; }
        public string Vspnumber { get; set; }
        public string Pipnumber { get; set; }
        public string Serialnumber { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }
        public string Pcehrcertificate { get; set; }
        public int Tyro { get; set; }
        public int Easyclaim { get; set; }
        public int Pcehr { get; set; }
        public int Argus { get; set; }
        public int Healthshare { get; set; }
        public int Country { get; set; }
        public int Pho { get; set; }
        public string Accvendorhpi { get; set; }
        public string Irdnumber { get; set; }
        public string Gstnumber { get; set; }
        public string BestHealthApiVersion { get; set; }
    }
}
