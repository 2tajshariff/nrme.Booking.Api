using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class ProductCombination
    {
        public int Recordid { get; set; }
        public int Combinationid { get; set; }
        public int Productid { get; set; }
        public int Packid { get; set; }
        public int Rxstatus { get; set; }
        public string Drugname { get; set; }
        public string Dose { get; set; }
        public int Frequency { get; set; }
        public int Food { get; set; }
        public int Otherdetail { get; set; }
        public int Route { get; set; }
        public int Prn { get; set; }
        public string Instructions { get; set; }
        public int Quantity { get; set; }
        public string Productunit { get; set; }
        public int Repeats { get; set; }
        public int Usepbsquantity { get; set; }
        public string Dosesperday { get; set; }
        public int Repeatinterval { get; set; }
        public int Regulation24 { get; set; }
        public int Restrictioncode { get; set; }
        public int Tgpexempt { get; set; }
        public int Allowsubstitution { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }

        public virtual Drugcombinations Combination { get; set; }
    }
}
