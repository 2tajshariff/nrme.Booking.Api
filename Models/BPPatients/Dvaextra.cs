using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Dvaextra
    {
        public int Recordid { get; set; }
        public int Recordstatus { get; set; }
        public int Invoiceid { get; set; }
        public int Rei { get; set; }
        public string Authorisedby { get; set; }
        public string Authorisetext { get; set; }
        public int Afterhours { get; set; }
        public string Starttime { get; set; }
        public string Endtime { get; set; }
        public string Reasoncode { get; set; }
        public string Conditiontext { get; set; }
        public string Acproviderno { get; set; }
        public int Acpercentage { get; set; }
        public string Aftercaretext { get; set; }
        public string Duplicateservicetext { get; set; }
        public string Multipleproceduretext { get; set; }
        public int Duration { get; set; }
        public int Seconddevice { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }
    }
}
