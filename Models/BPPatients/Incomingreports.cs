using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Incomingreports
    {
        public Incomingreports()
        {
            Incomingvalues = new HashSet<Incomingvalues>();
        }

        public int Reportid { get; set; }
        public int Internalid { get; set; }
        public int Recordstatus { get; set; }
        public int Userid { get; set; }
        public string Providername { get; set; }
        public int Providerid { get; set; }
        public string Providerreference { get; set; }
        public string Requestid { get; set; }
        public string Addressedto { get; set; }
        public string Providerno { get; set; }
        public string Hpii { get; set; }
        public string Hpio { get; set; }
        public string Requestby { get; set; }
        public DateTime? Requestdate { get; set; }
        public DateTime? Collectiondate { get; set; }
        public DateTime? Importdate { get; set; }
        public string Testname { get; set; }
        public DateTime? Reportdate { get; set; }
        public int Reporttime { get; set; }
        public string Requestedtests { get; set; }
        public string Reportheader { get; set; }
        public string Reportbody { get; set; }
        public int Checkstatus { get; set; }
        public DateTime? Checkdate { get; set; }
        public int Checkedby { get; set; }
        public int Notation { get; set; }
        public int Action { get; set; }
        public string Comment { get; set; }
        public int Reminder { get; set; }
        public DateTime? Actiondate { get; set; }
        public int Confidentialflag { get; set; }
        public int Normalflag { get; set; }
        public int Completionflag { get; set; }
        public int Storein { get; set; }
        public string Firstname { get; set; }
        public string Surname { get; set; }
        public DateTime? Dob { get; set; }
        public string Sex { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Postcode { get; set; }
        public string Homephone { get; set; }
        public string Workphone { get; set; }
        public string Mobilephone { get; set; }
        public string Email { get; set; }
        public string Medicareno { get; set; }
        public string Medicarelineno { get; set; }
        public string Ihi { get; set; }
        public int Dvacode { get; set; }
        public string Dvano { get; set; }
        public string Recordno { get; set; }
        public string Servicecode { get; set; }
        public string Testcode { get; set; }
        public int Testno { get; set; }
        public string Userreference { get; set; }
        public DateTime? Correspondencedate { get; set; }
        public string Contactname { get; set; }
        public int Contactid { get; set; }
        public string Subject { get; set; }
        public string Category { get; set; }
        public string Detail { get; set; }
        public int Confidential { get; set; }
        public int? Importtype { get; set; }
        public int? Reportsource { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }
        public int? Progressstatus { get; set; }
        public int? Locationid { get; set; }
        public int? Previoususerid { get; set; }
        public int? NirrecordId { get; set; }
        public int Contacted { get; set; }

        public virtual ICollection<Incomingvalues> Incomingvalues { get; set; }
    }
}
