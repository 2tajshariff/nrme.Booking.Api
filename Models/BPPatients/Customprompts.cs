using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Customprompts
    {
        public int Recordid { get; set; }
        public int Promptcode { get; set; }
        public int Userid { get; set; }
        public string Descript { get; set; }
        public int Interval { get; set; }
        public string Sex { get; set; }
        public int Agetop { get; set; }
        public int Agebot { get; set; }
        public int Aboriginal { get; set; }
        public int Tsi { get; set; }
        public string Disease { get; set; }
        public string Drug { get; set; }
        public string Drugclass { get; set; }
        public string Checkfor { get; set; }
        public string Value { get; set; }
        public string Checkin { get; set; }
        public int Period { get; set; }
        public string Item { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }

        public virtual Users User { get; set; }
    }
}
