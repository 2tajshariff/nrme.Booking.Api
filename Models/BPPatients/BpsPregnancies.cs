using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class BpsPregnancies
    {
        public int PregnancyId { get; set; }
        public int InternalId { get; set; }
        public int PregnancyNumber { get; set; }
        public DateTime? EdcbyDate { get; set; }
        public DateTime? EdcbyScan { get; set; }
        public string UseScan { get; set; }
        public DateTime? ScanDate { get; set; }
        public int Scanweeks { get; set; }
        public int Scandays { get; set; }
        public DateTime? ActualLmp { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public int GestationLength { get; set; }
        public string Ivf { get; set; }
        public string Diabetes { get; set; }
        public string Hypertension { get; set; }
        public string PreEclampsia { get; set; }
        public string RenalDisease { get; set; }
        public string OutcomeText { get; set; }
        public string Stage1 { get; set; }
        public string Stage2 { get; set; }
        public string Stage3 { get; set; }
        public string Onset { get; set; }
        public string Delivery { get; set; }
        public string Augmentation { get; set; }
        public string Analgesia { get; set; }
        public string Perineum { get; set; }
        public string Placenta { get; set; }
        public string BloodLoss { get; set; }
        public string AntiD { get; set; }
        public string Feeding { get; set; }
        public string DeliveryNotes { get; set; }
        public DateTime Created { get; set; }
    }
}
