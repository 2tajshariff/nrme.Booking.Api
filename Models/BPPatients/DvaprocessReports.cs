using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class DvaprocessReports
    {
        public int Recordid { get; set; }
        public int Recordstatus { get; set; }
        public int Batchid { get; set; }
        public int Bpserviceid { get; set; }
        public string Claimid { get; set; }
        public string Servicingprovidernum { get; set; }
        public int Claimbenefitpaid { get; set; }
        public int Userid { get; set; }
        public int Internalid { get; set; }
        public string Patientfamilyname { get; set; }
        public string Patientfirstname { get; set; }
        public string Veteranfilenum { get; set; }
        public string Accountreferencenum { get; set; }
        public DateTime? Dateofservice { get; set; }
        public int Chargeamount { get; set; }
        public int Itemnum { get; set; }
        public string Serviceid { get; set; }
        public string Cardflag { get; set; }
        public int Noofpatientsseen { get; set; }
        public int Servicebenefitamount { get; set; }
        public int Explanationcode { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }
        public string Voucherid { get; set; }
        public int? Claimchargeamount { get; set; }
    }
}
