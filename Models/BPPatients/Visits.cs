using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Visits
    {
        public Visits()
        {
            Antenatalvisits = new HashSet<Antenatalvisits>();
            Currentrx = new HashSet<Currentrx>();
            Deletedvisitlocks = new HashSet<Deletedvisitlocks>();
            Graphics = new HashSet<Graphics>();
            Healthlinkform = new HashSet<Healthlinkform>();
            Healthlinksession = new HashSet<Healthlinksession>();
            Immunisations = new HashSet<Immunisations>();
            Pasthistory = new HashSet<Pasthistory>();
            Prescriptions = new HashSet<Prescriptions>();
            Reactions = new HashSet<Reactions>();
            Requestedtests = new HashSet<Requestedtests>();
            Visitexamination = new HashSet<Visitexamination>();
            Visithistory = new HashSet<Visithistory>();
            Visitjoint = new HashSet<Visitjoint>();
            Visitlesion = new HashSet<Visitlesion>();
            Visitlock = new HashSet<Visitlock>();
            Visitlump = new HashSet<Visitlump>();
            Visitmbs = new HashSet<Visitmbs>();
            Visitparameters = new HashSet<Visitparameters>();
            Visitreason = new HashSet<Visitreason>();
            Visittext = new HashSet<Visittext>();
        }

        public int Visitid { get; set; }
        public int Internalid { get; set; }
        public int Userid { get; set; }
        public int Recordstatus { get; set; }
        public int Visitcode { get; set; }
        public string Drname { get; set; }
        public DateTime? Visitdate { get; set; }
        public DateTime? Recordeddate { get; set; }
        public int Starttime { get; set; }
        public int Endtime { get; set; }
        public int Duration { get; set; }
        public int Location { get; set; }
        public int Confidential { get; set; }
        public DateTime? Reviewdate { get; set; }
        public string History { get; set; }
        public string Exam { get; set; }
        public string Visitnotes { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }
        public int? Previoususerid { get; set; }

        public virtual Patients Internal { get; set; }
        public virtual Users User { get; set; }
        public virtual Visittype VisitcodeNavigation { get; set; }
        public virtual ICollection<Antenatalvisits> Antenatalvisits { get; set; }
        public virtual ICollection<Currentrx> Currentrx { get; set; }
        public virtual ICollection<Deletedvisitlocks> Deletedvisitlocks { get; set; }
        public virtual ICollection<Graphics> Graphics { get; set; }
        public virtual ICollection<Healthlinkform> Healthlinkform { get; set; }
        public virtual ICollection<Healthlinksession> Healthlinksession { get; set; }
        public virtual ICollection<Immunisations> Immunisations { get; set; }
        public virtual ICollection<Pasthistory> Pasthistory { get; set; }
        public virtual ICollection<Prescriptions> Prescriptions { get; set; }
        public virtual ICollection<Reactions> Reactions { get; set; }
        public virtual ICollection<Requestedtests> Requestedtests { get; set; }
        public virtual ICollection<Visitexamination> Visitexamination { get; set; }
        public virtual ICollection<Visithistory> Visithistory { get; set; }
        public virtual ICollection<Visitjoint> Visitjoint { get; set; }
        public virtual ICollection<Visitlesion> Visitlesion { get; set; }
        public virtual ICollection<Visitlock> Visitlock { get; set; }
        public virtual ICollection<Visitlump> Visitlump { get; set; }
        public virtual ICollection<Visitmbs> Visitmbs { get; set; }
        public virtual ICollection<Visitparameters> Visitparameters { get; set; }
        public virtual ICollection<Visitreason> Visitreason { get; set; }
        public virtual ICollection<Visittext> Visittext { get; set; }
    }
}
