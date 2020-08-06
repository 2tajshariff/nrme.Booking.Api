using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Operations
    {
        public int Recordid { get; set; }
        public int Recordstatus { get; set; }
        public int Operationstatus { get; set; }
        public int Internalid { get; set; }
        public int Userid { get; set; }
        public int Appointmentid { get; set; }
        public DateTime Operationdate { get; set; }
        public int Operationtime { get; set; }
        public int Operationcategory { get; set; }
        public string Operationname { get; set; }
        public string Operationdetail { get; set; }
        public int? Operationcode { get; set; }
        public string Mbsitem { get; set; }
        public int Operationside { get; set; }
        public int Anaestheticcode { get; set; }
        public string Operationlength { get; set; }
        public int Anaesthetistid { get; set; }
        public int Assistantid { get; set; }
        public int Facilityid { get; set; }
        public int Stay { get; set; }
        public int Preopid { get; set; }
        public string Indication { get; set; }
        public string Description { get; set; }
        public string Findings { get; set; }
        public string Outcome { get; set; }
        public int Outcomecode { get; set; }
        public string Comment { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }

        public virtual Patients Internal { get; set; }
        public virtual Users User { get; set; }
    }
}
