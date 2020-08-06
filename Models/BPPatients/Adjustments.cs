using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Adjustments
    {
        public int Recordid { get; set; }
        public int Invoiceid { get; set; }
        public int Serviceid { get; set; }
        public int Adjustment { get; set; }
        public int Writeoff { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
    }
}
