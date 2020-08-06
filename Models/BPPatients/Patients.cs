using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Patients
    {
        public Patients()
        {
            Accident = new HashSet<Accident>();
            Actions = new HashSet<Actions>();
            Acupuncturevisits = new HashSet<Acupuncturevisits>();
            Adfoccupation = new HashSet<Adfoccupation>();
            Admissions = new HashSet<Admissions>();
            Adrac = new HashSet<Adrac>();
            Alcohol = new HashSet<Alcohol>();
            AntenatalOther = new HashSet<AntenatalOther>();
            AntenatalResults = new HashSet<AntenatalResults>();
            Antenatalvisits = new HashSet<Antenatalvisits>();
            Appointments = new HashSet<Appointments>();
            Asthmaplan = new HashSet<Asthmaplan>();
            Auditc = new HashSet<Auditc>();
            Auditlog = new HashSet<Auditlog>();
            Births = new HashSet<Births>();
            ContactNotes = new HashSet<ContactNotes>();
            Correspondencein = new HashSet<Correspondencein>();
            Correspondenceout = new HashSet<Correspondenceout>();
            Currentrx = new HashSet<Currentrx>();
            Diabetes = new HashSet<Diabetes>();
            Dvaconditions = new HashSet<Dvaconditions>();
            Email = new HashSet<Email>();
            Epcreports = new HashSet<Epcreports>();
            Epctext = new HashSet<Epctext>();
            Epcvalues = new HashSet<Epcvalues>();
            Ereferrals = new HashSet<Ereferrals>();
            Familyhistorydetail = new HashSet<Familyhistorydetail>();
            Graphics = new HashSet<Graphics>();
            Healthcarehomes = new HashSet<Healthcarehomes>();
            Healthlinkform = new HashSet<Healthlinkform>();
            Healthlinksession = new HashSet<Healthlinksession>();
            Hiaudit = new HashSet<Hiaudit>();
            Hierrors = new HashSet<Hierrors>();
            Ihihistory = new HashSet<Ihihistory>();
            Immunisations = new HashSet<Immunisations>();
            Immunisedagainst = new HashSet<Immunisedagainst>();
            Inrdetail = new HashSet<Inrdetail>();
            Inrvalues = new HashSet<Inrvalues>();
            Investigations = new HashSet<Investigations>();
            K10 = new HashSet<K10>();
            MedicareAlias = new HashSet<MedicareAlias>();
            Medviewconsent = new HashSet<Medviewconsent>();
            Mmse = new HashSet<Mmse>();
            Nesnotifications = new HashSet<Nesnotifications>();
            Nirmessages = new HashSet<Nirmessages>();
            Notify = new HashSet<Notify>();
            Observations = new HashSet<Observations>();
            Obsgyndetail = new HashSet<Obsgyndetail>();
            Occupationhistory = new HashSet<Occupationhistory>();
            Opdose = new HashSet<Opdose>();
            Operations = new HashSet<Operations>();
            Opioid = new HashSet<Opioid>();
            Pain = new HashSet<Pain>();
            Papsmears = new HashSet<Papsmears>();
            Parameters = new HashSet<Parameters>();
            Pasthistory = new HashSet<Pasthistory>();
            PatientPatientgroup = new HashSet<PatientPatientgroup>();
            Patientethnicity = new HashSet<Patientethnicity>();
            Patientiwi = new HashSet<Patientiwi>();
            Patientphoto = new HashSet<Patientphoto>();
            Pcehrdocuments = new HashSet<Pcehrdocuments>();
            Pedrec = new HashSet<Pedrec>();
            Pregnancies = new HashSet<Pregnancies>();
            Pregnancyimaging = new HashSet<Pregnancyimaging>();
            Pregnancyresults = new HashSet<Pregnancyresults>();
            Prescriptions = new HashSet<Prescriptions>();
            Prompt = new HashSet<Prompt>();
            Reactions = new HashSet<Reactions>();
            Referrals = new HashSet<Referrals>();
            Reminders = new HashSet<Reminders>();
            Reminderssent = new HashSet<Reminderssent>();
            Reportvalues = new HashSet<Reportvalues>();
            Requestedtests = new HashSet<Requestedtests>();
            Scriptitems = new HashSet<Scriptitems>();
            Tobacco = new HashSet<Tobacco>();
            Transmissions = new HashSet<Transmissions>();
            Udfvalues = new HashSet<Udfvalues>();
            Uhgreport = new HashSet<Uhgreport>();
            Vipdata = new HashSet<Vipdata>();
            Visitexamination = new HashSet<Visitexamination>();
            Visithistory = new HashSet<Visithistory>();
            Visitjoint = new HashSet<Visitjoint>();
            Visitlesion = new HashSet<Visitlesion>();
            Visitlump = new HashSet<Visitlump>();
            Visitmbs = new HashSet<Visitmbs>();
            Visitparameters = new HashSet<Visitparameters>();
            Visitreason = new HashSet<Visitreason>();
            Visits = new HashSet<Visits>();
            Visittext = new HashSet<Visittext>();
            Workcover = new HashSet<Workcover>();
            Workcoveritems = new HashSet<Workcoveritems>();
            Workcovertext = new HashSet<Workcovertext>();
        }

        public int Internalid { get; set; }
        public int Recordstatus { get; set; }
        public string Externalid { get; set; }
        public string Ihi { get; set; }
        public int Ihistatus { get; set; }
        public int Ihirecordstatus { get; set; }
        public int Ihisource { get; set; }
        public int Origin { get; set; }
        public int Patientstatus { get; set; }
        public DateTime? Dateofdeath { get; set; }
        public int Titlecode { get; set; }
        public string Firstname { get; set; }
        public string Middlename { get; set; }
        public string Surname { get; set; }
        public string Preferredname { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string Postcode { get; set; }
        public string Postaladdress { get; set; }
        public string Postalcity { get; set; }
        public string Postalpostcode { get; set; }
        public DateTime? Dob { get; set; }
        public int Sexcode { get; set; }
        public int Ethniccode { get; set; }
        public string Homephone { get; set; }
        public string Workphone { get; set; }
        public string Mobilephone { get; set; }
        public string Medicareno { get; set; }
        public string Medicarelineno { get; set; }
        public string Medicareexpiry { get; set; }
        public int Pensioncode { get; set; }
        public string Pensionno { get; set; }
        public DateTime? Pensionstart { get; set; }
        public DateTime? Pensionexpiry { get; set; }
        public int Dvacode { get; set; }
        public string Dvano { get; set; }
        public string Safetynetno { get; set; }
        public string Recordno { get; set; }
        public string Religion { get; set; }
        public string Healthfundno { get; set; }
        public string Healthfundname { get; set; }
        public int Healthfundid { get; set; }
        public DateTime? Healthfundexpiry { get; set; }
        public int Accountcode { get; set; }
        public int Userid { get; set; }
        public int Denyaccess { get; set; }
        public int Noreminders { get; set; }
        public int Contactmethod { get; set; }
        public int Headoffamilyid { get; set; }
        public int Nextofkinid { get; set; }
        public int Emergencyid { get; set; }
        public string Referringdoctor { get; set; }
        public DateTime? Referraldate { get; set; }
        public int Referralcode { get; set; }
        public int Erx { get; set; }
        public int Dispense { get; set; }
        public int Medview { get; set; }
        public int Pharmacyid { get; set; }
        public int Ctg { get; set; }
        public string Othernotes { get; set; }
        public int Consentsmsreminder { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }
        public string Country { get; set; }
        public string Postalcountry { get; set; }
        public DateTime? Ihivalidated { get; set; }
        public int Defaultvisittype { get; set; }
        public int? Previoususerid { get; set; }
        public int? Registrationid { get; set; }
        public int? Enrolmentid { get; set; }
        public DateTime? Qed { get; set; }
        public string EligiblePublicFunding { get; set; }
        public string Enrolmentcheck { get; set; }
        public int Hchtier { get; set; }
        public DateTime? Hchstarted { get; set; }
        public DateTime? Hchcurrent { get; set; }
        public string Pendingmobilechange { get; set; }
        public int PublicFunding { get; set; }
        public int FinDependant { get; set; }
        public int Cscholder { get; set; }
        public int Hucholder { get; set; }
        public string Cscnumber { get; set; }
        public string IncSuppNumber { get; set; }
        public string Hucnumber { get; set; }
        public DateTime? Cscvalid { get; set; }
        public DateTime? Cscexpiry { get; set; }
        public DateTime? Hucvalid { get; set; }
        public DateTime? Hucexpiry { get; set; }
        public int Iwi { get; set; }
        public int? OverallPatientversion { get; set; }
        public int? CoreVersion { get; set; }
        public DateTime? MohChecked { get; set; }
        public int? Countryofbirth { get; set; }
        public int? CountryofbirthSource { get; set; }
        public string Placeofbirth { get; set; }
        public byte? Citizen { get; set; }
        public int? CitizenSource { get; set; }
        public int? Dateofdeathsource { get; set; }
        public int? NameSource { get; set; }
        public int? NameSetid { get; set; }
        public int? NameVersion { get; set; }
        public int? NameType { get; set; }
        public int? AddressGeotag { get; set; }
        public int? AddressSetid { get; set; }
        public int? AddressVersion { get; set; }
        public int? AddressDomicile { get; set; }
        public int? AddressNotvalidReason { get; set; }
        public DateTime? EsamChecked { get; set; }
        public string PostalSuburb { get; set; }
        public int? PostalAddressGeotag { get; set; }
        public int? PostalAddressDomicile { get; set; }
        public int? PostalAddressNotvalidReason { get; set; }
        public DateTime? PostalEsamChecked { get; set; }
        public int? DobSource { get; set; }
        public int Ethnic1code { get; set; }
        public int Ethnic2code { get; set; }

        public virtual Dvatype DvacodeNavigation { get; set; }
        public virtual Hchtiers HchtierNavigation { get; set; }
        public virtual Nextofkin Nextofkin { get; set; }
        public virtual Pensiontype PensioncodeNavigation { get; set; }
        public virtual Sex SexcodeNavigation { get; set; }
        public virtual Titles TitlecodeNavigation { get; set; }
        public virtual Users User { get; set; }
        public virtual Clinical Clinical { get; set; }
        public virtual Familyhistory Familyhistory { get; set; }
        public virtual PatientWhitecoat PatientWhitecoat { get; set; }
        public virtual Suid Suid { get; set; }
        public virtual ICollection<Accident> Accident { get; set; }
        public virtual ICollection<Actions> Actions { get; set; }
        public virtual ICollection<Acupuncturevisits> Acupuncturevisits { get; set; }
        public virtual ICollection<Adfoccupation> Adfoccupation { get; set; }
        public virtual ICollection<Admissions> Admissions { get; set; }
        public virtual ICollection<Adrac> Adrac { get; set; }
        public virtual ICollection<Alcohol> Alcohol { get; set; }
        public virtual ICollection<AntenatalOther> AntenatalOther { get; set; }
        public virtual ICollection<AntenatalResults> AntenatalResults { get; set; }
        public virtual ICollection<Antenatalvisits> Antenatalvisits { get; set; }
        public virtual ICollection<Appointments> Appointments { get; set; }
        public virtual ICollection<Asthmaplan> Asthmaplan { get; set; }
        public virtual ICollection<Auditc> Auditc { get; set; }
        public virtual ICollection<Auditlog> Auditlog { get; set; }
        public virtual ICollection<Births> Births { get; set; }
        public virtual ICollection<ContactNotes> ContactNotes { get; set; }
        public virtual ICollection<Correspondencein> Correspondencein { get; set; }
        public virtual ICollection<Correspondenceout> Correspondenceout { get; set; }
        public virtual ICollection<Currentrx> Currentrx { get; set; }
        public virtual ICollection<Diabetes> Diabetes { get; set; }
        public virtual ICollection<Dvaconditions> Dvaconditions { get; set; }
        public virtual ICollection<Email> Email { get; set; }
        public virtual ICollection<Epcreports> Epcreports { get; set; }
        public virtual ICollection<Epctext> Epctext { get; set; }
        public virtual ICollection<Epcvalues> Epcvalues { get; set; }
        public virtual ICollection<Ereferrals> Ereferrals { get; set; }
        public virtual ICollection<Familyhistorydetail> Familyhistorydetail { get; set; }
        public virtual ICollection<Graphics> Graphics { get; set; }
        public virtual ICollection<Healthcarehomes> Healthcarehomes { get; set; }
        public virtual ICollection<Healthlinkform> Healthlinkform { get; set; }
        public virtual ICollection<Healthlinksession> Healthlinksession { get; set; }
        public virtual ICollection<Hiaudit> Hiaudit { get; set; }
        public virtual ICollection<Hierrors> Hierrors { get; set; }
        public virtual ICollection<Ihihistory> Ihihistory { get; set; }
        public virtual ICollection<Immunisations> Immunisations { get; set; }
        public virtual ICollection<Immunisedagainst> Immunisedagainst { get; set; }
        public virtual ICollection<Inrdetail> Inrdetail { get; set; }
        public virtual ICollection<Inrvalues> Inrvalues { get; set; }
        public virtual ICollection<Investigations> Investigations { get; set; }
        public virtual ICollection<K10> K10 { get; set; }
        public virtual ICollection<MedicareAlias> MedicareAlias { get; set; }
        public virtual ICollection<Medviewconsent> Medviewconsent { get; set; }
        public virtual ICollection<Mmse> Mmse { get; set; }
        public virtual ICollection<Nesnotifications> Nesnotifications { get; set; }
        public virtual ICollection<Nirmessages> Nirmessages { get; set; }
        public virtual ICollection<Notify> Notify { get; set; }
        public virtual ICollection<Observations> Observations { get; set; }
        public virtual ICollection<Obsgyndetail> Obsgyndetail { get; set; }
        public virtual ICollection<Occupationhistory> Occupationhistory { get; set; }
        public virtual ICollection<Opdose> Opdose { get; set; }
        public virtual ICollection<Operations> Operations { get; set; }
        public virtual ICollection<Opioid> Opioid { get; set; }
        public virtual ICollection<Pain> Pain { get; set; }
        public virtual ICollection<Papsmears> Papsmears { get; set; }
        public virtual ICollection<Parameters> Parameters { get; set; }
        public virtual ICollection<Pasthistory> Pasthistory { get; set; }
        public virtual ICollection<PatientPatientgroup> PatientPatientgroup { get; set; }
        public virtual ICollection<Patientethnicity> Patientethnicity { get; set; }
        public virtual ICollection<Patientiwi> Patientiwi { get; set; }
        public virtual ICollection<Patientphoto> Patientphoto { get; set; }
        public virtual ICollection<Pcehrdocuments> Pcehrdocuments { get; set; }
        public virtual ICollection<Pedrec> Pedrec { get; set; }
        public virtual ICollection<Pregnancies> Pregnancies { get; set; }
        public virtual ICollection<Pregnancyimaging> Pregnancyimaging { get; set; }
        public virtual ICollection<Pregnancyresults> Pregnancyresults { get; set; }
        public virtual ICollection<Prescriptions> Prescriptions { get; set; }
        public virtual ICollection<Prompt> Prompt { get; set; }
        public virtual ICollection<Reactions> Reactions { get; set; }
        public virtual ICollection<Referrals> Referrals { get; set; }
        public virtual ICollection<Reminders> Reminders { get; set; }
        public virtual ICollection<Reminderssent> Reminderssent { get; set; }
        public virtual ICollection<Reportvalues> Reportvalues { get; set; }
        public virtual ICollection<Requestedtests> Requestedtests { get; set; }
        public virtual ICollection<Scriptitems> Scriptitems { get; set; }
        public virtual ICollection<Tobacco> Tobacco { get; set; }
        public virtual ICollection<Transmissions> Transmissions { get; set; }
        public virtual ICollection<Udfvalues> Udfvalues { get; set; }
        public virtual ICollection<Uhgreport> Uhgreport { get; set; }
        public virtual ICollection<Vipdata> Vipdata { get; set; }
        public virtual ICollection<Visitexamination> Visitexamination { get; set; }
        public virtual ICollection<Visithistory> Visithistory { get; set; }
        public virtual ICollection<Visitjoint> Visitjoint { get; set; }
        public virtual ICollection<Visitlesion> Visitlesion { get; set; }
        public virtual ICollection<Visitlump> Visitlump { get; set; }
        public virtual ICollection<Visitmbs> Visitmbs { get; set; }
        public virtual ICollection<Visitparameters> Visitparameters { get; set; }
        public virtual ICollection<Visitreason> Visitreason { get; set; }
        public virtual ICollection<Visits> Visits { get; set; }
        public virtual ICollection<Visittext> Visittext { get; set; }
        public virtual ICollection<Workcover> Workcover { get; set; }
        public virtual ICollection<Workcoveritems> Workcoveritems { get; set; }
        public virtual ICollection<Workcovertext> Workcovertext { get; set; }
    }
}
