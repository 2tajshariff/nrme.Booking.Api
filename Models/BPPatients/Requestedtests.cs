using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Requestedtests
    {
        public Requestedtests()
        {
            Testitems = new HashSet<Testitems>();
        }

        public int Requestid { get; set; }
        public int Internalid { get; set; }
        public int Userid { get; set; }
        public int Locationid { get; set; }
        public int Recordstatus { get; set; }
        public int Requesttype { get; set; }
        public DateTime Requestdate { get; set; }
        public int Requeststatus { get; set; }
        public int Providerid { get; set; }
        public string Providername { get; set; }
        public string Freetextitem { get; set; }
        public int Fasting { get; set; }
        public int Pregnant { get; set; }
        public DateTime? Lmp { get; set; }
        public DateTime? Edc { get; set; }
        public int Urgent { get; set; }
        public string Urgentby { get; set; }
        public string Urgentphone { get; set; }
        public string Urgentfax { get; set; }
        public string Clinicaldetails { get; set; }
        public int Smearsite { get; set; }
        public int Cervix { get; set; }
        public int Erosion { get; set; }
        public int Ectropion { get; set; }
        public int Postnatal { get; set; }
        public int Postmenopausal { get; set; }
        public int Ocp { get; set; }
        public int Hrt { get; set; }
        public int Hysterectomy { get; set; }
        public int Radiorx { get; set; }
        public int Iud { get; set; }
        public int Bleeding { get; set; }
        public string Copies { get; set; }
        public int Billing { get; set; }
        public int Papregister { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }
        public int? VisitId { get; set; }
        public int VisitUpdated { get; set; }
        public string Labrequestid { get; set; }
        public int Modality { get; set; }
        public int Consent { get; set; }
        public int Pmbleeding { get; set; }
        public int Imbleeding { get; set; }
        public int Pcbleeding { get; set; }
        public int Pvdischarge { get; set; }
        public int Dyspareunia { get; set; }
        public int PreviousAis { get; set; }
        public int TestOfCure { get; set; }
        public int Immunodeficient { get; set; }
        public int Desexposure { get; set; }
        public int PreviousUnsatisfactory { get; set; }
        public int PreviousAbnormal { get; set; }
        public int SelfCollected { get; set; }
        public int EarlyDebut { get; set; }

        public virtual Patients Internal { get; set; }
        public virtual Users User { get; set; }
        public virtual Visits Visit { get; set; }
        public virtual ICollection<Testitems> Testitems { get; set; }
    }
}
