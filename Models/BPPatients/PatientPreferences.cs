using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class PatientPreferences
    {
        public int RecordId { get; set; }
        public int RecordStatus { get; set; }
        public int Internalid { get; set; }
        public int PatientPrefrenceCode { get; set; }
        public string FactValue { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime Updated { get; set; }
        public int Updatedby { get; set; }
    }
}
