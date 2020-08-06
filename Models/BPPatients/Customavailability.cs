using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Customavailability
    {
        public int Packid { get; set; }
        public int Productid { get; set; }
        public int Restriction { get; set; }
        public int Quantity { get; set; }
        public string Productunit { get; set; }
        public int Doseperunit { get; set; }
        public int Repeats { get; set; }
        public string PbsdrugCode { get; set; }
        public int Mbmcode { get; set; }
        public int FormCode { get; set; }
        public int PackCode { get; set; }
        public int DefaultQuantity { get; set; }
        public int DefaultRepeats { get; set; }
        public int InitialText { get; set; }
        public int WrittenApproval { get; set; }
        public int NoteCode { get; set; }
        public int Rpbsonly { get; set; }
        public int Streamlined { get; set; }
        public int Caution { get; set; }
        public string PbscompanyCode { get; set; }
        public int BrandPremium { get; set; }
        public int GroupPremium { get; set; }
        public int Dpmq { get; set; }
        public int Mrvsn { get; set; }
        public string Amttppcode { get; set; }
        public string Amtmppcode { get; set; }
        public int Erxqty { get; set; }
        public int Section100 { get; set; }
    }
}
