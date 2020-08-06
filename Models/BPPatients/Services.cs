using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Services
    {
        public int Serviceid { get; set; }
        public int Recordstatus { get; set; }
        public int Servicestatus { get; set; }
        public DateTime? Servicedate { get; set; }
        public int Invoiceid { get; set; }
        public int Visitid { get; set; }
        public int Itemcode { get; set; }
        public int Itemid { get; set; }
        public int Mbsitem { get; set; }
        public string Description { get; set; }
        public int Gst { get; set; }
        public int Fee { get; set; }
        public int Adjustment { get; set; }
        public int Totalfee { get; set; }
        public int Paid { get; set; }
        public int Gap { get; set; }
        public string Servicetext { get; set; }
        public int Selfdeemed { get; set; }
        public int Mpo { get; set; }
        public string Restrictionoverride { get; set; }
        public int Linkid { get; set; }
        public int Patients { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }
        public int Inhospital { get; set; }
        public int Nnac { get; set; }
        public int Servicetype { get; set; }
        public int Locationid { get; set; }
        public int Userid { get; set; }
        public int Payercode { get; set; }
        public int Payerid { get; set; }
        public int Detailid { get; set; }
        public int Originalservicefee { get; set; }
        public int Adjustmentlinkid { get; set; }
        public int Servicelinkid { get; set; }
        public int Nds { get; set; }
        public int? Previoususerid { get; set; }
        public int ClaimBenefitPaid { get; set; }
    }
}
