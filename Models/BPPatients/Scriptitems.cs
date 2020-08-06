using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Scriptitems
    {
        public int Recordid { get; set; }
        public int Internalid { get; set; }
        public int Userid { get; set; }
        public int Scriptid { get; set; }
        public int Recordstatus { get; set; }
        public int Productid { get; set; }
        public int Packid { get; set; }
        public string Productname { get; set; }
        public string Productdescription { get; set; }
        public string Companyform { get; set; }
        public int Formcode { get; set; }
        public string Strength { get; set; }
        public string Dose { get; set; }
        public int Frequency { get; set; }
        public int Food { get; set; }
        public int Otherdetail { get; set; }
        public int Prn { get; set; }
        public int Route { get; set; }
        public string Instructions { get; set; }
        public int Quantity { get; set; }
        public string Productunit { get; set; }
        public int Repeats { get; set; }
        public int Repeatinterval { get; set; }
        public int Regulation24 { get; set; }
        public string Sahcno { get; set; }
        public string Scid { get; set; }
        public int Scidno { get; set; }
        public string Authorityindication { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }
        public int Npdrconsent { get; set; }
        public string HieStatus { get; set; }
        public byte? Patientconsent { get; set; }
        public int CertifiedCondition { get; set; }
        public int FrequentDispense { get; set; }
        public int SpecialistRecommendation { get; set; }
        public int Rppa { get; set; }
        public int InitialDispensePeriod { get; set; }

        public virtual Patients Internal { get; set; }
        public virtual Prescriptions Script { get; set; }
        public virtual Users User { get; set; }
    }
}
