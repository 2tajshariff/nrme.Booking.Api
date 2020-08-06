using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Setting
    {
        public int SettingType { get; set; }
        public int SettingKey { get; set; }
        public string SettingName { get; set; }
        public string SettingValue { get; set; }
        public int CreatedBy { get; set; }
        public DateTime Created { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? Updated { get; set; }
    }
}
