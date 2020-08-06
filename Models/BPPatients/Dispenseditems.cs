using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Dispenseditems
    {
        public int Itemid { get; set; }
        public int Internalid { get; set; }
        public string Scid { get; set; }
        public int Sequence { get; set; }
        public string Tradename { get; set; }
        public int Productid { get; set; }
        public int Packid { get; set; }
        public int Pharmacyid { get; set; }
        public DateTime? Dispensedate { get; set; }
        public int? Supplynumber { get; set; }
        public int? Dispensedquantity { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }
        public byte? Patientconsent { get; set; }
        public byte? Medicationmodified { get; set; }
        public byte? Instructionsmodified { get; set; }
        public byte? Forcenotification { get; set; }
        public string Pharmacynotes { get; set; }
        public string Confidentialityflag { get; set; }
    }
}
