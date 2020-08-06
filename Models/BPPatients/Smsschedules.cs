using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Smsschedules
    {
        public Smsschedules()
        {
            SmsscheduleAppttype = new HashSet<SmsscheduleAppttype>();
            SmsscheduleLocation = new HashSet<SmsscheduleLocation>();
            SmsscheduleUser = new HashSet<SmsscheduleUser>();
        }

        public int Scheduleid { get; set; }
        public string Schedulename { get; set; }
        public string Datespan { get; set; }
        public int? Daysahead { get; set; }
        public int Searchbytime { get; set; }
        public int? Searchtimestart { get; set; }
        public int? Searchtimeend { get; set; }
        public int Excludealreadysent { get; set; }
        public int Excluderecent { get; set; }
        public int? Excluderecentdays { get; set; }
        public string Schedule { get; set; }
        public string Scheduleday { get; set; }
        public string Schedulemonth { get; set; }
        public int Sendtime { get; set; }
        public int Templateid { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public int Sendsms { get; set; }
        public int Sendapp { get; set; }

        public virtual ICollection<SmsscheduleAppttype> SmsscheduleAppttype { get; set; }
        public virtual ICollection<SmsscheduleLocation> SmsscheduleLocation { get; set; }
        public virtual ICollection<SmsscheduleUser> SmsscheduleUser { get; set; }
    }
}
