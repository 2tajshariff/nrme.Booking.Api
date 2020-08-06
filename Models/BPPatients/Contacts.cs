using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Contacts
    {
        public Contacts()
        {
            Contactdetails = new HashSet<Contactdetails>();
            Referrals = new HashSet<Referrals>();
        }

        public int Contactid { get; set; }
        public int Recordstatus { get; set; }
        public int Contactcode { get; set; }
        public int Titlecode { get; set; }
        public string Firstname { get; set; }
        public string Surname { get; set; }
        public string Greeting { get; set; }
        public int Categorycode { get; set; }
        public string Ahphone { get; set; }
        public string Mobilephone { get; set; }
        public string Pager { get; set; }
        public string Hpi { get; set; }
        public string Providerno { get; set; }
        public string Abn { get; set; }
        public int Labid { get; set; }
        public int Natacode { get; set; }
        public int Assistant { get; set; }
        public int Operations { get; set; }
        public string Pkikey { get; set; }
        public string Comment { get; set; }
        public string Skype { get; set; }
        public string Email { get; set; }
        public string Url { get; set; }
        public int Messagingproviderid { get; set; }
        public string Accountid { get; set; }
        public int Otherrequests { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }
        public DateTime? Hpivalidated { get; set; }
        public string Hsdkey { get; set; }
        public int? EformsServiceCode { get; set; }
        public string EformDefaultUrl { get; set; }
        public int Eorder { get; set; }
        public string FhirdirectoryId { get; set; }
        public DateTime? FhirlastUpdated { get; set; }

        public virtual Categories CategorycodeNavigation { get; set; }
        public virtual Titles TitlecodeNavigation { get; set; }
        public virtual ICollection<Contactdetails> Contactdetails { get; set; }
        public virtual ICollection<Referrals> Referrals { get; set; }
    }
}
