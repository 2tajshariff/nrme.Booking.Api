using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Medicarebatch
    {
        public int Batchid { get; set; }
        public int Recordstatus { get; set; }
        public int Userid { get; set; }
        public int Hicol { get; set; }
        public int Processed { get; set; }
        public DateTime? Batchdate { get; set; }
        public string Batchnumber { get; set; }
        public int Hospital { get; set; }
        public int Services { get; set; }
        public int Vouchers { get; set; }
        public int Amount { get; set; }
        public int Paid { get; set; }
        public int Paymentid { get; set; }
        public string Providerno { get; set; }
        public string Payee { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }
        public int? Locationid { get; set; }
    }
}
