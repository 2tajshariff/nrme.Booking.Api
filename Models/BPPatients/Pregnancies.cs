using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Pregnancies
    {
        public Pregnancies()
        {
            Antenatalvisits = new HashSet<Antenatalvisits>();
            Births = new HashSet<Births>();
            Pregnancyimaging = new HashSet<Pregnancyimaging>();
            Pregnancyresults = new HashSet<Pregnancyresults>();
        }

        public int Pregnancyid { get; set; }
        public int Recordstatus { get; set; }
        public int Internalid { get; set; }
        public int Userid { get; set; }
        public int Pregnancynumber { get; set; }
        public DateTime? Edcbydate { get; set; }
        public DateTime? Edcbyscan { get; set; }
        public int Usescan { get; set; }
        public int Scandays { get; set; }
        public int Scanweeks { get; set; }
        public int Certainty { get; set; }
        public DateTime? Scandate { get; set; }
        public DateTime? Actuallmp { get; set; }
        public DateTime? Nominallmp { get; set; }
        public DateTime? Enddate { get; set; }
        public int Gestationlength { get; set; }
        public int Ivf { get; set; }
        public int Gdm { get; set; }
        public int Hypertension { get; set; }
        public int Eclampsia { get; set; }
        public int Renaldisease { get; set; }
        public int Outcomecode { get; set; }
        public string Stage1labour { get; set; }
        public string Stage2labour { get; set; }
        public string Stage3labour { get; set; }
        public int Onsetcode { get; set; }
        public int Deliverycode { get; set; }
        public int Augmentationcode { get; set; }
        public int Analgesiacode { get; set; }
        public int Perineumcode { get; set; }
        public int Placentacode { get; set; }
        public int Bloodlosscode { get; set; }
        public int AntiD { get; set; }
        public int Feedingcode { get; set; }
        public int Pnbleeding { get; set; }
        public int Pnamenorrhoea { get; set; }
        public int Pncswound { get; set; }
        public int Pnperineum { get; set; }
        public int Pnuterus { get; set; }
        public int Pncontraception { get; set; }
        public int Pndepression { get; set; }
        public string Deliverynotes { get; set; }
        public string Pnvisitnotes { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }

        public virtual Labouranalgesia AnalgesiacodeNavigation { get; set; }
        public virtual Labouraugmentation AugmentationcodeNavigation { get; set; }
        public virtual Bloodloss BloodlosscodeNavigation { get; set; }
        public virtual Labourdelivery DeliverycodeNavigation { get; set; }
        public virtual Feeding FeedingcodeNavigation { get; set; }
        public virtual Patients Internal { get; set; }
        public virtual Labouronset OnsetcodeNavigation { get; set; }
        public virtual Pregnancyoutcome OutcomecodeNavigation { get; set; }
        public virtual Perineum PerineumcodeNavigation { get; set; }
        public virtual Placenta PlacentacodeNavigation { get; set; }
        public virtual ICollection<Antenatalvisits> Antenatalvisits { get; set; }
        public virtual ICollection<Births> Births { get; set; }
        public virtual ICollection<Pregnancyimaging> Pregnancyimaging { get; set; }
        public virtual ICollection<Pregnancyresults> Pregnancyresults { get; set; }
    }
}
