using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Currentrx
    {
        public int Recordid { get; set; }
        public int Internalid { get; set; }
        public int Recordstatus { get; set; }
        public int Productid { get; set; }
        public int Packid { get; set; }
        public string Drugname { get; set; }
        public int Rxstatus { get; set; }
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
        public DateTime? Firstdate { get; set; }
        public DateTime? Lastdate { get; set; }
        public int Lastquantity { get; set; }
        public int Lastrepeats { get; set; }
        public string Indication { get; set; }
        public int Indicationcode { get; set; }
        public int Authority { get; set; }
        public string Authoritynumber { get; set; }
        public string Approvalnumber { get; set; }
        public int Authoritycode { get; set; }
        public string Authorityindication { get; set; }
        public string Authoritydetail { get; set; }
        public int Previousauthority { get; set; }
        public int Sendtopatient { get; set; }
        public int Summary { get; set; }
        public int Compliancecheck { get; set; }
        public string Sahcno { get; set; }
        public string Scid { get; set; }
        public int Scidno { get; set; }
        public DateTime? Deletiondate { get; set; }
        public string Deletionreason { get; set; }
        public string Comment { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }
        public int Npdrconsent { get; set; }
        public string Barcode { get; set; }
        public int? VisitId { get; set; }
        public int VisitUpdated { get; set; }
        public byte? Patientconsent { get; set; }
        public int CertifiedCondition { get; set; }
        public int FrequentDispense { get; set; }
        public int SpecialistRecommendation { get; set; }
        public int Rppa { get; set; }
        public int InitialDispensePeriod { get; set; }
        public DateTime? AuthorityExpiry { get; set; }

        public virtual Patients Internal { get; set; }
        public virtual Visits Visit { get; set; }
    }
}
