using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Invoices
    {
        public Invoices()
        {
            Deletedinvoicelocks = new HashSet<Deletedinvoicelocks>();
            Invoicelock = new HashSet<Invoicelock>();
        }

        public int Invoiceid { get; set; }
        public int Recordstatus { get; set; }
        public int Complex { get; set; }
        public int Userid { get; set; }
        public int Locationid { get; set; }
        public int Internalid { get; set; }
        public DateTime? Invoicedate { get; set; }
        public string Visittime { get; set; }
        public int Feeschedule { get; set; }
        public int Payercode { get; set; }
        public int Payerid { get; set; }
        public int Detailid { get; set; }
        public int Gst { get; set; }
        public int Nnac { get; set; }
        public int Multipleops { get; set; }
        public int Multipleopschecked { get; set; }
        public int Patients { get; set; }
        public int Hospital { get; set; }
        public int Imaging { get; set; }
        public int Total { get; set; }
        public int Cargo { get; set; }
        public int Referralid { get; set; }
        public string Noreferralcode { get; set; }
        public int Appointmentid { get; set; }
        public string Claimno { get; set; }
        public string Dvalocation { get; set; }
        public string Hospitalname { get; set; }
        public string Notes { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }
        public int Discounted { get; set; }
        public int Fullprivatefee { get; set; }
        public int? Previoususerid { get; set; }
        public DateTime? Accidentdate { get; set; }
        public DateTime? Senttoworkcover { get; set; }
        public int Dirchecked { get; set; }

        public virtual ICollection<Deletedinvoicelocks> Deletedinvoicelocks { get; set; }
        public virtual ICollection<Invoicelock> Invoicelock { get; set; }
    }
}
