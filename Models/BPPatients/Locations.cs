using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Locations
    {
        public Locations()
        {
            Appointments = new HashSet<Appointments>();
            BhaLocationKeys = new HashSet<BhaLocationKeys>();
            BhaLocationTokens = new HashSet<BhaLocationTokens>();
            ContactNotes = new HashSet<ContactNotes>();
            Healthlinkform = new HashSet<Healthlinkform>();
            Healthlinksession = new HashSet<Healthlinksession>();
            Nirmessages = new HashSet<Nirmessages>();
            Pcehraccess = new HashSet<Pcehraccess>();
            Pcehrdocuments = new HashSet<Pcehrdocuments>();
            ProviderLocation = new HashSet<ProviderLocation>();
            Rooms = new HashSet<Rooms>();
            SmsscheduleLocation = new HashSet<SmsscheduleLocation>();
            UserReportLocations = new HashSet<UserReportLocations>();
            Users = new HashSet<Users>();
        }

        public int Locationid { get; set; }
        public int Recordstatus { get; set; }
        public int Locationcode { get; set; }
        public string Locationname { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string Postcode { get; set; }
        public string Hpio { get; set; }
        public int Rrma { get; set; }
        public string Phone { get; set; }
        public string Ahphone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Pkikey { get; set; }
        public string Lspnumber { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }
        public int Direxempt { get; set; }
        public int? AppStatus { get; set; }
        public int? OnboardUser { get; set; }
        public DateTime? AppLicenceExpiry { get; set; }
        public string Abn { get; set; }

        public virtual Users OnboardUserNavigation { get; set; }
        public virtual ICollection<Appointments> Appointments { get; set; }
        public virtual ICollection<BhaLocationKeys> BhaLocationKeys { get; set; }
        public virtual ICollection<BhaLocationTokens> BhaLocationTokens { get; set; }
        public virtual ICollection<ContactNotes> ContactNotes { get; set; }
        public virtual ICollection<Healthlinkform> Healthlinkform { get; set; }
        public virtual ICollection<Healthlinksession> Healthlinksession { get; set; }
        public virtual ICollection<Nirmessages> Nirmessages { get; set; }
        public virtual ICollection<Pcehraccess> Pcehraccess { get; set; }
        public virtual ICollection<Pcehrdocuments> Pcehrdocuments { get; set; }
        public virtual ICollection<ProviderLocation> ProviderLocation { get; set; }
        public virtual ICollection<Rooms> Rooms { get; set; }
        public virtual ICollection<SmsscheduleLocation> SmsscheduleLocation { get; set; }
        public virtual ICollection<UserReportLocations> UserReportLocations { get; set; }
        public virtual ICollection<Users> Users { get; set; }
    }
}
