using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class BPSPatientsContext : DbContext
    {
        public BPSPatientsContext()
        {
        }

        public BPSPatientsContext(DbContextOptions<BPSPatientsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Accident> Accident { get; set; }
        public virtual DbSet<Accidentdiagnosis> Accidentdiagnosis { get; set; }
        public virtual DbSet<Accidentlink> Accidentlink { get; set; }
        public virtual DbSet<Accomodation> Accomodation { get; set; }
        public virtual DbSet<Accounttext> Accounttext { get; set; }
        public virtual DbSet<Accounttype> Accounttype { get; set; }
        public virtual DbSet<Acirbatches> Acirbatches { get; set; }
        public virtual DbSet<Acknowledgements> Acknowledgements { get; set; }
        public virtual DbSet<Actionitems> Actionitems { get; set; }
        public virtual DbSet<Actions> Actions { get; set; }
        public virtual DbSet<Activecodes> Activecodes { get; set; }
        public virtual DbSet<Acupunctureconditions> Acupunctureconditions { get; set; }
        public virtual DbSet<Acupuncturevisits> Acupuncturevisits { get; set; }
        public virtual DbSet<Adfoccupation> Adfoccupation { get; set; }
        public virtual DbSet<Adjustments> Adjustments { get; set; }
        public virtual DbSet<Admissionconditions> Admissionconditions { get; set; }
        public virtual DbSet<Admissiondetails> Admissiondetails { get; set; }
        public virtual DbSet<Admissionfollowup> Admissionfollowup { get; set; }
        public virtual DbSet<Admissions> Admissions { get; set; }
        public virtual DbSet<Adrac> Adrac { get; set; }
        public virtual DbSet<Alcohol> Alcohol { get; set; }
        public virtual DbSet<Alcoholstatus> Alcoholstatus { get; set; }
        public virtual DbSet<Amafees> Amafees { get; set; }
        public virtual DbSet<Anengagement> Anengagement { get; set; }
        public virtual DbSet<Anposition> Anposition { get; set; }
        public virtual DbSet<Anpresentation> Anpresentation { get; set; }
        public virtual DbSet<AntenatalOther> AntenatalOther { get; set; }
        public virtual DbSet<AntenatalResults> AntenatalResults { get; set; }
        public virtual DbSet<Antenatalvisits> Antenatalvisits { get; set; }
        public virtual DbSet<Appointmentcodes> Appointmentcodes { get; set; }
        public virtual DbSet<Appointmentlayout> Appointmentlayout { get; set; }
        public virtual DbSet<Appointmentlayoutusers> Appointmentlayoutusers { get; set; }
        public virtual DbSet<Appointmentlocks> Appointmentlocks { get; set; }
        public virtual DbSet<Appointmentnotes> Appointmentnotes { get; set; }
        public virtual DbSet<Appointments> Appointments { get; set; }
        public virtual DbSet<Appointmenttypes> Appointmenttypes { get; set; }
        public virtual DbSet<Argussetup> Argussetup { get; set; }
        public virtual DbSet<Asthmaplan> Asthmaplan { get; set; }
        public virtual DbSet<Auditc> Auditc { get; set; }
        public virtual DbSet<Auditlog> Auditlog { get; set; }
        public virtual DbSet<Authority> Authority { get; set; }
        public virtual DbSet<Autofill> Autofill { get; set; }
        public virtual DbSet<AwsConnectionSettings> AwsConnectionSettings { get; set; }
        public virtual DbSet<AzureEventHubSettings> AzureEventHubSettings { get; set; }
        public virtual DbSet<Backupmessage> Backupmessage { get; set; }
        public virtual DbSet<Bankaccounts> Bankaccounts { get; set; }
        public virtual DbSet<Banking> Banking { get; set; }
        public virtual DbSet<BankingbatchPaymentparts> BankingbatchPaymentparts { get; set; }
        public virtual DbSet<Banknames> Banknames { get; set; }
        public virtual DbSet<BatchService> BatchService { get; set; }
        public virtual DbSet<BhaLocationKeys> BhaLocationKeys { get; set; }
        public virtual DbSet<BhaLocationTokens> BhaLocationTokens { get; set; }
        public virtual DbSet<BhaMessages> BhaMessages { get; set; }
        public virtual DbSet<BhaReplies> BhaReplies { get; set; }
        public virtual DbSet<Billinggroups> Billinggroups { get; set; }
        public virtual DbSet<Births> Births { get; set; }
        public virtual DbSet<Bloodloss> Bloodloss { get; set; }
        public virtual DbSet<Bodyside> Bodyside { get; set; }
        public virtual DbSet<Bpcommscredit> Bpcommscredit { get; set; }
        public virtual DbSet<Bpcommsenrolmentcode> Bpcommsenrolmentcode { get; set; }
        public virtual DbSet<Bponline> Bponline { get; set; }
        public virtual DbSet<Bpremote> Bpremote { get; set; }
        public virtual DbSet<BpsActions> BpsActions { get; set; }
        public virtual DbSet<BpsAlcohol> BpsAlcohol { get; set; }
        public virtual DbSet<BpsAllActions> BpsAllActions { get; set; }
        public virtual DbSet<BpsAllHistory> BpsAllHistory { get; set; }
        public virtual DbSet<BpsAllHistory1> BpsAllHistory1 { get; set; }
        public virtual DbSet<BpsAllImmunisations> BpsAllImmunisations { get; set; }
        public virtual DbSet<BpsAllObservations> BpsAllObservations { get; set; }
        public virtual DbSet<BpsAllPapSmears> BpsAllPapSmears { get; set; }
        public virtual DbSet<BpsAllParameters> BpsAllParameters { get; set; }
        public virtual DbSet<BpsAllPregnancies> BpsAllPregnancies { get; set; }
        public virtual DbSet<BpsAllPrescriptions> BpsAllPrescriptions { get; set; }
        public virtual DbSet<BpsAllReminders> BpsAllReminders { get; set; }
        public virtual DbSet<BpsAllRequests> BpsAllRequests { get; set; }
        public virtual DbSet<BpsAntenatalVisits> BpsAntenatalVisits { get; set; }
        public virtual DbSet<BpsAppointments> BpsAppointments { get; set; }
        public virtual DbSet<BpsBirths> BpsBirths { get; set; }
        public virtual DbSet<BpsClinical> BpsClinical { get; set; }
        public virtual DbSet<BpsClinicalImages> BpsClinicalImages { get; set; }
        public virtual DbSet<BpsContactAddresses> BpsContactAddresses { get; set; }
        public virtual DbSet<BpsContacts> BpsContacts { get; set; }
        public virtual DbSet<BpsCorrespondenceIn> BpsCorrespondenceIn { get; set; }
        public virtual DbSet<BpsCorrespondenceOut> BpsCorrespondenceOut { get; set; }
        public virtual DbSet<BpsCurrentRx> BpsCurrentRx { get; set; }
        public virtual DbSet<BpsDaysAway> BpsDaysAway { get; set; }
        public virtual DbSet<BpsDiabetes> BpsDiabetes { get; set; }
        public virtual DbSet<BpsEpcreports> BpsEpcreports { get; set; }
        public virtual DbSet<BpsExtraSessions> BpsExtraSessions { get; set; }
        public virtual DbSet<BpsFamilyHistory> BpsFamilyHistory { get; set; }
        public virtual DbSet<BpsFamilyHistoryDetail> BpsFamilyHistoryDetail { get; set; }
        public virtual DbSet<BpsHistory> BpsHistory { get; set; }
        public virtual DbSet<BpsImmunisations> BpsImmunisations { get; set; }
        public virtual DbSet<BpsInvestigations> BpsInvestigations { get; set; }
        public virtual DbSet<BpsObsGyn> BpsObsGyn { get; set; }
        public virtual DbSet<BpsObservations> BpsObservations { get; set; }
        public virtual DbSet<BpsOccupationHistory> BpsOccupationHistory { get; set; }
        public virtual DbSet<BpsPapSmears> BpsPapSmears { get; set; }
        public virtual DbSet<BpsParameters> BpsParameters { get; set; }
        public virtual DbSet<BpsPatientLogin> BpsPatientLogin { get; set; }
        public virtual DbSet<BpsPatients> BpsPatients { get; set; }
        public virtual DbSet<BpsPracticeLocations> BpsPracticeLocations { get; set; }
        public virtual DbSet<BpsPregnancies> BpsPregnancies { get; set; }
        public virtual DbSet<BpsPrescriptions> BpsPrescriptions { get; set; }
        public virtual DbSet<BpsReactions> BpsReactions { get; set; }
        public virtual DbSet<BpsReminders> BpsReminders { get; set; }
        public virtual DbSet<BpsReportValues> BpsReportValues { get; set; }
        public virtual DbSet<BpsRequests> BpsRequests { get; set; }
        public virtual DbSet<BpsServices> BpsServices { get; set; }
        public virtual DbSet<BpsSessions> BpsSessions { get; set; }
        public virtual DbSet<BpsTobacco> BpsTobacco { get; set; }
        public virtual DbSet<BpsUsers> BpsUsers { get; set; }
        public virtual DbSet<BpsVisitReason> BpsVisitReason { get; set; }
        public virtual DbSet<BpsVisits> BpsVisits { get; set; }
        public virtual DbSet<Bpsbackup> Bpsbackup { get; set; }
        public virtual DbSet<Bpsbackuptime> Bpsbackuptime { get; set; }
        public virtual DbSet<Bulkbilleasyclaims> Bulkbilleasyclaims { get; set; }
        public virtual DbSet<Cancellationreasons> Cancellationreasons { get; set; }
        public virtual DbSet<Cancellations> Cancellations { get; set; }
        public virtual DbSet<Cancelledappointments> Cancelledappointments { get; set; }
        public virtual DbSet<Careplandetail> Careplandetail { get; set; }
        public virtual DbSet<Careplangoals> Careplangoals { get; set; }
        public virtual DbSet<Careplanitems> Careplanitems { get; set; }
        public virtual DbSet<Careplanproblems> Careplanproblems { get; set; }
        public virtual DbSet<Careplantasks> Careplantasks { get; set; }
        public virtual DbSet<Careplantemplateitems> Careplantemplateitems { get; set; }
        public virtual DbSet<Careplantemplates> Careplantemplates { get; set; }
        public virtual DbSet<Carer> Carer { get; set; }
        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<CdmNetsetup> CdmNetsetup { get; set; }
        public virtual DbSet<CdmNetvalue> CdmNetvalue { get; set; }
        public virtual DbSet<Ceasedreasons> Ceasedreasons { get; set; }
        public virtual DbSet<Certificates> Certificates { get; set; }
        public virtual DbSet<Chequedrawers> Chequedrawers { get; set; }
        public virtual DbSet<Clientscript> Clientscript { get; set; }
        public virtual DbSet<Clinical> Clinical { get; set; }
        public virtual DbSet<Clinicaltext> Clinicaltext { get; set; }
        public virtual DbSet<CommonfeeSchedule> CommonfeeSchedule { get; set; }
        public virtual DbSet<Commonfees> Commonfees { get; set; }
        public virtual DbSet<Complexinstructions> Complexinstructions { get; set; }
        public virtual DbSet<Complicationcodes> Complicationcodes { get; set; }
        public virtual DbSet<Complications> Complications { get; set; }
        public virtual DbSet<ContactMethod> ContactMethod { get; set; }
        public virtual DbSet<ContactNotes> ContactNotes { get; set; }
        public virtual DbSet<Contactdetails> Contactdetails { get; set; }
        public virtual DbSet<Contacts> Contacts { get; set; }
        public virtual DbSet<Correspondencein> Correspondencein { get; set; }
        public virtual DbSet<Correspondenceout> Correspondenceout { get; set; }
        public virtual DbSet<Cstcodes> Cstcodes { get; set; }
        public virtual DbSet<Ctg> Ctg { get; set; }
        public virtual DbSet<Currentrx> Currentrx { get; set; }
        public virtual DbSet<CustomColours> CustomColours { get; set; }
        public virtual DbSet<CustomContactNoteReasons> CustomContactNoteReasons { get; set; }
        public virtual DbSet<CustomReminderType> CustomReminderType { get; set; }
        public virtual DbSet<Customavailability> Customavailability { get; set; }
        public virtual DbSet<Customclinicaldetails> Customclinicaldetails { get; set; }
        public virtual DbSet<Customfields> Customfields { get; set; }
        public virtual DbSet<CustomproductIngredient> CustomproductIngredient { get; set; }
        public virtual DbSet<Customproductnames> Customproductnames { get; set; }
        public virtual DbSet<Customproducts> Customproducts { get; set; }
        public virtual DbSet<Customprompts> Customprompts { get; set; }
        public virtual DbSet<Customtests> Customtests { get; set; }
        public virtual DbSet<Dailymessages> Dailymessages { get; set; }
        public virtual DbSet<Dayofweek> Dayofweek { get; set; }
        public virtual DbSet<Daysaway> Daysaway { get; set; }
        public virtual DbSet<Defaultdose> Defaultdose { get; set; }
        public virtual DbSet<Defaultmessaging> Defaultmessaging { get; set; }
        public virtual DbSet<Deletedappointmentlocks> Deletedappointmentlocks { get; set; }
        public virtual DbSet<Deletedinvoicelocks> Deletedinvoicelocks { get; set; }
        public virtual DbSet<Deletedmaolpaymentlocks> Deletedmaolpaymentlocks { get; set; }
        public virtual DbSet<Deletedvisitlocks> Deletedvisitlocks { get; set; }
        public virtual DbSet<Diabetes> Diabetes { get; set; }
        public virtual DbSet<Dispenseditems> Dispenseditems { get; set; }
        public virtual DbSet<Documentpages> Documentpages { get; set; }
        public virtual DbSet<Documentstore> Documentstore { get; set; }
        public virtual DbSet<Documenttypes> Documenttypes { get; set; }
        public virtual DbSet<Dosecodes> Dosecodes { get; set; }
        public virtual DbSet<Drugcombinations> Drugcombinations { get; set; }
        public virtual DbSet<Drugfavourites> Drugfavourites { get; set; }
        public virtual DbSet<Drugsheets> Drugsheets { get; set; }
        public virtual DbSet<Dtb> Dtb { get; set; }
        public virtual DbSet<Dvabatch> Dvabatch { get; set; }
        public virtual DbSet<DvabatchService> DvabatchService { get; set; }
        public virtual DbSet<Dvaconditions> Dvaconditions { get; set; }
        public virtual DbSet<Dvaextra> Dvaextra { get; set; }
        public virtual DbSet<DvapaymentClaims> DvapaymentClaims { get; set; }
        public virtual DbSet<DvapaymentRuns> DvapaymentRuns { get; set; }
        public virtual DbSet<DvaprocessReports> DvaprocessReports { get; set; }
        public virtual DbSet<Dvatype> Dvatype { get; set; }
        public virtual DbSet<EasyclaimService> EasyclaimService { get; set; }
        public virtual DbSet<Easyclaimpaymentruns> Easyclaimpaymentruns { get; set; }
        public virtual DbSet<Educationleaflets> Educationleaflets { get; set; }
        public virtual DbSet<Email> Email { get; set; }
        public virtual DbSet<EnrolmentStatus> EnrolmentStatus { get; set; }
        public virtual DbSet<Eorderpath> Eorderpath { get; set; }
        public virtual DbSet<Epcreports> Epcreports { get; set; }
        public virtual DbSet<Epctext> Epctext { get; set; }
        public virtual DbSet<Epctypes> Epctypes { get; set; }
        public virtual DbSet<Epcvalues> Epcvalues { get; set; }
        public virtual DbSet<EprescriptionLog> EprescriptionLog { get; set; }
        public virtual DbSet<Ereferrals> Ereferrals { get; set; }
        public virtual DbSet<Erx> Erx { get; set; }
        public virtual DbSet<ErxSetup> ErxSetup { get; set; }
        public virtual DbSet<Ethnicity> Ethnicity { get; set; }
        public virtual DbSet<Extrasessions> Extrasessions { get; set; }
        public virtual DbSet<Factsheetcategories> Factsheetcategories { get; set; }
        public virtual DbSet<FactsheetcategoriesSources> FactsheetcategoriesSources { get; set; }
        public virtual DbSet<Factsheetcategorysource> Factsheetcategorysource { get; set; }
        public virtual DbSet<Factsheetcontents> Factsheetcontents { get; set; }
        public virtual DbSet<Factsheetdrugs> Factsheetdrugs { get; set; }
        public virtual DbSet<Factsheetgroups> Factsheetgroups { get; set; }
        public virtual DbSet<Factsheets> Factsheets { get; set; }
        public virtual DbSet<FactsheetsFactsheetcategories> FactsheetsFactsheetcategories { get; set; }
        public virtual DbSet<FactsheetsFactsheetdrugs> FactsheetsFactsheetdrugs { get; set; }
        public virtual DbSet<Factsheetshistory> Factsheetshistory { get; set; }
        public virtual DbSet<Factsheettypes> Factsheettypes { get; set; }
        public virtual DbSet<Factsheetuserfavourites> Factsheetuserfavourites { get; set; }
        public virtual DbSet<Familyhistory> Familyhistory { get; set; }
        public virtual DbSet<Familyhistorydetail> Familyhistorydetail { get; set; }
        public virtual DbSet<Favouritetestitems> Favouritetestitems { get; set; }
        public virtual DbSet<Favouritetests> Favouritetests { get; set; }
        public virtual DbSet<Feeding> Feeding { get; set; }
        public virtual DbSet<Feeschedules> Feeschedules { get; set; }
        public virtual DbSet<FhircategoryMapping> FhircategoryMapping { get; set; }
        public virtual DbSet<Fieldvalues> Fieldvalues { get; set; }
        public virtual DbSet<Followup> Followup { get; set; }
        public virtual DbSet<Foodcodes> Foodcodes { get; set; }
        public virtual DbSet<Forms> Forms { get; set; }
        public virtual DbSet<Frequencycodes> Frequencycodes { get; set; }
        public virtual DbSet<Gbrdisplayorder> Gbrdisplayorder { get; set; }
        public virtual DbSet<Generatedtext> Generatedtext { get; set; }
        public virtual DbSet<Genericcounter> Genericcounter { get; set; }
        public virtual DbSet<Gp2gp> Gp2gp { get; set; }
        public virtual DbSet<Gp2gpfields> Gp2gpfields { get; set; }
        public virtual DbSet<Graphics> Graphics { get; set; }
        public virtual DbSet<Grouppermissions> Grouppermissions { get; set; }
        public virtual DbSet<Hchtiers> Hchtiers { get; set; }
        public virtual DbSet<Healthcarehomes> Healthcarehomes { get; set; }
        public virtual DbSet<Healthelink> Healthelink { get; set; }
        public virtual DbSet<Healthlinkform> Healthlinkform { get; set; }
        public virtual DbSet<Healthlinksession> Healthlinksession { get; set; }
        public virtual DbSet<Helid> Helid { get; set; }
        public virtual DbSet<HelmessageReport> HelmessageReport { get; set; }
        public virtual DbSet<HelmessageVisit> HelmessageVisit { get; set; }
        public virtual DbSet<Helmessages> Helmessages { get; set; }
        public virtual DbSet<Helobr> Helobr { get; set; }
        public virtual DbSet<Helpath> Helpath { get; set; }
        public virtual DbSet<Helreports> Helreports { get; set; }
        public virtual DbSet<Hiaudit> Hiaudit { get; set; }
        public virtual DbSet<Hicstore> Hicstore { get; set; }
        public virtual DbSet<Hientities> Hientities { get; set; }
        public virtual DbSet<Hierrors> Hierrors { get; set; }
        public virtual DbSet<Hl7message> Hl7message { get; set; }
        public virtual DbSet<Ihihistory> Ihihistory { get; set; }
        public virtual DbSet<ImmunisationIndicationLink> ImmunisationIndicationLink { get; set; }
        public virtual DbSet<Immunisations> Immunisations { get; set; }
        public virtual DbSet<Immunisedagainst> Immunisedagainst { get; set; }
        public virtual DbSet<Incomingmail> Incomingmail { get; set; }
        public virtual DbSet<Incomingreports> Incomingreports { get; set; }
        public virtual DbSet<Incomingvalues> Incomingvalues { get; set; }
        public virtual DbSet<Inrdetail> Inrdetail { get; set; }
        public virtual DbSet<Inrvalues> Inrvalues { get; set; }
        public virtual DbSet<Instructioncodes> Instructioncodes { get; set; }
        public virtual DbSet<Internetappointments> Internetappointments { get; set; }
        public virtual DbSet<Investigationpages> Investigationpages { get; set; }
        public virtual DbSet<Investigations> Investigations { get; set; }
        public virtual DbSet<InvoiceDeposit> InvoiceDeposit { get; set; }
        public virtual DbSet<Invoicedeletereason> Invoicedeletereason { get; set; }
        public virtual DbSet<Invoicelock> Invoicelock { get; set; }
        public virtual DbSet<Invoicenotes> Invoicenotes { get; set; }
        public virtual DbSet<Invoices> Invoices { get; set; }
        public virtual DbSet<K10> K10 { get; set; }
        public virtual DbSet<Labcodes> Labcodes { get; set; }
        public virtual DbSet<Labellayouts> Labellayouts { get; set; }
        public virtual DbSet<Labels> Labels { get; set; }
        public virtual DbSet<Laboratories> Laboratories { get; set; }
        public virtual DbSet<Labouranalgesia> Labouranalgesia { get; set; }
        public virtual DbSet<Labouraugmentation> Labouraugmentation { get; set; }
        public virtual DbSet<Labourdelivery> Labourdelivery { get; set; }
        public virtual DbSet<Labouronset> Labouronset { get; set; }
        public virtual DbSet<Leafletcategories> Leafletcategories { get; set; }
        public virtual DbSet<Letterhead> Letterhead { get; set; }
        public virtual DbSet<Linkdetails> Linkdetails { get; set; }
        public virtual DbSet<Linkpaths> Linkpaths { get; set; }
        public virtual DbSet<Liveswith> Liveswith { get; set; }
        public virtual DbSet<Locations> Locations { get; set; }
        public virtual DbSet<LogDeletedReports> LogDeletedReports { get; set; }
        public virtual DbSet<LogPatientMerge> LogPatientMerge { get; set; }
        public virtual DbSet<LogPatientsIn> LogPatientsIn { get; set; }
        public virtual DbSet<LogReports> LogReports { get; set; }
        public virtual DbSet<LogResultFiles> LogResultFiles { get; set; }
        public virtual DbSet<Login> Login { get; set; }
        public virtual DbSet<Machinepreferences> Machinepreferences { get; set; }
        public virtual DbSet<Maolpaymentlock> Maolpaymentlock { get; set; }
        public virtual DbSet<Maolupdate> Maolupdate { get; set; }
        public virtual DbSet<Maritalstatus> Maritalstatus { get; set; }
        public virtual DbSet<MedicareAlias> MedicareAlias { get; set; }
        public virtual DbSet<Medicarebatch> Medicarebatch { get; set; }
        public virtual DbSet<Medicareeasyclaim> Medicareeasyclaim { get; set; }
        public virtual DbSet<Medisecure> Medisecure { get; set; }
        public virtual DbSet<Medrefercorrespondence> Medrefercorrespondence { get; set; }
        public virtual DbSet<Medreviewdetails> Medreviewdetails { get; set; }
        public virtual DbSet<Medview> Medview { get; set; }
        public virtual DbSet<Medviewconsent> Medviewconsent { get; set; }
        public virtual DbSet<Messagegroups> Messagegroups { get; set; }
        public virtual DbSet<Messagegroupusers> Messagegroupusers { get; set; }
        public virtual DbSet<Messages> Messages { get; set; }
        public virtual DbSet<Messagessent> Messagessent { get; set; }
        public virtual DbSet<Messagestatus> Messagestatus { get; set; }
        public virtual DbSet<Messagingpath> Messagingpath { get; set; }
        public virtual DbSet<Messagingproviders> Messagingproviders { get; set; }
        public virtual DbSet<Miscellaneous> Miscellaneous { get; set; }
        public virtual DbSet<Mmse> Mmse { get; set; }
        public virtual DbSet<Moldetails> Moldetails { get; set; }
        public virtual DbSet<NesnotificationParameters> NesnotificationParameters { get; set; }
        public virtual DbSet<NesnotificationStatus> NesnotificationStatus { get; set; }
        public virtual DbSet<Nesnotifications> Nesnotifications { get; set; }
        public virtual DbSet<Nextofkin> Nextofkin { get; set; }
        public virtual DbSet<Nirmessages> Nirmessages { get; set; }
        public virtual DbSet<Notify> Notify { get; set; }
        public virtual DbSet<Noyes> Noyes { get; set; }
        public virtual DbSet<Npsdetails> Npsdetails { get; set; }
        public virtual DbSet<NpsusageStatistics> NpsusageStatistics { get; set; }
        public virtual DbSet<Observations> Observations { get; set; }
        public virtual DbSet<ObservationsSnomed> ObservationsSnomed { get; set; }
        public virtual DbSet<Obsgyndetail> Obsgyndetail { get; set; }
        public virtual DbSet<Occupationhistory> Occupationhistory { get; set; }
        public virtual DbSet<Occupations> Occupations { get; set; }
        public virtual DbSet<Oedema> Oedema { get; set; }
        public virtual DbSet<Opdose> Opdose { get; set; }
        public virtual DbSet<Operations> Operations { get; set; }
        public virtual DbSet<Opioid> Opioid { get; set; }
        public virtual DbSet<Pain> Pain { get; set; }
        public virtual DbSet<Papresults> Papresults { get; set; }
        public virtual DbSet<Papsmears> Papsmears { get; set; }
        public virtual DbSet<Parameters> Parameters { get; set; }
        public virtual DbSet<Pasthistory> Pasthistory { get; set; }
        public virtual DbSet<Pastsmoking> Pastsmoking { get; set; }
        public virtual DbSet<PatientAppEnrolment> PatientAppEnrolment { get; set; }
        public virtual DbSet<PatientEnrolments> PatientEnrolments { get; set; }
        public virtual DbSet<PatientPatientgroup> PatientPatientgroup { get; set; }
        public virtual DbSet<PatientPreferenceClass> PatientPreferenceClass { get; set; }
        public virtual DbSet<PatientPreferences> PatientPreferences { get; set; }
        public virtual DbSet<PatientPresence> PatientPresence { get; set; }
        public virtual DbSet<PatientWhitecoat> PatientWhitecoat { get; set; }
        public virtual DbSet<Patientbankaccounts> Patientbankaccounts { get; set; }
        public virtual DbSet<Patientclaims> Patientclaims { get; set; }
        public virtual DbSet<Patientethnicity> Patientethnicity { get; set; }
        public virtual DbSet<Patientgroups> Patientgroups { get; set; }
        public virtual DbSet<Patientiwi> Patientiwi { get; set; }
        public virtual DbSet<Patientlogin> Patientlogin { get; set; }
        public virtual DbSet<Patientphoto> Patientphoto { get; set; }
        public virtual DbSet<Patients> Patients { get; set; }
        public virtual DbSet<Patientstatus> Patientstatus { get; set; }
        public virtual DbSet<Payer> Payer { get; set; }
        public virtual DbSet<PaymentClaims> PaymentClaims { get; set; }
        public virtual DbSet<PaymentRuns> PaymentRuns { get; set; }
        public virtual DbSet<PaymentService> PaymentService { get; set; }
        public virtual DbSet<Paymentdeletereason> Paymentdeletereason { get; set; }
        public virtual DbSet<PaymentpartService> PaymentpartService { get; set; }
        public virtual DbSet<Paymentparts> Paymentparts { get; set; }
        public virtual DbSet<Payments> Payments { get; set; }
        public virtual DbSet<Paymenttypes> Paymenttypes { get; set; }
        public virtual DbSet<Pcehraccess> Pcehraccess { get; set; }
        public virtual DbSet<Pcehrdocuments> Pcehrdocuments { get; set; }
        public virtual DbSet<Pedrec> Pedrec { get; set; }
        public virtual DbSet<PendingFiles> PendingFiles { get; set; }
        public virtual DbSet<Pensiontype> Pensiontype { get; set; }
        public virtual DbSet<Perineum> Perineum { get; set; }
        public virtual DbSet<Permissions> Permissions { get; set; }
        public virtual DbSet<Permissiontypes> Permissiontypes { get; set; }
        public virtual DbSet<Pharmacy> Pharmacy { get; set; }
        public virtual DbSet<Placenta> Placenta { get; set; }
        public virtual DbSet<Pmhfavourites> Pmhfavourites { get; set; }
        public virtual DbSet<Popdetails> Popdetails { get; set; }
        public virtual DbSet<Practice> Practice { get; set; }
        public virtual DbSet<Pregnancies> Pregnancies { get; set; }
        public virtual DbSet<Pregnancyimaging> Pregnancyimaging { get; set; }
        public virtual DbSet<Pregnancyoutcome> Pregnancyoutcome { get; set; }
        public virtual DbSet<Pregnancyresults> Pregnancyresults { get; set; }
        public virtual DbSet<Prescriptions> Prescriptions { get; set; }
        public virtual DbSet<Preventivehealth> Preventivehealth { get; set; }
        public virtual DbSet<Printers> Printers { get; set; }
        public virtual DbSet<ProcessReports> ProcessReports { get; set; }
        public virtual DbSet<ProductCombination> ProductCombination { get; set; }
        public virtual DbSet<Prompt> Prompt { get; set; }
        public virtual DbSet<ProviderLocation> ProviderLocation { get; set; }
        public virtual DbSet<Providerpayments> Providerpayments { get; set; }
        public virtual DbSet<Psidetails> Psidetails { get; set; }
        public virtual DbSet<QueueConfigurations> QueueConfigurations { get; set; }
        public virtual DbSet<Quoteitems> Quoteitems { get; set; }
        public virtual DbSet<Reactions> Reactions { get; set; }
        public virtual DbSet<Receipts> Receipts { get; set; }
        public virtual DbSet<Referrals> Referrals { get; set; }
        public virtual DbSet<RegistrationStatus> RegistrationStatus { get; set; }
        public virtual DbSet<Relations> Relations { get; set; }
        public virtual DbSet<Reminderbatch> Reminderbatch { get; set; }
        public virtual DbSet<Reminderlist> Reminderlist { get; set; }
        public virtual DbSet<Reminderreasons> Reminderreasons { get; set; }
        public virtual DbSet<Reminders> Reminders { get; set; }
        public virtual DbSet<Reminderssent> Reminderssent { get; set; }
        public virtual DbSet<Reportcomments> Reportcomments { get; set; }
        public virtual DbSet<Reportextensions> Reportextensions { get; set; }
        public virtual DbSet<Reportoptions> Reportoptions { get; set; }
        public virtual DbSet<Reportpaths> Reportpaths { get; set; }
        public virtual DbSet<Reportstore> Reportstore { get; set; }
        public virtual DbSet<Reportvalues> Reportvalues { get; set; }
        public virtual DbSet<Requestedtests> Requestedtests { get; set; }
        public virtual DbSet<Requestformatdetail> Requestformatdetail { get; set; }
        public virtual DbSet<Requestformats> Requestformats { get; set; }
        public virtual DbSet<Reservedappointments> Reservedappointments { get; set; }
        public virtual DbSet<Resultbatch> Resultbatch { get; set; }
        public virtual DbSet<Reversals> Reversals { get; set; }
        public virtual DbSet<Rh> Rh { get; set; }
        public virtual DbSet<Rooms> Rooms { get; set; }
        public virtual DbSet<Scriptitems> Scriptitems { get; set; }
        public virtual DbSet<Servicelogin> Servicelogin { get; set; }
        public virtual DbSet<Servicenotes> Servicenotes { get; set; }
        public virtual DbSet<Services> Services { get; set; }
        public virtual DbSet<Sessions> Sessions { get; set; }
        public virtual DbSet<Setting> Setting { get; set; }
        public virtual DbSet<Severitycodes> Severitycodes { get; set; }
        public virtual DbSet<Sex> Sex { get; set; }
        public virtual DbSet<Sexuality> Sexuality { get; set; }
        public virtual DbSet<Smokingstatus> Smokingstatus { get; set; }
        public virtual DbSet<Smokingtype> Smokingtype { get; set; }
        public virtual DbSet<Smscreditcodes> Smscreditcodes { get; set; }
        public virtual DbSet<Smsmessageid> Smsmessageid { get; set; }
        public virtual DbSet<Smsmessages> Smsmessages { get; set; }
        public virtual DbSet<Smsreplies> Smsreplies { get; set; }
        public virtual DbSet<SmsreplyKeywords> SmsreplyKeywords { get; set; }
        public virtual DbSet<SmsscheduleAppttype> SmsscheduleAppttype { get; set; }
        public virtual DbSet<SmsscheduleLocation> SmsscheduleLocation { get; set; }
        public virtual DbSet<SmsscheduleUser> SmsscheduleUser { get; set; }
        public virtual DbSet<Smsschedules> Smsschedules { get; set; }
        public virtual DbSet<Smstemplate> Smstemplate { get; set; }
        public virtual DbSet<Smtpdetails> Smtpdetails { get; set; }
        public virtual DbSet<Sonicdetails> Sonicdetails { get; set; }
        public virtual DbSet<Sonicpath> Sonicpath { get; set; }
        public virtual DbSet<Sonicrequest> Sonicrequest { get; set; }
        public virtual DbSet<Sterilisation> Sterilisation { get; set; }
        public virtual DbSet<Suid> Suid { get; set; }
        public virtual DbSet<Templatefaves> Templatefaves { get; set; }
        public virtual DbSet<Terminalreasons> Terminalreasons { get; set; }
        public virtual DbSet<Testitems> Testitems { get; set; }
        public virtual DbSet<Titles> Titles { get; set; }
        public virtual DbSet<Tobacco> Tobacco { get; set; }
        public virtual DbSet<Todolist> Todolist { get; set; }
        public virtual DbSet<Transactions> Transactions { get; set; }
        public virtual DbSet<Transidentity> Transidentity { get; set; }
        public virtual DbSet<Transmissions> Transmissions { get; set; }
        public virtual DbSet<Tyroeftpayments> Tyroeftpayments { get; set; }
        public virtual DbSet<Tyroefttransactions> Tyroefttransactions { get; set; }
        public virtual DbSet<Udfnames> Udfnames { get; set; }
        public virtual DbSet<Udfvalues> Udfvalues { get; set; }
        public virtual DbSet<Uhganswer> Uhganswer { get; set; }
        public virtual DbSet<Uhgquestion> Uhgquestion { get; set; }
        public virtual DbSet<Uhgreanswer> Uhgreanswer { get; set; }
        public virtual DbSet<Uhgreport> Uhgreport { get; set; }
        public virtual DbSet<Uhgreportsquestions> Uhgreportsquestions { get; set; }
        public virtual DbSet<Uhgselectedinformation> Uhgselectedinformation { get; set; }
        public virtual DbSet<Unsentclaims> Unsentclaims { get; set; }
        public virtual DbSet<Urine> Urine { get; set; }
        public virtual DbSet<UserNumbers> UserNumbers { get; set; }
        public virtual DbSet<UserReportLocations> UserReportLocations { get; set; }
        public virtual DbSet<Useralias> Useralias { get; set; }
        public virtual DbSet<Userdisplay> Userdisplay { get; set; }
        public virtual DbSet<Usergroups> Usergroups { get; set; }
        public virtual DbSet<Userpermissions> Userpermissions { get; set; }
        public virtual DbSet<Userpreferences> Userpreferences { get; set; }
        public virtual DbSet<Userprocedures> Userprocedures { get; set; }
        public virtual DbSet<Userqualifications> Userqualifications { get; set; }
        public virtual DbSet<Userreports> Userreports { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<Vaccinebatch> Vaccinebatch { get; set; }
        public virtual DbSet<Vipdata> Vipdata { get; set; }
        public virtual DbSet<Vipfields> Vipfields { get; set; }
        public virtual DbSet<Visitexamination> Visitexamination { get; set; }
        public virtual DbSet<Visithistory> Visithistory { get; set; }
        public virtual DbSet<Visitjoint> Visitjoint { get; set; }
        public virtual DbSet<Visitlesion> Visitlesion { get; set; }
        public virtual DbSet<Visitlock> Visitlock { get; set; }
        public virtual DbSet<Visitlump> Visitlump { get; set; }
        public virtual DbSet<Visitmbs> Visitmbs { get; set; }
        public virtual DbSet<Visitparameters> Visitparameters { get; set; }
        public virtual DbSet<Visitreason> Visitreason { get; set; }
        public virtual DbSet<Visits> Visits { get; set; }
        public virtual DbSet<Visittext> Visittext { get; set; }
        public virtual DbSet<Visittype> Visittype { get; set; }
        public virtual DbSet<WindowsUserGroup> WindowsUserGroup { get; set; }
        public virtual DbSet<WorkCoverQldproviderAccounts> WorkCoverQldproviderAccounts { get; set; }
        public virtual DbSet<Workcover> Workcover { get; set; }
        public virtual DbSet<Workcoverdetails> Workcoverdetails { get; set; }
        public virtual DbSet<Workcoveritems> Workcoveritems { get; set; }
        public virtual DbSet<Workcovertext> Workcovertext { get; set; }
        public virtual DbSet<Workcoverusersqld> Workcoverusersqld { get; set; }
        public virtual DbSet<Wptemplates> Wptemplates { get; set; }
        public virtual DbSet<Yesno> Yesno { get; set; }
        public virtual DbSet<Yesnoblank> Yesnoblank { get; set; }
        public virtual DbSet<Yesnounknown> Yesnounknown { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-UG65FTO\\BPSINSTANCE;Database=BPSPatients;User ID=BPSRawData;Password=Ghada123;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:DefaultSchema", "bpsrawdata");

            modelBuilder.Entity<Accident>(entity =>
            {
                entity.HasKey(e => e.Recordid);

                entity.ToTable("ACCIDENT", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Accidentdate)
                    .HasColumnName("ACCIDENTDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Accidentinnz).HasColumnName("ACCIDENTINNZ");

                entity.Property(e => e.Activitycode).HasColumnName("ACTIVITYCODE");

                entity.Property(e => e.Causeofinjury)
                    .HasColumnName("CAUSEOFINJURY")
                    .HasMaxLength(750)
                    .IsUnicode(false);

                entity.Property(e => e.Claimnotes)
                    .HasColumnName("CLAIMNOTES")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Claimnum)
                    .HasColumnName("CLAIMNUM")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Consultdate)
                    .HasColumnName("CONSULTDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Dischargedate)
                    .HasColumnName("DISCHARGEDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Employmentgradual).HasColumnName("EMPLOYMENTGRADUAL");

                entity.Property(e => e.Employmentstatus).HasColumnName("EMPLOYMENTSTATUS");

                entity.Property(e => e.Formsession)
                    .HasColumnName("FORMSESSION")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Injurynotes)
                    .HasColumnName("INJURYNOTES")
                    .HasMaxLength(750)
                    .IsUnicode(false);

                entity.Property(e => e.Insurer).HasColumnName("INSURER");

                entity.Property(e => e.Internalid).HasColumnName("INTERNALID");

                entity.Property(e => e.Locationcode).HasColumnName("LOCATIONCODE");

                entity.Property(e => e.Masterclaim)
                    .HasColumnName("MASTERCLAIM")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Motorvehicleroad).HasColumnName("MOTORVEHICLEROAD");

                entity.Property(e => e.Occupationcode).HasColumnName("OCCUPATIONCODE");

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Scenecode).HasColumnName("SCENECODE");

                entity.Property(e => e.Sportcode).HasColumnName("SPORTCODE");

                entity.Property(e => e.Treatmentinjury).HasColumnName("TREATMENTINJURY");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.Property(e => e.Workrelated).HasColumnName("WORKRELATED");

                entity.Property(e => e.Worktype).HasColumnName("WORKTYPE");

                entity.HasOne(d => d.Internal)
                    .WithMany(p => p.Accident)
                    .HasForeignKey(d => d.Internalid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ACCIDENT_PATIENTS");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Accident)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ACCIDENT_USERS");
            });

            modelBuilder.Entity<Accidentdiagnosis>(entity =>
            {
                entity.HasKey(e => e.Recordid);

                entity.ToTable("ACCIDENTDIAGNOSIS", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Claimid).HasColumnName("CLAIMID");

                entity.Property(e => e.Codesystem)
                    .IsRequired()
                    .HasColumnName("CODESYSTEM")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Injurycode).HasColumnName("INJURYCODE");

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Sidecode).HasColumnName("SIDECODE");

                entity.HasOne(d => d.Claim)
                    .WithMany(p => p.Accidentdiagnosis)
                    .HasForeignKey(d => d.Claimid)
                    .HasConstraintName("FK_ACCIDENTDIAGNOSIS_ACCIDENT");
            });

            modelBuilder.Entity<Accidentlink>(entity =>
            {
                entity.HasKey(e => new { e.Claimid, e.Appointmentid, e.Visitid });

                entity.ToTable("ACCIDENTLINK", "dbo");

                entity.Property(e => e.Claimid).HasColumnName("CLAIMID");

                entity.Property(e => e.Appointmentid).HasColumnName("APPOINTMENTID");

                entity.Property(e => e.Visitid).HasColumnName("VISITID");

                entity.HasOne(d => d.Claim)
                    .WithMany(p => p.Accidentlink)
                    .HasForeignKey(d => d.Claimid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AccidentLink_ACCIDENT");
            });

            modelBuilder.Entity<Accomodation>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ACCOMODATION", "dbo");

                entity.Property(e => e.Accomodationcode).HasColumnName("ACCOMODATIONCODE");

                entity.Property(e => e.Accomodationtext)
                    .HasColumnName("ACCOMODATIONTEXT")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Accounttext>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__ACCOUNTTEXT__233F2673");

                entity.ToTable("ACCOUNTTEXT", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasColumnName("CONTENT")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Locationid).HasColumnName("LOCATIONID");

                entity.Property(e => e.Overdueby).HasColumnName("OVERDUEBY");

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Textcode).HasColumnName("TEXTCODE");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");
            });

            modelBuilder.Entity<Accounttype>(entity =>
            {
                entity.HasKey(e => e.Accountcode)
                    .HasName("PK__ACCOUNTTYPE__73BA3083");

                entity.ToTable("ACCOUNTTYPE", "dbo");

                entity.Property(e => e.Accountcode)
                    .HasColumnName("ACCOUNTCODE")
                    .ValueGeneratedNever();

                entity.Property(e => e.Accounttype1)
                    .IsRequired()
                    .HasColumnName("ACCOUNTTYPE")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Acirbatches>(entity =>
            {
                entity.HasKey(e => e.Batchid)
                    .HasName("PK__ACIRBatches__4A23E96A");

                entity.ToTable("ACIRBatches", "dbo");

                entity.Property(e => e.Batchid).HasColumnName("BATCHID");

                entity.Property(e => e.Batchdate)
                    .HasColumnName("BATCHDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Batchnumber)
                    .HasColumnName("BATCHNUMBER")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Providerno)
                    .HasColumnName("PROVIDERNO")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Userid).HasColumnName("USERID");
            });

            modelBuilder.Entity<Acknowledgements>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__ACKNOWLEDGEMENTS__286302EC");

                entity.ToTable("ACKNOWLEDGEMENTS", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Acknowledge).HasColumnName("ACKNOWLEDGE");

                entity.Property(e => e.Ackpath)
                    .HasColumnName("ACKPATH")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Facility)
                    .IsRequired()
                    .HasColumnName("FACILITY")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Actionitems>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__ACTIONITEMS__42ACE4D4");

                entity.ToTable("ACTIONITEMS", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Au).HasColumnName("AU");

                entity.Property(e => e.Displayorder).HasColumnName("DISPLAYORDER");

                entity.Property(e => e.Itemtext)
                    .IsRequired()
                    .HasColumnName("ITEMTEXT")
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Nz).HasColumnName("NZ");

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Userid).HasColumnName("USERID");
            });

            modelBuilder.Entity<Actions>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__ACTIONS__467D75B8");

                entity.ToTable("ACTIONS", "dbo");

                entity.HasIndex(e => e.Duedate)
                    .HasName("ACTIONS1");

                entity.HasIndex(e => e.Priority)
                    .HasName("ACTIONS3");

                entity.HasIndex(e => e.Userid)
                    .HasName("ACTIONS2");

                entity.HasIndex(e => new { e.Userid, e.Duedate })
                    .HasName("ACTIONS4");

                entity.HasIndex(e => new { e.Userid, e.Priority, e.Duedate })
                    .HasName("ACTIONS5");

                entity.HasIndex(e => new { e.Recordid, e.Actiontext, e.Added, e.Performed, e.Statustext, e.Created, e.Createdby, e.Updated, e.Updatedby, e.Internalid, e.Recordstatus, e.Actionstatus, e.Performedby, e.Userid, e.Priority, e.Duedate })
                    .HasName("ACTIONS6");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Actionstatus).HasColumnName("ACTIONSTATUS");

                entity.Property(e => e.Actiontext)
                    .IsRequired()
                    .HasColumnName("ACTIONTEXT")
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Added)
                    .HasColumnName("ADDED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Comment)
                    .HasColumnName("COMMENT")
                    .HasColumnType("text");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Duedate)
                    .HasColumnName("DUEDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Internalid).HasColumnName("INTERNALID");

                entity.Property(e => e.Performed)
                    .HasColumnName("PERFORMED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Performedby).HasColumnName("PERFORMEDBY");

                entity.Property(e => e.Previoususerid).HasColumnName("PREVIOUSUSERID");

                entity.Property(e => e.Priority).HasColumnName("PRIORITY");

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Statustext)
                    .HasColumnName("STATUSTEXT")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.HasOne(d => d.Internal)
                    .WithMany(p => p.Actions)
                    .HasForeignKey(d => d.Internalid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ACTIONS__INTERNA__4C364F0E");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Actions)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ACTIONS__USERID__4D2A7347");
            });

            modelBuilder.Entity<Activecodes>(entity =>
            {
                entity.HasKey(e => e.Activecode)
                    .HasName("PK__ACTIVECODES__46E78A0C");

                entity.ToTable("ACTIVECODES", "dbo");

                entity.Property(e => e.Activecode)
                    .HasColumnName("ACTIVECODE")
                    .ValueGeneratedNever();

                entity.Property(e => e.Activestatus)
                    .IsRequired()
                    .HasColumnName("ACTIVESTATUS")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Acupunctureconditions>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__ACUPUNCTURECONDI__08211BE3");

                entity.ToTable("ACUPUNCTURECONDITIONS", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Condition)
                    .HasColumnName("CONDITION")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Severity).HasColumnName("SEVERITY");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Visitid).HasColumnName("VISITID");

                entity.HasOne(d => d.Visit)
                    .WithMany(p => p.Acupunctureconditions)
                    .HasForeignKey(d => d.Visitid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ACUPUNCTU__VISIT__0A096455");
            });

            modelBuilder.Entity<Acupuncturevisits>(entity =>
            {
                entity.HasKey(e => e.Visitid)
                    .HasName("PK__ACUPUNCTUREVISIT__035C66C6");

                entity.ToTable("ACUPUNCTUREVISITS", "dbo");

                entity.Property(e => e.Visitid).HasColumnName("VISITID");

                entity.Property(e => e.Acupuncturedate)
                    .HasColumnName("ACUPUNCTUREDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Acupuncturepoints)
                    .HasColumnName("ACUPUNCTUREPOINTS")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Acupuncturetime).HasColumnName("ACUPUNCTURETIME");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Internalid).HasColumnName("INTERNALID");

                entity.Property(e => e.Pulse)
                    .HasColumnName("PULSE")
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Tongue)
                    .HasColumnName("TONGUE")
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.HasOne(d => d.Internal)
                    .WithMany(p => p.Acupuncturevisits)
                    .HasForeignKey(d => d.Internalid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ACUPUNCTU__INTER__0544AF38");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Acupuncturevisits)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ACUPUNCTU__USERI__0638D371");
            });

            modelBuilder.Entity<Adfoccupation>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__ADFOCCUPATION__723CC7BC");

                entity.ToTable("ADFOCCUPATION", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Adfcode).HasColumnName("ADFCODE");

                entity.Property(e => e.Adfprompt).HasColumnName("ADFPROMPT");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Internalid).HasColumnName("INTERNALID");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.HasOne(d => d.Internal)
                    .WithMany(p => p.Adfoccupation)
                    .HasForeignKey(d => d.Internalid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ADFOCCUPA__INTER__75193467");
            });

            modelBuilder.Entity<Adjustments>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__ADJUSTMENTS__03275C9C");

                entity.ToTable("ADJUSTMENTS", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Adjustment).HasColumnName("ADJUSTMENT");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Invoiceid).HasColumnName("INVOICEID");

                entity.Property(e => e.Serviceid).HasColumnName("SERVICEID");

                entity.Property(e => e.Writeoff).HasColumnName("WRITEOFF");
            });

            modelBuilder.Entity<Admissionconditions>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__ADMISSIONCONDITI__6B4FD30B");

                entity.ToTable("ADMISSIONCONDITIONS", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Admissionid).HasColumnName("ADMISSIONID");

                entity.Property(e => e.Conditioncode).HasColumnName("CONDITIONCODE");

                entity.Property(e => e.Conditiondate)
                    .HasColumnName("CONDITIONDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");
            });

            modelBuilder.Entity<Admissiondetails>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__ADMISSIONDETAILS__677F4227");

                entity.ToTable("ADMISSIONDETAILS", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Admissionid).HasColumnName("ADMISSIONID");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");
            });

            modelBuilder.Entity<Admissionfollowup>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__ADMISSIONFOLLOWU__70148828");

                entity.ToTable("ADMISSIONFOLLOWUP", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Admissionid).HasColumnName("ADMISSIONID");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Followupdate)
                    .HasColumnName("FOLLOWUPDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Followuptime)
                    .HasColumnName("FOLLOWUPTIME")
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Followupwhen)
                    .HasColumnName("FOLLOWUPWHEN")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Followupwith)
                    .HasColumnName("FOLLOWUPWITH")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");
            });

            modelBuilder.Entity<Admissions>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__ADMISSIONS__4F12BBB9");

                entity.ToTable("ADMISSIONS", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Admissiondate)
                    .HasColumnName("ADMISSIONDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Bed)
                    .HasColumnName("BED")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Condition)
                    .HasColumnName("CONDITION")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Conditioncode)
                    .HasColumnName("CONDITIONCODE")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Dischargecode).HasColumnName("DISCHARGECODE");

                entity.Property(e => e.Dischargedate)
                    .HasColumnName("DISCHARGEDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Internalid).HasColumnName("INTERNALID");

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Treatedby)
                    .HasColumnName("TREATEDBY")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.Property(e => e.Usualgp).HasColumnName("USUALGP");

                entity.Property(e => e.Ward)
                    .HasColumnName("WARD")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.Internal)
                    .WithMany(p => p.Admissions)
                    .HasForeignKey(d => d.Internalid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ADMISSION__INTER__53D770D6");
            });

            modelBuilder.Entity<Adrac>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__ADRAC__55BFB948");

                entity.ToTable("ADRAC", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Batch)
                    .HasColumnName("BATCH")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Comments)
                    .HasColumnName("COMMENTS")
                    .HasColumnType("text");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasColumnType("text");

                entity.Property(e => e.Dose)
                    .HasColumnName("DOSE")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Drugname)
                    .HasColumnName("DRUGNAME")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Form)
                    .HasColumnName("FORM")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Frequency)
                    .HasColumnName("FREQUENCY")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Includepmh)
                    .HasColumnName("INCLUDEPMH")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Includerx)
                    .HasColumnName("INCLUDERX")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Indication)
                    .HasColumnName("INDICATION")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Internalid).HasColumnName("INTERNALID");

                entity.Property(e => e.Messageid)
                    .HasColumnName("MESSAGEID")
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Onsetdate)
                    .HasColumnName("ONSETDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Outcome)
                    .HasColumnName("OUTCOME")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Outdate)
                    .HasColumnName("OUTDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Productid).HasColumnName("PRODUCTID");

                entity.Property(e => e.Reacfreq)
                    .HasColumnName("REACFREQ")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Reaction)
                    .HasColumnName("REACTION")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Recdate)
                    .HasColumnName("RECDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Route)
                    .HasColumnName("ROUTE")
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sequelae)
                    .HasColumnName("SEQUELAE")
                    .HasColumnType("text");

                entity.Property(e => e.Severity)
                    .HasColumnName("SEVERITY")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Startdate)
                    .HasColumnName("STARTDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Stopdate)
                    .HasColumnName("STOPDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Treatedat)
                    .HasColumnName("TREATEDAT")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Treatment)
                    .HasColumnName("TREATMENT")
                    .HasColumnType("text");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.Property(e => e.Weight)
                    .HasColumnName("WEIGHT")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.Internal)
                    .WithMany(p => p.Adrac)
                    .HasForeignKey(d => d.Internalid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ADRAC__INTERNALI__589C25F3");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Adrac)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ADRAC__USERID__59904A2C");
            });

            modelBuilder.Entity<Alcohol>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__ALCOHOL__084B3915");

                entity.ToTable("ALCOHOL", "dbo");

                entity.HasIndex(e => new { e.Recordstatus, e.Internalid })
                    .HasName("ALCOHOL1");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Alcoholcode).HasColumnName("ALCOHOLCODE");

                entity.Property(e => e.Alcoholtext)
                    .HasColumnName("ALCOHOLTEXT")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Comment)
                    .HasColumnName("COMMENT")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Daysperweek).HasColumnName("DAYSPERWEEK");

                entity.Property(e => e.Drinksperday).HasColumnName("DRINKSPERDAY");

                entity.Property(e => e.Internalid).HasColumnName("INTERNALID");

                entity.Property(e => e.Pastalcohollevel).HasColumnName("PASTALCOHOLLEVEL");

                entity.Property(e => e.Pastdaysperweek).HasColumnName("PASTDAYSPERWEEK");

                entity.Property(e => e.Pastdrinksperday).HasColumnName("PASTDRINKSPERDAY");

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Yearstarted).HasColumnName("YEARSTARTED");

                entity.Property(e => e.Yearstopped).HasColumnName("YEARSTOPPED");

                entity.HasOne(d => d.Internal)
                    .WithMany(p => p.Alcohol)
                    .HasForeignKey(d => d.Internalid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ALCOHOL__INTERNA__11D4A34F");
            });

            modelBuilder.Entity<Alcoholstatus>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ALCOHOLSTATUS", "dbo");

                entity.Property(e => e.Alcoholcode).HasColumnName("ALCOHOLCODE");

                entity.Property(e => e.Alcoholtext)
                    .HasColumnName("ALCOHOLTEXT")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Amafees>(entity =>
            {
                entity.HasKey(e => e.Itemid)
                    .HasName("PK__AMAFEES__615C547D");

                entity.ToTable("AMAFEES", "dbo");

                entity.Property(e => e.Itemid).HasColumnName("ITEMID");

                entity.Property(e => e.Amacode)
                    .HasColumnName("AMACODE")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Amount).HasColumnName("AMOUNT");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Gst).HasColumnName("GST");

                entity.Property(e => e.Itemcode).HasColumnName("ITEMCODE");

                entity.Property(e => e.Mbsitem).HasColumnName("MBSITEM");

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");
            });

            modelBuilder.Entity<Anengagement>(entity =>
            {
                entity.HasKey(e => e.Engagementcode)
                    .HasName("PK__ANENGAGEMENT__01142BA1");

                entity.ToTable("ANENGAGEMENT", "dbo");

                entity.Property(e => e.Engagementcode)
                    .HasColumnName("ENGAGEMENTCODE")
                    .ValueGeneratedNever();

                entity.Property(e => e.Engagement)
                    .IsRequired()
                    .HasColumnName("ENGAGEMENT")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Anposition>(entity =>
            {
                entity.HasKey(e => e.Positioncode)
                    .HasName("PK__ANPOSITION__7F2BE32F");

                entity.ToTable("ANPOSITION", "dbo");

                entity.Property(e => e.Positioncode)
                    .HasColumnName("POSITIONCODE")
                    .ValueGeneratedNever();

                entity.Property(e => e.Position)
                    .IsRequired()
                    .HasColumnName("POSITION")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Anpresentation>(entity =>
            {
                entity.HasKey(e => e.Presentationcode)
                    .HasName("PK__ANPRESENTATION__7D439ABD");

                entity.ToTable("ANPRESENTATION", "dbo");

                entity.Property(e => e.Presentationcode)
                    .HasColumnName("PRESENTATIONCODE")
                    .ValueGeneratedNever();

                entity.Property(e => e.Presentation)
                    .IsRequired()
                    .HasColumnName("PRESENTATION")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<AntenatalOther>(entity =>
            {
                entity.HasKey(e => e.Resultid)
                    .HasName("PK__AntenatalOther__70B3A6A6");

                entity.ToTable("AntenatalOther", "dbo");

                entity.Property(e => e.Resultid).HasColumnName("RESULTID");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Internalid).HasColumnName("INTERNALID");

                entity.Property(e => e.Pregnancyid).HasColumnName("PREGNANCYID");

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Resultdate)
                    .HasColumnName("RESULTDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Resultname)
                    .IsRequired()
                    .HasColumnName("RESULTNAME")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Resultvalue)
                    .HasColumnName("RESULTVALUE")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.HasOne(d => d.Internal)
                    .WithMany(p => p.AntenatalOther)
                    .HasForeignKey(d => d.Internalid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Antenatal__INTER__729BEF18");
            });

            modelBuilder.Entity<AntenatalResults>(entity =>
            {
                entity.HasKey(e => e.Resultid)
                    .HasName("PK__AntenatalResults__672A3C6C");

                entity.ToTable("AntenatalResults", "dbo");

                entity.Property(e => e.Resultid).HasColumnName("RESULTID");

                entity.Property(e => e.Antibody1)
                    .HasColumnName("ANTIBODY1")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Antibody2)
                    .HasColumnName("ANTIBODY2")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Antibody3)
                    .HasColumnName("ANTIBODY3")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Cmv).HasColumnName("CMV");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Det)
                    .HasColumnName("DET")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Gtt)
                    .HasColumnName("GTT")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Hb1)
                    .HasColumnName("HB1")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Hb2)
                    .HasColumnName("HB2")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Hb3)
                    .HasColumnName("HB3")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Hepatitisb).HasColumnName("HEPATITISB");

                entity.Property(e => e.Hepatitisc).HasColumnName("HEPATITISC");

                entity.Property(e => e.Hiv).HasColumnName("HIV");

                entity.Property(e => e.Internalid).HasColumnName("INTERNALID");

                entity.Property(e => e.Pregnancyid).HasColumnName("PREGNANCYID");

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Resultdate1)
                    .HasColumnName("RESULTDATE1")
                    .HasColumnType("datetime");

                entity.Property(e => e.Resultdate2)
                    .HasColumnName("RESULTDATE2")
                    .HasColumnType("datetime");

                entity.Property(e => e.Resultdate3)
                    .HasColumnName("RESULTDATE3")
                    .HasColumnType("datetime");

                entity.Property(e => e.Rubella).HasColumnName("RUBELLA");

                entity.Property(e => e.Syphilis).HasColumnName("SYPHILIS");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Urine)
                    .HasColumnName("URINE")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.Internal)
                    .WithMany(p => p.AntenatalResults)
                    .HasForeignKey(d => d.Internalid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Antenatal__INTER__6ECB5E34");
            });

            modelBuilder.Entity<Antenatalvisits>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__ANTENATALVISITS__0C3BC58A");

                entity.ToTable("ANTENATALVISITS", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Ankleoedema).HasColumnName("ANKLEOEDEMA");

                entity.Property(e => e.Clinicalsize).HasColumnName("CLINICALSIZE");

                entity.Property(e => e.Comment)
                    .HasColumnName("COMMENT")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Crl).HasColumnName("CRL");

                entity.Property(e => e.Diastolic).HasColumnName("DIASTOLIC");

                entity.Property(e => e.Engaged).HasColumnName("ENGAGED");

                entity.Property(e => e.Foetalheart).HasColumnName("FOETALHEART");

                entity.Property(e => e.Foetalheartrate).HasColumnName("FOETALHEARTRATE");

                entity.Property(e => e.Fundusheight).HasColumnName("FUNDUSHEIGHT");

                entity.Property(e => e.Glucose).HasColumnName("GLUCOSE");

                entity.Property(e => e.Internalid).HasColumnName("INTERNALID");

                entity.Property(e => e.Movements).HasColumnName("MOVEMENTS");

                entity.Property(e => e.Position).HasColumnName("POSITION");

                entity.Property(e => e.Pregnancyid).HasColumnName("PREGNANCYID");

                entity.Property(e => e.Presentation).HasColumnName("PRESENTATION");

                entity.Property(e => e.Protein).HasColumnName("PROTEIN");

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Sizebydates).HasColumnName("SIZEBYDATES");

                entity.Property(e => e.Systolic).HasColumnName("SYSTOLIC");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Urine)
                    .HasColumnName("URINE")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.Property(e => e.Visitdate)
                    .HasColumnName("VISITDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Visitid).HasColumnName("VISITID");

                entity.Property(e => e.Weight)
                    .HasColumnName("WEIGHT")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.Internal)
                    .WithMany(p => p.Antenatalvisits)
                    .HasForeignKey(d => d.Internalid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ANTENATAL__INTER__1D66518C");

                entity.HasOne(d => d.Pregnancy)
                    .WithMany(p => p.Antenatalvisits)
                    .HasForeignKey(d => d.Pregnancyid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ANTENATAL__PREGN__1F4E99FE");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Antenatalvisits)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ANTENATAL__USERI__1E5A75C5");

                entity.HasOne(d => d.Visit)
                    .WithMany(p => p.Antenatalvisits)
                    .HasForeignKey(d => d.Visitid)
                    .HasConstraintName("FK__ANTENATAL__VISIT__2042BE37");
            });

            modelBuilder.Entity<Appointmentcodes>(entity =>
            {
                entity.HasKey(e => e.Appointmentcode)
                    .HasName("PK__APPOINTMENTCODES__37D02F05");

                entity.ToTable("APPOINTMENTCODES", "dbo");

                entity.Property(e => e.Appointmentcode)
                    .HasColumnName("APPOINTMENTCODE")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Appointmentlayout>(entity =>
            {
                entity.HasKey(e => e.Layoutid)
                    .HasName("PK__APPOINTMENTLAYOU__2FFA0313");

                entity.ToTable("APPOINTMENTLAYOUT", "dbo");

                entity.Property(e => e.Layoutid).HasColumnName("LAYOUTID");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Layoutname)
                    .HasColumnName("LAYOUTNAME")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Locationid).HasColumnName("LOCATIONID");

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");
            });

            modelBuilder.Entity<Appointmentlayoutusers>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__APPOINTMENTLAYOU__32D66FBE");

                entity.ToTable("APPOINTMENTLAYOUTUSERS", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Layoutid).HasColumnName("LAYOUTID");

                entity.Property(e => e.Locationid).HasColumnName("LOCATIONID");

                entity.Property(e => e.Position).HasColumnName("POSITION");

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Userid).HasColumnName("USERID");
            });

            modelBuilder.Entity<Appointmentlocks>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__APPOINTM__84D4D4F5A145CFB9");

                entity.ToTable("APPOINTMENTLOCKS", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Appointmentdate)
                    .HasColumnName("APPOINTMENTDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Appointmenttime).HasColumnName("APPOINTMENTTIME");

                entity.Property(e => e.Computer)
                    .HasColumnName("COMPUTER")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Userid).HasColumnName("USERID");
            });

            modelBuilder.Entity<Appointmentnotes>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__APPOINTMENTNOTES__2DBCB4E6");

                entity.ToTable("APPOINTMENTNOTES", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Appointmentnote)
                    .IsRequired()
                    .HasColumnName("APPOINTMENTNOTE")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Internalid).HasColumnName("INTERNALID");

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");
            });

            modelBuilder.Entity<Appointments>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__APPOINTMENTS__118A8A8C");

                entity.ToTable("APPOINTMENTS", "dbo");

                entity.HasIndex(e => e.Appointmentdate)
                    .HasName("APPOINTMENTS2");

                entity.HasIndex(e => e.Userid)
                    .HasName("APPOINTMENTS1");

                entity.HasIndex(e => new { e.Userid, e.Appointmenttime })
                    .HasName("APPOINTMENTS3");

                entity.HasIndex(e => new { e.Internalid, e.Recordstatus, e.Appointmentcode, e.Appointmentdate })
                    .HasName("APPOINTMENTS4");

                entity.HasIndex(e => new { e.Recordid, e.Internalid, e.Userid, e.Appointmenttime, e.Appointmentlength, e.Appointmentcode, e.Appointmenttype, e.Reason, e.Arrivaltime, e.Consultationtime, e.Roomid, e.Created, e.Createdby, e.Updatedby, e.Updated, e.Bookedby, e.Urgent, e.Accounttype, e.Nnac, e.Itemlist, e.Comment, e.Visitid, e.Visitlength, e.Locationid, e.Patients, e.Operationid, e.Remindersentdate, e.Attendanceconfirmed, e.Attendanceupdated, e.Followup, e.Recordstatus, e.Appointmentdate })
                    .HasName("Appointments_RecordStatusAppointmentDate");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Accounttype).HasColumnName("ACCOUNTTYPE");

                entity.Property(e => e.Appointmentcode).HasColumnName("APPOINTMENTCODE");

                entity.Property(e => e.Appointmentdate)
                    .HasColumnName("APPOINTMENTDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Appointmentlength).HasColumnName("APPOINTMENTLENGTH");

                entity.Property(e => e.Appointmenttime).HasColumnName("APPOINTMENTTIME");

                entity.Property(e => e.Appointmenttype).HasColumnName("APPOINTMENTTYPE");

                entity.Property(e => e.Arrivaltime).HasColumnName("ARRIVALTIME");

                entity.Property(e => e.Attendanceconfirmed).HasColumnName("ATTENDANCECONFIRMED");

                entity.Property(e => e.Attendanceupdated)
                    .HasColumnName("ATTENDANCEUPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Attendanceupdatedby).HasColumnName("ATTENDANCEUPDATEDBY");

                entity.Property(e => e.Bookedby).HasColumnName("BOOKEDBY");

                entity.Property(e => e.Comment)
                    .HasColumnName("COMMENT")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Consultationtime).HasColumnName("CONSULTATIONTIME");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Followup).HasColumnName("FOLLOWUP");

                entity.Property(e => e.Internalid).HasColumnName("INTERNALID");

                entity.Property(e => e.Itemlist)
                    .HasColumnName("ITEMLIST")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Locationid).HasColumnName("LOCATIONID");

                entity.Property(e => e.Nnac).HasColumnName("NNAC");

                entity.Property(e => e.Operationid).HasColumnName("OPERATIONID");

                entity.Property(e => e.Patients).HasColumnName("PATIENTS");

                entity.Property(e => e.Reason)
                    .HasColumnName("REASON")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Remindersent).HasColumnName("REMINDERSENT");

                entity.Property(e => e.Remindersentdate)
                    .HasColumnName("REMINDERSENTDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Remindersentuserid).HasColumnName("REMINDERSENTUSERID");

                entity.Property(e => e.Roomid).HasColumnName("ROOMID");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Urgent).HasColumnName("URGENT");

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.Property(e => e.Videourl)
                    .HasColumnName("VIDEOURL")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Visitid).HasColumnName("VISITID");

                entity.Property(e => e.Visitlength).HasColumnName("VISITLENGTH");

                entity.HasOne(d => d.Internal)
                    .WithMany(p => p.Appointments)
                    .HasForeignKey(d => d.Internalid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__APPOINTME__INTER__1FD8A9E3");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.Appointments)
                    .HasForeignKey(d => d.Locationid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LOCATIONIDAPPOINTMENTS_LOCATIONIDLOCATIONS");

                entity.HasOne(d => d.Room)
                    .WithMany(p => p.Appointments)
                    .HasForeignKey(d => d.Roomid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__APPOINTME__ROOMI__1EE485AA");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AppointmentsNavigation)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__APPOINTME__USERI__20CCCE1C");
            });

            modelBuilder.Entity<Appointmenttypes>(entity =>
            {
                entity.HasKey(e => e.Appointmentcode)
                    .HasName("PK__APPOINTMENTTYPES__29820FAE");

                entity.ToTable("APPOINTMENTTYPES", "dbo");

                entity.Property(e => e.Appointmentcode).HasColumnName("APPOINTMENTCODE");

                entity.Property(e => e.Appointmentlength).HasColumnName("APPOINTMENTLENGTH");

                entity.Property(e => e.Au).HasColumnName("AU");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Iconindex).HasColumnName("ICONINDEX");

                entity.Property(e => e.Listorder).HasColumnName("LISTORDER");

                entity.Property(e => e.Nz).HasColumnName("NZ");

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");
            });

            modelBuilder.Entity<Argussetup>(entity =>
            {
                entity.HasKey(e => e.Recordid);

                entity.ToTable("ARGUSSETUP", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Arguspw)
                    .HasColumnName("ARGUSPW")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Argususer)
                    .HasColumnName("ARGUSUSER")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Port).HasColumnName("PORT");

                entity.Property(e => e.Servername)
                    .HasColumnName("SERVERNAME")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");
            });

            modelBuilder.Entity<Asthmaplan>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__ASTHMAPLAN__2C88998B");

                entity.ToTable("ASTHMAPLAN", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Bestpefr).HasColumnName("BESTPEFR");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Emergency)
                    .HasColumnName("EMERGENCY")
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.Exercise)
                    .HasColumnName("EXERCISE")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Internalid).HasColumnName("INTERNALID");

                entity.Property(e => e.Mild)
                    .HasColumnName("MILD")
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.Moderate)
                    .HasColumnName("MODERATE")
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.Plandate)
                    .HasColumnName("PLANDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Severe)
                    .HasColumnName("SEVERE")
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.HasOne(d => d.Internal)
                    .WithMany(p => p.Asthmaplan)
                    .HasForeignKey(d => d.Internalid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ASTHMAPLA__INTER__2F650636");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Asthmaplan)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ASTHMAPLA__USERI__30592A6F");
            });

            modelBuilder.Entity<Auditc>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__AUDITC__84D4D4F51D5D76E7");

                entity.ToTable("AUDITC", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Auditcdate)
                    .HasColumnName("AUDITCDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Internalid).HasColumnName("INTERNALID");

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Score).HasColumnName("SCORE");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.HasOne(d => d.Internal)
                    .WithMany(p => p.Auditc)
                    .HasForeignKey(d => d.Internalid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AUDITC__INTERNAL__3059F5C6");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Auditc)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AUDITC__USERID__314E19FF");
            });

            modelBuilder.Entity<Auditlog>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__AUDITLOG__84D4D4F54381305A");

                entity.ToTable("AUDITLOG", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Computer)
                    .HasColumnName("COMPUTER")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Details)
                    .HasColumnName("DETAILS")
                    .HasColumnType("text");

                entity.Property(e => e.Internalid).HasColumnName("INTERNALID");

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Source)
                    .IsRequired()
                    .HasColumnName("SOURCE")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.HasOne(d => d.Internal)
                    .WithMany(p => p.Auditlog)
                    .HasForeignKey(d => d.Internalid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AUDITLOG__INTERN__40905D8F");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Auditlog)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AUDITLOG__USERID__418481C8");
            });

            modelBuilder.Entity<Authority>(entity =>
            {
                entity.HasKey(e => e.Userid)
                    .HasName("PK__AUTHORITY__05A3D694");

                entity.ToTable("AUTHORITY", "dbo");

                entity.Property(e => e.Userid)
                    .HasColumnName("USERID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Authorityid).HasColumnName("AUTHORITYID");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.HasOne(d => d.User)
                    .WithOne(p => p.Authority)
                    .HasForeignKey<Authority>(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AUTHORITY__USERI__078C1F06");
            });

            modelBuilder.Entity<Autofill>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__AUTOFILL__63D8CE75");

                entity.ToTable("AUTOFILL", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Keycombination)
                    .HasColumnName("KEYCOMBINATION")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Textvalue)
                    .HasColumnName("TEXTVALUE")
                    .HasColumnType("text");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Usagecode).HasColumnName("USAGECODE");

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Autofill)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__AUTOFILL__USERID__65C116E7");
            });

            modelBuilder.Entity<AwsConnectionSettings>(entity =>
            {
                entity.HasKey(e => e.Environment);

                entity.ToTable("AwsConnectionSettings", "dbo");

                entity.Property(e => e.Environment).HasMaxLength(15);

                entity.Property(e => e.ApiClientId)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.ApiGatewayUrl)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.IdentityPoolId)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.LogoCache)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.S3serviceUrl)
                    .IsRequired()
                    .HasColumnName("S3ServiceUrl")
                    .HasMaxLength(500);

                entity.Property(e => e.UserPoolId)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<AzureEventHubSettings>(entity =>
            {
                entity.ToTable("AzureEventHubSettings", "dbo");

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.EndPointUrl)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Environment)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.EventHubName)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.SharedAccessKey)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SharedAccessKeyName)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Updated).HasColumnType("datetime");
            });

            modelBuilder.Entity<Backupmessage>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BACKUPMESSAGE", "dbo");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Userid).HasColumnName("USERID");
            });

            modelBuilder.Entity<Bankaccounts>(entity =>
            {
                entity.HasKey(e => e.Accountid)
                    .HasName("PK__BANKACCOUNTS__1308BEAA");

                entity.ToTable("BANKACCOUNTS", "dbo");

                entity.Property(e => e.Accountid).HasColumnName("ACCOUNTID");

                entity.Property(e => e.Accountname)
                    .IsRequired()
                    .HasColumnName("ACCOUNTNAME")
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Accountnumber)
                    .IsRequired()
                    .HasColumnName("ACCOUNTNUMBER")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Bankname)
                    .IsRequired()
                    .HasColumnName("BANKNAME")
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Bsbnumber)
                    .IsRequired()
                    .HasColumnName("BSBNUMBER")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Mid).HasColumnName("MID");

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Userid).HasColumnName("USERID");
            });

            modelBuilder.Entity<Banking>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__BANKING__16D94F8E");

                entity.ToTable("BANKING", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Accountid).HasColumnName("ACCOUNTID");

                entity.Property(e => e.Bankingdate)
                    .HasColumnName("BANKINGDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cash).HasColumnName("CASH");

                entity.Property(e => e.Cheque).HasColumnName("CHEQUE");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Credit).HasColumnName("CREDIT");

                entity.Property(e => e.Eftpos).HasColumnName("EFTPOS");

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Total).HasColumnName("TOTAL");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");
            });

            modelBuilder.Entity<BankingbatchPaymentparts>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__BANKINGB__84D4D4F53C594571");

                entity.ToTable("BANKINGBATCH_PAYMENTPARTS", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Batchid).HasColumnName("BATCHID");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Paymentpartid).HasColumnName("PAYMENTPARTID");

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.HasOne(d => d.Batch)
                    .WithMany(p => p.BankingbatchPaymentparts)
                    .HasForeignKey(d => d.Batchid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__BANKINGBA__BATCH__094028A5");

                entity.HasOne(d => d.Paymentpart)
                    .WithMany(p => p.BankingbatchPaymentparts)
                    .HasForeignKey(d => d.Paymentpartid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__BANKINGBA__PAYME__0A344CDE");
            });

            modelBuilder.Entity<Banknames>(entity =>
            {
                entity.HasKey(e => e.Bankid)
                    .HasName("PK__BANKNAMES__2AE0483B");

                entity.ToTable("BANKNAMES", "dbo");

                entity.Property(e => e.Bankid).HasColumnName("BANKID");

                entity.Property(e => e.Bankname)
                    .IsRequired()
                    .HasColumnName("BANKNAME")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");
            });

            modelBuilder.Entity<BatchService>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BATCH_SERVICE", "dbo");

                entity.HasIndex(e => new { e.BatchServicePaid, e.Batchid })
                    .HasName("BatchID_BatchServicePaid");

                entity.HasIndex(e => new { e.Batchid, e.BatchServiceStatus })
                    .HasName("BATCH_SERVICE1");

                entity.Property(e => e.Batchid).HasColumnName("BATCHID");

                entity.Property(e => e.Claimserviceid)
                    .HasColumnName("CLAIMSERVICEID")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Serviceid).HasColumnName("SERVICEID");
            });

            modelBuilder.Entity<BhaLocationKeys>(entity =>
            {
                entity.HasKey(e => e.RecordId)
                    .HasName("PK__BhaLocat__FBDF78E977BF1C5D");

                entity.ToTable("BhaLocationKeys", "dbo");

                entity.Property(e => e.Content)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Updated).HasColumnType("datetime");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.BhaLocationKeys)
                    .HasForeignKey(d => d.LocationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__BhaLocati__Locat__60C822F7");
            });

            modelBuilder.Entity<BhaLocationTokens>(entity =>
            {
                entity.HasKey(e => e.RecordId)
                    .HasName("PK__BhaLocat__FBDF78E98D39C59E");

                entity.ToTable("BhaLocationTokens", "dbo");

                entity.Property(e => e.Content)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Updated).HasColumnType("datetime");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.BhaLocationTokens)
                    .HasForeignKey(d => d.LocationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__BhaLocati__Locat__5DEBB64C");
            });

            modelBuilder.Entity<BhaMessages>(entity =>
            {
                entity.HasKey(e => e.BhaMessageId);

                entity.ToTable("BhaMessages", "dbo");

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.MessageBody)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.MessageGuid)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Updated).HasColumnType("datetime");
            });

            modelBuilder.Entity<BhaReplies>(entity =>
            {
                entity.HasKey(e => e.BhaReplyId)
                    .HasName("PK__BhaRepli__492A58704193E091");

                entity.ToTable("BhaReplies", "dbo");

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.ReceivedReply).HasColumnType("datetime");

                entity.Property(e => e.ReplyText)
                    .IsRequired()
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.Updated).HasColumnType("datetime");

                entity.HasOne(d => d.BhaMessage)
                    .WithMany(p => p.BhaReplies)
                    .HasForeignKey(d => d.BhaMessageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__BhaReplie__BhaMe__73DAF76B");
            });

            modelBuilder.Entity<Billinggroups>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__BILLINGGROUPS__33FF9E21");

                entity.ToTable("BILLINGGROUPS", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Groupid).HasColumnName("GROUPID");

                entity.Property(e => e.Payercode).HasColumnName("PAYERCODE");
            });

            modelBuilder.Entity<Births>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__BIRTHS__1E8F7FEF");

                entity.ToTable("BIRTHS", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Apgar1).HasColumnName("APGAR1");

                entity.Property(e => e.Apgar5).HasColumnName("APGAR5");

                entity.Property(e => e.Birthorder).HasColumnName("BIRTHORDER");

                entity.Property(e => e.ChildId).HasColumnName("CHILD_ID");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Firstname)
                    .HasColumnName("FIRSTNAME")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Internalid).HasColumnName("INTERNALID");

                entity.Property(e => e.Live).HasColumnName("LIVE");

                entity.Property(e => e.Pregnancyid).HasColumnName("PREGNANCYID");

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Sex).HasColumnName("SEX");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Weight)
                    .HasColumnName("WEIGHT")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.Internal)
                    .WithMany(p => p.Births)
                    .HasForeignKey(d => d.Internalid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__BIRTHS__INTERNAL__2630A1B7");

                entity.HasOne(d => d.Pregnancy)
                    .WithMany(p => p.Births)
                    .HasForeignKey(d => d.Pregnancyid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__BIRTHS__PREGNANC__2724C5F0");
            });

            modelBuilder.Entity<Bloodloss>(entity =>
            {
                entity.HasKey(e => e.Bloodlosscode)
                    .HasName("PK__BLOODLOSS__10566F31");

                entity.ToTable("BLOODLOSS", "dbo");

                entity.Property(e => e.Bloodlosscode)
                    .HasColumnName("BLOODLOSSCODE")
                    .ValueGeneratedNever();

                entity.Property(e => e.Bloodlosstext)
                    .IsRequired()
                    .HasColumnName("BLOODLOSSTEXT")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Bodyside>(entity =>
            {
                entity.HasKey(e => e.Sidecode)
                    .HasName("PK__BODYSIDE__48CFD27E");

                entity.ToTable("BODYSIDE", "dbo");

                entity.Property(e => e.Sidecode)
                    .HasColumnName("SIDECODE")
                    .ValueGeneratedNever();

                entity.Property(e => e.Side)
                    .IsRequired()
                    .HasColumnName("SIDE")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Bpcommscredit>(entity =>
            {
                entity.HasKey(e => e.CreditId);

                entity.ToTable("BPCOMMSCREDIT", "dbo");

                entity.Property(e => e.CostBha)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CostSms)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.CreditKey)
                    .IsRequired()
                    .HasMaxLength(57)
                    .IsUnicode(false);

                entity.Property(e => e.Hash).IsRequired();

                entity.Property(e => e.Remaining)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Updated).HasColumnType("datetime");
            });

            modelBuilder.Entity<Bpcommsenrolmentcode>(entity =>
            {
                entity.HasKey(e => new { e.Internalid, e.Type });

                entity.ToTable("BPCOMMSENROLMENTCODE", "dbo");

                entity.Property(e => e.Internalid).HasColumnName("INTERNALID");

                entity.Property(e => e.Type).HasColumnName("TYPE");

                entity.Property(e => e.Enrolmentcode)
                    .IsRequired()
                    .HasColumnName("ENROLMENTCODE")
                    .HasMaxLength(20);

                entity.Property(e => e.Sentdate)
                    .HasColumnName("SENTDATE")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Bponline>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__BPOnline__12D3B480");

                entity.ToTable("BPOnline", "dbo");

                entity.Property(e => e.Recordid)
                    .HasColumnName("RECORDID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Bppath)
                    .HasColumnName("BPPATH")
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.Computer)
                    .HasColumnName("COMPUTER")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");
            });

            modelBuilder.Entity<Bpremote>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__BPREMOTE__07F6335A");

                entity.ToTable("BPREMOTE", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Downloadtime)
                    .HasColumnName("DOWNLOADTIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.Server)
                    .HasColumnName("SERVER")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Userid).HasColumnName("USERID");
            });

            modelBuilder.Entity<BpsActions>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BPS_Actions", "dbo");

                entity.Property(e => e.ActionText)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Added).HasColumnType("datetime");

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.DueDate).HasColumnType("datetime");

                entity.Property(e => e.InternalId).HasColumnName("InternalID");

                entity.Property(e => e.Performed)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Provider)
                    .HasMaxLength(162)
                    .IsUnicode(false);

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");
            });

            modelBuilder.Entity<BpsAlcohol>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BPS_Alcohol", "dbo");

                entity.Property(e => e.Comment)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.InternalId).HasColumnName("InternalID");

                entity.Property(e => e.NonDrinker)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PastAlcoholLevel)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<BpsAllActions>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BPS_All_Actions", "dbo");

                entity.Property(e => e.ActionText)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Added).HasColumnType("datetime");

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.DueDate).HasColumnType("datetime");

                entity.Property(e => e.InternalId).HasColumnName("InternalID");

                entity.Property(e => e.Performed)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Provider)
                    .HasMaxLength(162)
                    .IsUnicode(false);

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");
            });

            modelBuilder.Entity<BpsAllHistory>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BPS_All_History", "dbo");

                entity.Property(e => e.Acute)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Comminuted)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Compound)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Condition)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ConditionId).HasColumnName("ConditionID");

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Details).HasColumnType("text");

                entity.Property(e => e.Displaced)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Fracture)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Greenstick)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.InternalId).HasColumnName("InternalID");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Severity)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Side)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Snomed)
                    .HasColumnName("SNOMED")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Spiral)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Summary)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<BpsAllHistory1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BPS_AllHistory", "dbo");

                entity.Property(e => e.Acute)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Comminuted)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Compound)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Condition)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ConditionId).HasColumnName("ConditionID");

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Details).HasColumnType("text");

                entity.Property(e => e.Displaced)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Fracture)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Greenstick)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.InternalId).HasColumnName("InternalID");

                entity.Property(e => e.Severity)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Side)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Snomed)
                    .HasColumnName("SNOMED")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Spiral)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Summary)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<BpsAllImmunisations>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BPS_All_Immunisations", "dbo");

                entity.Property(e => e.Acirtransmitted)
                    .HasColumnName("ACIRTransmitted")
                    .HasColumnType("datetime");

                entity.Property(e => e.BatchNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Comment)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.GivenDate).HasColumnType("datetime");

                entity.Property(e => e.InternalId).HasColumnName("InternalID");

                entity.Property(e => e.Provider)
                    .HasMaxLength(162)
                    .IsUnicode(false);

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.VaccineId).HasColumnName("VaccineID");

                entity.Property(e => e.VaccineName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Vivasprinted)
                    .HasColumnName("VIVASPrinted")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<BpsAllObservations>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BPS_All_Observations", "dbo");

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.InternalId).HasColumnName("InternalID");

                entity.Property(e => e.ObservationDate).HasColumnType("datetime");

                entity.Property(e => e.ObservationName)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ObservationValue)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Provider)
                    .HasMaxLength(162)
                    .IsUnicode(false);

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<BpsAllPapSmears>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BPS_All_PapSmears", "dbo");

                entity.Property(e => e.Comment)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Csttype)
                    .HasColumnName("CSTType")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EndocervicalCells)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Hpv)
                    .IsRequired()
                    .HasColumnName("HPV")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Hpv16)
                    .HasColumnName("HPV16")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Hpv18)
                    .HasColumnName("HPV18")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Hpvother)
                    .HasColumnName("HPVOther")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.InternalId).HasColumnName("InternalID");

                entity.Property(e => e.PapDate).HasColumnType("datetime");

                entity.Property(e => e.PerformedBy)
                    .HasMaxLength(162)
                    .IsUnicode(false);

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Result)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<BpsAllParameters>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BPS_All_Parameters", "dbo");

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.InternalId).HasColumnName("InternalID");

                entity.Property(e => e.ObservationDate).HasColumnType("datetime");

                entity.Property(e => e.ObservationName)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ObservationValue)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Provider)
                    .HasMaxLength(162)
                    .IsUnicode(false);

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");
            });

            modelBuilder.Entity<BpsAllPregnancies>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BPS_All_Pregnancies", "dbo");

                entity.Property(e => e.ActualLmp)
                    .HasColumnName("ActualLMP")
                    .HasColumnType("datetime");

                entity.Property(e => e.Analgesia)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AntiD)
                    .IsRequired()
                    .HasColumnName("Anti_D")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Augmentation)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BloodLoss)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Delivery)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DeliveryDate).HasColumnType("datetime");

                entity.Property(e => e.DeliveryNotes)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Diabetes)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EdcbyDate)
                    .HasColumnName("EDCByDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.EdcbyScan)
                    .HasColumnName("EDCByScan")
                    .HasColumnType("datetime");

                entity.Property(e => e.Feeding)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Hypertension)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.InternalId).HasColumnName("InternalID");

                entity.Property(e => e.Ivf)
                    .IsRequired()
                    .HasColumnName("IVF")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Onset)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OutcomeText)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Perineum)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Placenta)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PreEclampsia)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PregnancyId).HasColumnName("PregnancyID");

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.RenalDisease)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ScanDate).HasColumnType("datetime");

                entity.Property(e => e.Stage1)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Stage2)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Stage3)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UseScan)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<BpsAllPrescriptions>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BPS_All_Prescriptions", "dbo");

                entity.Property(e => e.AllowSubstitution)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ApprovalNumber)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Authority)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AuthorityNumber)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Dose)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Food)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Frequency)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Instructions)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.InternalId).HasColumnName("InternalID");

                entity.Property(e => e.OtherDetail)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Prn)
                    .IsRequired()
                    .HasColumnName("PRN")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductDescription)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ProductName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ProductUnit)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Provider)
                    .HasMaxLength(162)
                    .IsUnicode(false);

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Regulation24)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sahcno)
                    .HasColumnName("SAHCNo")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Scid)
                    .HasColumnName("SCID")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ScriptDate).HasColumnType("datetime");

                entity.Property(e => e.Scriptid).HasColumnName("SCRIPTID");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<BpsAllReminders>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BPS_All_Reminders", "dbo");

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.InternalId).HasColumnName("InternalID");

                entity.Property(e => e.Location)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Provider)
                    .HasMaxLength(162)
                    .IsUnicode(false);

                entity.Property(e => e.ReasonText)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Recurring)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ReminderDue).HasColumnType("datetime");

                entity.Property(e => e.Reminderid).HasColumnName("REMINDERID");

                entity.Property(e => e.Sent)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<BpsAllRequests>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BPS_All_Requests", "dbo");

                entity.Property(e => e.ClinicalDetails)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Copies)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.InternalId).HasColumnName("InternalID");

                entity.Property(e => e.Provider)
                    .HasMaxLength(162)
                    .IsUnicode(false);

                entity.Property(e => e.ProviderName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RequestDate).HasColumnType("datetime");

                entity.Property(e => e.RequestId).HasColumnName("RequestID");

                entity.Property(e => e.RequestedTests)
                    .HasMaxLength(1000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BpsAntenatalVisits>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BPS_AntenatalVisits", "dbo");

                entity.Property(e => e.AnkleOedema)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Comment)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Engagement)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FoetalHeartHeard)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FoetalMovements)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.InternalId).HasColumnName("InternalID");

                entity.Property(e => e.Position)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PregnancyId).HasColumnName("PregnancyID");

                entity.Property(e => e.Presentation)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Provider)
                    .HasMaxLength(162)
                    .IsUnicode(false);

                entity.Property(e => e.UrineGlucose)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UrineOther)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UrineProtein)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.VisitDate).HasColumnType("datetime");

                entity.Property(e => e.Weight)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<BpsAppointments>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BPS_Appointments", "dbo");

                entity.Property(e => e.AppointmentDate).HasColumnType("datetime");

                entity.Property(e => e.AppointmentType)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BookedBy)
                    .HasMaxLength(131)
                    .IsUnicode(false);

                entity.Property(e => e.InternalId).HasColumnName("InternalID");

                entity.Property(e => e.Patient)
                    .HasMaxLength(81)
                    .IsUnicode(false);

                entity.Property(e => e.Provider)
                    .HasMaxLength(162)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Urgent)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<BpsBirths>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BPS_Births", "dbo");

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Firstname)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.InternalId).HasColumnName("InternalID");

                entity.Property(e => e.Live)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PregnancyId).HasColumnName("PregnancyID");

                entity.Property(e => e.Weight)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<BpsClinical>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BPS_Clinical", "dbo");

                entity.Property(e => e.AccomodationText)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BloodGroup)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EliteSports)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.HasCarer)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.InternalId).HasColumnName("InternalID");

                entity.Property(e => e.IsCarer)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.KnownAllergies)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LivesWithText)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MaritalStatusName)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NoSignificantFamilyHistory)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NoSignificantPastHistory)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PaceMaker)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Recreation)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Retired)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SexualityName)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SmokingStatus)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SocialHistory)
                    .HasMaxLength(1000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BpsClinicalImages>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BPS_ClinicalImages", "dbo");

                entity.Property(e => e.Category)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Comment)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.CorrespondenceDate).HasColumnType("datetime");

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Detail)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentId).HasColumnName("DocumentID");

                entity.Property(e => e.InternalId).HasColumnName("InternalID");

                entity.Property(e => e.Provider)
                    .HasMaxLength(162)
                    .IsUnicode(false);

                entity.Property(e => e.Subject)
                    .HasMaxLength(61)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UserReference)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<BpsContactAddresses>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BPS_ContactAddresses", "dbo");

                entity.Property(e => e.Abn)
                    .HasColumnName("ABN")
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Address1)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Address2)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Ahphone)
                    .HasColumnName("AHPhone")
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.City)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Comment)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.ContactId).HasColumnName("ContactID");

                entity.Property(e => e.Email)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Firstname)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Greeting)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MobilePhone)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Pager)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Phone)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Postcode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProviderNo)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SiteComment)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.SiteEmail)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Surname)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Url)
                    .HasColumnName("URL")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BpsContacts>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BPS_Contacts", "dbo");

                entity.Property(e => e.Abn)
                    .HasColumnName("ABN")
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Ahphone)
                    .HasColumnName("AHPhone")
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Comment)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.ContactId).HasColumnName("ContactID");

                entity.Property(e => e.Email)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Firstname)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Greeting)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MobilePhone)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Pager)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProviderNo)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Surname)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Url)
                    .HasColumnName("URL")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BpsCorrespondenceIn>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BPS_CorrespondenceIn", "dbo");

                entity.Property(e => e.Category)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Comment)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Confidential)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ContactName)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CorrespondenceDate).HasColumnType("datetime");

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Detail)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentId).HasColumnName("DocumentID");

                entity.Property(e => e.InternalId).HasColumnName("InternalID");

                entity.Property(e => e.Provider)
                    .HasMaxLength(162)
                    .IsUnicode(false);

                entity.Property(e => e.Subject)
                    .HasMaxLength(61)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UserReference)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<BpsCorrespondenceOut>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BPS_CorrespondenceOut", "dbo");

                entity.Property(e => e.Comment)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Confidential)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ContactName)
                    .HasMaxLength(90)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CorrespondenceDate).HasColumnType("datetime");

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Draft)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.InternalId).HasColumnName("InternalID");

                entity.Property(e => e.Provider)
                    .HasMaxLength(162)
                    .IsUnicode(false);

                entity.Property(e => e.RecordId).HasColumnName("RecordID");

                entity.Property(e => e.Subject)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<BpsCurrentRx>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BPS_CurrentRx", "dbo");

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Dose)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DrugName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.FirstDate).HasColumnType("datetime");

                entity.Property(e => e.Food)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Frequency)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Indication)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Instructions)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.InternalId).HasColumnName("InternalID");

                entity.Property(e => e.LastDate).HasColumnType("datetime");

                entity.Property(e => e.OtherDetail)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Prn)
                    .IsRequired()
                    .HasColumnName("PRN")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.ProductUnit)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Scid)
                    .HasColumnName("SCID")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Scidno).HasColumnName("SCIDNO");
            });

            modelBuilder.Entity<BpsDaysAway>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BPS_DaysAway", "dbo");

                entity.Property(e => e.FinishDate).HasColumnType("datetime");

                entity.Property(e => e.Provider)
                    .HasMaxLength(162)
                    .IsUnicode(false);

                entity.Property(e => e.Reason)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StartDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<BpsDiabetes>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BPS_Diabetes", "dbo");

                entity.Property(e => e.DataName)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DateRecorded).HasColumnType("datetime");

                entity.Property(e => e.DateValue).HasColumnType("datetime");

                entity.Property(e => e.DiabetesValue)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.InternalId).HasColumnName("InternalID");

                entity.Property(e => e.Provider)
                    .HasMaxLength(162)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<BpsEpcreports>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BPS_EPCReports", "dbo");

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Finalised)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.InternalId).HasColumnName("InternalID");

                entity.Property(e => e.Provider)
                    .HasMaxLength(162)
                    .IsUnicode(false);

                entity.Property(e => e.ReportDate).HasColumnType("datetime");

                entity.Property(e => e.ReportId).HasColumnName("ReportID");

                entity.Property(e => e.ReportType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<BpsExtraSessions>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BPS_ExtraSessions", "dbo");

                entity.Property(e => e.Provider)
                    .HasMaxLength(162)
                    .IsUnicode(false);

                entity.Property(e => e.SessionDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<BpsFamilyHistory>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BPS_FamilyHistory", "dbo");

                entity.Property(e => e.Comment)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.FatherAlive)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FathersCauseOfDeath)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.InternalId).HasColumnName("InternalID");

                entity.Property(e => e.MotherAlive)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MothersCauseOfDeath)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Unknown)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<BpsFamilyHistoryDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BPS_FamilyHistoryDetail", "dbo");

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.Condition)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.InternalId).HasColumnName("InternalID");

                entity.Property(e => e.RelationName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<BpsHistory>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BPS_History", "dbo");

                entity.Property(e => e.Acute)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Comminuted)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Compound)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Condition)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ConditionId).HasColumnName("ConditionID");

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Details).HasColumnType("text");

                entity.Property(e => e.Displaced)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Fracture)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Greenstick)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.InternalId).HasColumnName("InternalID");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Severity)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Side)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Snomed)
                    .HasColumnName("SNOMED")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Spiral)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Summary)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<BpsImmunisations>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BPS_Immunisations", "dbo");

                entity.Property(e => e.Acirtransmitted)
                    .HasColumnName("ACIRTransmitted")
                    .HasColumnType("datetime");

                entity.Property(e => e.BatchNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Comment)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.GivenDate).HasColumnType("datetime");

                entity.Property(e => e.InternalId).HasColumnName("InternalID");

                entity.Property(e => e.Provider)
                    .HasMaxLength(162)
                    .IsUnicode(false);

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.VaccineId).HasColumnName("VaccineID");

                entity.Property(e => e.VaccineName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Vivasprinted)
                    .HasColumnName("VIVASPrinted")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<BpsInvestigations>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BPS_Investigations", "dbo");

                entity.Property(e => e.Action)
                    .HasMaxLength(22)
                    .IsUnicode(false);

                entity.Property(e => e.Actioned).HasColumnType("datetime");

                entity.Property(e => e.Checked).HasColumnType("datetime");

                entity.Property(e => e.CheckedBy)
                    .HasMaxLength(162)
                    .IsUnicode(false);

                entity.Property(e => e.Collected).HasColumnType("datetime");

                entity.Property(e => e.Comment)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Completed)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Confidential)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.InternalId).HasColumnName("InternalID");

                entity.Property(e => e.Normal)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Notation)
                    .HasMaxLength(21)
                    .IsUnicode(false);

                entity.Property(e => e.Provider)
                    .HasMaxLength(162)
                    .IsUnicode(false);

                entity.Property(e => e.ProviderName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ReportBody).HasColumnType("image");

                entity.Property(e => e.ReportHeader).HasColumnType("image");

                entity.Property(e => e.ReportId).HasColumnName("ReportID");

                entity.Property(e => e.Reported).HasColumnType("datetime");

                entity.Property(e => e.TestName)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<BpsObsGyn>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BPS_ObsGyn", "dbo");

                entity.Property(e => e.BreastFeeding)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CurrentPregnancyId).HasColumnName("CurrentPregnancyID");

                entity.Property(e => e.EdcbyDate)
                    .HasColumnName("EDCByDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.EdcbyScan)
                    .HasColumnName("EDCByScan")
                    .HasColumnType("datetime");

                entity.Property(e => e.GravidityKnown)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.InternalId).HasColumnName("InternalID");

                entity.Property(e => e.LastPapSmearDate).HasColumnType("datetime");

                entity.Property(e => e.LastPapSmearResult)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Lnmp)
                    .HasColumnName("LNMP")
                    .HasColumnType("datetime");

                entity.Property(e => e.NotForSmears)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<BpsObservations>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BPS_Observations", "dbo");

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.InternalId).HasColumnName("InternalID");

                entity.Property(e => e.ObservationDate).HasColumnType("datetime");

                entity.Property(e => e.ObservationName)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ObservationValue)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Provider)
                    .HasMaxLength(162)
                    .IsUnicode(false);

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<BpsOccupationHistory>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BPS_OccupationHistory", "dbo");

                entity.Property(e => e.Adfstatus).HasColumnName("ADFStatus");

                entity.Property(e => e.Animals)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Asbestos)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Comment)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Dust)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Employer)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.InternalId).HasColumnName("InternalID");

                entity.Property(e => e.OccupationName)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Radiation)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<BpsPapSmears>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BPS_PapSmears", "dbo");

                entity.Property(e => e.Comment)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Csttype)
                    .HasColumnName("CSTType")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EndocervicalCells)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Hpv16)
                    .HasColumnName("HPV16")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Hpv18)
                    .HasColumnName("HPV18")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Hpvchanges)
                    .HasColumnName("HPVChanges")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Hpvother)
                    .HasColumnName("HPVOther")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.InternalId).HasColumnName("InternalID");

                entity.Property(e => e.PapDate).HasColumnType("datetime");

                entity.Property(e => e.PerformedBy)
                    .HasMaxLength(162)
                    .IsUnicode(false);

                entity.Property(e => e.Result)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<BpsParameters>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BPS_Parameters", "dbo");

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.InternalId).HasColumnName("InternalID");

                entity.Property(e => e.ObservationDate).HasColumnType("datetime");

                entity.Property(e => e.ObservationName)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ObservationValue)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Provider)
                    .HasMaxLength(162)
                    .IsUnicode(false);

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");
            });

            modelBuilder.Entity<BpsPatientLogin>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BPS_PatientLogin", "dbo");

                entity.Property(e => e.Firstname)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Surname)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BpsPatients>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BPS_Patients", "dbo");

                entity.Property(e => e.Address1)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Address2)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.City)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Dob)
                    .HasColumnName("DOB")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dvano)
                    .HasColumnName("DVANo")
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Email)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Ethnicity)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ExternalId)
                    .HasColumnName("ExternalID")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Firstname)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Hchstart)
                    .HasColumnName("HCHStart")
                    .HasColumnType("datetime");

                entity.Property(e => e.Hchtier)
                    .HasColumnName("HCHTier")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.HealthFundName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HealthFundNo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.HomePhone)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Ihi)
                    .HasColumnName("IHI")
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.InternalId).HasColumnName("InternalID");

                entity.Property(e => e.MedicareExpiry)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MedicareLineNo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MedicareNo)
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Middlename)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MobilePhone)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PensionExpiry).HasColumnType("datetime");

                entity.Property(e => e.PensionNo)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PensionStart).HasColumnType("datetime");

                entity.Property(e => e.PensionType)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PostalAddress)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PostalCity)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PostalPostcode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Postcode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Preferredname)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RecordNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Religion)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SafetyNetNo)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sex)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StatusText)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Surname)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UsualDoctor)
                    .HasMaxLength(162)
                    .IsUnicode(false);

                entity.Property(e => e.WorkPhone)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<BpsPracticeLocations>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BPS_PracticeLocations", "dbo");

                entity.Property(e => e.Address1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Address2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Ahphone)
                    .HasColumnName("AHPhone")
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.City)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Email)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LocationId)
                    .HasColumnName("LocationID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.LocationName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PostCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<BpsPregnancies>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BPS_Pregnancies", "dbo");

                entity.Property(e => e.ActualLmp)
                    .HasColumnName("ActualLMP")
                    .HasColumnType("datetime");

                entity.Property(e => e.Analgesia)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AntiD)
                    .IsRequired()
                    .HasColumnName("Anti_D")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Augmentation)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BloodLoss)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Delivery)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DeliveryDate).HasColumnType("datetime");

                entity.Property(e => e.DeliveryNotes)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Diabetes)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EdcbyDate)
                    .HasColumnName("EDCByDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.EdcbyScan)
                    .HasColumnName("EDCByScan")
                    .HasColumnType("datetime");

                entity.Property(e => e.Feeding)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Hypertension)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.InternalId).HasColumnName("InternalID");

                entity.Property(e => e.Ivf)
                    .IsRequired()
                    .HasColumnName("IVF")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Onset)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OutcomeText)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Perineum)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Placenta)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PreEclampsia)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PregnancyId).HasColumnName("PregnancyID");

                entity.Property(e => e.RenalDisease)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ScanDate).HasColumnType("datetime");

                entity.Property(e => e.Stage1)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Stage2)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Stage3)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UseScan)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<BpsPrescriptions>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BPS_Prescriptions", "dbo");

                entity.Property(e => e.AllowSubstitution)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ApprovalNumber)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Authority)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AuthorityNumber)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Dose)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Food)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Frequency)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Instructions)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.InternalId).HasColumnName("InternalID");

                entity.Property(e => e.OtherDetail)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Prn)
                    .IsRequired()
                    .HasColumnName("PRN")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductDescription)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ProductName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ProductUnit)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Provider)
                    .HasMaxLength(162)
                    .IsUnicode(false);

                entity.Property(e => e.Regulation24)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sahcno)
                    .HasColumnName("SAHCNo")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Scid)
                    .HasColumnName("SCID")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ScriptDate).HasColumnType("datetime");

                entity.Property(e => e.Scriptid).HasColumnName("SCRIPTID");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<BpsReactions>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BPS_Reactions", "dbo");

                entity.Property(e => e.Comment).IsUnicode(false);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.InternalId).HasColumnName("InternalID");

                entity.Property(e => e.ItemName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Reaction)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Severity)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<BpsReminders>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BPS_Reminders", "dbo");

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.InternalId).HasColumnName("InternalID");

                entity.Property(e => e.Location)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Provider)
                    .HasMaxLength(162)
                    .IsUnicode(false);

                entity.Property(e => e.ReasonText)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Recurring)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ReminderDue).HasColumnType("datetime");

                entity.Property(e => e.Reminderid).HasColumnName("REMINDERID");

                entity.Property(e => e.Sent)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<BpsReportValues>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BPS_ReportValues", "dbo");

                entity.Property(e => e.AbnormalFlag)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Bpcode).HasColumnName("BPCode");

                entity.Property(e => e.InternalId).HasColumnName("InternalID");

                entity.Property(e => e.LoincCode)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Range)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ReportDate).HasColumnType("datetime");

                entity.Property(e => e.ReportId).HasColumnName("ReportID");

                entity.Property(e => e.ResultName)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ResultValue)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Units)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<BpsRequests>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BPS_Requests", "dbo");

                entity.Property(e => e.ClinicalDetails)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Copies)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.InternalId).HasColumnName("InternalID");

                entity.Property(e => e.Provider)
                    .HasMaxLength(162)
                    .IsUnicode(false);

                entity.Property(e => e.ProviderName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RequestDate).HasColumnType("datetime");

                entity.Property(e => e.RequestId).HasColumnName("RequestID");

                entity.Property(e => e.RequestedTests)
                    .HasMaxLength(1000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BpsServices>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BPS_Services", "dbo");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Internalid).HasColumnName("INTERNALID");

                entity.Property(e => e.Mbsitem).HasColumnName("MBSITEM");

                entity.Property(e => e.Servicedate)
                    .HasColumnName("SERVICEDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Serviceid).HasColumnName("SERVICEID");
            });

            modelBuilder.Entity<BpsSessions>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BPS_Sessions", "dbo");

                entity.Property(e => e.Day)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.Provider)
                    .HasMaxLength(162)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<BpsTobacco>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BPS_Tobacco", "dbo");

                entity.Property(e => e.InternalId).HasColumnName("InternalID");

                entity.Property(e => e.PastSmokingStatus)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SmokingStatus)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SmokingType)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<BpsUsers>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BPS_Users", "dbo");

                entity.Property(e => e.Abn)
                    .HasColumnName("ABN")
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Email)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Firstname)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.GroupName)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.HomePhone)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LocationName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MobilePhone)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Pager)
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PrescriberNo)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProviderNo)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RegistrationNo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Surname)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<BpsVisitReason>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BPS_VisitReason", "dbo");

                entity.Property(e => e.InternalId).HasColumnName("InternalID");

                entity.Property(e => e.Provider)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Reason)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.VisitDate).HasColumnType("datetime");

                entity.Property(e => e.VisitId).HasColumnName("VisitID");
            });

            modelBuilder.Entity<BpsVisits>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BPS_Visits", "dbo");

                entity.Property(e => e.Confidential)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.DrName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.InternalId).HasColumnName("InternalID");

                entity.Property(e => e.ReviewDate).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.VisitDate).HasColumnType("datetime");

                entity.Property(e => e.VisitId).HasColumnName("VisitID");

                entity.Property(e => e.VisitNotes).HasColumnType("text");

                entity.Property(e => e.VisitType)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Bpsbackup>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__BPSBACKUP__0AD2A005");

                entity.ToTable("BPSBACKUP", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Backuppath)
                    .HasColumnName("BACKUPPATH")
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.Backuptime).HasColumnName("BACKUPTIME");

                entity.Property(e => e.Deleteold).HasColumnName("DELETEOLD");

                entity.Property(e => e.Performbackup).HasColumnName("PERFORMBACKUP");

                entity.Property(e => e.Sendmessage).HasColumnName("SENDMESSAGE");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");
            });

            modelBuilder.Entity<Bpsbackuptime>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__BPSBACKUPTIME__108B795B");

                entity.ToTable("BPSBACKUPTIME", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Backupday).HasColumnName("BACKUPDAY");

                entity.Property(e => e.Backuppath)
                    .HasColumnName("BACKUPPATH")
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.Backuptime).HasColumnName("BACKUPTIME");

                entity.Property(e => e.Compressed).HasColumnName("COMPRESSED");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");
            });

            modelBuilder.Entity<Bulkbilleasyclaims>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__BULKBILL__84D4D4F5F14C674C");

                entity.ToTable("BULKBILLEASYCLAIMS", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Claimbenefitpaid).HasColumnName("CLAIMBENEFITPAID");

                entity.Property(e => e.Claimchargeamount).HasColumnName("CLAIMCHARGEAMOUNT");

                entity.Property(e => e.Claimid)
                    .IsRequired()
                    .HasColumnName("CLAIMID")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Dateoftransmission)
                    .HasColumnName("DATEOFTRANSMISSION")
                    .HasColumnType("datetime");

                entity.Property(e => e.Payeeprovidernum)
                    .HasColumnName("PAYEEPROVIDERNUM")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Servicingprovidernum)
                    .HasColumnName("SERVICINGPROVIDERNUM")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");
            });

            modelBuilder.Entity<Cancellationreasons>(entity =>
            {
                entity.HasKey(e => e.Reasoncode)
                    .HasName("PK__CANCELLATIONREAS__22751F6C");

                entity.ToTable("CANCELLATIONREASONS", "dbo");

                entity.Property(e => e.Reasoncode).HasColumnName("REASONCODE");

                entity.Property(e => e.Reason)
                    .IsRequired()
                    .HasColumnName("REASON")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");
            });

            modelBuilder.Entity<Cancellations>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__CANCELLATIONS__73E5190C");

                entity.ToTable("CANCELLATIONS", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Appointmentid).HasColumnName("APPOINTMENTID");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Internalid).HasColumnName("INTERNALID");

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Userid).HasColumnName("USERID");
            });

            modelBuilder.Entity<Cancelledappointments>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CANCELLEDAPPOINTMENTS", "dbo");

                entity.Property(e => e.Appointmentid).HasColumnName("APPOINTMENTID");

                entity.Property(e => e.Cancelledby).HasColumnName("CANCELLEDBY");

                entity.Property(e => e.Cancelleddate)
                    .HasColumnName("CANCELLEDDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cancelledtime).HasColumnName("CANCELLEDTIME");

                entity.Property(e => e.Reason)
                    .HasColumnName("REASON")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.CancelledbyNavigation)
                    .WithMany(p => p.Cancelledappointments)
                    .HasForeignKey(d => d.Cancelledby)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CANCELLED__CANCE__2C29722F");
            });

            modelBuilder.Entity<Careplandetail>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__CAREPLANDETAIL__4924D839");

                entity.ToTable("CAREPLANDETAIL", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Bywho)
                    .HasColumnName("BYWHO")
                    .HasMaxLength(162)
                    .IsUnicode(false);

                entity.Property(e => e.Comments)
                    .HasColumnName("COMMENTS")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Consent).HasColumnName("CONSENT");

                entity.Property(e => e.Cptype).HasColumnName("CPTYPE");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Currentplan)
                    .HasColumnName("CURRENTPLAN")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Currentplandate)
                    .HasColumnName("CURRENTPLANDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Interpret).HasColumnName("INTERPRET");

                entity.Property(e => e.Outcome)
                    .HasColumnName("OUTCOME")
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.Patientcopy).HasColumnName("PATIENTCOPY");

                entity.Property(e => e.Planid).HasColumnName("PLANID");

                entity.Property(e => e.Purpose).HasColumnName("PURPOSE");

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Reminder).HasColumnName("REMINDER");

                entity.Property(e => e.Review).HasColumnName("REVIEW");

                entity.Property(e => e.Reviewdate)
                    .HasColumnName("REVIEWDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.HasOne(d => d.Plan)
                    .WithMany(p => p.Careplandetail)
                    .HasForeignKey(d => d.Planid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CAREPLAND__PLANI__51BA1E3A");
            });

            modelBuilder.Entity<Careplangoals>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__CAREPLANGOALS__5772F790");

                entity.ToTable("CAREPLANGOALS", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Goal)
                    .HasColumnName("GOAL")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Planid).HasColumnName("PLANID");

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Result).HasColumnName("RESULT");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.HasOne(d => d.Plan)
                    .WithMany(p => p.Careplangoals)
                    .HasForeignKey(d => d.Planid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CAREPLANG__PLANI__5A4F643B");
            });

            modelBuilder.Entity<Careplanitems>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__CAREPLANITEMS__46486B8E");

                entity.ToTable("CAREPLANITEMS", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Itemtext)
                    .HasColumnName("ITEMTEXT")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Itemtype).HasColumnName("ITEMTYPE");

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");
            });

            modelBuilder.Entity<Careplanproblems>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__CAREPLANPROBLEMS__53A266AC");

                entity.ToTable("CAREPLANPROBLEMS", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Planid).HasColumnName("PLANID");

                entity.Property(e => e.Problem)
                    .HasColumnName("PROBLEM")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.HasOne(d => d.Plan)
                    .WithMany(p => p.Careplanproblems)
                    .HasForeignKey(d => d.Planid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CAREPLANP__PLANI__558AAF1E");
            });

            modelBuilder.Entity<Careplantasks>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__CAREPLANTASKS__5C37ACAD");

                entity.ToTable("CAREPLANTASKS", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Actioncode).HasColumnName("ACTIONCODE");

                entity.Property(e => e.Actiondate)
                    .HasColumnName("ACTIONDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Actioned)
                    .HasColumnName("ACTIONED")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Actiontext)
                    .HasColumnName("ACTIONTEXT")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Datedue)
                    .HasColumnName("DATEDUE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Detailid).HasColumnName("DETAILID");

                entity.Property(e => e.Planid).HasColumnName("PLANID");

                entity.Property(e => e.Provider)
                    .HasColumnName("PROVIDER")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Providercode).HasColumnName("PROVIDERCODE");

                entity.Property(e => e.Providerid).HasColumnName("PROVIDERID");

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Task)
                    .HasColumnName("TASK")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.HasOne(d => d.Plan)
                    .WithMany(p => p.Careplantasks)
                    .HasForeignKey(d => d.Planid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CAREPLANT__PLANI__61F08603");
            });

            modelBuilder.Entity<Careplantemplateitems>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__CAREPLANTEMPLATE__18227982");

                entity.ToTable("CAREPLANTEMPLATEITEMS", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Detailid).HasColumnName("DETAILID");

                entity.Property(e => e.Dueindays).HasColumnName("DUEINDAYS");

                entity.Property(e => e.Itemcode).HasColumnName("ITEMCODE");

                entity.Property(e => e.Itemtext)
                    .HasColumnName("ITEMTEXT")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Provider)
                    .HasColumnName("PROVIDER")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Providercode).HasColumnName("PROVIDERCODE");

                entity.Property(e => e.Providerid).HasColumnName("PROVIDERID");

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Templateid).HasColumnName("TEMPLATEID");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");
            });

            modelBuilder.Entity<Careplantemplates>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__CAREPLANTEMPLATE__1451E89E");

                entity.ToTable("CAREPLANTEMPLATES", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Templatename)
                    .HasColumnName("TEMPLATENAME")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Userid).HasColumnName("USERID");
            });

            modelBuilder.Entity<Carer>(entity =>
            {
                entity.HasKey(e => e.Internalid)
                    .HasName("PK__CARER__1209AD79");

                entity.ToTable("CARER", "dbo");

                entity.Property(e => e.Internalid)
                    .HasColumnName("INTERNALID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .HasColumnName("ADDRESS")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.City)
                    .HasColumnName("CITY")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Contactphone)
                    .HasColumnName("CONTACTPHONE")
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Contactphone2)
                    .HasColumnName("CONTACTPHONE2")
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Firstname)
                    .HasColumnName("FIRSTNAME")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Postcode)
                    .HasColumnName("POSTCODE")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Relationship)
                    .HasColumnName("RELATIONSHIP")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Surname)
                    .HasColumnName("SURNAME")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Titlecode).HasColumnName("TITLECODE");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.HasOne(d => d.TitlecodeNavigation)
                    .WithMany(p => p.Carer)
                    .HasForeignKey(d => d.Titlecode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CARER__TITLECODE__14E61A24");
            });

            modelBuilder.Entity<Categories>(entity =>
            {
                entity.HasKey(e => e.Categorycode)
                    .HasName("PK__CATEGORIES__778AC167");

                entity.ToTable("CATEGORIES", "dbo");

                entity.Property(e => e.Categorycode).HasColumnName("CATEGORYCODE");

                entity.Property(e => e.Categoryname)
                    .IsRequired()
                    .HasColumnName("CATEGORYNAME")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Categorytype).HasColumnName("CATEGORYTYPE");

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");
            });

            modelBuilder.Entity<CdmNetsetup>(entity =>
            {
                entity.HasKey(e => e.KeyTypeId)
                    .HasName("PK__cdmNetse__53FD04BFFA383050");

                entity.ToTable("cdmNetsetup", "dbo");

                entity.Property(e => e.KeyTypeId).HasColumnName("keyTypeId");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("createdBy")
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("createdOn")
                    .HasColumnType("datetime");

                entity.Property(e => e.KeyType)
                    .IsRequired()
                    .HasColumnName("keyType")
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasColumnName("modifiedBy")
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedOn)
                    .HasColumnName("modifiedOn")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<CdmNetvalue>(entity =>
            {
                entity.HasKey(e => new { e.KeyTypeId, e.Id })
                    .HasName("PK__cdmNetva__B0DC3A3CD3C0B2AE");

                entity.ToTable("cdmNetvalue", "dbo");

                entity.Property(e => e.KeyTypeId).HasColumnName("keyTypeId");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("createdBy")
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedOn)
                    .HasColumnName("createdOn")
                    .HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy)
                    .IsRequired()
                    .HasColumnName("modifiedBy")
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedOn)
                    .HasColumnName("modifiedOn")
                    .HasColumnType("datetime");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasColumnName("value");

                entity.HasOne(d => d.KeyType)
                    .WithMany(p => p.CdmNetvalue)
                    .HasForeignKey(d => d.KeyTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__cdmNetval__keyTy__66B60677");
            });

            modelBuilder.Entity<Ceasedreasons>(entity =>
            {
                entity.HasKey(e => e.Reasoncode)
                    .HasName("PK__CEASEDREASONS__1F98B2C1");

                entity.ToTable("CEASEDREASONS", "dbo");

                entity.Property(e => e.Reasoncode).HasColumnName("REASONCODE");

                entity.Property(e => e.Reason)
                    .IsRequired()
                    .HasColumnName("REASON")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");
            });

            modelBuilder.Entity<Certificates>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__CERTIFICATES__0C11A858");

                entity.ToTable("CERTIFICATES", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Certificate).HasColumnType("image");

                entity.Property(e => e.Certificatetype).HasColumnName("CERTIFICATETYPE");

                entity.Property(e => e.Filename)
                    .HasColumnName("FILENAME")
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Password)
                    .HasColumnName("PASSWORD")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Serialnumber)
                    .HasColumnName("SERIALNUMBER")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Chequedrawers>(entity =>
            {
                entity.HasKey(e => e.Drawerid)
                    .HasName("PK__CHEQUEDRAWERS__2803DB90");

                entity.ToTable("CHEQUEDRAWERS", "dbo");

                entity.Property(e => e.Drawerid).HasColumnName("DRAWERID");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Drawername)
                    .IsRequired()
                    .HasColumnName("DRAWERNAME")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");
            });

            modelBuilder.Entity<Clientscript>(entity =>
            {
                entity.HasKey(e => e.Scriptguid);

                entity.ToTable("CLIENTSCRIPT", "dbo");

                entity.Property(e => e.Scriptguid)
                    .HasColumnName("SCRIPTGUID")
                    .HasMaxLength(36);
            });

            modelBuilder.Entity<Clinical>(entity =>
            {
                entity.HasKey(e => e.Internalid)
                    .HasName("PK__CLINICAL__5B78929E");

                entity.ToTable("CLINICAL", "dbo");

                entity.Property(e => e.Internalid)
                    .HasColumnName("INTERNALID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Accomodation).HasColumnName("ACCOMODATION");

                entity.Property(e => e.Acd).HasColumnName("ACD");

                entity.Property(e => e.Alcoholstatus).HasColumnName("ALCOHOLSTATUS");

                entity.Property(e => e.Bloodgroup)
                    .HasColumnName("BLOODGROUP")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Causeofdeath)
                    .HasColumnName("CAUSEOFDEATH")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Causeofdeathcode).HasColumnName("CAUSEOFDEATHCODE");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Drnote)
                    .HasColumnName("DRNOTE")
                    .HasColumnType("image");

                entity.Property(e => e.Elitesports).HasColumnName("ELITESPORTS");

                entity.Property(e => e.Familyhistory).HasColumnName("FAMILYHISTORY");

                entity.Property(e => e.Hascarer).HasColumnName("HASCARER");

                entity.Property(e => e.Hidedrnote).HasColumnName("HIDEDRNOTE");

                entity.Property(e => e.Iscarer).HasColumnName("ISCARER");

                entity.Property(e => e.Knownallergies).HasColumnName("KNOWNALLERGIES");

                entity.Property(e => e.Liveswith).HasColumnName("LIVESWITH");

                entity.Property(e => e.Maritalstatus).HasColumnName("MARITALSTATUS");

                entity.Property(e => e.Nir).HasColumnName("NIR");

                entity.Property(e => e.Othercomment)
                    .HasColumnName("OTHERCOMMENT")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Pacemaker).HasColumnName("PACEMAKER");

                entity.Property(e => e.Pasthistory).HasColumnName("PASTHISTORY");

                entity.Property(e => e.Pcehr).HasColumnName("PCEHR");

                entity.Property(e => e.Powerofattorney).HasColumnName("POWEROFATTORNEY");

                entity.Property(e => e.Recreation)
                    .HasColumnName("RECREATION")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Retired).HasColumnName("RETIRED");

                entity.Property(e => e.Rh).HasColumnName("RH");

                entity.Property(e => e.Safeinhome).HasColumnName("SAFEINHOME");

                entity.Property(e => e.Sexuality).HasColumnName("SEXUALITY");

                entity.Property(e => e.Shs)
                    .HasColumnName("SHS")
                    .HasColumnType("datetime");

                entity.Property(e => e.Smokingstatus).HasColumnName("SMOKINGSTATUS");

                entity.Property(e => e.Socialhx)
                    .HasColumnName("SOCIALHX")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Webster).HasColumnName("WEBSTER");

                entity.HasOne(d => d.Internal)
                    .WithOne(p => p.Clinical)
                    .HasForeignKey<Clinical>(d => d.Internalid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CLINICAL__INTERN__69C6B1F5");
            });

            modelBuilder.Entity<Clinicaltext>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__CLINICALTEXT__19DFD96B");

                entity.ToTable("CLINICALTEXT", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Item1)
                    .HasColumnName("ITEM1")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Item2)
                    .HasColumnName("ITEM2")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Item3)
                    .HasColumnName("ITEM3")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Item4)
                    .HasColumnName("ITEM4")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Itemcode).HasColumnName("ITEMCODE");

                entity.Property(e => e.Itemname)
                    .IsRequired()
                    .HasColumnName("ITEMNAME")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Itemtype).HasColumnName("ITEMTYPE");

                entity.Property(e => e.Objectcode).HasColumnName("OBJECTCODE");
            });

            modelBuilder.Entity<CommonfeeSchedule>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__COMMONFEE_SCHEDU__4A58F394");

                entity.ToTable("COMMONFEE_SCHEDULE", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Amount).HasColumnName("AMOUNT");

                entity.Property(e => e.Itemid).HasColumnName("ITEMID");

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Scheduleid).HasColumnName("SCHEDULEID");
            });

            modelBuilder.Entity<Commonfees>(entity =>
            {
                entity.HasKey(e => e.Itemid)
                    .HasName("PK__COMMONFEES__011F1899");

                entity.ToTable("COMMONFEES", "dbo");

                entity.HasIndex(e => new { e.Userid, e.Recordstatus, e.Itemcode, e.Mbsitem })
                    .HasName("COMMONFEES1");

                entity.Property(e => e.Itemid).HasColumnName("ITEMID");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.Gst).HasColumnName("GST");

                entity.Property(e => e.Itemcode).HasColumnName("ITEMCODE");

                entity.Property(e => e.Mbsitem).HasColumnName("MBSITEM");

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Userid).HasColumnName("USERID");
            });

            modelBuilder.Entity<Complexinstructions>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__COMPLEXINSTRUCTI__67A95F59");

                entity.ToTable("COMPLEXINSTRUCTIONS", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Instruction)
                    .HasColumnName("INSTRUCTION")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Complexinstructions)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__COMPLEXIN__USERI__689D8392");
            });

            modelBuilder.Entity<Complicationcodes>(entity =>
            {
                entity.HasKey(e => e.Complicationcode)
                    .HasName("PK__COMPLICATIONCODE__25518C17");

                entity.ToTable("COMPLICATIONCODES", "dbo");

                entity.Property(e => e.Complicationcode).HasColumnName("COMPLICATIONCODE");

                entity.Property(e => e.Complication)
                    .IsRequired()
                    .HasColumnName("COMPLICATION")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");
            });

            modelBuilder.Entity<Complications>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__COMPLICATIONS__443605EA");

                entity.ToTable("COMPLICATIONS", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Complication)
                    .HasColumnName("COMPLICATION")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Complicationcode).HasColumnName("COMPLICATIONCODE");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Detail)
                    .HasColumnName("DETAIL")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Internalid).HasColumnName("INTERNALID");

                entity.Property(e => e.Operationid).HasColumnName("OPERATIONID");

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");
            });

            modelBuilder.Entity<ContactMethod>(entity =>
            {
                entity.HasKey(e => e.MethodCode)
                    .HasName("PK__ContactM__11E9210CDDB921CD");

                entity.ToTable("ContactMethod", "dbo");

                entity.Property(e => e.MethodCode).ValueGeneratedNever();

                entity.Property(e => e.Au).HasColumnName("AU");

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Method)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Nz).HasColumnName("NZ");
            });

            modelBuilder.Entity<ContactNotes>(entity =>
            {
                entity.HasKey(e => e.RecordId)
                    .HasName("PK__ContactN__FBDF78C971D6CC61");

                entity.ToTable("ContactNotes", "dbo");

                entity.Property(e => e.RecordId).HasColumnName("RecordID");

                entity.Property(e => e.ContactDate).HasColumnType("datetime");

                entity.Property(e => e.ContactMethodId).HasColumnName("ContactMethodID");

                entity.Property(e => e.ContactNoteReasonId).HasColumnName("ContactNoteReasonID");

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Details)
                    .HasMaxLength(1200)
                    .IsUnicode(false);

                entity.Property(e => e.InternalId).HasColumnName("InternalID");

                entity.Property(e => e.Locationid).HasColumnName("LOCATIONID");

                entity.Property(e => e.Message)
                    .HasMaxLength(750)
                    .IsUnicode(false);

                entity.Property(e => e.MessageId).HasColumnName("MessageID");

                entity.Property(e => e.OriginLinkId).HasColumnName("OriginLinkID");

                entity.Property(e => e.Updated).HasColumnType("datetime");

                entity.HasOne(d => d.ContactMethod)
                    .WithMany(p => p.ContactNotes)
                    .HasForeignKey(d => d.ContactMethodId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ContactNo__Conta__38EF3BC7");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.ContactNotes)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ContactNo__Creat__3AD78439");

                entity.HasOne(d => d.Internal)
                    .WithMany(p => p.ContactNotes)
                    .HasForeignKey(d => d.InternalId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ContactNo__Inter__37FB178E");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.ContactNotes)
                    .HasForeignKey(d => d.Locationid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ContactNo__LOCAT__39E36000");
            });

            modelBuilder.Entity<Contactdetails>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__CONTACTDETAILS__575DE8F7");

                entity.ToTable("CONTACTDETAILS", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Address1)
                    .HasColumnName("ADDRESS1")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Address2)
                    .HasColumnName("ADDRESS2")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Addresscode).HasColumnName("ADDRESSCODE");

                entity.Property(e => e.Capabilities)
                    .HasColumnName("CAPABILITIES")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasColumnName("CITY")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Comment)
                    .HasColumnName("COMMENT")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Contactid).HasColumnName("CONTACTID");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Email)
                    .HasColumnName("EMAIL")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasColumnName("FAX")
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Hpio)
                    .HasColumnName("HPIO")
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Hpiovalidated)
                    .HasColumnName("HPIOVALIDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Hsdkey)
                    .HasColumnName("HSDKEY")
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Hsdupdate)
                    .HasColumnName("HSDUPDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Phone)
                    .HasColumnName("PHONE")
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Postcode)
                    .HasColumnName("POSTCODE")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.Contactdetails)
                    .HasForeignKey(d => d.Contactid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CONTACTDE__CONTA__5A3A55A2");
            });

            modelBuilder.Entity<Contacts>(entity =>
            {
                entity.HasKey(e => e.Contactid)
                    .HasName("PK__CONTACTS__4BEC364B");

                entity.ToTable("CONTACTS", "dbo");

                entity.Property(e => e.Contactid).HasColumnName("CONTACTID");

                entity.Property(e => e.Abn)
                    .HasColumnName("ABN")
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Accountid)
                    .HasColumnName("ACCOUNTID")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Ahphone)
                    .HasColumnName("AHPHONE")
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Assistant).HasColumnName("ASSISTANT");

                entity.Property(e => e.Categorycode).HasColumnName("CATEGORYCODE");

                entity.Property(e => e.Comment)
                    .HasColumnName("COMMENT")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Contactcode).HasColumnName("CONTACTCODE");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.EformDefaultUrl)
                    .HasColumnName("EFormDefaultURL")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EformsServiceCode).HasColumnName("EFormsServiceCode");

                entity.Property(e => e.Email)
                    .HasColumnName("EMAIL")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Eorder).HasColumnName("EORDER");

                entity.Property(e => e.FhirdirectoryId)
                    .HasColumnName("FHIRDirectoryID")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.FhirlastUpdated)
                    .HasColumnName("FHIRLastUpdated")
                    .HasColumnType("datetime");

                entity.Property(e => e.Firstname)
                    .HasColumnName("FIRSTNAME")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Greeting)
                    .HasColumnName("GREETING")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Hpi)
                    .HasColumnName("HPI")
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Hpivalidated)
                    .HasColumnName("HPIVALIDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Hsdkey)
                    .HasColumnName("HSDKEY")
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Labid).HasColumnName("LABID");

                entity.Property(e => e.Messagingproviderid).HasColumnName("MESSAGINGPROVIDERID");

                entity.Property(e => e.Mobilephone)
                    .HasColumnName("MOBILEPHONE")
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Natacode).HasColumnName("NATACODE");

                entity.Property(e => e.Operations).HasColumnName("OPERATIONS");

                entity.Property(e => e.Otherrequests).HasColumnName("OTHERREQUESTS");

                entity.Property(e => e.Pager)
                    .HasColumnName("PAGER")
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Pkikey)
                    .HasColumnName("PKIKEY")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Providerno)
                    .HasColumnName("PROVIDERNO")
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Skype)
                    .HasColumnName("SKYPE")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Surname)
                    .IsRequired()
                    .HasColumnName("SURNAME")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Titlecode).HasColumnName("TITLECODE");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Url)
                    .HasColumnName("URL")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.HasOne(d => d.CategorycodeNavigation)
                    .WithMany(p => p.Contacts)
                    .HasForeignKey(d => d.Categorycode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CONTACTS__CATEGO__5575A085");

                entity.HasOne(d => d.TitlecodeNavigation)
                    .WithMany(p => p.Contacts)
                    .HasForeignKey(d => d.Titlecode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CONTACTS__TITLEC__54817C4C");
            });

            modelBuilder.Entity<Correspondencein>(entity =>
            {
                entity.HasKey(e => e.Documentid)
                    .HasName("PK__CORRESPONDENCEIN__1352D76D");

                entity.ToTable("CORRESPONDENCEIN", "dbo");

                entity.HasIndex(e => e.Correspondencedate)
                    .HasName("CORRESPONDENCEIN2");

                entity.HasIndex(e => e.Internalid)
                    .HasName("CORRESPONDENCEIN1");

                entity.HasIndex(e => new { e.Internalid, e.Recordstatus, e.Userid, e.Documentid, e.Correspondencedate })
                    .HasName("CORRESPONDENCEIN3");

                entity.Property(e => e.Documentid).HasColumnName("DOCUMENTID");

                entity.Property(e => e.Action).HasColumnName("ACTION");

                entity.Property(e => e.Actiondate)
                    .HasColumnName("ACTIONDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Actioned).HasColumnName("ACTIONED");

                entity.Property(e => e.Category)
                    .HasColumnName("CATEGORY")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Checkdate)
                    .HasColumnName("CHECKDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Checkedby).HasColumnName("CHECKEDBY");

                entity.Property(e => e.Clinicalimage).HasColumnName("CLINICALIMAGE");

                entity.Property(e => e.Comment)
                    .HasColumnName("COMMENT")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Confidentialflag).HasColumnName("CONFIDENTIALFLAG");

                entity.Property(e => e.Contactid).HasColumnName("CONTACTID");

                entity.Property(e => e.Contactname)
                    .HasColumnName("CONTACTNAME")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Correspondencedate)
                    .HasColumnName("CORRESPONDENCEDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Detail)
                    .HasColumnName("DETAIL")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Internalid).HasColumnName("INTERNALID");

                entity.Property(e => e.Locationid).HasColumnName("LOCATIONID");

                entity.Property(e => e.Notation).HasColumnName("NOTATION");

                entity.Property(e => e.Origin).HasColumnName("ORIGIN");

                entity.Property(e => e.Pagesettings)
                    .HasColumnName("PAGESETTINGS")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Sendername)
                    .HasColumnName("SENDERNAME")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Statuscode).HasColumnName("STATUSCODE");

                entity.Property(e => e.Stored).HasColumnName("STORED");

                entity.Property(e => e.Subject)
                    .HasColumnName("SUBJECT")
                    .HasMaxLength(61)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.Property(e => e.Userreference)
                    .HasColumnName("USERREFERENCE")
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.Internal)
                    .WithMany(p => p.Correspondencein)
                    .HasForeignKey(d => d.Internalid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CORRESPON__INTER__1BE81D6E");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Correspondencein)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CORRESPON__USERI__1CDC41A7");
            });

            modelBuilder.Entity<Correspondenceout>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__CORRESPONDENCEOU__0D99FE17");

                entity.ToTable("CORRESPONDENCEOUT", "dbo");

                entity.HasIndex(e => e.Correspondencedate)
                    .HasName("CORRESPONDENCEOUT2");

                entity.HasIndex(e => e.Internalid)
                    .HasName("CORRESPONDENCEOUT1");

                entity.HasIndex(e => new { e.Stored, e.Sendername, e.Statuscode, e.Contactid, e.Contactname, e.Subject, e.Comment, e.Pagesettings, e.Created, e.Createdby, e.Updated, e.Updatedby, e.Internalid, e.Recordstatus, e.Recordid, e.Userid, e.Correspondencedate })
                    .HasName("CORRESPONDENCEOUT3");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Action).HasColumnName("ACTION");

                entity.Property(e => e.Actiondate)
                    .HasColumnName("ACTIONDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Actioned).HasColumnName("ACTIONED");

                entity.Property(e => e.Category)
                    .HasColumnName("CATEGORY")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Checkdate)
                    .HasColumnName("CHECKDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Checkedby).HasColumnName("CHECKEDBY");

                entity.Property(e => e.Comment)
                    .HasColumnName("COMMENT")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Confidentialflag).HasColumnName("CONFIDENTIALFLAG");

                entity.Property(e => e.Contactid).HasColumnName("CONTACTID");

                entity.Property(e => e.Contactname)
                    .HasColumnName("CONTACTNAME")
                    .HasMaxLength(90)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Correspondencedate)
                    .HasColumnName("CORRESPONDENCEDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Internalid).HasColumnName("INTERNALID");

                entity.Property(e => e.Locationid).HasColumnName("LOCATIONID");

                entity.Property(e => e.Notation).HasColumnName("NOTATION");

                entity.Property(e => e.Origin).HasColumnName("ORIGIN");

                entity.Property(e => e.Pagesettings)
                    .HasColumnName("PAGESETTINGS")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Sendername)
                    .HasColumnName("SENDERNAME")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Statuscode).HasColumnName("STATUSCODE");

                entity.Property(e => e.Stored).HasColumnName("STORED");

                entity.Property(e => e.Subject)
                    .HasColumnName("SUBJECT")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.Property(e => e.Userreference)
                    .HasColumnName("USERREFERENCE")
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.Internal)
                    .WithMany(p => p.Correspondenceout)
                    .HasForeignKey(d => d.Internalid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CORRESPON__INTER__10766AC2");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Correspondenceout)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CORRESPON__USERI__116A8EFB");
            });

            modelBuilder.Entity<Cstcodes>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CSTCODES", "dbo");

                entity.Property(e => e.Cstcode).HasColumnName("CSTCODE");

                entity.Property(e => e.Csttype)
                    .HasColumnName("CSTTYPE")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Ctg>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CTG", "dbo");

                entity.Property(e => e.Ctgdate)
                    .HasColumnName("CTGDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Ctgid).HasColumnName("CTGID");
            });

            modelBuilder.Entity<Currentrx>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__CURRENTRX__2101D846");

                entity.ToTable("CURRENTRX", "dbo");

                entity.HasIndex(e => e.Internalid)
                    .HasName("CURRENTRX1");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Allowsubstitution).HasColumnName("ALLOWSUBSTITUTION");

                entity.Property(e => e.Approvalnumber)
                    .HasColumnName("APPROVALNUMBER")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Authority).HasColumnName("AUTHORITY");

                entity.Property(e => e.AuthorityExpiry).HasColumnType("datetime");

                entity.Property(e => e.Authoritycode).HasColumnName("AUTHORITYCODE");

                entity.Property(e => e.Authoritydetail)
                    .HasColumnName("AUTHORITYDETAIL")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Authorityindication)
                    .HasColumnName("AUTHORITYINDICATION")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Authoritynumber)
                    .HasColumnName("AUTHORITYNUMBER")
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Barcode)
                    .HasMaxLength(17)
                    .IsUnicode(false);

                entity.Property(e => e.Comment)
                    .HasColumnName("COMMENT")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Compliancecheck).HasColumnName("COMPLIANCECHECK");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Deletiondate)
                    .HasColumnName("DELETIONDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deletionreason)
                    .HasColumnName("DELETIONREASON")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Dose)
                    .HasColumnName("DOSE")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Dosesperday)
                    .HasColumnName("DOSESPERDAY")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Drugname)
                    .HasColumnName("DRUGNAME")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Firstdate)
                    .HasColumnName("FIRSTDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Food).HasColumnName("FOOD");

                entity.Property(e => e.Frequency).HasColumnName("FREQUENCY");

                entity.Property(e => e.Indication)
                    .HasColumnName("INDICATION")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Indicationcode).HasColumnName("INDICATIONCODE");

                entity.Property(e => e.Instructions)
                    .HasColumnName("INSTRUCTIONS")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Internalid).HasColumnName("INTERNALID");

                entity.Property(e => e.Lastdate)
                    .HasColumnName("LASTDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Lastquantity).HasColumnName("LASTQUANTITY");

                entity.Property(e => e.Lastrepeats).HasColumnName("LASTREPEATS");

                entity.Property(e => e.Npdrconsent).HasColumnName("NPDRCONSENT");

                entity.Property(e => e.Otherdetail).HasColumnName("OTHERDETAIL");

                entity.Property(e => e.Packid).HasColumnName("PACKID");

                entity.Property(e => e.Patientconsent).HasColumnName("PATIENTCONSENT");

                entity.Property(e => e.Previousauthority).HasColumnName("PREVIOUSAUTHORITY");

                entity.Property(e => e.Prn).HasColumnName("PRN");

                entity.Property(e => e.Productid).HasColumnName("PRODUCTID");

                entity.Property(e => e.Productunit)
                    .HasColumnName("PRODUCTUNIT")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Quantity).HasColumnName("QUANTITY");

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Regulation24).HasColumnName("REGULATION24");

                entity.Property(e => e.Repeatinterval).HasColumnName("REPEATINTERVAL");

                entity.Property(e => e.Repeats).HasColumnName("REPEATS");

                entity.Property(e => e.Restrictioncode).HasColumnName("RESTRICTIONCODE");

                entity.Property(e => e.Route).HasColumnName("ROUTE");

                entity.Property(e => e.Rppa).HasColumnName("RPPA");

                entity.Property(e => e.Rxstatus).HasColumnName("RXSTATUS");

                entity.Property(e => e.Sahcno)
                    .HasColumnName("SAHCNO")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Scid)
                    .HasColumnName("SCID")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Scidno).HasColumnName("SCIDNO");

                entity.Property(e => e.Sendtopatient).HasColumnName("SENDTOPATIENT");

                entity.Property(e => e.Summary).HasColumnName("SUMMARY");

                entity.Property(e => e.Tgpexempt).HasColumnName("TGPEXEMPT");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Usepbsquantity).HasColumnName("USEPBSQUANTITY");

                entity.HasOne(d => d.Internal)
                    .WithMany(p => p.Currentrx)
                    .HasForeignKey(d => d.Internalid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CURRENTRX__INTER__33208881");

                entity.HasOne(d => d.Visit)
                    .WithMany(p => p.Currentrx)
                    .HasForeignKey(d => d.VisitId)
                    .HasConstraintName("FK__CURRENTRX__Visit__18826C35");
            });

            modelBuilder.Entity<CustomColours>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__CustomColours__5F54107A");

                entity.ToTable("CustomColours", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Colourid).HasColumnName("COLOURID");

                entity.Property(e => e.Colourref).HasColumnName("COLOURREF");
            });

            modelBuilder.Entity<CustomContactNoteReasons>(entity =>
            {
                entity.HasKey(e => e.RecordId)
                    .HasName("PK__CustomCo__FBDF78C91617382C");

                entity.ToTable("CustomContactNoteReasons", "dbo");

                entity.Property(e => e.RecordId).HasColumnName("RecordID");

                entity.Property(e => e.Au).HasColumnName("AU");

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Nz).HasColumnName("NZ");

                entity.Property(e => e.Reason)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Updated).HasColumnType("datetime");
            });

            modelBuilder.Entity<CustomReminderType>(entity =>
            {
                entity.HasKey(e => e.ReminderTypeId)
                    .HasName("PK__CustomRe__56776C12872930D0");

                entity.ToTable("CustomReminderType", "dbo");

                entity.Property(e => e.ReminderTypeId).HasColumnName("ReminderTypeID");

                entity.Property(e => e.Description)
                    .HasMaxLength(70)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Customavailability>(entity =>
            {
                entity.HasKey(e => e.Packid)
                    .HasName("PK__CUSTOMAVAILABILI__5F3414E9");

                entity.ToTable("CUSTOMAVAILABILITY", "dbo");

                entity.Property(e => e.Packid).HasColumnName("PACKID");

                entity.Property(e => e.Amtmppcode)
                    .HasColumnName("AMTMPPCODE")
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Amttppcode)
                    .HasColumnName("AMTTPPCODE")
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Doseperunit).HasColumnName("DOSEPERUNIT");

                entity.Property(e => e.Dpmq).HasColumnName("DPMQ");

                entity.Property(e => e.Erxqty).HasColumnName("ERXQTY");

                entity.Property(e => e.Mbmcode).HasColumnName("MBMCode");

                entity.Property(e => e.Mrvsn).HasColumnName("MRVSN");

                entity.Property(e => e.PbscompanyCode)
                    .IsRequired()
                    .HasColumnName("PBSCompanyCode")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PbsdrugCode)
                    .IsRequired()
                    .HasColumnName("PBSDrugCode")
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Productid).HasColumnName("PRODUCTID");

                entity.Property(e => e.Productunit)
                    .HasColumnName("PRODUCTUNIT")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Quantity).HasColumnName("QUANTITY");

                entity.Property(e => e.Repeats).HasColumnName("REPEATS");

                entity.Property(e => e.Restriction).HasColumnName("RESTRICTION");

                entity.Property(e => e.Rpbsonly).HasColumnName("RPBSOnly");

                entity.Property(e => e.Section100).HasColumnName("SECTION100");
            });

            modelBuilder.Entity<Customclinicaldetails>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__CUSTOMCLINICALDE__697C9932");

                entity.ToTable("CUSTOMCLINICALDETAILS", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Itemname)
                    .IsRequired()
                    .HasColumnName("ITEMNAME")
                    .HasMaxLength(750)
                    .IsUnicode(false);

                entity.Property(e => e.Itemtype).HasColumnName("ITEMTYPE");

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Userid).HasColumnName("USERID");
            });

            modelBuilder.Entity<Customfields>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__CUSTOMFIELDS__740F363E");

                entity.ToTable("CUSTOMFIELDS", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Defaultvalue)
                    .HasColumnName("DEFAULTVALUE")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Fieldname)
                    .IsRequired()
                    .HasColumnName("FIELDNAME")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Fieldtype)
                    .IsRequired()
                    .HasColumnName("FIELDTYPE")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Internalid).HasColumnName("INTERNALID");

                entity.Property(e => e.Listboxarray)
                    .HasColumnName("LISTBOXARRAY")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Savevalue).HasColumnName("SAVEVALUE");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Usesavedvalue).HasColumnName("USESAVEDVALUE");
            });

            modelBuilder.Entity<CustomproductIngredient>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__CUSTOMPRODUCT_IN__5D4BCC77");

                entity.ToTable("CUSTOMPRODUCT_INGREDIENT", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Ingredientid).HasColumnName("INGREDIENTID");

                entity.Property(e => e.Ingredientname)
                    .HasColumnName("INGREDIENTNAME")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Productid).HasColumnName("PRODUCTID");

                entity.Property(e => e.Strength)
                    .HasColumnName("STRENGTH")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Strengthunit)
                    .HasColumnName("STRENGTHUNIT")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Customproductnames>(entity =>
            {
                entity.HasKey(e => e.Productnameid)
                    .HasName("PK__CUSTOMPRODUCTNAM__4668671F");

                entity.ToTable("CUSTOMPRODUCTNAMES", "dbo");

                entity.Property(e => e.Productnameid).HasColumnName("PRODUCTNAMEID");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Productname)
                    .IsRequired()
                    .HasColumnName("PRODUCTNAME")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Customproductnames)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CUSTOMPRO__USERI__4850AF91");
            });

            modelBuilder.Entity<Customproducts>(entity =>
            {
                entity.HasKey(e => e.Productid)
                    .HasName("PK__CUSTOMPRODUCTS__4A38F803");

                entity.ToTable("CUSTOMPRODUCTS", "dbo");

                entity.Property(e => e.Productid).HasColumnName("PRODUCTID");

                entity.Property(e => e.Address)
                    .HasColumnName("ADDRESS")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Breastcode).HasColumnName("BREASTCODE");

                entity.Property(e => e.Cmicode).HasColumnName("CMICODE");

                entity.Property(e => e.Companyform)
                    .HasColumnName("COMPANYFORM")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Companyid).HasColumnName("COMPANYID");

                entity.Property(e => e.Companyname)
                    .HasColumnName("COMPANYNAME")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Diseasecheck).HasColumnName("DISEASECHECK");

                entity.Property(e => e.Dosage)
                    .HasColumnName("DOSAGE")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Ean).HasColumnName("EAN");

                entity.Property(e => e.Fax)
                    .HasColumnName("FAX")
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Form)
                    .HasColumnName("FORM")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Formcode).HasColumnName("FORMCODE");

                entity.Property(e => e.Genericname)
                    .HasColumnName("GENERICNAME")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Glutencode).HasColumnName("GLUTENCODE");

                entity.Property(e => e.Intcheck).HasColumnName("INTCHECK");

                entity.Property(e => e.Listorder).HasColumnName("LISTORDER");

                entity.Property(e => e.Mimsbmcode).HasColumnName("MIMSBMCODE");

                entity.Property(e => e.Noteid).HasColumnName("NOTEID");

                entity.Property(e => e.Phone)
                    .HasColumnName("PHONE")
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Picode).HasColumnName("PICODE");

                entity.Property(e => e.Pregnancycode).HasColumnName("PREGNANCYCODE");

                entity.Property(e => e.Productdescription)
                    .HasColumnName("PRODUCTDESCRIPTION")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Productnameid).HasColumnName("PRODUCTNAMEID");

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Route)
                    .HasColumnName("ROUTE")
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Routeid).HasColumnName("ROUTEID");

                entity.Property(e => e.Sportcode).HasColumnName("SPORTCODE");

                entity.Property(e => e.Strength)
                    .HasColumnName("STRENGTH")
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.Property(e => e.Usestrength).HasColumnName("USESTRENGTH");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Customproducts)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CUSTOMPRO__USERI__5B638405");
            });

            modelBuilder.Entity<Customprompts>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__CUSTOMPROMPTS__6A85CC04");

                entity.ToTable("CUSTOMPROMPTS", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Aboriginal).HasColumnName("ABORIGINAL");

                entity.Property(e => e.Agebot).HasColumnName("AGEBOT");

                entity.Property(e => e.Agetop).HasColumnName("AGETOP");

                entity.Property(e => e.Checkfor)
                    .HasColumnName("CHECKFOR")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Checkin)
                    .HasColumnName("CHECKIN")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Descript)
                    .HasColumnName("DESCRIPT")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Disease)
                    .HasColumnName("DISEASE")
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Drug)
                    .HasColumnName("DRUG")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Drugclass)
                    .HasColumnName("DRUGCLASS")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Interval).HasColumnName("INTERVAL");

                entity.Property(e => e.Item)
                    .HasColumnName("ITEM")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Period).HasColumnName("PERIOD");

                entity.Property(e => e.Promptcode).HasColumnName("PROMPTCODE");

                entity.Property(e => e.Sex)
                    .HasColumnName("SEX")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Tsi).HasColumnName("TSI");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.Property(e => e.Value)
                    .HasColumnName("VALUE")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Customprompts)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CUSTOMPRO__USERI__7226EDCC");
            });

            modelBuilder.Entity<Customtests>(entity =>
            {
                entity.HasKey(e => e.Testid)
                    .HasName("PK__CUSTOMTESTS__64B7E415");

                entity.ToTable("CUSTOMTESTS", "dbo");

                entity.Property(e => e.Testid).HasColumnName("TESTID");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Testcode)
                    .HasColumnName("TESTCODE")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Testname)
                    .IsRequired()
                    .HasColumnName("TESTNAME")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Testtype).HasColumnName("TESTTYPE");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Customtests)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CUSTOMTES__USERI__679450C0");
            });

            modelBuilder.Entity<Dailymessages>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__DAILYMESSAGES__6BB9E75F");

                entity.ToTable("DAILYMESSAGES", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Locationid).HasColumnName("LOCATIONID");

                entity.Property(e => e.Message)
                    .HasColumnName("MESSAGE")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Messagedate)
                    .HasColumnName("MESSAGEDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");
            });

            modelBuilder.Entity<Dayofweek>(entity =>
            {
                entity.HasKey(e => e.Daycode)
                    .HasName("PK__DAYOFWEEK__39B87777");

                entity.ToTable("DAYOFWEEK", "dbo");

                entity.Property(e => e.Daycode)
                    .HasColumnName("DAYCODE")
                    .ValueGeneratedNever();

                entity.Property(e => e.Day)
                    .IsRequired()
                    .HasColumnName("DAY")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Daysaway>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__DAYSAWAY__7D4E87B5");

                entity.ToTable("DAYSAWAY", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Awayreason)
                    .HasColumnName("AWAYREASON")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Finishdate)
                    .HasColumnName("FINISHDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Startdate)
                    .HasColumnName("STARTDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Userid).HasColumnName("USERID");
            });

            modelBuilder.Entity<Defaultdose>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__DEFAULTDOSE__0169315C");

                entity.ToTable("DEFAULTDOSE", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Dose)
                    .HasColumnName("DOSE")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Food).HasColumnName("FOOD");

                entity.Property(e => e.Frequency).HasColumnName("FREQUENCY");

                entity.Property(e => e.Instructions)
                    .HasColumnName("INSTRUCTIONS")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Otherdetail).HasColumnName("OTHERDETAIL");

                entity.Property(e => e.Prn).HasColumnName("PRN");

                entity.Property(e => e.Productid).HasColumnName("PRODUCTID");

                entity.Property(e => e.Route).HasColumnName("ROUTE");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Defaultdose)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DEFAULTDO__USERI__07220AB2");
            });

            modelBuilder.Entity<Defaultmessaging>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__DEFAULTMESSAGING__1392CE8F");

                entity.ToTable("DEFAULTMESSAGING", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Messagingproviderid).HasColumnName("MESSAGINGPROVIDERID");

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.HasOne(d => d.Messagingprovider)
                    .WithMany(p => p.Defaultmessaging)
                    .HasForeignKey(d => d.Messagingproviderid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DEFAULTME__MESSA__166F3B3A");
            });

            modelBuilder.Entity<Deletedappointmentlocks>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__DELETEDA__84D4D4F54F6C1490");

                entity.ToTable("DELETEDAPPOINTMENTLOCKS", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Appointmentdate)
                    .HasColumnName("APPOINTMENTDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Appointmenttime).HasColumnName("APPOINTMENTTIME");

                entity.Property(e => e.Computer)
                    .HasColumnName("COMPUTER")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Deletedby).HasColumnName("DELETEDBY");

                entity.Property(e => e.Deleteddate)
                    .HasColumnName("DELETEDDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.HasOne(d => d.DeletedbyNavigation)
                    .WithMany(p => p.DeletedappointmentlocksDeletedbyNavigation)
                    .HasForeignKey(d => d.Deletedby)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DELETEDAP__DELET__181857E1");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.DeletedappointmentlocksUser)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DELETEDAP__USERI__172433A8");
            });

            modelBuilder.Entity<Deletedinvoicelocks>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__DELETEDI__84D4D4F542C32F32");

                entity.ToTable("DELETEDINVOICELOCKS", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Computer)
                    .HasColumnName("COMPUTER")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Deletedby).HasColumnName("DELETEDBY");

                entity.Property(e => e.Deleteddate)
                    .HasColumnName("DELETEDDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Invoiceid).HasColumnName("INVOICEID");

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.HasOne(d => d.DeletedbyNavigation)
                    .WithMany(p => p.DeletedinvoicelocksDeletedbyNavigation)
                    .HasForeignKey(d => d.Deletedby)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DELETEDIN__DELET__26667738");

                entity.HasOne(d => d.Invoice)
                    .WithMany(p => p.Deletedinvoicelocks)
                    .HasForeignKey(d => d.Invoiceid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DELETEDIN__INVOI__247E2EC6");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.DeletedinvoicelocksUser)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DELETEDIN__USERI__257252FF");
            });

            modelBuilder.Entity<Deletedmaolpaymentlocks>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__DELETEDM__84D4D4F5ED2905F9");

                entity.ToTable("DELETEDMAOLPAYMENTLOCKS", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Computer)
                    .HasColumnName("COMPUTER")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Deletedby).HasColumnName("DELETEDBY");

                entity.Property(e => e.Deleteddate)
                    .HasColumnName("DELETEDDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.HasOne(d => d.DeletedbyNavigation)
                    .WithMany(p => p.DeletedmaolpaymentlocksDeletedbyNavigation)
                    .HasForeignKey(d => d.Deletedby)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DELETEDMA__DELET__1DD13137");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.DeletedmaolpaymentlocksUser)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DELETEDMA__USERI__1CDD0CFE");
            });

            modelBuilder.Entity<Deletedvisitlocks>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__DELETEDV__84D4D4F5F2BEE696");

                entity.ToTable("DELETEDVISITLOCKS", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Computer)
                    .HasColumnName("COMPUTER")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Deletedby).HasColumnName("DELETEDBY");

                entity.Property(e => e.Deleteddate)
                    .HasColumnName("DELETEDDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.Property(e => e.Visitid).HasColumnName("VISITID");

                entity.HasOne(d => d.DeletedbyNavigation)
                    .WithMany(p => p.DeletedvisitlocksDeletedbyNavigation)
                    .HasForeignKey(d => d.Deletedby)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DELETEDVI__DELET__1447C6FD");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.DeletedvisitlocksUser)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DELETEDVI__USERI__1353A2C4");

                entity.HasOne(d => d.Visit)
                    .WithMany(p => p.Deletedvisitlocks)
                    .HasForeignKey(d => d.Visitid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DELETEDVI__VISIT__125F7E8B");
            });

            modelBuilder.Entity<Diabetes>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__DIABETES__0EC32C7A");

                entity.ToTable("DIABETES", "dbo");

                entity.HasIndex(e => new { e.Recordid, e.Userid, e.Datatime, e.Datavalue, e.Datevalue, e.Created, e.Createdby, e.Updated, e.Updatedby, e.Recordstatus, e.Internalid, e.Dataname, e.Datadate })
                    .HasName("DIABETES1");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Datadate)
                    .HasColumnName("DATADATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dataname)
                    .HasColumnName("DATANAME")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Datatime).HasColumnName("DATATIME");

                entity.Property(e => e.Datavalue)
                    .HasColumnName("DATAVALUE")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Datevalue)
                    .HasColumnName("DATEVALUE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Internalid).HasColumnName("INTERNALID");

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.HasOne(d => d.Internal)
                    .WithMany(p => p.Diabetes)
                    .HasForeignKey(d => d.Internalid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DIABETES__INTERN__119F9925");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Diabetes)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DIABETES__USERID__1293BD5E");
            });

            modelBuilder.Entity<Dispenseditems>(entity =>
            {
                entity.HasKey(e => e.Itemid)
                    .HasName("PK__DISPENSEDITEMS__1EA559DF");

                entity.ToTable("DISPENSEDITEMS", "dbo");

                entity.Property(e => e.Itemid).HasColumnName("ITEMID");

                entity.Property(e => e.Confidentialityflag)
                    .HasColumnName("CONFIDENTIALITYFLAG")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Dispensedate)
                    .HasColumnName("DISPENSEDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dispensedquantity).HasColumnName("DISPENSEDQUANTITY");

                entity.Property(e => e.Forcenotification).HasColumnName("FORCENOTIFICATION");

                entity.Property(e => e.Instructionsmodified).HasColumnName("INSTRUCTIONSMODIFIED");

                entity.Property(e => e.Internalid).HasColumnName("INTERNALID");

                entity.Property(e => e.Medicationmodified).HasColumnName("MEDICATIONMODIFIED");

                entity.Property(e => e.Packid).HasColumnName("PACKID");

                entity.Property(e => e.Patientconsent).HasColumnName("PATIENTCONSENT");

                entity.Property(e => e.Pharmacyid).HasColumnName("PHARMACYID");

                entity.Property(e => e.Pharmacynotes)
                    .HasColumnName("PHARMACYNOTES")
                    .IsUnicode(false);

                entity.Property(e => e.Productid).HasColumnName("PRODUCTID");

                entity.Property(e => e.Scid)
                    .HasColumnName("SCID")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sequence).HasColumnName("SEQUENCE");

                entity.Property(e => e.Supplynumber).HasColumnName("SUPPLYNUMBER");

                entity.Property(e => e.Tradename)
                    .HasColumnName("TRADENAME")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");
            });

            modelBuilder.Entity<Documentpages>(entity =>
            {
                entity.HasKey(e => e.Documentpageid)
                    .HasName("PK__DOCUMENTPAGES__1EC48A19");

                entity.ToTable("DOCUMENTPAGES", "dbo");

                entity.Property(e => e.Documentpageid).HasColumnName("DOCUMENTPAGEID");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Documentid).HasColumnName("DOCUMENTID");

                entity.Property(e => e.Pagenumber).HasColumnName("PAGENUMBER");

                entity.Property(e => e.Pagesettings)
                    .HasColumnName("PAGESETTINGS")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.HasOne(d => d.Document)
                    .WithMany(p => p.Documentpages)
                    .HasForeignKey(d => d.Documentid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DOCUMENTP__DOCUM__1FB8AE52");
            });

            modelBuilder.Entity<Documentstore>(entity =>
            {
                entity.HasKey(e => e.Currentstore)
                    .HasName("PK__DOCUMENTSTORE__17036CC0");

                entity.ToTable("DOCUMENTSTORE", "dbo");

                entity.Property(e => e.Currentstore).HasColumnName("CURRENTSTORE");

                entity.Property(e => e.Field2).HasColumnName("FIELD2");
            });

            modelBuilder.Entity<Documenttypes>(entity =>
            {
                entity.HasKey(e => e.Documenttypeid)
                    .HasName("PK__DOCUMENTTYPES__21A0F6C4");

                entity.ToTable("DOCUMENTTYPES", "dbo");

                entity.Property(e => e.Documenttypeid).HasColumnName("DOCUMENTTYPEID");

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasColumnName("CATEGORY")
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");
            });

            modelBuilder.Entity<Dosecodes>(entity =>
            {
                entity.HasKey(e => e.Dosecode)
                    .HasName("PK__DOSECODES__3F466844");

                entity.ToTable("DOSECODES", "dbo");

                entity.Property(e => e.Dosecode)
                    .HasColumnName("DOSECODE")
                    .ValueGeneratedNever();

                entity.Property(e => e.Dosetext)
                    .IsRequired()
                    .HasColumnName("DOSETEXT")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Drugcombinations>(entity =>
            {
                entity.HasKey(e => e.Combinationid)
                    .HasName("PK__DRUGCOMBINATIONS__147C05D0");

                entity.ToTable("DRUGCOMBINATIONS", "dbo");

                entity.Property(e => e.Combinationid).HasColumnName("COMBINATIONID");

                entity.Property(e => e.Combinationname)
                    .IsRequired()
                    .HasColumnName("COMBINATIONNAME")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Drugcombinations)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DRUGCOMBI__USERI__16644E42");
            });

            modelBuilder.Entity<Drugfavourites>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__DRUGFAVOURITES__090A5324");

                entity.ToTable("DRUGFAVOURITES", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Productnameid).HasColumnName("PRODUCTNAMEID");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Drugfavourites)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DRUGFAVOU__USERI__09FE775D");
            });

            modelBuilder.Entity<Drugsheets>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__DRUGSHEETS__4BB72C21");

                entity.ToTable("DRUGSHEETS", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Addressleft).HasColumnName("ADDRESSLEFT");

                entity.Property(e => e.Addresstop).HasColumnName("ADDRESSTOP");

                entity.Property(e => e.Allergiesleft).HasColumnName("ALLERGIESLEFT");

                entity.Property(e => e.Allergiestop).HasColumnName("ALLERGIESTOP");

                entity.Property(e => e.Bottommargin).HasColumnName("BOTTOMMARGIN");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Dateleft).HasColumnName("DATELEFT");

                entity.Property(e => e.Datetop).HasColumnName("DATETOP");

                entity.Property(e => e.Daysperpage).HasColumnName("DAYSPERPAGE");

                entity.Property(e => e.Dobleft).HasColumnName("DOBLEFT");

                entity.Property(e => e.Dobtop).HasColumnName("DOBTOP");

                entity.Property(e => e.Doctorleft).HasColumnName("DOCTORLEFT");

                entity.Property(e => e.Doctortop).HasColumnName("DOCTORTOP");

                entity.Property(e => e.Drugsleft).HasColumnName("DRUGSLEFT");

                entity.Property(e => e.Drugsperpage).HasColumnName("DRUGSPERPAGE");

                entity.Property(e => e.Drugstop).HasColumnName("DRUGSTOP");

                entity.Property(e => e.Generic).HasColumnName("GENERIC");

                entity.Property(e => e.Haslines).HasColumnName("HASLINES");

                entity.Property(e => e.Leftmargin).HasColumnName("LEFTMARGIN");

                entity.Property(e => e.Medicareleft).HasColumnName("MEDICARELEFT");

                entity.Property(e => e.Medicaretop).HasColumnName("MEDICARETOP");

                entity.Property(e => e.Nameleft).HasColumnName("NAMELEFT");

                entity.Property(e => e.Nametop).HasColumnName("NAMETOP");

                entity.Property(e => e.Portrait).HasColumnName("PORTRAIT");

                entity.Property(e => e.Prnseparate).HasColumnName("PRNSEPARATE");

                entity.Property(e => e.Recordleft).HasColumnName("RECORDLEFT");

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Recordtop).HasColumnName("RECORDTOP");

                entity.Property(e => e.Rightmargin).HasColumnName("RIGHTMARGIN");

                entity.Property(e => e.Sheetname)
                    .IsRequired()
                    .HasColumnName("SHEETNAME")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sheettitle)
                    .HasColumnName("SHEETTITLE")
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Timesperday).HasColumnName("TIMESPERDAY");

                entity.Property(e => e.Titleleft).HasColumnName("TITLELEFT");

                entity.Property(e => e.Titletop).HasColumnName("TITLETOP");

                entity.Property(e => e.Topmargin).HasColumnName("TOPMARGIN");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");
            });

            modelBuilder.Entity<Dtb>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__DTB__388F4914");

                entity.ToTable("DTB", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Opendate)
                    .HasColumnName("OPENDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Opentime).HasColumnName("OPENTIME");

                entity.Property(e => e.Userid).HasColumnName("USERID");
            });

            modelBuilder.Entity<Dvabatch>(entity =>
            {
                entity.HasKey(e => e.Batchid)
                    .HasName("PK__DVABATCH__03C67B1A");

                entity.ToTable("DVABATCH", "dbo");

                entity.HasIndex(e => new { e.Hicol, e.Recordstatus })
                    .HasName("DVABATCH1");

                entity.Property(e => e.Batchid).HasColumnName("BATCHID");

                entity.Property(e => e.Amount).HasColumnName("AMOUNT");

                entity.Property(e => e.Batchdate)
                    .HasColumnName("BATCHDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Batchnumber)
                    .IsRequired()
                    .HasColumnName("BATCHNUMBER")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Hicol).HasColumnName("HICOL");

                entity.Property(e => e.Hospital).HasColumnName("HOSPITAL");

                entity.Property(e => e.Locationid).HasColumnName("LOCATIONID");

                entity.Property(e => e.Paid).HasColumnName("PAID");

                entity.Property(e => e.Payee)
                    .HasColumnName("PAYEE")
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Paymentid).HasColumnName("PAYMENTID");

                entity.Property(e => e.Processed).HasColumnName("PROCESSED");

                entity.Property(e => e.Providerno)
                    .HasColumnName("PROVIDERNO")
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Services).HasColumnName("SERVICES");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.Property(e => e.Vouchers).HasColumnName("VOUCHERS");
            });

            modelBuilder.Entity<DvabatchService>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DVABATCH_SERVICE", "dbo");

                entity.HasIndex(e => new { e.Batchid, e.BatchServiceStatus })
                    .HasName("DVABATCH_SERVICE1");

                entity.Property(e => e.Batchid).HasColumnName("BATCHID");

                entity.Property(e => e.Claimserviceid)
                    .HasColumnName("CLAIMSERVICEID")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Serviceid).HasColumnName("SERVICEID");
            });

            modelBuilder.Entity<Dvaconditions>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__DVAConditions__1E45672C");

                entity.ToTable("DVAConditions", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Condition)
                    .HasColumnName("CONDITION")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Internalid).HasColumnName("INTERNALID");

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.HasOne(d => d.Internal)
                    .WithMany(p => p.Dvaconditions)
                    .HasForeignKey(d => d.Internalid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DVACondit__INTER__202DAF9E");
            });

            modelBuilder.Entity<Dvaextra>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__DVAExtra__4DF47A4E");

                entity.ToTable("DVAExtra", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Acpercentage).HasColumnName("ACPERCENTAGE");

                entity.Property(e => e.Acproviderno)
                    .HasColumnName("ACPROVIDERNO")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Aftercaretext)
                    .HasColumnName("AFTERCARETEXT")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Afterhours).HasColumnName("AFTERHOURS");

                entity.Property(e => e.Authorisedby)
                    .HasColumnName("AUTHORISEDBY")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Authorisetext)
                    .HasColumnName("AUTHORISETEXT")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Conditiontext)
                    .HasColumnName("CONDITIONTEXT")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Duplicateservicetext)
                    .HasColumnName("DUPLICATESERVICETEXT")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Duration).HasColumnName("DURATION");

                entity.Property(e => e.Endtime)
                    .HasColumnName("ENDTIME")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Invoiceid).HasColumnName("INVOICEID");

                entity.Property(e => e.Multipleproceduretext)
                    .HasColumnName("MULTIPLEPROCEDURETEXT")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Reasoncode)
                    .HasColumnName("REASONCODE")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Rei).HasColumnName("REI");

                entity.Property(e => e.Seconddevice).HasColumnName("SECONDDEVICE");

                entity.Property(e => e.Starttime)
                    .HasColumnName("STARTTIME")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");
            });

            modelBuilder.Entity<DvapaymentClaims>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__DVAPaymentClaims__455F344D");

                entity.ToTable("DVAPaymentClaims", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Amountclaimed).HasColumnName("AMOUNTCLAIMED");

                entity.Property(e => e.Batchid).HasColumnName("BATCHID");

                entity.Property(e => e.Claimbenefitpaid).HasColumnName("CLAIMBENEFITPAID");

                entity.Property(e => e.Claimdate)
                    .HasColumnName("CLAIMDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Claimid)
                    .HasColumnName("CLAIMID")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Paymentrundate)
                    .HasColumnName("PAYMENTRUNDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Paymentrunid).HasColumnName("PAYMENTRUNID");

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");
            });

            modelBuilder.Entity<DvapaymentRuns>(entity =>
            {
                entity.HasKey(e => e.PaymentRunId)
                    .HasName("PK__DVAPaymentRuns__409A7F30");

                entity.ToTable("DVAPaymentRuns", "dbo");

                entity.Property(e => e.PaymentRunId).HasColumnName("PaymentRunID");

                entity.Property(e => e.Bankaccountname)
                    .HasColumnName("BANKACCOUNTNAME")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Bankaccountnum)
                    .HasColumnName("BANKACCOUNTNUM")
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Bsbcode)
                    .HasColumnName("BSBCODE")
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Depositamount).HasColumnName("DEPOSITAMOUNT");

                entity.Property(e => e.Paymentrundate)
                    .HasColumnName("PAYMENTRUNDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Paymentrunnum).HasColumnName("PAYMENTRUNNUM");

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Userid).HasColumnName("USERID");
            });

            modelBuilder.Entity<DvaprocessReports>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__DVAProcessReport__2C938683");

                entity.ToTable("DVAProcessReports", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Accountreferencenum)
                    .HasColumnName("ACCOUNTREFERENCENUM")
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Batchid).HasColumnName("BATCHID");

                entity.Property(e => e.Bpserviceid).HasColumnName("BPSERVICEID");

                entity.Property(e => e.Cardflag)
                    .HasColumnName("CARDFLAG")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Chargeamount).HasColumnName("CHARGEAMOUNT");

                entity.Property(e => e.Claimbenefitpaid).HasColumnName("CLAIMBENEFITPAID");

                entity.Property(e => e.Claimchargeamount).HasColumnName("CLAIMCHARGEAMOUNT");

                entity.Property(e => e.Claimid)
                    .HasColumnName("CLAIMID")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Dateofservice)
                    .HasColumnName("DATEOFSERVICE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Explanationcode).HasColumnName("EXPLANATIONCODE");

                entity.Property(e => e.Internalid).HasColumnName("INTERNALID");

                entity.Property(e => e.Itemnum).HasColumnName("ITEMNUM");

                entity.Property(e => e.Noofpatientsseen).HasColumnName("NOOFPATIENTSSEEN");

                entity.Property(e => e.Patientfamilyname)
                    .HasColumnName("PATIENTFAMILYNAME")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Patientfirstname)
                    .HasColumnName("PATIENTFIRSTNAME")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Servicebenefitamount).HasColumnName("SERVICEBENEFITAMOUNT");

                entity.Property(e => e.Serviceid)
                    .HasColumnName("SERVICEID")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Servicingprovidernum)
                    .HasColumnName("SERVICINGPROVIDERNUM")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.Property(e => e.Veteranfilenum)
                    .HasColumnName("VETERANFILENUM")
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Voucherid)
                    .HasColumnName("VOUCHERID")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Dvatype>(entity =>
            {
                entity.HasKey(e => e.Dvacode)
                    .HasName("PK__DVATYPE__5441852A");

                entity.ToTable("DVATYPE", "dbo");

                entity.Property(e => e.Dvacode)
                    .HasColumnName("DVACODE")
                    .ValueGeneratedNever();

                entity.Property(e => e.Dvatype1)
                    .IsRequired()
                    .HasColumnName("DVATYPE")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<EasyclaimService>(entity =>
            {
                entity.ToTable("EASYCLAIM_SERVICE", "dbo");

                entity.Property(e => e.EasyclaimServiceid).HasColumnName("EASYCLAIM_SERVICEID");

                entity.Property(e => e.Adjusted).HasColumnName("ADJUSTED");

                entity.Property(e => e.Bulkbilleasyclaimid).HasColumnName("BULKBILLEASYCLAIMID");

                entity.Property(e => e.Claimid)
                    .HasColumnName("CLAIMID")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Claimserviceid)
                    .HasColumnName("CLAIMSERVICEID")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Easyclaimid).HasColumnName("EASYCLAIMID");

                entity.Property(e => e.Errorcode)
                    .HasColumnName("ERRORCODE")
                    .HasMaxLength(50);

                entity.Property(e => e.Paymentrunid).HasColumnName("PAYMENTRUNID");

                entity.Property(e => e.Serviceid).HasColumnName("SERVICEID");

                entity.Property(e => e.Transactionstatus).HasColumnName("TRANSACTIONSTATUS");

                entity.HasOne(d => d.Bulkbilleasyclaim)
                    .WithMany(p => p.EasyclaimService)
                    .HasForeignKey(d => d.Bulkbilleasyclaimid)
                    .HasConstraintName("FK__EASYCLAIM__BULKB__2A6C1246");

                entity.HasOne(d => d.Easyclaim)
                    .WithMany(p => p.EasyclaimService)
                    .HasForeignKey(d => d.Easyclaimid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EASYCLAIM_SERVICE_MEDICAREEASYCLAIM");

                entity.HasOne(d => d.Paymentrun)
                    .WithMany(p => p.EasyclaimService)
                    .HasForeignKey(d => d.Paymentrunid)
                    .HasConstraintName("FK_EASYCLAIM_SERVICE_EASYCLAIMPAYMENTRUNS");
            });

            modelBuilder.Entity<Easyclaimpaymentruns>(entity =>
            {
                entity.HasKey(e => e.Paymentrunid);

                entity.ToTable("EASYCLAIMPAYMENTRUNS", "dbo");

                entity.Property(e => e.Paymentrunid).HasColumnName("PAYMENTRUNID");

                entity.Property(e => e.Bankaccountname)
                    .HasColumnName("BANKACCOUNTNAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Bankaccountnum)
                    .HasColumnName("BANKACCOUNTNUM")
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.Bsbcode)
                    .HasColumnName("BSBCODE")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Depositamount).HasColumnName("DEPOSITAMOUNT");

                entity.Property(e => e.Paymentrundate)
                    .HasColumnName("PAYMENTRUNDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Paymentrunnum)
                    .HasColumnName("PAYMENTRUNNUM")
                    .HasMaxLength(50);

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");
            });

            modelBuilder.Entity<Educationleaflets>(entity =>
            {
                entity.HasKey(e => e.Leafletid)
                    .HasName("PK__EDUCATIONLEAFLET__7CA47C3F");

                entity.ToTable("EDUCATIONLEAFLETS", "dbo");

                entity.Property(e => e.Leafletid).HasColumnName("LEAFLETID");

                entity.Property(e => e.Categoryid).HasColumnName("CATEGORYID");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Leafletname)
                    .IsRequired()
                    .HasColumnName("LEAFLETNAME")
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Stored).HasColumnName("STORED");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Educationleaflets)
                    .HasForeignKey(d => d.Categoryid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__EDUCATION__CATEG__7F80E8EA");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Educationleaflets)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__EDUCATION__USERI__7E8CC4B1");
            });

            modelBuilder.Entity<Email>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__EMAIL__52442E1F");

                entity.ToTable("EMAIL", "dbo");

                entity.HasIndex(e => new { e.Email1, e.Internalid })
                    .HasName("EMAIL1");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Email1)
                    .HasColumnName("EMAIL")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Emailcode).HasColumnName("EMAILCODE");

                entity.Property(e => e.Internalid).HasColumnName("INTERNALID");

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.HasOne(d => d.Internal)
                    .WithMany(p => p.Email)
                    .HasForeignKey(d => d.Internalid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__EMAIL__INTERNALI__55209ACA");
            });

            modelBuilder.Entity<EnrolmentStatus>(entity =>
            {
                entity.HasKey(e => e.RecordId);

                entity.ToTable("ENROLMENT_STATUS", "dbo");

                entity.Property(e => e.RecordId).HasColumnName("RecordID");

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Updated).HasColumnType("datetime");
            });

            modelBuilder.Entity<Eorderpath>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("EORDERPATH", "dbo");

                entity.Property(e => e.Computer)
                    .HasColumnName("COMPUTER")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Contactid).HasColumnName("CONTACTID");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Filepath)
                    .HasColumnName("FILEPATH")
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.Recordid)
                    .HasColumnName("RECORDID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");
            });

            modelBuilder.Entity<Epcreports>(entity =>
            {
                entity.HasKey(e => e.Reportid)
                    .HasName("PK__EPCREPORTS__324172E1");

                entity.ToTable("EPCREPORTS", "dbo");

                entity.HasIndex(e => new { e.Stored, e.Reporttype, e.Reportstatus, e.Pagesettings, e.Created, e.Createdby, e.Updated, e.Updatedby, e.Reportsubtype, e.Recordstatus, e.Internalid, e.Reportid, e.Userid, e.Reportdate })
                    .HasName("EPCREPORTS1");

                entity.Property(e => e.Reportid).HasColumnName("REPORTID");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Duration).HasColumnName("DURATION");

                entity.Property(e => e.Internalid).HasColumnName("INTERNALID");

                entity.Property(e => e.Pagesettings)
                    .HasColumnName("PAGESETTINGS")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Reportdate)
                    .HasColumnName("REPORTDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Reportstatus).HasColumnName("REPORTSTATUS");

                entity.Property(e => e.Reportsubtype).HasColumnName("REPORTSUBTYPE");

                entity.Property(e => e.Reporttype).HasColumnName("REPORTTYPE");

                entity.Property(e => e.Stored).HasColumnName("STORED");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.HasOne(d => d.Internal)
                    .WithMany(p => p.Epcreports)
                    .HasForeignKey(d => d.Internalid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__EPCREPORT__INTER__361203C5");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Epcreports)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__EPCREPORT__USERI__370627FE");
            });

            modelBuilder.Entity<Epctext>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__EPCTEXT__3F9B6DFF");

                entity.ToTable("EPCTEXT", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Datadate)
                    .HasColumnName("DATADATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dataname)
                    .IsRequired()
                    .HasColumnName("DATANAME")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Datastring)
                    .HasColumnName("DATASTRING")
                    .HasColumnType("text");

                entity.Property(e => e.Datatype).HasColumnName("DATATYPE");

                entity.Property(e => e.Datavalue).HasColumnName("DATAVALUE");

                entity.Property(e => e.Internalid).HasColumnName("INTERNALID");

                entity.Property(e => e.Recorddate)
                    .HasColumnName("RECORDDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Reportid).HasColumnName("REPORTID");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.HasOne(d => d.Internal)
                    .WithMany(p => p.Epctext)
                    .HasForeignKey(d => d.Internalid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__EPCTEXT__INTERNA__4277DAAA");

                entity.HasOne(d => d.Report)
                    .WithMany(p => p.Epctext)
                    .HasForeignKey(d => d.Reportid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__EPCTEXT__REPORTI__4460231C");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Epctext)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__EPCTEXT__USERID__436BFEE3");
            });

            modelBuilder.Entity<Epctypes>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("EPCTypes", "dbo");

                entity.Property(e => e.Epccode).HasColumnName("EPCCODE");

                entity.Property(e => e.Epctext)
                    .HasColumnName("EPCTEXT")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Epcvalues>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__EPCVALUES__38EE7070");

                entity.ToTable("EPCVALUES", "dbo");

                entity.HasIndex(e => new { e.Reportid, e.Datatype })
                    .HasName("EPCVALUES1");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Datadate)
                    .HasColumnName("DATADATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dataname)
                    .IsRequired()
                    .HasColumnName("DATANAME")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Datastring)
                    .HasColumnName("DATASTRING")
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.Datatype).HasColumnName("DATATYPE");

                entity.Property(e => e.Datavalue).HasColumnName("DATAVALUE");

                entity.Property(e => e.Internalid).HasColumnName("INTERNALID");

                entity.Property(e => e.Recorddate)
                    .HasColumnName("RECORDDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Reportid).HasColumnName("REPORTID");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.HasOne(d => d.Internal)
                    .WithMany(p => p.Epcvalues)
                    .HasForeignKey(d => d.Internalid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__EPCVALUES__INTER__3BCADD1B");

                entity.HasOne(d => d.Report)
                    .WithMany(p => p.Epcvalues)
                    .HasForeignKey(d => d.Reportid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__EPCVALUES__REPOR__3DB3258D");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Epcvalues)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__EPCVALUES__USERI__3CBF0154");
            });

            modelBuilder.Entity<EprescriptionLog>(entity =>
            {
                entity.HasKey(e => e.Logid)
                    .HasName("PK__eprescri__E39E279E3314E12C");

                entity.ToTable("eprescription_log", "dbo");

                entity.Property(e => e.Logid).HasColumnName("LOGID");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Errors)
                    .IsRequired()
                    .HasColumnName("ERRORS")
                    .IsUnicode(false);

                entity.Property(e => e.Message)
                    .IsRequired()
                    .HasColumnName("MESSAGE")
                    .IsUnicode(false);

                entity.Property(e => e.Messagetype)
                    .IsRequired()
                    .HasColumnName("MESSAGETYPE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Response)
                    .IsRequired()
                    .HasColumnName("RESPONSE")
                    .IsUnicode(false);

                entity.Property(e => e.Scid)
                    .IsRequired()
                    .HasColumnName("SCID")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.Scriptid).HasColumnName("SCRIPTID");
            });

            modelBuilder.Entity<Ereferrals>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__EREFERRALS__39A368DE");

                entity.ToTable("EREFERRALS", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Ackcode).HasColumnName("ACKCODE");

                entity.Property(e => e.Ackdate)
                    .HasColumnName("ACKDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Details)
                    .HasColumnName("DETAILS")
                    .HasMaxLength(99)
                    .IsUnicode(false);

                entity.Property(e => e.Documentid).HasColumnName("DOCUMENTID");

                entity.Property(e => e.Internalid).HasColumnName("INTERNALID");

                entity.Property(e => e.Messageid)
                    .HasColumnName("MESSAGEID")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Messagingproviderid).HasColumnName("MESSAGINGPROVIDERID");

                entity.Property(e => e.Recipientid).HasColumnName("RECIPIENTID");

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Statuscode).HasColumnName("STATUSCODE");

                entity.Property(e => e.Storeddate)
                    .HasColumnName("STOREDDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Transmitdate)
                    .HasColumnName("TRANSMITDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.HasOne(d => d.Internal)
                    .WithMany(p => p.Ereferrals)
                    .HasForeignKey(d => d.Internalid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__EREFERRAL__UPDAT__3D73F9C2");

                entity.HasOne(d => d.Messagingprovider)
                    .WithMany(p => p.Ereferrals)
                    .HasForeignKey(d => d.Messagingproviderid)
                    .HasConstraintName("FK_EREFERRALS_MESSAGINGPROVIDERS");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Ereferrals)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__EREFERRAL__USERI__3E681DFB");
            });

            modelBuilder.Entity<Erx>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__ERX__49EEDF40");

                entity.ToTable("ERX", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Certificate)
                    .HasColumnName("CERTIFICATE")
                    .HasColumnType("image");

                entity.Property(e => e.Filename)
                    .HasColumnName("FILENAME")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Password)
                    .HasColumnName("PASSWORD")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Thumbprint)
                    .HasColumnName("THUMBPRINT")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<ErxSetup>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__ErxSetup__6932806F");

                entity.ToTable("ErxSetup", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Port).HasColumnName("PORT");

                entity.Property(e => e.Servername)
                    .HasColumnName("SERVERNAME")
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");
            });

            modelBuilder.Entity<Ethnicity>(entity =>
            {
                entity.HasKey(e => e.Ethniccode)
                    .HasName("PK__ETHNICITY__5812160E");

                entity.ToTable("ETHNICITY", "dbo");

                entity.Property(e => e.Ethniccode)
                    .HasColumnName("ETHNICCODE")
                    .ValueGeneratedNever();

                entity.Property(e => e.Ascceg).HasColumnName("ASCCEG");

                entity.Property(e => e.Ethnictype)
                    .IsRequired()
                    .HasColumnName("ETHNICTYPE")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Level0).HasColumnName("LEVEL0");

                entity.Property(e => e.Level1).HasColumnName("LEVEL1");

                entity.Property(e => e.Level2).HasColumnName("LEVEL2");

                entity.Property(e => e.Level3).HasColumnName("LEVEL3");

                entity.Property(e => e.Level4).HasColumnName("LEVEL4");

                entity.Property(e => e.Nzname)
                    .HasColumnName("NZNAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Extrasessions>(entity =>
            {
                entity.HasKey(e => e.Sessionid)
                    .HasName("PK__EXTRASESSIONS__75AD65ED");

                entity.ToTable("EXTRASESSIONS", "dbo");

                entity.HasIndex(e => new { e.Endtime, e.Rgb, e.Length, e.Locationid, e.Sessiondate, e.Userid, e.Recordstatus, e.Starttime })
                    .HasName("ExtraSessions_RecordStatusUserIDSessionsDate");

                entity.Property(e => e.Sessionid).HasColumnName("SESSIONID");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Endtime).HasColumnName("ENDTIME");

                entity.Property(e => e.Label)
                    .HasColumnName("LABEL")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Length).HasColumnName("LENGTH");

                entity.Property(e => e.Locationid).HasColumnName("LOCATIONID");

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Rgb).HasColumnName("RGB");

                entity.Property(e => e.Sessiondate)
                    .HasColumnName("SESSIONDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Special).HasColumnName("SPECIAL");

                entity.Property(e => e.Starttime).HasColumnName("STARTTIME");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Userid).HasColumnName("USERID");
            });

            modelBuilder.Entity<Factsheetcategories>(entity =>
            {
                entity.ToTable("FACTSHEETCATEGORIES", "dbo");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.IsPrimary).HasColumnName("Is_primary");
            });

            modelBuilder.Entity<FactsheetcategoriesSources>(entity =>
            {
                entity.HasKey(e => new { e.CategoryId, e.SourceId })
                    .HasName("PK_dbo.FACTSHEETCATEGORIES_SOURCES");

                entity.ToTable("FACTSHEETCATEGORIES_SOURCES", "dbo");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.SourceId).HasColumnName("SourceID");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.FactsheetcategoriesSources)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_dbo.FACTSHEETCATEGORIES_SOURCES_dbo.FACTSHEETCATEGGORIES_CategoryID");

                entity.HasOne(d => d.Source)
                    .WithMany(p => p.FactsheetcategoriesSources)
                    .HasForeignKey(d => d.SourceId)
                    .HasConstraintName("FK_dbo.FACTSHEETCATEGORIES_SOURCES_dbo.FACTSHEETCATEGGORYSOURCE_SourceID");
            });

            modelBuilder.Entity<Factsheetcategorysource>(entity =>
            {
                entity.ToTable("FACTSHEETCATEGORYSOURCE", "dbo");

                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<Factsheetcontents>(entity =>
            {
                entity.HasKey(e => new { e.FactSheetId, e.Language })
                    .HasName("PK_dbo.FACTSHEETCONTENTS");

                entity.ToTable("FACTSHEETCONTENTS", "dbo");

                entity.Property(e => e.FactSheetId).HasColumnName("FactSheetID");

                entity.Property(e => e.Language).HasMaxLength(128);

                entity.Property(e => e.FileUrl).HasColumnName("File_url");

                entity.HasOne(d => d.FactSheet)
                    .WithMany(p => p.Factsheetcontents)
                    .HasForeignKey(d => d.FactSheetId)
                    .HasConstraintName("FK_dbo.FACTSHEETCONTENTS_dbo.FACTSHEETS_FactSheetID");
            });

            modelBuilder.Entity<Factsheetdrugs>(entity =>
            {
                entity.ToTable("FACTSHEETDRUGS", "dbo");

                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<Factsheetgroups>(entity =>
            {
                entity.ToTable("FACTSHEETGROUPS", "dbo");

                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<Factsheets>(entity =>
            {
                entity.ToTable("FACTSHEETS", "dbo");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.DetailViewUrl).HasColumnName("Detail_view_url");

                entity.Property(e => e.EmailFactsheetUrl).HasColumnName("Email_factsheet_url");

                entity.Property(e => e.GroupId).HasColumnName("Group_Id");

                entity.Property(e => e.HealthFund).HasColumnName("Health_fund");

                entity.Property(e => e.IsActive).HasColumnName("Is_active");

                entity.Property(e => e.IsPaid).HasColumnName("Is_paid");

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.Property(e => e.SponsorName).HasColumnName("Sponsor_name");

                entity.Property(e => e.TypeId).HasColumnName("Type_Id");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.Factsheets)
                    .HasForeignKey(d => d.GroupId)
                    .HasConstraintName("FK_dbo.FACTSHEETS_dbo.FACTSHEETGROUPS_Group_Id");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.Factsheets)
                    .HasForeignKey(d => d.TypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dbo.FACTSHEETS_dbo.FACTSHEETTYPES_Type_Id");
            });

            modelBuilder.Entity<FactsheetsFactsheetcategories>(entity =>
            {
                entity.HasKey(e => new { e.FactSheetId, e.CategoryId })
                    .HasName("PK_dbo.FACTSHEETS_FACTSHEETCATEGORIES");

                entity.ToTable("FACTSHEETS_FACTSHEETCATEGORIES", "dbo");

                entity.Property(e => e.FactSheetId).HasColumnName("FactSheetID");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.FactsheetsFactsheetcategories)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_dbo.FACTSHEETS_FACTSHEETCATEGORIES_dbo.FACTSHEETCATEGGORIES_CategoryID");

                entity.HasOne(d => d.FactSheet)
                    .WithMany(p => p.FactsheetsFactsheetcategories)
                    .HasForeignKey(d => d.FactSheetId)
                    .HasConstraintName("FK_dbo.FACTSHEETS_FACTSHEETCATEGORIES_dbo.FACTSHEETS_FactSheetID");
            });

            modelBuilder.Entity<FactsheetsFactsheetdrugs>(entity =>
            {
                entity.HasKey(e => new { e.FactSheetId, e.FactSheetDrugId })
                    .HasName("PK_FactSheets_FactSheetDRUGS");

                entity.ToTable("FACTSHEETS_FACTSHEETDRUGS", "dbo");

                entity.Property(e => e.FactSheetId).HasColumnName("FactSheetID");

                entity.Property(e => e.FactSheetDrugId).HasColumnName("FactSheetDrugID");

                entity.HasOne(d => d.FactSheetDrug)
                    .WithMany(p => p.FactsheetsFactsheetdrugs)
                    .HasForeignKey(d => d.FactSheetDrugId)
                    .HasConstraintName("FK_FactSheets_FactSheetDRUGS_FACTSHEETDRUGS");

                entity.HasOne(d => d.FactSheet)
                    .WithMany(p => p.FactsheetsFactsheetdrugs)
                    .HasForeignKey(d => d.FactSheetId)
                    .HasConstraintName("FK_FactSheets_FactSheetDRUGS_FACTSHEETS");
            });

            modelBuilder.Entity<Factsheetshistory>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.FactSheetId });

                entity.ToTable("FACTSHEETSHISTORY", "dbo");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.FactSheetId).HasColumnName("FactSheetID");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.HasOne(d => d.FactSheet)
                    .WithMany(p => p.Factsheetshistory)
                    .HasForeignKey(d => d.FactSheetId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FACTSHEETSHISTORY_FACTSHEETS");
            });

            modelBuilder.Entity<Factsheettypes>(entity =>
            {
                entity.ToTable("FACTSHEETTYPES", "dbo");

                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<Factsheetuserfavourites>(entity =>
            {
                entity.HasKey(e => new { e.FactSheetId, e.UserId })
                    .HasName("PK_dbo.FACTSHEETUSERFAVOURITES");

                entity.ToTable("FACTSHEETUSERFAVOURITES", "dbo");

                entity.Property(e => e.FactSheetId).HasColumnName("FactSheetID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.HasOne(d => d.FactSheet)
                    .WithMany(p => p.Factsheetuserfavourites)
                    .HasForeignKey(d => d.FactSheetId)
                    .HasConstraintName("FK_dbo.FACTSHEETUSERFAVOURITES_dbo.FACTSHEETS_FactSheetID");
            });

            modelBuilder.Entity<Familyhistory>(entity =>
            {
                entity.HasKey(e => e.Internalid)
                    .HasName("PK__FAMILYHISTORY__6BAEFA67");

                entity.ToTable("FAMILYHISTORY", "dbo");

                entity.Property(e => e.Internalid)
                    .HasColumnName("INTERNALID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Adopted).HasColumnName("ADOPTED");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Fhcomment)
                    .HasColumnName("FHCOMMENT")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Matageatdeath).HasColumnName("MATAGEATDEATH");

                entity.Property(e => e.Matalive).HasColumnName("MATALIVE");

                entity.Property(e => e.Matcauseofdeath)
                    .HasColumnName("MATCAUSEOFDEATH")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Matcauseofdeathcode).HasColumnName("MATCAUSEOFDEATHCODE");

                entity.Property(e => e.Patageatdeath).HasColumnName("PATAGEATDEATH");

                entity.Property(e => e.Patalive).HasColumnName("PATALIVE");

                entity.Property(e => e.Patcauseofdeath)
                    .HasColumnName("PATCAUSEOFDEATH")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Patcauseofdeathcode).HasColumnName("PATCAUSEOFDEATHCODE");

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.HasOne(d => d.Internal)
                    .WithOne(p => p.Familyhistory)
                    .HasForeignKey<Familyhistory>(d => d.Internalid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__FAMILYHIS__INTER__74444068");
            });

            modelBuilder.Entity<Familyhistorydetail>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__FAMILYHISTORYDET__762C88DA");

                entity.ToTable("FAMILYHISTORYDETAIL", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Condition)
                    .IsRequired()
                    .HasColumnName("CONDITION")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Diseasecode).HasColumnName("DISEASECODE");

                entity.Property(e => e.Diseasecomment)
                    .HasColumnName("DISEASECOMMENT")
                    .IsUnicode(false);

                entity.Property(e => e.Internalid).HasColumnName("INTERNALID");

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Relationcode).HasColumnName("RELATIONCODE");

                entity.Property(e => e.Relationno).HasColumnName("RELATIONNO");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.HasOne(d => d.Internal)
                    .WithMany(p => p.Familyhistorydetail)
                    .HasForeignKey(d => d.Internalid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__FAMILYHIS__INTER__79FD19BE");

                entity.HasOne(d => d.RelationcodeNavigation)
                    .WithMany(p => p.Familyhistorydetail)
                    .HasForeignKey(d => d.Relationcode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__FAMILYHIS__RELAT__7AF13DF7");
            });

            modelBuilder.Entity<Favouritetestitems>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__FAVOURITETESTITE__7211DF33");

                entity.ToTable("FAVOURITETESTITEMS", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Favouriteid).HasColumnName("FAVOURITEID");

                entity.Property(e => e.Labtestcode)
                    .HasColumnName("LABTESTCODE")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Testid).HasColumnName("TESTID");

                entity.Property(e => e.Testname)
                    .HasColumnName("TESTNAME")
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.HasOne(d => d.Favourite)
                    .WithMany(p => p.Favouritetestitems)
                    .HasForeignKey(d => d.Favouriteid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__FAVOURITE__FAVOU__73FA27A5");
            });

            modelBuilder.Entity<Favouritetests>(entity =>
            {
                entity.HasKey(e => e.Favouriteid)
                    .HasName("PK__FAVOURITETESTS__6D4D2A16");

                entity.ToTable("FAVOURITETESTS", "dbo");

                entity.Property(e => e.Favouriteid).HasColumnName("FAVOURITEID");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Favouritename)
                    .HasColumnName("FAVOURITENAME")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Favouriteno).HasColumnName("FAVOURITENO");

                entity.Property(e => e.Labcode).HasColumnName("LABCODE");

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Favouritetests)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__FAVOURITE__USERI__702996C1");
            });

            modelBuilder.Entity<Feeding>(entity =>
            {
                entity.HasKey(e => e.Feedingcode)
                    .HasName("PK__FEEDING__123EB7A3");

                entity.ToTable("FEEDING", "dbo");

                entity.Property(e => e.Feedingcode)
                    .HasColumnName("FEEDINGCODE")
                    .ValueGeneratedNever();

                entity.Property(e => e.Feedingtext)
                    .IsRequired()
                    .HasColumnName("FEEDINGTEXT")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Feeschedules>(entity =>
            {
                entity.HasKey(e => e.Scheduleid)
                    .HasName("PK__FEESCHEDULES__42B7D1CC");

                entity.ToTable("FEESCHEDULES", "dbo");

                entity.Property(e => e.Scheduleid).HasColumnName("SCHEDULEID");

                entity.Property(e => e.Addfixed).HasColumnName("ADDFIXED");

                entity.Property(e => e.Addpercent).HasColumnName("ADDPERCENT");

                entity.Property(e => e.Percentex).HasColumnName("PERCENTEX");

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Rounding).HasColumnName("ROUNDING");

                entity.Property(e => e.Roundto).HasColumnName("ROUNDTO");

                entity.Property(e => e.Schedulename)
                    .HasColumnName("SCHEDULENAME")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<FhircategoryMapping>(entity =>
            {
                entity.HasKey(e => e.ExternalCode);

                entity.ToTable("FHIRCategoryMapping", "dbo");

                entity.Property(e => e.ExternalCode)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Updated).HasColumnType("datetime");

                entity.HasOne(d => d.CategoryCodeNavigation)
                    .WithMany(p => p.FhircategoryMapping)
                    .HasForeignKey(d => d.CategoryCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__FHIRCateg__Categ__76B76416");
            });

            modelBuilder.Entity<Fieldvalues>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__FIELDVALUES__75F77EB0");

                entity.ToTable("FIELDVALUES", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Fieldname)
                    .IsRequired()
                    .HasColumnName("FIELDNAME")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Fieldvalue)
                    .IsRequired()
                    .HasColumnName("FIELDVALUE")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Internalid).HasColumnName("INTERNALID");

                entity.Property(e => e.Linkid).HasColumnName("LINKID");

                entity.Property(e => e.Previoususerid).HasColumnName("PREVIOUSUSERID");

                entity.Property(e => e.Recdate)
                    .HasColumnName("RECDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Source)
                    .IsRequired()
                    .HasColumnName("SOURCE")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Fieldvalues)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__FIELDVALU__USERI__76EBA2E9");
            });

            modelBuilder.Entity<Followup>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__FOLLOWUP__0DA4EB0F");

                entity.ToTable("FOLLOWUP", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Comment)
                    .HasColumnName("COMMENT")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Commentdate)
                    .HasColumnName("COMMENTDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Commenttime).HasColumnName("COMMENTTIME");

                entity.Property(e => e.Converted).HasColumnName("CONVERTED");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Resultid).HasColumnName("RESULTID");

                entity.Property(e => e.Resulttype).HasColumnName("RESULTTYPE");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Userid).HasColumnName("USERID");
            });

            modelBuilder.Entity<Foodcodes>(entity =>
            {
                entity.HasKey(e => e.Foodcode)
                    .HasName("PK__FOODCODES__4316F928");

                entity.ToTable("FOODCODES", "dbo");

                entity.Property(e => e.Foodcode)
                    .HasColumnName("FOODCODE")
                    .ValueGeneratedNever();

                entity.Property(e => e.Foodtext)
                    .IsRequired()
                    .HasColumnName("FOODTEXT")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Forms>(entity =>
            {
                entity.HasKey(e => e.Formid)
                    .HasName("PK__FORMS__25A691D2");

                entity.ToTable("FORMS", "dbo");

                entity.Property(e => e.Formid).HasColumnName("FORMID");

                entity.Property(e => e.Category)
                    .HasColumnName("CATEGORY")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Formname)
                    .HasColumnName("FORMNAME")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Item)
                    .HasColumnName("ITEM")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");
            });

            modelBuilder.Entity<Frequencycodes>(entity =>
            {
                entity.HasKey(e => e.Frequencycode)
                    .HasName("PK__FREQUENCYCODES__412EB0B6");

                entity.ToTable("FREQUENCYCODES", "dbo");

                entity.Property(e => e.Frequencycode)
                    .HasColumnName("FREQUENCYCODE")
                    .ValueGeneratedNever();

                entity.Property(e => e.Frequencytext)
                    .IsRequired()
                    .HasColumnName("FREQUENCYTEXT")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Gbrdisplayorder>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__GBRDISPL__84D4D4F513A12FA7");

                entity.ToTable("GBRDISPLAYORDER", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Contextid).HasColumnName("CONTEXTID");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Displayorder).HasColumnName("DISPLAYORDER");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Userid).HasColumnName("USERID");
            });

            modelBuilder.Entity<Generatedtext>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__GENERATEDTEXT__7FEAFD3E");

                entity.ToTable("GENERATEDTEXT", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Notestext)
                    .HasColumnName("NOTESTEXT")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Textcode).HasColumnName("TEXTCODE");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Generatedtext)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__GENERATED__USERI__03BB8E22");
            });

            modelBuilder.Entity<Genericcounter>(entity =>
            {
                entity.HasKey(e => e.Countername)
                    .HasName("PK__GENERICCOUNTER__33D4B598");

                entity.ToTable("GENERICCOUNTER", "dbo");

                entity.Property(e => e.Countername)
                    .HasColumnName("COUNTERNAME")
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Countervalue).HasColumnName("COUNTERVALUE");
            });

            modelBuilder.Entity<Gp2gp>(entity =>
            {
                entity.HasKey(e => e.RecordId)
                    .HasName("PK__GP2GP__FBDF78C9FBBDA686");

                entity.ToTable("GP2GP", "dbo");

                entity.Property(e => e.RecordId).HasColumnName("RecordID");

                entity.Property(e => e.CorrespondenceId).HasColumnName("CorrespondenceID");

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.EffectiveDate).HasColumnType("datetime");

                entity.Property(e => e.From)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.InternalId).HasColumnName("InternalID");

                entity.Property(e => e.Patient)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ReportId).HasColumnName("ReportID");

                entity.Property(e => e.To)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TransferId)
                    .IsRequired()
                    .HasColumnName("TransferID")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Updated).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.Gp2gpCreatedByNavigation)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__GP2GP__CreatedBy__59E61B3E");

                entity.HasOne(d => d.UpdatedByNavigation)
                    .WithMany(p => p.Gp2gpUpdatedByNavigation)
                    .HasForeignKey(d => d.UpdatedBy)
                    .HasConstraintName("FK__GP2GP__UpdatedBy__5ADA3F77");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Gp2gpUser)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__GP2GP__UserID__5BCE63B0");
            });

            modelBuilder.Entity<Gp2gpfields>(entity =>
            {
                entity.HasKey(e => e.RecordId)
                    .HasName("PK__GP2GPFie__FBDF78C9FFAF40A7");

                entity.ToTable("GP2GPFields", "dbo");

                entity.Property(e => e.RecordId).HasColumnName("RecordID");

                entity.Property(e => e.Guid)
                    .IsRequired()
                    .HasColumnName("GUID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ImportId).HasColumnName("ImportID");

                entity.Property(e => e.TransferId).HasColumnName("TransferID");

                entity.HasOne(d => d.Transfer)
                    .WithMany(p => p.Gp2gpfields)
                    .HasForeignKey(d => d.TransferId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__GP2GPFiel__Trans__5EAAD05B");
            });

            modelBuilder.Entity<Graphics>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__GRAPHICS__086B34A6");

                entity.ToTable("GRAPHICS", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Content)
                    .HasColumnName("CONTENT")
                    .HasColumnType("image");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Imagecode).HasColumnName("IMAGECODE");

                entity.Property(e => e.Internalid).HasColumnName("INTERNALID");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Visitid).HasColumnName("VISITID");

                entity.HasOne(d => d.Internal)
                    .WithMany(p => p.Graphics)
                    .HasForeignKey(d => d.Internalid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__GRAPHICS__INTERN__095F58DF");

                entity.HasOne(d => d.Visit)
                    .WithMany(p => p.Graphics)
                    .HasForeignKey(d => d.Visitid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__GRAPHICS__VISITI__0A537D18");
            });

            modelBuilder.Entity<Grouppermissions>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__GROUPPERMISSIONS__4E53A1AA");

                entity.ToTable("GROUPPERMISSIONS", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Groupcode).HasColumnName("GROUPCODE");

                entity.Property(e => e.Permissioncode).HasColumnName("PERMISSIONCODE");

                entity.Property(e => e.Permissionlevel).HasColumnName("PERMISSIONLEVEL");

                entity.HasOne(d => d.GroupcodeNavigation)
                    .WithMany(p => p.Grouppermissions)
                    .HasForeignKey(d => d.Groupcode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__GROUPPERM__GROUP__5224328E");

                entity.HasOne(d => d.PermissioncodeNavigation)
                    .WithMany(p => p.Grouppermissions)
                    .HasForeignKey(d => d.Permissioncode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__GROUPPERM__PERMI__531856C7");
            });

            modelBuilder.Entity<Hchtiers>(entity =>
            {
                entity.HasKey(e => e.Tiercode)
                    .HasName("PK__HCHTIERS__FFBDCB75F0AA478C");

                entity.ToTable("HCHTIERS", "dbo");

                entity.Property(e => e.Tiercode)
                    .HasColumnName("TIERCODE")
                    .ValueGeneratedNever();

                entity.Property(e => e.Tiername)
                    .HasColumnName("TIERNAME")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Healthcarehomes>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HEALTHCAREHOMES", "dbo");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Internalid).HasColumnName("INTERNALID");

                entity.Property(e => e.Recordid)
                    .HasColumnName("RECORDID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Startdate)
                    .HasColumnName("STARTDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Tiercode).HasColumnName("TIERCODE");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.HasOne(d => d.Internal)
                    .WithMany(p => p.Healthcarehomes)
                    .HasForeignKey(d => d.Internalid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HEALTHCAR__INTER__5185DF67");

                entity.HasOne(d => d.TiercodeNavigation)
                    .WithMany(p => p.Healthcarehomes)
                    .HasForeignKey(d => d.Tiercode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HEALTHCAR__TIERC__527A03A0");
            });

            modelBuilder.Entity<Healthelink>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__HEALTHELINK__6E96540A");

                entity.ToTable("HEALTHELINK", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Accountname)
                    .HasColumnName("ACCOUNTNAME")
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Allowreenrol).HasColumnName("ALLOWREENROL");

                entity.Property(e => e.Forcereason).HasColumnName("FORCEREASON");

                entity.Property(e => e.Helcode).HasColumnName("HELCODE");

                entity.Property(e => e.Loginurl)
                    .HasColumnName("LOGINURL")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Receivingfacility)
                    .HasColumnName("RECEIVINGFACILITY")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Resend).HasColumnName("RESEND");

                entity.Property(e => e.Resenddays).HasColumnName("RESENDDAYS");

                entity.Property(e => e.Retries).HasColumnName("RETRIES");

                entity.Property(e => e.Serveronly).HasColumnName("SERVERONLY");
            });

            modelBuilder.Entity<Healthlinkform>(entity =>
            {
                entity.HasKey(e => e.Sessionkey);

                entity.ToTable("HEALTHLINKFORM", "dbo");

                entity.Property(e => e.Sessionkey)
                    .HasColumnName("SESSIONKEY")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Addressee)
                    .HasColumnName("ADDRESSEE")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Completed).HasColumnName("COMPLETED");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Data)
                    .HasColumnName("DATA")
                    .IsUnicode(false);

                entity.Property(e => e.Formstatus)
                    .IsRequired()
                    .HasColumnName("FORMSTATUS")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Internalid).HasColumnName("INTERNALID");

                entity.Property(e => e.Locationid).HasColumnName("LOCATIONID");

                entity.Property(e => e.Messageid)
                    .HasColumnName("MESSAGEID")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Resumepath)
                    .HasColumnName("RESUMEPATH")
                    .IsUnicode(false);

                entity.Property(e => e.Subject)
                    .HasColumnName("SUBJECT")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.Property(e => e.Viewid).HasColumnName("VIEWID");

                entity.Property(e => e.Visitid).HasColumnName("VISITID");

                entity.HasOne(d => d.Internal)
                    .WithMany(p => p.Healthlinkform)
                    .HasForeignKey(d => d.Internalid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HEALTHLIN__INTER__5F49EED9");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.Healthlinkform)
                    .HasForeignKey(d => d.Locationid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HEALTHLIN__LOCAT__6132374B");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Healthlinkform)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HEALTHLIN__USERI__603E1312");

                entity.HasOne(d => d.Visit)
                    .WithMany(p => p.Healthlinkform)
                    .HasForeignKey(d => d.Visitid)
                    .HasConstraintName("FK__HEALTHLIN__VISIT__62265B84");
            });

            modelBuilder.Entity<Healthlinksession>(entity =>
            {
                entity.HasKey(e => e.Sessionkey);

                entity.ToTable("HEALTHLINKSESSION", "dbo");

                entity.Property(e => e.Sessionkey)
                    .HasColumnName("SESSIONKEY")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Internalid).HasColumnName("INTERNALID");

                entity.Property(e => e.Locationid).HasColumnName("LOCATIONID");

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.Property(e => e.Visitid).HasColumnName("VISITID");

                entity.HasOne(d => d.Internal)
                    .WithMany(p => p.Healthlinksession)
                    .HasForeignKey(d => d.Internalid)
                    .HasConstraintName("FK__HEALTHLIN__INTER__59911583");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.Healthlinksession)
                    .HasForeignKey(d => d.Locationid)
                    .HasConstraintName("FK__HEALTHLIN__LOCAT__5B795DF5");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Healthlinksession)
                    .HasForeignKey(d => d.Userid)
                    .HasConstraintName("FK__HEALTHLIN__USERI__5A8539BC");

                entity.HasOne(d => d.Visit)
                    .WithMany(p => p.Healthlinksession)
                    .HasForeignKey(d => d.Visitid)
                    .HasConstraintName("FK__HEALTHLIN__VISIT__5C6D822E");
            });

            modelBuilder.Entity<Helid>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HELID", "dbo");

                entity.Property(e => e.Helid1)
                    .HasColumnName("HELID")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Userid).HasColumnName("USERID");
            });

            modelBuilder.Entity<HelmessageReport>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__HELMESSA__84D4D4F5F9A9793B");

                entity.ToTable("HELMESSAGE_REPORT", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Messageid).HasColumnName("MESSAGEID");

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Reportid).HasColumnName("REPORTID");
            });

            modelBuilder.Entity<HelmessageVisit>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__HELMESSA__84D4D4F5C500101F");

                entity.ToTable("HELMESSAGE_VISIT", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Messageid).HasColumnName("MESSAGEID");

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Visitid).HasColumnName("VISITID");
            });

            modelBuilder.Entity<Helmessages>(entity =>
            {
                entity.HasKey(e => e.Messageid)
                    .HasName("PK__HELMESSAGES__00B50445");

                entity.ToTable("HELMESSAGES", "dbo");

                entity.Property(e => e.Messageid).HasColumnName("MESSAGEID");

                entity.Property(e => e.Ackdate)
                    .HasColumnName("ACKDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Acknowledged).HasColumnName("ACKNOWLEDGED");

                entity.Property(e => e.Lastsent)
                    .HasColumnName("LASTSENT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Message)
                    .HasColumnName("MESSAGE")
                    .HasColumnType("text");

                entity.Property(e => e.Messagedate)
                    .HasColumnName("MESSAGEDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Resends).HasColumnName("RESENDS");
            });

            modelBuilder.Entity<Helobr>(entity =>
            {
                entity.HasKey(e => e.Obr)
                    .HasName("PK__HELOBR__0D1ADB2A");

                entity.ToTable("HELOBR", "dbo");

                entity.Property(e => e.Obr).HasColumnName("OBR");

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");
            });

            modelBuilder.Entity<Helpath>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__HELPATH__7CE47361");

                entity.ToTable("HELPATH", "dbo");

                entity.Property(e => e.Recordid)
                    .HasColumnName("RECORDID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Computer)
                    .HasColumnName("COMPUTER")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Hlpath)
                    .HasColumnName("HLPATH")
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.Pathtype).HasColumnName("PATHTYPE");

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");
            });

            modelBuilder.Entity<Helreports>(entity =>
            {
                entity.HasKey(e => e.Incomingid)
                    .HasName("PK__HELREPORTS__0B3292B8");

                entity.ToTable("HELREPORTS", "dbo");

                entity.Property(e => e.Incomingid)
                    .HasColumnName("INCOMINGID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Provider)
                    .HasColumnName("PROVIDER")
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Reportid).HasColumnName("REPORTID");
            });

            modelBuilder.Entity<Hiaudit>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__HIAUDIT__3B6BB5BF");

                entity.ToTable("HIAUDIT", "dbo");

                entity.HasIndex(e => e.Operation)
                    .HasName("IX_HIAUDIT");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Accessdate)
                    .HasColumnName("ACCESSDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Accesstime).HasColumnName("ACCESSTIME");

                entity.Property(e => e.Entitytype).HasColumnName("ENTITYTYPE");

                entity.Property(e => e.Hpii)
                    .HasColumnName("HPII")
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Hpio)
                    .HasColumnName("HPIO")
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Identifier)
                    .HasColumnName("IDENTIFIER")
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Internalid).HasColumnName("INTERNALID");

                entity.Property(e => e.Localid).HasColumnName("LOCALID");

                entity.Property(e => e.Messageid)
                    .HasColumnName("MESSAGEID")
                    .HasMaxLength(48)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Operation)
                    .HasColumnName("OPERATION")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SearchName)
                    .HasMaxLength(160)
                    .IsUnicode(false);

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.Property(e => e.Version)
                    .HasColumnName("VERSION")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.EntitytypeNavigation)
                    .WithMany(p => p.Hiaudit)
                    .HasForeignKey(d => d.Entitytype)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HIAUDIT__ENTITYT__22C00386");

                entity.HasOne(d => d.Internal)
                    .WithMany(p => p.Hiaudit)
                    .HasForeignKey(d => d.Internalid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HIAUDIT__INTERNA__47726548");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Hiaudit)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HIAUDIT__USERID__40306ADC");
            });

            modelBuilder.Entity<Hicstore>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__HICStore__15B0212B");

                entity.ToTable("HICStore", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Phrase)
                    .HasColumnName("PHRASE")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");
            });

            modelBuilder.Entity<Hientities>(entity =>
            {
                entity.HasKey(e => e.Entitytype)
                    .HasName("PK__HIENTITIES__1FE396DB");

                entity.ToTable("HIENTITIES", "dbo");

                entity.Property(e => e.Entitytype)
                    .HasColumnName("ENTITYTYPE")
                    .ValueGeneratedNever();

                entity.Property(e => e.Entityname)
                    .IsRequired()
                    .HasColumnName("ENTITYNAME")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Hierrors>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__HIERRORS__4218B34E");

                entity.ToTable("HIERRORS", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Entitytype).HasColumnName("ENTITYTYPE");

                entity.Property(e => e.Errorcode)
                    .HasColumnName("ERRORCODE")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Errordate)
                    .HasColumnName("ERRORDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Errortext)
                    .HasColumnName("ERRORTEXT")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Errortime).HasColumnName("ERRORTIME");

                entity.Property(e => e.Internalid).HasColumnName("INTERNALID");

                entity.Property(e => e.Localid).HasColumnName("LOCALID");

                entity.Property(e => e.Messageid)
                    .HasColumnName("MESSAGEID")
                    .HasMaxLength(48)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SearchName)
                    .HasMaxLength(160)
                    .IsUnicode(false);

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.HasOne(d => d.EntitytypeNavigation)
                    .WithMany(p => p.Hierrors)
                    .HasForeignKey(d => d.Entitytype)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HIERRORS__ENTITY__259C7031");

                entity.HasOne(d => d.Internal)
                    .WithMany(p => p.Hierrors)
                    .HasForeignKey(d => d.Internalid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HIERRORS__INTERN__48668981");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Hierrors)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HIERRORS__USERID__46DD686B");
            });

            modelBuilder.Entity<Hl7message>(entity =>
            {
                entity.ToTable("HL7MESSAGE", "dbo");

                entity.Property(e => e.Hl7messageid).HasColumnName("HL7MESSAGEID");

                entity.Property(e => e.Internalid).HasColumnName("INTERNALID");
            });

            modelBuilder.Entity<Ihihistory>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__IHIHISTORY__3BFFE745");

                entity.ToTable("IHIHISTORY", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Effective)
                    .HasColumnName("EFFECTIVE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Ihi)
                    .HasColumnName("IHI")
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Ihirecordstatus).HasColumnName("IHIRECORDSTATUS");

                entity.Property(e => e.Ihisource).HasColumnName("IHISOURCE");

                entity.Property(e => e.Ihistatus).HasColumnName("IHISTATUS");

                entity.Property(e => e.Internalid).HasColumnName("INTERNALID");

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.HasOne(d => d.Internal)
                    .WithMany(p => p.Ihihistory)
                    .HasForeignKey(d => d.Internalid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__IHIHISTOR__INTER__40C49C62");
            });

            modelBuilder.Entity<ImmunisationIndicationLink>(entity =>
            {
                entity.HasKey(e => e.RecordId)
                    .HasName("PK__Immunisa__FBDF78E9749D942B");

                entity.ToTable("ImmunisationIndicationLink", "dbo");

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Updated).HasColumnType("datetime");
            });

            modelBuilder.Entity<Immunisations>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__IMMUNISATIONS__573DED66");

                entity.ToTable("IMMUNISATIONS", "dbo");

                entity.HasIndex(e => e.Givendate)
                    .HasName("IMMUNISATIONS2");

                entity.HasIndex(e => e.Internalid)
                    .HasName("IMMUNISATIONS1");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Acir).HasColumnName("ACIR");

                entity.Property(e => e.Acirtransmitted)
                    .HasColumnName("ACIRTRANSMITTED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Administeredby).HasColumnName("ADMINISTEREDBY");

                entity.Property(e => e.Administeredbylocationid).HasColumnName("ADMINISTEREDBYLOCATIONID");

                entity.Property(e => e.Aefi).HasColumnName("AEFI");

                entity.Property(e => e.Aefitype).HasColumnName("AEFIType");

                entity.Property(e => e.Batchnumber)
                    .HasColumnName("BATCHNUMBER")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Comment)
                    .HasColumnName("COMMENT")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Consentcode).HasColumnName("CONSENTCODE");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.DateDue).HasColumnType("datetime");

                entity.Property(e => e.Expirydate)
                    .HasColumnName("EXPIRYDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Givendate)
                    .HasColumnName("GIVENDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Influenza)
                    .HasColumnName("INFLUENZA")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Influenzasent).HasColumnName("INFLUENZASENT");

                entity.Property(e => e.Internalid).HasColumnName("INTERNALID");

                entity.Property(e => e.Notgivenhere).HasColumnName("NOTGIVENHERE");

                entity.Property(e => e.Orderedbylocationid).HasColumnName("ORDEREDBYLOCATIONID");

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Route).HasColumnName("ROUTE");

                entity.Property(e => e.Sequence).HasColumnName("SEQUENCE");

                entity.Property(e => e.Sitecode).HasColumnName("SITECODE");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.Property(e => e.Vaccineid).HasColumnName("VACCINEID");

                entity.Property(e => e.Vaccinename)
                    .IsRequired()
                    .HasColumnName("VACCINENAME")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Vivas).HasColumnName("VIVAS");

                entity.Property(e => e.Vivasprinted)
                    .HasColumnName("VIVASPRINTED")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.Internal)
                    .WithMany(p => p.Immunisations)
                    .HasForeignKey(d => d.Internalid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__IMMUNISAT__INTER__63A3C44B");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Immunisations)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__IMMUNISAT__USERI__6497E884");

                entity.HasOne(d => d.Visit)
                    .WithMany(p => p.Immunisations)
                    .HasForeignKey(d => d.VisitId)
                    .HasConstraintName("FK__IMMUNISAT__Visit__0E04DDC2");
            });

            modelBuilder.Entity<Immunisedagainst>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__IMMUNISEDAGAINST__668030F6");

                entity.ToTable("IMMUNISEDAGAINST", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Diseaseid).HasColumnName("DISEASEID");

                entity.Property(e => e.Immunisationdate)
                    .HasColumnName("IMMUNISATIONDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Internalid).HasColumnName("INTERNALID");

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Sequence).HasColumnName("SEQUENCE");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Vaccinename)
                    .IsRequired()
                    .HasColumnName("VACCINENAME")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.Internal)
                    .WithMany(p => p.Immunisedagainst)
                    .HasForeignKey(d => d.Internalid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__IMMUNISED__INTER__695C9DA1");
            });

            modelBuilder.Entity<Incomingmail>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__INCOMINGMAIL__5AC46587");

                entity.ToTable("INCOMINGMAIL", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Addressee)
                    .HasColumnName("ADDRESSEE")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Attachments)
                    .HasColumnName("ATTACHMENTS")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Bcc)
                    .HasColumnName("BCC")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Bodytext)
                    .HasColumnName("BODYTEXT")
                    .HasColumnType("text");

                entity.Property(e => e.Copies)
                    .HasColumnName("COPIES")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Inboxid).HasColumnName("INBOXID");

                entity.Property(e => e.Internalid).HasColumnName("INTERNALID");

                entity.Property(e => e.Locationid).HasColumnName("LOCATIONID");

                entity.Property(e => e.Previoususerid).HasColumnName("PREVIOUSUSERID");

                entity.Property(e => e.Priority).HasColumnName("PRIORITY");

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Recvdate)
                    .HasColumnName("RECVDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Sender)
                    .HasColumnName("SENDER")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Senderemail)
                    .HasColumnName("SENDEREMAIL")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Sentdate)
                    .HasColumnName("SENTDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Subject)
                    .HasColumnName("SUBJECT")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Userid).HasColumnName("USERID");
            });

            modelBuilder.Entity<Incomingreports>(entity =>
            {
                entity.HasKey(e => e.Reportid)
                    .HasName("PK__INCOMINGREPORTS__3D7E1B63");

                entity.ToTable("INCOMINGREPORTS", "dbo");

                entity.HasIndex(e => new { e.Internalid, e.Recordstatus, e.Userid, e.Reportdate })
                    .HasName("INCOMINGREPORTS1");

                entity.Property(e => e.Reportid).HasColumnName("REPORTID");

                entity.Property(e => e.Action).HasColumnName("ACTION");

                entity.Property(e => e.Actiondate)
                    .HasColumnName("ACTIONDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Address)
                    .HasColumnName("ADDRESS")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Addressedto)
                    .HasColumnName("ADDRESSEDTO")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Category)
                    .HasColumnName("CATEGORY")
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Checkdate)
                    .HasColumnName("CHECKDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Checkedby).HasColumnName("CHECKEDBY");

                entity.Property(e => e.Checkstatus).HasColumnName("CHECKSTATUS");

                entity.Property(e => e.City)
                    .HasColumnName("CITY")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Collectiondate)
                    .HasColumnName("COLLECTIONDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Comment)
                    .HasColumnName("COMMENT")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Completionflag).HasColumnName("COMPLETIONFLAG");

                entity.Property(e => e.Confidential).HasColumnName("CONFIDENTIAL");

                entity.Property(e => e.Confidentialflag).HasColumnName("CONFIDENTIALFLAG");

                entity.Property(e => e.Contacted).HasColumnName("CONTACTED");

                entity.Property(e => e.Contactid).HasColumnName("CONTACTID");

                entity.Property(e => e.Contactname)
                    .HasColumnName("CONTACTNAME")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Correspondencedate)
                    .HasColumnName("CORRESPONDENCEDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Detail)
                    .HasColumnName("DETAIL")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Dob)
                    .HasColumnName("DOB")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dvacode).HasColumnName("DVACODE");

                entity.Property(e => e.Dvano)
                    .HasColumnName("DVANO")
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Email)
                    .HasColumnName("EMAIL")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Firstname)
                    .HasColumnName("FIRSTNAME")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Homephone)
                    .HasColumnName("HOMEPHONE")
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Hpii)
                    .HasColumnName("HPII")
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Hpio)
                    .HasColumnName("HPIO")
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Ihi)
                    .HasColumnName("IHI")
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Importdate)
                    .HasColumnName("IMPORTDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Importtype).HasColumnName("IMPORTTYPE");

                entity.Property(e => e.Internalid).HasColumnName("INTERNALID");

                entity.Property(e => e.Locationid).HasColumnName("LOCATIONID");

                entity.Property(e => e.Medicarelineno)
                    .HasColumnName("MEDICARELINENO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Medicareno)
                    .HasColumnName("MEDICARENO")
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Mobilephone)
                    .HasColumnName("MOBILEPHONE")
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NirrecordId).HasColumnName("NIRRecordId");

                entity.Property(e => e.Normalflag).HasColumnName("NORMALFLAG");

                entity.Property(e => e.Notation).HasColumnName("NOTATION");

                entity.Property(e => e.Postcode)
                    .HasColumnName("POSTCODE")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Previoususerid).HasColumnName("PREVIOUSUSERID");

                entity.Property(e => e.Progressstatus).HasColumnName("PROGRESSSTATUS");

                entity.Property(e => e.Providerid).HasColumnName("PROVIDERID");

                entity.Property(e => e.Providername)
                    .HasColumnName("PROVIDERNAME")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Providerno)
                    .HasColumnName("PROVIDERNO")
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Providerreference)
                    .HasColumnName("PROVIDERREFERENCE")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Recordno)
                    .HasColumnName("RECORDNO")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Reminder).HasColumnName("REMINDER");

                entity.Property(e => e.Reportbody)
                    .HasColumnName("REPORTBODY")
                    .HasColumnType("text");

                entity.Property(e => e.Reportdate)
                    .HasColumnName("REPORTDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Reportheader)
                    .HasColumnName("REPORTHEADER")
                    .HasColumnType("text");

                entity.Property(e => e.Reportsource).HasColumnName("REPORTSOURCE");

                entity.Property(e => e.Reporttime).HasColumnName("REPORTTIME");

                entity.Property(e => e.Requestby)
                    .HasColumnName("REQUESTBY")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Requestdate)
                    .HasColumnName("REQUESTDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Requestedtests)
                    .HasColumnName("REQUESTEDTESTS")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Requestid)
                    .HasColumnName("REQUESTID")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Servicecode)
                    .HasColumnName("SERVICECODE")
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sex)
                    .HasColumnName("SEX")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Storein).HasColumnName("STOREIN");

                entity.Property(e => e.Subject)
                    .HasColumnName("SUBJECT")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Surname)
                    .HasColumnName("SURNAME")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Testcode)
                    .HasColumnName("TESTCODE")
                    .HasMaxLength(18)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Testname)
                    .HasColumnName("TESTNAME")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Testno).HasColumnName("TESTNO");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.Property(e => e.Userreference)
                    .HasColumnName("USERREFERENCE")
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Workphone)
                    .HasColumnName("WORKPHONE")
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Incomingvalues>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__INCOMINGVALUES__5090EFD7");

                entity.ToTable("INCOMINGVALUES", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Abnormalflag)
                    .HasColumnName("ABNORMALFLAG")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Bpcode).HasColumnName("BPCODE");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Datatype)
                    .HasColumnName("DATATYPE")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Loinccode)
                    .HasColumnName("LOINCCODE")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Range)
                    .HasColumnName("RANGE")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Reportdate)
                    .HasColumnName("REPORTDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Reportid).HasColumnName("REPORTID");

                entity.Property(e => e.Resultname)
                    .HasColumnName("RESULTNAME")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Resultvalue)
                    .HasColumnName("RESULTVALUE")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Units)
                    .HasColumnName("UNITS")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.HasOne(d => d.Report)
                    .WithMany(p => p.Incomingvalues)
                    .HasForeignKey(d => d.Reportid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__INCOMINGV__REPOR__52793849");
            });

            modelBuilder.Entity<Inrdetail>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__INRDETAIL__6D2D2E85");

                entity.ToTable("INRDETAIL", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Comment)
                    .HasColumnName("COMMENT")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Inrreason)
                    .HasColumnName("INRREASON")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Internalid).HasColumnName("INTERNALID");

                entity.Property(e => e.Rangebottom)
                    .HasColumnName("RANGEBOTTOM")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Rangetop)
                    .HasColumnName("RANGETOP")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.HasOne(d => d.Internal)
                    .WithMany(p => p.Inrdetail)
                    .HasForeignKey(d => d.Internalid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__INRDETAIL__INTER__6F1576F7");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Inrdetail)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__INRDETAIL__USERI__70099B30");
            });

            modelBuilder.Entity<Inrvalues>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__INRVALUES__71F1E3A2");

                entity.ToTable("INRVALUES", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Comment)
                    .HasColumnName("COMMENT")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Inrdate)
                    .HasColumnName("INRDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Inrdose)
                    .HasColumnName("INRDOSE")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Inrvalue)
                    .HasColumnName("INRVALUE")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Internalid).HasColumnName("INTERNALID");

                entity.Property(e => e.Nextreview)
                    .HasColumnName("NEXTREVIEW")
                    .HasColumnType("datetime");

                entity.Property(e => e.Recorddate)
                    .HasColumnName("RECORDDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.HasOne(d => d.Internal)
                    .WithMany(p => p.Inrvalues)
                    .HasForeignKey(d => d.Internalid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__INRVALUES__INTER__73DA2C14");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Inrvalues)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__INRVALUES__USERI__74CE504D");
            });

            modelBuilder.Entity<Instructioncodes>(entity =>
            {
                entity.HasKey(e => e.Instructioncode)
                    .HasName("PK__INSTRUCTIONCODES__44FF419A");

                entity.ToTable("INSTRUCTIONCODES", "dbo");

                entity.Property(e => e.Instructioncode)
                    .HasColumnName("INSTRUCTIONCODE")
                    .ValueGeneratedNever();

                entity.Property(e => e.Instructiontext)
                    .IsRequired()
                    .HasColumnName("INSTRUCTIONTEXT")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Internetappointments>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__INTERNETAPPOINTM__56BECA79");

                entity.ToTable("INTERNETAPPOINTMENTS", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Appointmenttime).HasColumnName("APPOINTMENTTIME");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Dayofweek).HasColumnName("DAYOFWEEK");

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Userid).HasColumnName("USERID");
            });

            modelBuilder.Entity<Investigationpages>(entity =>
            {
                entity.HasKey(e => e.Investigationpageid);

                entity.ToTable("INVESTIGATIONPAGES", "dbo");

                entity.Property(e => e.Investigationpageid).HasColumnName("INVESTIGATIONPAGEID");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Pagenumber).HasColumnName("PAGENUMBER");

                entity.Property(e => e.Pagesettings)
                    .HasColumnName("PAGESETTINGS")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Reportid).HasColumnName("REPORTID");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.HasOne(d => d.Report)
                    .WithMany(p => p.Investigationpages)
                    .HasForeignKey(d => d.Reportid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_INVESTIGATIONPAGES_INVESTIGATIONPAGES");
            });

            modelBuilder.Entity<Investigations>(entity =>
            {
                entity.HasKey(e => e.Reportid)
                    .HasName("PK__INVESTIGATIONS__5708E33C");

                entity.ToTable("INVESTIGATIONS", "dbo");

                entity.HasIndex(e => e.Collectiondate)
                    .HasName("INVESTIGATIONS2");

                entity.HasIndex(e => e.Internalid)
                    .HasName("INVESTIGATIONS1");

                entity.HasIndex(e => new { e.Checkedby, e.Collectiondate })
                    .HasName("INVESTIGATIONS3");

                entity.HasIndex(e => new { e.Notation, e.Collectiondate })
                    .HasName("INVESTIGATIONS4");

                entity.HasIndex(e => new { e.Checkedby, e.Notation, e.Collectiondate })
                    .HasName("INVESTIGATIONS5");

                entity.HasIndex(e => new { e.Internalid, e.Recordstatus, e.Checkedby, e.Userid, e.Reportid, e.Collectiondate })
                    .HasName("INVESTIGATIONS6");

                entity.HasIndex(e => new { e.Importdate, e.Requestid, e.Requestdate, e.Providerreference, e.Providername, e.Providerid, e.Testname, e.Reportdate, e.Reporttime, e.Normalflag, e.Completionflag, e.Confidentialflag, e.Checkdate, e.Notation, e.Action, e.Comment, e.Actioned, e.Actiondate, e.Internalid, e.Recordstatus, e.Reportid, e.Checkedby, e.Userid, e.Collectiondate })
                    .HasName("INVESTIGATIONS7");

                entity.Property(e => e.Reportid).HasColumnName("REPORTID");

                entity.Property(e => e.Action).HasColumnName("ACTION");

                entity.Property(e => e.Actiondate)
                    .HasColumnName("ACTIONDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Actioned).HasColumnName("ACTIONED");

                entity.Property(e => e.Checkdate)
                    .HasColumnName("CHECKDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Checkedby).HasColumnName("CHECKEDBY");

                entity.Property(e => e.Collectiondate)
                    .HasColumnName("COLLECTIONDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Comment)
                    .HasColumnName("COMMENT")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Completionflag).HasColumnName("COMPLETIONFLAG");

                entity.Property(e => e.Confidentialflag).HasColumnName("CONFIDENTIALFLAG");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Importdate)
                    .HasColumnName("IMPORTDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Internalid).HasColumnName("INTERNALID");

                entity.Property(e => e.Locationid).HasColumnName("LOCATIONID");

                entity.Property(e => e.Normalflag).HasColumnName("NORMALFLAG");

                entity.Property(e => e.Notation).HasColumnName("NOTATION");

                entity.Property(e => e.Origin).HasColumnName("ORIGIN");

                entity.Property(e => e.Providerid).HasColumnName("PROVIDERID");

                entity.Property(e => e.Providername)
                    .HasColumnName("PROVIDERNAME")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Providerreference)
                    .HasColumnName("PROVIDERREFERENCE")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Reportbody)
                    .HasColumnName("REPORTBODY")
                    .HasColumnType("image");

                entity.Property(e => e.Reportdate)
                    .HasColumnName("REPORTDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Reportheader)
                    .HasColumnName("REPORTHEADER")
                    .HasColumnType("image");

                entity.Property(e => e.Reporttime).HasColumnName("REPORTTIME");

                entity.Property(e => e.Requestdate)
                    .HasColumnName("REQUESTDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Requestid).HasColumnName("REQUESTID");

                entity.Property(e => e.Stored).HasColumnName("STORED");

                entity.Property(e => e.Testname)
                    .HasColumnName("TESTNAME")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.HasOne(d => d.Internal)
                    .WithMany(p => p.Investigations)
                    .HasForeignKey(d => d.Internalid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__INVESTIGA__INTER__636EBA21");
            });

            modelBuilder.Entity<InvoiceDeposit>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__INVOICE___84D4D4F5FA450A9D");

                entity.ToTable("INVOICE_DEPOSIT", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Amount).HasColumnName("AMOUNT");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Depositid).HasColumnName("DEPOSITID");

                entity.Property(e => e.Invoiceid).HasColumnName("INVOICEID");

                entity.Property(e => e.Paymentid).HasColumnName("PAYMENTID");

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");
            });

            modelBuilder.Entity<Invoicedeletereason>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__INVOICEDELETEREA__66010E09");

                entity.ToTable("INVOICEDELETEREASON", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Invoiceid).HasColumnName("INVOICEID");

                entity.Property(e => e.Reason)
                    .HasColumnName("REASON")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");
            });

            modelBuilder.Entity<Invoicelock>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__INVOICEL__84D4D4F59AF4001B");

                entity.ToTable("INVOICELOCK", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Computer)
                    .HasColumnName("COMPUTER")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Invoiceid).HasColumnName("INVOICEID");

                entity.Property(e => e.Lockdate)
                    .HasColumnName("LOCKDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Locktime).HasColumnName("LOCKTIME");

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.HasOne(d => d.Invoice)
                    .WithMany(p => p.Invoicelock)
                    .HasForeignKey(d => d.Invoiceid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__INVOICELO__INVOI__21A1C21B");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Invoicelock)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__INVOICELO__USERI__20AD9DE2");
            });

            modelBuilder.Entity<Invoicenotes>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__INVOICENOTES__23C93658");

                entity.ToTable("INVOICENOTES", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Notetext)
                    .HasColumnName("NOTETEXT")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");
            });

            modelBuilder.Entity<Invoices>(entity =>
            {
                entity.HasKey(e => e.Invoiceid)
                    .HasName("PK__INVOICES__07CC1628");

                entity.ToTable("INVOICES", "dbo");

                entity.HasIndex(e => new { e.Internalid, e.Recordstatus, e.Invoicedate })
                    .HasName("INVOICES1");

                entity.HasIndex(e => new { e.Invoiceid, e.Payerid, e.Recordstatus, e.Payercode })
                    .HasName("Invoices_PID_RS_PC");

                entity.HasIndex(e => new { e.Payercode, e.Recordstatus, e.Locationid, e.Internalid, e.Userid, e.Invoiceid })
                    .HasName("INVOICES_PC_RS_LID_INT_UID_INVID");

                entity.HasIndex(e => new { e.Payercode, e.Recordstatus, e.Locationid, e.Userid, e.Invoiceid, e.Internalid })
                    .HasName("INVOICES_PC_RS_LID_UID_INVID_INT");

                entity.Property(e => e.Invoiceid).HasColumnName("INVOICEID");

                entity.Property(e => e.Accidentdate)
                    .HasColumnName("ACCIDENTDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Appointmentid).HasColumnName("APPOINTMENTID");

                entity.Property(e => e.Cargo).HasColumnName("CARGO");

                entity.Property(e => e.Claimno)
                    .HasColumnName("CLAIMNO")
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Complex).HasColumnName("COMPLEX");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Detailid).HasColumnName("DETAILID");

                entity.Property(e => e.Dirchecked).HasColumnName("DIRCHECKED");

                entity.Property(e => e.Discounted).HasColumnName("DISCOUNTED");

                entity.Property(e => e.Dvalocation)
                    .HasColumnName("DVALOCATION")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Feeschedule).HasColumnName("FEESCHEDULE");

                entity.Property(e => e.Fullprivatefee).HasColumnName("FULLPRIVATEFEE");

                entity.Property(e => e.Gst).HasColumnName("GST");

                entity.Property(e => e.Hospital).HasColumnName("HOSPITAL");

                entity.Property(e => e.Hospitalname)
                    .HasColumnName("HOSPITALNAME")
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.Imaging).HasColumnName("IMAGING");

                entity.Property(e => e.Internalid).HasColumnName("INTERNALID");

                entity.Property(e => e.Invoicedate)
                    .HasColumnName("INVOICEDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Locationid).HasColumnName("LOCATIONID");

                entity.Property(e => e.Multipleops).HasColumnName("MULTIPLEOPS");

                entity.Property(e => e.Multipleopschecked).HasColumnName("MULTIPLEOPSCHECKED");

                entity.Property(e => e.Nnac).HasColumnName("NNAC");

                entity.Property(e => e.Noreferralcode)
                    .HasColumnName("NOREFERRALCODE")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Notes)
                    .HasColumnName("NOTES")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Patients).HasColumnName("PATIENTS");

                entity.Property(e => e.Payercode).HasColumnName("PAYERCODE");

                entity.Property(e => e.Payerid).HasColumnName("PAYERID");

                entity.Property(e => e.Previoususerid).HasColumnName("PREVIOUSUSERID");

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Referralid).HasColumnName("REFERRALID");

                entity.Property(e => e.Senttoworkcover)
                    .HasColumnName("SENTTOWORKCOVER")
                    .HasColumnType("datetime");

                entity.Property(e => e.Total).HasColumnName("TOTAL");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.Property(e => e.Visittime)
                    .HasColumnName("VISITTIME")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<K10>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__K10__6B84DD35");

                entity.ToTable("K10", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Internalid).HasColumnName("INTERNALID");

                entity.Property(e => e.K10date)
                    .HasColumnName("K10DATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Score).HasColumnName("SCORE");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.HasOne(d => d.Internal)
                    .WithMany(p => p.K10)
                    .HasForeignKey(d => d.Internalid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__K10__INTERNALID__77EAB41A");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.K10)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__K10__USERID__78DED853");
            });

            modelBuilder.Entity<Labcodes>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__LABCODES__0ABD916C");

                entity.ToTable("LABCODES", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Labid).HasColumnName("LABID");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Usercode)
                    .IsRequired()
                    .HasColumnName("USERCODE")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Labcodes)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LABCODES__USERID__0BB1B5A5");
            });

            modelBuilder.Entity<Labellayouts>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__LABELLAYOUTS__3C34F16F");

                entity.ToTable("LABELLAYOUTS", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Addressleft).HasColumnName("ADDRESSLEFT");

                entity.Property(e => e.Addresstop).HasColumnName("ADDRESSTOP");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Dobleft).HasColumnName("DOBLEFT");

                entity.Property(e => e.Dobtop).HasColumnName("DOBTOP");

                entity.Property(e => e.Layoutname)
                    .IsRequired()
                    .HasColumnName("LAYOUTNAME")
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Medicareleft).HasColumnName("MEDICARELEFT");

                entity.Property(e => e.Medicaretop).HasColumnName("MEDICARETOP");

                entity.Property(e => e.Nameleft).HasColumnName("NAMELEFT");

                entity.Property(e => e.Nametop).HasColumnName("NAMETOP");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");
            });

            modelBuilder.Entity<Labels>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__LABELS__339FAB6E");

                entity.ToTable("LABELS", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Bottommargin).HasColumnName("BOTTOMMARGIN");

                entity.Property(e => e.Columns).HasColumnName("COLUMNS");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Fontname)
                    .HasColumnName("FONTNAME")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Fontsize).HasColumnName("FONTSIZE");

                entity.Property(e => e.Labelname)
                    .IsRequired()
                    .HasColumnName("LABELNAME")
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Leftmargin).HasColumnName("LEFTMARGIN");

                entity.Property(e => e.Rightmargin).HasColumnName("RIGHTMARGIN");

                entity.Property(e => e.Rows).HasColumnName("ROWS");

                entity.Property(e => e.Topmargin).HasColumnName("TOPMARGIN");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");
            });

            modelBuilder.Entity<Laboratories>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__LABORATORIES__004002F9");

                entity.ToTable("LABORATORIES", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Duplicateoffset).HasColumnName("DUPLICATEOFFSET");

                entity.Property(e => e.EformDefaultUrl)
                    .HasColumnName("EFormDefaultURL")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Labeloffset).HasColumnName("LABELOFFSET");

                entity.Property(e => e.Labels).HasColumnName("LABELS");

                entity.Property(e => e.Labid).HasColumnName("LABID");

                entity.Property(e => e.Patientcopy).HasColumnName("PATIENTCOPY");

                entity.Property(e => e.Plainpaper).HasColumnName("PLAINPAPER");

                entity.Property(e => e.Programname)
                    .HasColumnName("PROGRAMNAME")
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.Requestformat).HasColumnName("REQUESTFORMAT");

                entity.Property(e => e.Txcode).HasColumnName("TXCODE");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.HasOne(d => d.RequestformatNavigation)
                    .WithMany(p => p.Laboratories)
                    .HasForeignKey(d => d.Requestformat)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LABORATOR__REQUE__07E124C1");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Laboratories)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LABORATOR__USERI__08D548FA");
            });

            modelBuilder.Entity<Labouranalgesia>(entity =>
            {
                entity.HasKey(e => e.Analgesiacode)
                    .HasName("PK__LABOURANALGESIA__0A9D95DB");

                entity.ToTable("LABOURANALGESIA", "dbo");

                entity.Property(e => e.Analgesiacode)
                    .HasColumnName("ANALGESIACODE")
                    .ValueGeneratedNever();

                entity.Property(e => e.Analgesiatext)
                    .IsRequired()
                    .HasColumnName("ANALGESIATEXT")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Labouraugmentation>(entity =>
            {
                entity.HasKey(e => e.Augmentationcode)
                    .HasName("PK__LABOURAUGMENTATI__08B54D69");

                entity.ToTable("LABOURAUGMENTATION", "dbo");

                entity.Property(e => e.Augmentationcode)
                    .HasColumnName("AUGMENTATIONCODE")
                    .ValueGeneratedNever();

                entity.Property(e => e.Augmentationtext)
                    .IsRequired()
                    .HasColumnName("AUGMENTATIONTEXT")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Labourdelivery>(entity =>
            {
                entity.HasKey(e => e.Deliverycode)
                    .HasName("PK__LABOURDELIVERY__06CD04F7");

                entity.ToTable("LABOURDELIVERY", "dbo");

                entity.Property(e => e.Deliverycode)
                    .HasColumnName("DELIVERYCODE")
                    .ValueGeneratedNever();

                entity.Property(e => e.Deliverytext)
                    .IsRequired()
                    .HasColumnName("DELIVERYTEXT")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Labouronset>(entity =>
            {
                entity.HasKey(e => e.Onsetcode)
                    .HasName("PK__LABOURONSET__04E4BC85");

                entity.ToTable("LABOURONSET", "dbo");

                entity.Property(e => e.Onsetcode)
                    .HasColumnName("ONSETCODE")
                    .ValueGeneratedNever();

                entity.Property(e => e.Onsettext)
                    .IsRequired()
                    .HasColumnName("ONSETTEXT")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Leafletcategories>(entity =>
            {
                entity.HasKey(e => e.Categoryid)
                    .HasName("PK__LEAFLETCATEGORIE__78D3EB5B");

                entity.ToTable("LEAFLETCATEGORIES", "dbo");

                entity.Property(e => e.Categoryid).HasColumnName("CATEGORYID");

                entity.Property(e => e.Categoryname)
                    .HasColumnName("CATEGORYNAME")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Parentcategory).HasColumnName("PARENTCATEGORY");

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Leafletcategories)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LEAFLETCA__USERI__7ABC33CD");
            });

            modelBuilder.Entity<Letterhead>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__LETTERHEAD__2FCF1A8A");

                entity.ToTable("LETTERHEAD", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Content)
                    .HasColumnName("CONTENT")
                    .HasColumnType("text");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Locationid).HasColumnName("LOCATIONID");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Userid).HasColumnName("USERID");
            });

            modelBuilder.Entity<Linkdetails>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__LINKDETAILS__173876EA");

                entity.ToTable("LINKDETAILS", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Ignoreblanks).HasColumnName("IGNOREBLANKS");

                entity.Property(e => e.Linked).HasColumnName("LINKED");

                entity.Property(e => e.Overwrite).HasColumnName("OVERWRITE");

                entity.Property(e => e.Pracsoftformat).HasColumnName("PRACSOFTFORMAT");

                entity.Property(e => e.Transferdata).HasColumnName("TRANSFERDATA");

                entity.Property(e => e.Transferimm).HasColumnName("TRANSFERIMM");

                entity.Property(e => e.Transfervisits).HasColumnName("TRANSFERVISITS");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");
            });

            modelBuilder.Entity<Linkpaths>(entity =>
            {
                entity.HasKey(e => e.Computer)
                    .HasName("PK__LINKPATHS__1FCDBCEB");

                entity.ToTable("LINKPATHS", "dbo");

                entity.Property(e => e.Computer)
                    .HasColumnName("COMPUTER")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Immpath)
                    .HasColumnName("IMMPATH")
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.Inpath)
                    .HasColumnName("INPATH")
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.Outpath)
                    .HasColumnName("OUTPATH")
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.Readlink).HasColumnName("READLINK");

                entity.Property(e => e.Scriptpath)
                    .HasColumnName("SCRIPTPATH")
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Visitspath)
                    .HasColumnName("VISITSPATH")
                    .HasMaxLength(1024)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Liveswith>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LIVESWITH", "dbo");

                entity.Property(e => e.Liveswithcode).HasColumnName("LIVESWITHCODE");

                entity.Property(e => e.Liveswithtext)
                    .HasColumnName("LIVESWITHTEXT")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Locations>(entity =>
            {
                entity.HasKey(e => e.Locationid)
                    .HasName("PK__LOCATIONS__2B0A656D");

                entity.ToTable("LOCATIONS", "dbo");

                entity.Property(e => e.Locationid).HasColumnName("LOCATIONID");

                entity.Property(e => e.Abn)
                    .HasColumnName("ABN")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.Address1)
                    .HasColumnName("ADDRESS1")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Address2)
                    .HasColumnName("ADDRESS2")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Ahphone)
                    .HasColumnName("AHPHONE")
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AppLicenceExpiry).HasColumnType("datetime");

                entity.Property(e => e.City)
                    .HasColumnName("CITY")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Direxempt).HasColumnName("DIRExempt");

                entity.Property(e => e.Email)
                    .HasColumnName("EMAIL")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasColumnName("FAX")
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Hpio)
                    .HasColumnName("HPIO")
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Locationcode).HasColumnName("LOCATIONCODE");

                entity.Property(e => e.Locationname)
                    .IsRequired()
                    .HasColumnName("LOCATIONNAME")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Lspnumber)
                    .HasColumnName("LSPNUMBER")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Phone)
                    .HasColumnName("PHONE")
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Pkikey)
                    .HasColumnName("PKIKEY")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Postcode)
                    .HasColumnName("POSTCODE")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Rrma).HasColumnName("RRMA");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.HasOne(d => d.OnboardUserNavigation)
                    .WithMany(p => p.Locations)
                    .HasForeignKey(d => d.OnboardUser)
                    .HasConstraintName("FK__LOCATIONS__Onboa__5B0F49A1");
            });

            modelBuilder.Entity<LogDeletedReports>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LogDeletedReports", "dbo");

                entity.Property(e => e.Addressee)
                    .HasColumnName("ADDRESSEE")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Collectiondate)
                    .HasColumnName("COLLECTIONDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleteddate)
                    .HasColumnName("DELETEDDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deletedfrom).HasColumnName("DELETEDFROM");

                entity.Property(e => e.Dob)
                    .HasColumnName("DOB")
                    .HasColumnType("datetime");

                entity.Property(e => e.Firstname)
                    .HasColumnName("FIRSTNAME")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Internalid).HasColumnName("INTERNALID");

                entity.Property(e => e.Reportdate)
                    .HasColumnName("REPORTDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Requestdate)
                    .HasColumnName("REQUESTDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Surname)
                    .HasColumnName("SURNAME")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Testname)
                    .HasColumnName("TESTNAME")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Userid).HasColumnName("USERID");
            });

            modelBuilder.Entity<LogPatientMerge>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LogPatientMerge", "dbo");

                entity.Property(e => e.Mergedate)
                    .HasColumnName("MERGEDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Patient1).HasColumnName("PATIENT1");

                entity.Property(e => e.Patient2).HasColumnName("PATIENT2");

                entity.Property(e => e.Userid).HasColumnName("USERID");
            });

            modelBuilder.Entity<LogPatientsIn>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LogPatientsIn", "dbo");

                entity.Property(e => e.Computer)
                    .IsRequired()
                    .HasColumnName("COMPUTER")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Dob)
                    .HasColumnName("DOB")
                    .HasColumnType("datetime");

                entity.Property(e => e.Externalid)
                    .HasColumnName("EXTERNALID")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Firstname)
                    .HasColumnName("FIRSTNAME")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Internalid).HasColumnName("INTERNALID");

                entity.Property(e => e.Linkcode).HasColumnName("LINKCODE");

                entity.Property(e => e.Processcode).HasColumnName("PROCESSCODE");

                entity.Property(e => e.Processdate)
                    .HasColumnName("PROCESSDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Processtime).HasColumnName("PROCESSTIME");

                entity.Property(e => e.Surname)
                    .HasColumnName("SURNAME")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<LogReports>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LogReports", "dbo");

                entity.HasIndex(e => e.Processdate)
                    .HasName("LogReports1");

                entity.Property(e => e.Addressee)
                    .HasColumnName("ADDRESSEE")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Collectiondate)
                    .HasColumnName("COLLECTIONDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dob)
                    .HasColumnName("DOB")
                    .HasColumnType("datetime");

                entity.Property(e => e.Firstname)
                    .HasColumnName("FIRSTNAME")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Internalid).HasColumnName("INTERNALID");

                entity.Property(e => e.Loggedinid).HasColumnName("LOGGEDINID");

                entity.Property(e => e.Processcode).HasColumnName("PROCESSCODE");

                entity.Property(e => e.Processdate)
                    .HasColumnName("PROCESSDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Reportdate)
                    .HasColumnName("REPORTDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Requestdate)
                    .HasColumnName("REQUESTDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Surname)
                    .HasColumnName("SURNAME")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Testname)
                    .HasColumnName("TESTNAME")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Userid).HasColumnName("USERID");
            });

            modelBuilder.Entity<LogResultFiles>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LogResultFiles", "dbo");

                entity.HasIndex(e => e.Processdate)
                    .HasName("LogResultFiles1");

                entity.Property(e => e.Computer)
                    .IsRequired()
                    .HasColumnName("COMPUTER")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Filename)
                    .IsRequired()
                    .HasColumnName("FILENAME")
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Processcode).HasColumnName("PROCESSCODE");

                entity.Property(e => e.Processdate)
                    .HasColumnName("PROCESSDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Reportcount).HasColumnName("REPORTCOUNT");
            });

            modelBuilder.Entity<Login>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__LOGIN__09746778");

                entity.ToTable("LOGIN", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Computer)
                    .IsRequired()
                    .HasColumnName("COMPUTER")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Logintime)
                    .HasColumnName("LOGINTIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.Logouttime)
                    .HasColumnName("LOGOUTTIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Login)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LOGIN__USERID__0B5CAFEA");
            });

            modelBuilder.Entity<Machinepreferences>(entity =>
            {
                entity.HasKey(e => e.Recordid);

                entity.ToTable("MACHINEPREFERENCES", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Computer)
                    .HasColumnName("COMPUTER")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Preferencename)
                    .HasColumnName("PREFERENCENAME")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Preferencetextvalue)
                    .HasColumnName("PREFERENCETEXTVALUE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Preferencevalue).HasColumnName("PREFERENCEVALUE");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");
            });

            modelBuilder.Entity<Maolpaymentlock>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MAOLPAYMENTLOCK", "dbo");

                entity.Property(e => e.Computer)
                    .HasColumnName("COMPUTER")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Lockdate)
                    .HasColumnName("LOCKDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Locktime).HasColumnName("LOCKTIME");

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Maolpaymentlock)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__MAOLPAYME__USERI__1A00A053");
            });

            modelBuilder.Entity<Maolupdate>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__MAOLUpdate__26A5A303");

                entity.ToTable("MAOLUpdate", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Updatecompleted).HasColumnName("UPDATECOMPLETED");
            });

            modelBuilder.Entity<Maritalstatus>(entity =>
            {
                entity.HasKey(e => e.Maritalstatuscode)
                    .HasName("PK__MARITALSTATUS__52593CB8");

                entity.ToTable("MARITALSTATUS", "dbo");

                entity.Property(e => e.Maritalstatuscode)
                    .HasColumnName("MARITALSTATUSCODE")
                    .ValueGeneratedNever();

                entity.Property(e => e.Maritalstatusname)
                    .IsRequired()
                    .HasColumnName("MARITALSTATUSNAME")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<MedicareAlias>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__MedicareAlias__1A74D648");

                entity.ToTable("MedicareAlias", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Aliasname)
                    .HasColumnName("ALIASNAME")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Internalid).HasColumnName("INTERNALID");

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.HasOne(d => d.Internal)
                    .WithMany(p => p.MedicareAlias)
                    .HasForeignKey(d => d.Internalid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__MedicareA__INTER__1C5D1EBA");
            });

            modelBuilder.Entity<Medicarebatch>(entity =>
            {
                entity.HasKey(e => e.Batchid)
                    .HasName("PK__MEDICAREBATCH__7484378A");

                entity.ToTable("MEDICAREBATCH", "dbo");

                entity.HasIndex(e => new { e.Hicol, e.Recordstatus })
                    .HasName("MEDICAREBATCH1");

                entity.HasIndex(e => new { e.Batchid, e.Userid, e.Processed, e.Batchnumber, e.Hospital, e.Services, e.Vouchers, e.Amount, e.Paid, e.Paymentid, e.Providerno, e.Payee, e.Created, e.Createdby, e.Updated, e.Updatedby, e.Locationid, e.Hicol, e.Recordstatus, e.Batchdate })
                    .HasName("MEDICAREBATCH_HI_RS_BD");

                entity.Property(e => e.Batchid).HasColumnName("BATCHID");

                entity.Property(e => e.Amount).HasColumnName("AMOUNT");

                entity.Property(e => e.Batchdate)
                    .HasColumnName("BATCHDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Batchnumber)
                    .IsRequired()
                    .HasColumnName("BATCHNUMBER")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Hicol).HasColumnName("HICOL");

                entity.Property(e => e.Hospital).HasColumnName("HOSPITAL");

                entity.Property(e => e.Locationid).HasColumnName("LOCATIONID");

                entity.Property(e => e.Paid).HasColumnName("PAID");

                entity.Property(e => e.Payee)
                    .HasColumnName("PAYEE")
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Paymentid).HasColumnName("PAYMENTID");

                entity.Property(e => e.Processed).HasColumnName("PROCESSED");

                entity.Property(e => e.Providerno)
                    .HasColumnName("PROVIDERNO")
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Services).HasColumnName("SERVICES");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.Property(e => e.Vouchers).HasColumnName("VOUCHERS");
            });

            modelBuilder.Entity<Medicareeasyclaim>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__MEDICAREEASYCLAI__2784B8A3");

                entity.ToTable("MEDICAREEASYCLAIM", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Claimtype).HasColumnName("CLAIMTYPE");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Internalid).HasColumnName("INTERNALID");

                entity.Property(e => e.Invoiceid).HasColumnName("INVOICEID");

                entity.Property(e => e.Mid).HasColumnName("MID");

                entity.Property(e => e.Providerno)
                    .HasColumnName("PROVIDERNO")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Tid).HasColumnName("TID");

                entity.Property(e => e.Transactiondate)
                    .HasColumnName("TRANSACTIONDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Transactionerror)
                    .HasColumnName("TRANSACTIONERROR")
                    .HasMaxLength(500);

                entity.Property(e => e.Transactionerrorid).HasColumnName("TRANSACTIONERRORID");

                entity.Property(e => e.Transactionid)
                    .IsRequired()
                    .HasColumnName("TRANSACTIONID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Transactionresult).HasColumnName("TRANSACTIONRESULT");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Userid).HasColumnName("USERID");
            });

            modelBuilder.Entity<Medisecure>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__MEDISECURE__5DF5D7ED");

                entity.ToTable("MEDISECURE", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Barcode)
                    .HasColumnName("BARCODE")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Internalid).HasColumnName("INTERNALID");

                entity.Property(e => e.Returncode).HasColumnName("RETURNCODE");

                entity.Property(e => e.Scriptdate)
                    .HasColumnName("SCRIPTDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Scriptid).HasColumnName("SCRIPTID");

                entity.Property(e => e.Signed).HasColumnName("SIGNED");

                entity.Property(e => e.Userid).HasColumnName("USERID");
            });

            modelBuilder.Entity<Medrefercorrespondence>(entity =>
            {
                entity.HasKey(e => e.Recordid);

                entity.ToTable("MEDREFERCORRESPONDENCE", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Actionedbyrecipient).HasColumnName("ACTIONEDBYRECIPIENT");

                entity.Property(e => e.Certificateurl)
                    .HasColumnName("CERTIFICATEURL")
                    .HasMaxLength(250);

                entity.Property(e => e.Correspondenceinid).HasColumnName("CORRESPONDENCEINID");

                entity.Property(e => e.Correspondenceoutid).HasColumnName("CORRESPONDENCEOUTID");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Medreferid)
                    .HasColumnName("MEDREFERID")
                    .HasMaxLength(15);

                entity.Property(e => e.Medreferstatus)
                    .HasColumnName("MEDREFERSTATUS")
                    .HasMaxLength(15);

                entity.Property(e => e.Recipientid).HasColumnName("RECIPIENTID");

                entity.Property(e => e.Recipientname)
                    .HasColumnName("RECIPIENTNAME")
                    .HasMaxLength(50);

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.HasOne(d => d.Correspondenceout)
                    .WithMany(p => p.Medrefercorrespondence)
                    .HasForeignKey(d => d.Correspondenceoutid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MEDREFERCORRESPONDENCE_CORRESPONDENCEOUT");
            });

            modelBuilder.Entity<Medreviewdetails>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MEDREVIEWDETAILS", "dbo");

                entity.Property(e => e.Comment)
                    .HasColumnName("COMMENT")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Internalid).HasColumnName("INTERNALID");

                entity.Property(e => e.Productid).HasColumnName("PRODUCTID");

                entity.Property(e => e.Recommendations).HasColumnName("RECOMMENDATIONS");

                entity.Property(e => e.Recordid)
                    .HasColumnName("RECORDID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Reviewid).HasColumnName("REVIEWID");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.HasOne(d => d.Review)
                    .WithMany(p => p.Medreviewdetails)
                    .HasForeignKey(d => d.Reviewid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__MEDREVIEW__REVIE__32CB82C6");
            });

            modelBuilder.Entity<Medview>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__MEDVIEW__4F72AE6C");

                entity.ToTable("MEDVIEW", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Active).HasColumnName("ACTIVE");

                entity.Property(e => e.Port).HasColumnName("PORT");

                entity.Property(e => e.Server)
                    .HasColumnName("SERVER")
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Statement)
                    .HasColumnName("STATEMENT")
                    .HasMaxLength(1000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Medviewconsent>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__MEDVIEWCONSENT__53433F50");

                entity.ToTable("MEDVIEWCONSENT", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Consentafter).HasColumnName("CONSENTAFTER");

                entity.Property(e => e.Consentbefore).HasColumnName("CONSENTBEFORE");

                entity.Property(e => e.Internalid).HasColumnName("INTERNALID");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.HasOne(d => d.Internal)
                    .WithMany(p => p.Medviewconsent)
                    .HasForeignKey(d => d.Internalid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__MEDVIEWCO__INTER__58FC18A6");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Medviewconsent)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__MEDVIEWCO__USERI__59F03CDF");
            });

            modelBuilder.Entity<Messagegroups>(entity =>
            {
                entity.HasKey(e => e.Messagegroupid)
                    .HasName("PK__MESSAGEGROUPS__33DFA290");

                entity.ToTable("MESSAGEGROUPS", "dbo");

                entity.Property(e => e.Messagegroupid).HasColumnName("MESSAGEGROUPID");

                entity.Property(e => e.Messagegroup)
                    .HasColumnName("MESSAGEGROUP")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");
            });

            modelBuilder.Entity<Messagegroupusers>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__MESSAGEGROUPUSER__36BC0F3B");

                entity.ToTable("MESSAGEGROUPUSERS", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Messagegroupid).HasColumnName("MESSAGEGROUPID");

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.HasOne(d => d.Messagegroup)
                    .WithMany(p => p.Messagegroupusers)
                    .HasForeignKey(d => d.Messagegroupid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__MESSAGEGR__MESSA__3A8CA01F");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Messagegroupusers)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__MESSAGEGR__USERI__3B80C458");
            });

            modelBuilder.Entity<Messages>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__MESSAGES__2A563856");

                entity.ToTable("MESSAGES", "dbo");

                entity.HasIndex(e => e.Userid)
                    .HasName("MESSAGES1");

                entity.HasIndex(e => new { e.Userid, e.Messagestatus, e.Messagedate, e.Messagetime })
                    .HasName("MESSAGES2");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Fromid).HasColumnName("FROMID");

                entity.Property(e => e.Internalid).HasColumnName("INTERNALID");

                entity.Property(e => e.Message)
                    .HasColumnName("MESSAGE")
                    .HasColumnType("text");

                entity.Property(e => e.Messagedate)
                    .HasColumnName("MESSAGEDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Messageid).HasColumnName("MESSAGEID");

                entity.Property(e => e.Messagestatus).HasColumnName("MESSAGESTATUS");

                entity.Property(e => e.Messagetime).HasColumnName("MESSAGETIME");

                entity.Property(e => e.Previoususerid).HasColumnName("PREVIOUSUSERID");

                entity.Property(e => e.Priority).HasColumnName("PRIORITY");

                entity.Property(e => e.Subject)
                    .HasColumnName("SUBJECT")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Messages)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__MESSAGES__USERID__31F75A1E");
            });

            modelBuilder.Entity<Messagessent>(entity =>
            {
                entity.HasKey(e => e.Messageid)
                    .HasName("PK__MESSAGESSENT__22B5168E");

                entity.ToTable("MESSAGESSENT", "dbo");

                entity.Property(e => e.Messageid).HasColumnName("MESSAGEID");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Internalid).HasColumnName("INTERNALID");

                entity.Property(e => e.Message)
                    .HasColumnName("MESSAGE")
                    .HasColumnType("text");

                entity.Property(e => e.Messagedate)
                    .HasColumnName("MESSAGEDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Messagestatus).HasColumnName("MESSAGESTATUS");

                entity.Property(e => e.Messagetime).HasColumnName("MESSAGETIME");

                entity.Property(e => e.Previoususerid).HasColumnName("PREVIOUSUSERID");

                entity.Property(e => e.Priority).HasColumnName("PRIORITY");

                entity.Property(e => e.Sentto)
                    .HasColumnName("SENTTO")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Subject)
                    .HasColumnName("SUBJECT")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Messagessent)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__MESSAGESS__USERI__286DEFE4");
            });

            modelBuilder.Entity<Messagestatus>(entity =>
            {
                entity.HasKey(e => new { e.Statuscode, e.Methodcode });

                entity.ToTable("MESSAGESTATUS", "dbo");

                entity.Property(e => e.Statuscode).HasColumnName("STATUSCODE");

                entity.Property(e => e.Methodcode).HasColumnName("METHODCODE");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.MethodcodeNavigation)
                    .WithMany(p => p.Messagestatus)
                    .HasForeignKey(d => d.Methodcode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MESSAGESTATUS_ContactMethod");
            });

            modelBuilder.Entity<Messagingpath>(entity =>
            {
                entity.HasKey(e => e.RecordId)
                    .HasName("PK__MESSAGINGPATH__185783AC");

                entity.ToTable("MESSAGINGPATH", "dbo");

                entity.Property(e => e.RecordId).HasColumnName("RecordID");

                entity.Property(e => e.Computer)
                    .HasColumnName("COMPUTER")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Filepath)
                    .HasColumnName("FILEPATH")
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.Invalidaccessattempts).HasColumnName("INVALIDACCESSATTEMPTS");

                entity.Property(e => e.Messagingproviderid).HasColumnName("MESSAGINGPROVIDERID");

                entity.Property(e => e.Pathtype).HasColumnName("PATHTYPE");

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");
            });

            modelBuilder.Entity<Messagingproviders>(entity =>
            {
                entity.HasKey(e => e.Messagingproviderid)
                    .HasName("PK__MESSAGINGPROVIDE__10B661E4");

                entity.ToTable("MESSAGINGPROVIDERS", "dbo");

                entity.Property(e => e.Messagingproviderid).HasColumnName("MESSAGINGPROVIDERID");

                entity.Property(e => e.Accountid)
                    .HasColumnName("ACCOUNTID")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Pathin)
                    .HasColumnName("PATHIN")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Pathout)
                    .HasColumnName("PATHOUT")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Providername)
                    .HasColumnName("PROVIDERNAME")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Usecda).HasColumnName("USECDA");
            });

            modelBuilder.Entity<Miscellaneous>(entity =>
            {
                entity.HasKey(e => e.Itemdescription)
                    .HasName("PK__MISCELLANEOUS__37A5467C");

                entity.ToTable("MISCELLANEOUS", "dbo");

                entity.Property(e => e.Itemdescription)
                    .HasColumnName("ITEMDESCRIPTION")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Itemvalue)
                    .IsRequired()
                    .HasColumnName("ITEMVALUE")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Mmse>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__MMSE__5B4E756C");

                entity.ToTable("MMSE", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Internalid).HasColumnName("INTERNALID");

                entity.Property(e => e.Mmsedate)
                    .HasColumnName("MMSEDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Score).HasColumnName("SCORE");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.HasOne(d => d.Internal)
                    .WithMany(p => p.Mmse)
                    .HasForeignKey(d => d.Internalid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__MMSE__INTERNALID__68A8708A");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Mmse)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__MMSE__USERID__699C94C3");
            });

            modelBuilder.Entity<Moldetails>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__MOLDetails__10EB6C0E");

                entity.ToTable("MOLDetails", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.CertificateId)
                    .HasColumnName("CertificateID")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Email)
                    .HasColumnName("EMAIL")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Locationcode)
                    .HasColumnName("LOCATIONCODE")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Locationid).HasColumnName("LOCATIONID");

                entity.Property(e => e.PassPhrase)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProxyId)
                    .HasColumnName("ProxyID")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProxyPassword)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<NesnotificationParameters>(entity =>
            {
                entity.HasKey(e => e.RecordId)
                    .HasName("PK__NESNotif__FBDF78C9D3454F19");

                entity.ToTable("NESNotificationParameters", "dbo");

                entity.Property(e => e.RecordId).HasColumnName("RecordID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NotificationId).HasColumnName("NotificationID");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.Notification)
                    .WithMany(p => p.NesnotificationParameters)
                    .HasForeignKey(d => d.NotificationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__NESNotifi__Notif__278FA59B");
            });

            modelBuilder.Entity<NesnotificationStatus>(entity =>
            {
                entity.HasKey(e => e.StatusCode)
                    .HasName("PK__NESNotif__6A7B44FDCC31EC13");

                entity.ToTable("NESNotificationStatus", "dbo");

                entity.Property(e => e.StatusText)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Nesnotifications>(entity =>
            {
                entity.HasKey(e => e.NotificationId)
                    .HasName("PK__NESNotif__20CF2E32C179A754");

                entity.ToTable("NESNotifications", "dbo");

                entity.Property(e => e.NotificationId).HasColumnName("NotificationID");

                entity.Property(e => e.Imported).HasColumnType("datetime");

                entity.Property(e => e.LastError)
                    .HasMaxLength(1023)
                    .IsUnicode(false);

                entity.Property(e => e.LastPoll).HasColumnType("datetime");

                entity.Property(e => e.Nesid).HasColumnName("NESID");

                entity.Property(e => e.NotificationDate).HasColumnType("datetime");

                entity.Property(e => e.OperationName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Reason)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.Internal)
                    .WithMany(p => p.Nesnotifications)
                    .HasForeignKey(d => d.InternalId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__NESNotifi__Inter__23BF14B7");

                entity.HasOne(d => d.StatusNavigation)
                    .WithMany(p => p.Nesnotifications)
                    .HasForeignKey(d => d.Status)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__NESNotifi__Statu__24B338F0");
            });

            modelBuilder.Entity<Nextofkin>(entity =>
            {
                entity.ToTable("NEXTOFKIN", "dbo");

                entity.Property(e => e.Nextofkinid).HasColumnName("NEXTOFKINID");

                entity.Property(e => e.Address)
                    .HasColumnName("ADDRESS")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.City)
                    .HasColumnName("CITY")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Contactphone)
                    .HasColumnName("CONTACTPHONE")
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Contactphone2)
                    .HasColumnName("CONTACTPHONE2")
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Firstname)
                    .HasColumnName("FIRSTNAME")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Headoffamilyid).HasColumnName("HEADOFFAMILYID");

                entity.Property(e => e.Internalid).HasColumnName("INTERNALID");

                entity.Property(e => e.Postcode)
                    .HasColumnName("POSTCODE")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Relationship)
                    .HasColumnName("RELATIONSHIP")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Surname)
                    .HasColumnName("SURNAME")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Titlecode).HasColumnName("TITLECODE");

                entity.Property(e => e.Type).HasColumnName("TYPE");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.HasOne(d => d.TitlecodeNavigation)
                    .WithMany(p => p.Nextofkin)
                    .HasForeignKey(d => d.Titlecode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__NEXTOFKIN__TITLE__10216507");
            });

            modelBuilder.Entity<Nirmessages>(entity =>
            {
                entity.HasKey(e => e.RecordId)
                    .HasName("PK__NIRMessa__FBDF78E9ED03DBC8");

                entity.ToTable("NIRMessages", "dbo");

                entity.Property(e => e.AckComment)
                    .HasMaxLength(99)
                    .IsUnicode(false);

                entity.Property(e => e.AckDate).HasColumnType("datetime");

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Details)
                    .HasMaxLength(99)
                    .IsUnicode(false);

                entity.Property(e => e.MessageId)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Updated).HasColumnType("datetime");

                entity.HasOne(d => d.Immunisation)
                    .WithMany(p => p.Nirmessages)
                    .HasForeignKey(d => d.ImmunisationId)
                    .HasConstraintName("FK__NIRMessag__Immun__5F14E4AF");

                entity.HasOne(d => d.Internal)
                    .WithMany(p => p.Nirmessages)
                    .HasForeignKey(d => d.InternalId)
                    .HasConstraintName("FK__NIRMessag__Inter__5C387804");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.Nirmessages)
                    .HasForeignKey(d => d.LocationId)
                    .HasConstraintName("FK__NIRMessag__Locat__5E20C076");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Nirmessages)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__NIRMessag__UserI__5D2C9C3D");
            });

            modelBuilder.Entity<Notify>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__NOTIFY__34B3CB38");

                entity.ToTable("NOTIFY", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Internalid).HasColumnName("INTERNALID");

                entity.Property(e => e.Notation).HasColumnName("NOTATION");

                entity.Property(e => e.Testname)
                    .HasColumnName("TESTNAME")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.HasOne(d => d.Internal)
                    .WithMany(p => p.Notify)
                    .HasForeignKey(d => d.Internalid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__NOTIFY__INTERNAL__369C13AA");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Notify)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__NOTIFY__USERID__379037E3");
            });

            modelBuilder.Entity<Noyes>(entity =>
            {
                entity.HasKey(e => e.Yesnocode)
                    .HasName("PK__NOYES__3B75D760");

                entity.ToTable("NOYES", "dbo");

                entity.Property(e => e.Yesnocode)
                    .HasColumnName("YESNOCODE")
                    .ValueGeneratedNever();

                entity.Property(e => e.Yesnoword)
                    .IsRequired()
                    .HasColumnName("YESNOWORD")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Npsdetails>(entity =>
            {
                entity.HasKey(e => e.Detailid)
                    .HasName("PK__NPSDetails__6379A719");

                entity.ToTable("NPSDetails", "dbo");

                entity.Property(e => e.Detailid).HasColumnName("DETAILID");

                entity.Property(e => e.Consentprompt).HasColumnName("CONSENTPROMPT");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Dontshow).HasColumnName("DONTSHOW");

                entity.Property(e => e.Productid).HasColumnName("PRODUCTID");

                entity.Property(e => e.Timesseen).HasColumnName("TIMESSEEN");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Userid).HasColumnName("USERID");
            });

            modelBuilder.Entity<NpsusageStatistics>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__NPSUsageStatisti__5BD88551");

                entity.ToTable("NPSUsageStatistics", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Documentid)
                    .IsRequired()
                    .HasColumnName("DOCUMENTID")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Enduserid).HasColumnName("ENDUSERID");

                entity.Property(e => e.Producttype)
                    .IsRequired()
                    .HasColumnName("PRODUCTTYPE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Referralcomponent).HasColumnName("REFERRALCOMPONENT");

                entity.Property(e => e.Secondsonscreen).HasColumnName("SECONDSONSCREEN");

                entity.Property(e => e.Submitted).HasColumnName("SUBMITTED");

                entity.Property(e => e.Submitteddate)
                    .HasColumnName("SUBMITTEDDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Viewdate)
                    .HasColumnName("VIEWDATE")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Observations>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__OBSERVATIONS__247D636F");

                entity.ToTable("OBSERVATIONS", "dbo");

                entity.HasIndex(e => e.Internalid)
                    .HasName("OBSERVATIONS1");

                entity.HasIndex(e => e.Obsdate)
                    .HasName("OBSERVATIONS2");

                entity.HasIndex(e => new { e.Userid, e.Obstime, e.Dataname, e.Datavalue, e.Created, e.Createdby, e.Updated, e.Updatedby, e.Internalid, e.Obsdate, e.Recordstatus, e.Datacode, e.Modifier, e.Recordid })
                    .HasName("OBSERVATIONS3");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Datacode).HasColumnName("DATACODE");

                entity.Property(e => e.Dataname)
                    .IsRequired()
                    .HasColumnName("DATANAME")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Datavalue)
                    .IsRequired()
                    .HasColumnName("DATAVALUE")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Internalid).HasColumnName("INTERNALID");

                entity.Property(e => e.Modifier).HasColumnName("MODIFIER");

                entity.Property(e => e.Obsdate)
                    .HasColumnName("OBSDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Obstime).HasColumnName("OBSTIME");

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.HasOne(d => d.Internal)
                    .WithMany(p => p.Observations)
                    .HasForeignKey(d => d.Internalid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__OBSERVATI__INTER__284DF453");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Observations)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__OBSERVATI__USERI__2942188C");
            });

            modelBuilder.Entity<ObservationsSnomed>(entity =>
            {
                entity.HasKey(e => new { e.Datacode, e.Modifier })
                    .HasName("PK__OBSERVAT__3597F08A1D38CD4B");

                entity.ToTable("OBSERVATIONS_SNOMED", "dbo");

                entity.Property(e => e.Datacode).HasColumnName("DATACODE");

                entity.Property(e => e.Modifier).HasColumnName("MODIFIER");

                entity.Property(e => e.Snomedcode).HasColumnName("SNOMEDCODE");
            });

            modelBuilder.Entity<Obsgyndetail>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__OBSGYNDETAIL__1F2E9E6D");

                entity.ToTable("OBSGYNDETAIL", "dbo");

                entity.HasIndex(e => new { e.Recordid, e.Recordstatus, e.Lastpapdate, e.Lastpapresult, e.Nopap, e.Breastfeeding, e.Gravidityknown, e.Gravidity, e.Parity, e.Miscarriages, e.Terminations, e.Actuallmp, e.Nominallmp, e.Edcbydate, e.Edcbyscan, e.Pregnancyid, e.Created, e.Createdby, e.Updated, e.Updatedby, e.Cyclelength, e.Internalid })
                    .HasName("OBSGYNDETAIL1");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Actuallmp)
                    .HasColumnName("ACTUALLMP")
                    .HasColumnType("datetime");

                entity.Property(e => e.Breastfeeding).HasColumnName("BREASTFEEDING");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Cyclelength).HasColumnName("CYCLELENGTH");

                entity.Property(e => e.Edcbydate)
                    .HasColumnName("EDCBYDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Edcbyscan)
                    .HasColumnName("EDCBYSCAN")
                    .HasColumnType("datetime");

                entity.Property(e => e.Gravidity).HasColumnName("GRAVIDITY");

                entity.Property(e => e.Gravidityknown).HasColumnName("GRAVIDITYKNOWN");

                entity.Property(e => e.Internalid).HasColumnName("INTERNALID");

                entity.Property(e => e.LastMammogramDate).HasColumnType("datetime");

                entity.Property(e => e.Lastpapdate)
                    .HasColumnName("LASTPAPDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Lastpapresult).HasColumnName("LASTPAPRESULT");

                entity.Property(e => e.Miscarriages).HasColumnName("MISCARRIAGES");

                entity.Property(e => e.Nominallmp)
                    .HasColumnName("NOMINALLMP")
                    .HasColumnType("datetime");

                entity.Property(e => e.Nopap).HasColumnName("NOPAP");

                entity.Property(e => e.Optout).HasColumnName("OPTOUT");

                entity.Property(e => e.Optoutreason)
                    .HasColumnName("OPTOUTREASON")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Parity).HasColumnName("PARITY");

                entity.Property(e => e.Pregnancyid).HasColumnName("PREGNANCYID");

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Terminations).HasColumnName("TERMINATIONS");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.HasOne(d => d.Internal)
                    .WithMany(p => p.Obsgyndetail)
                    .HasForeignKey(d => d.Internalid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__OBSGYNDET__INTER__2AA05119");
            });

            modelBuilder.Entity<Occupationhistory>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__OCCUPATIONHISTOR__13BCEBC1");

                entity.ToTable("OCCUPATIONHISTORY", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Animal).HasColumnName("ANIMAL");

                entity.Property(e => e.Asbestos).HasColumnName("ASBESTOS");

                entity.Property(e => e.Comment)
                    .HasColumnName("COMMENT")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Dust).HasColumnName("DUST");

                entity.Property(e => e.Employer)
                    .HasColumnName("EMPLOYER")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Internalid).HasColumnName("INTERNALID");

                entity.Property(e => e.Occupation)
                    .HasColumnName("OCCUPATION")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Occupationcode).HasColumnName("OCCUPATIONCODE");

                entity.Property(e => e.Principal).HasColumnName("PRINCIPAL");

                entity.Property(e => e.Radiation).HasColumnName("RADIATION");

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Yearstarted).HasColumnName("YEARSTARTED");

                entity.Property(e => e.Yearstopped).HasColumnName("YEARSTOPPED");

                entity.HasOne(d => d.Internal)
                    .WithMany(p => p.Occupationhistory)
                    .HasForeignKey(d => d.Internalid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__OCCUPATIO__INTER__1C5231C2");

                entity.HasOne(d => d.OccupationcodeNavigation)
                    .WithMany(p => p.Occupationhistory)
                    .HasForeignKey(d => d.Occupationcode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__OCCUPATIO__OCCUP__1D4655FB");
            });

            modelBuilder.Entity<Occupations>(entity =>
            {
                entity.HasKey(e => e.Occupationcode)
                    .HasName("PK__OCCUPATIONS__59FA5E80");

                entity.ToTable("OCCUPATIONS", "dbo");

                entity.Property(e => e.Occupationcode)
                    .HasColumnName("OCCUPATIONCODE")
                    .ValueGeneratedNever();

                entity.Property(e => e.Occupationname)
                    .IsRequired()
                    .HasColumnName("OCCUPATIONNAME")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Occupationtype).HasColumnName("OCCUPATIONTYPE");
            });

            modelBuilder.Entity<Oedema>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OEDEMA", "dbo");

                entity.Property(e => e.Oedemacode).HasColumnName("OEDEMACODE");

                entity.Property(e => e.Oedematext)
                    .HasColumnName("OEDEMATEXT")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Opdose>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__OPDOSE__3F3159AB");

                entity.ToTable("OPDOSE", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Dose)
                    .HasColumnName("DOSE")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Internalid).HasColumnName("INTERNALID");

                entity.Property(e => e.Opdate)
                    .HasColumnName("OPDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Opioidid).HasColumnName("OPIOIDID");

                entity.Property(e => e.Started)
                    .HasColumnName("STARTED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Stopped)
                    .HasColumnName("STOPPED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.HasOne(d => d.Internal)
                    .WithMany(p => p.Opdose)
                    .HasForeignKey(d => d.Internalid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__OPDOSE__INTERNAL__40257DE4");

                entity.HasOne(d => d.Opioid)
                    .WithMany(p => p.Opdose)
                    .HasForeignKey(d => d.Opioidid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__OPDOSE__OPIOIDID__4119A21D");
            });

            modelBuilder.Entity<Operations>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__OPERATIONS__10CB707D");

                entity.ToTable("OPERATIONS", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Anaestheticcode).HasColumnName("ANAESTHETICCODE");

                entity.Property(e => e.Anaesthetistid).HasColumnName("ANAESTHETISTID");

                entity.Property(e => e.Appointmentid).HasColumnName("APPOINTMENTID");

                entity.Property(e => e.Assistantid).HasColumnName("ASSISTANTID");

                entity.Property(e => e.Comment)
                    .HasColumnName("COMMENT")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasColumnType("text");

                entity.Property(e => e.Facilityid).HasColumnName("FACILITYID");

                entity.Property(e => e.Findings)
                    .HasColumnName("FINDINGS")
                    .HasColumnType("text");

                entity.Property(e => e.Indication)
                    .HasColumnName("INDICATION")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Internalid).HasColumnName("INTERNALID");

                entity.Property(e => e.Mbsitem)
                    .HasColumnName("MBSITEM")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Operationcategory).HasColumnName("OPERATIONCATEGORY");

                entity.Property(e => e.Operationcode).HasColumnName("OPERATIONCODE");

                entity.Property(e => e.Operationdate)
                    .HasColumnName("OPERATIONDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Operationdetail)
                    .HasColumnName("OPERATIONDETAIL")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Operationlength)
                    .HasColumnName("OPERATIONLENGTH")
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.Operationname)
                    .HasColumnName("OPERATIONNAME")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Operationside).HasColumnName("OPERATIONSIDE");

                entity.Property(e => e.Operationstatus).HasColumnName("OPERATIONSTATUS");

                entity.Property(e => e.Operationtime).HasColumnName("OPERATIONTIME");

                entity.Property(e => e.Outcome)
                    .HasColumnName("OUTCOME")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Outcomecode).HasColumnName("OUTCOMECODE");

                entity.Property(e => e.Preopid).HasColumnName("PREOPID");

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Stay).HasColumnName("STAY");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.HasOne(d => d.Internal)
                    .WithMany(p => p.Operations)
                    .HasForeignKey(d => d.Internalid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__OPERATION__INTER__1E256B9B");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.OperationsNavigation)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__OPERATION__USERI__1F198FD4");
            });

            modelBuilder.Entity<Opioid>(entity =>
            {
                entity.ToTable("OPIOID", "dbo");

                entity.Property(e => e.Opioidid).HasColumnName("OPIOIDID");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Drugcode)
                    .HasColumnName("DRUGCODE")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Givenat).HasColumnName("GIVENAT");

                entity.Property(e => e.Instructions)
                    .HasColumnName("INSTRUCTIONS")
                    .HasColumnType("text");

                entity.Property(e => e.Internalid).HasColumnName("INTERNALID");

                entity.Property(e => e.Month)
                    .HasColumnName("MONTH")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Opdate)
                    .HasColumnName("OPDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Programno)
                    .HasColumnName("PROGRAMNO")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Quantity)
                    .HasColumnName("QUANTITY")
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.Property(e => e.Year)
                    .HasColumnName("YEAR")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.Internal)
                    .WithMany(p => p.Opioid)
                    .HasForeignKey(d => d.Internalid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__OPIOID__INTERNAL__3C54ED00");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Opioid)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__OPIOID__USERID__3D491139");
            });

            modelBuilder.Entity<Pain>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__PAIN__4301EA8F");

                entity.ToTable("PAIN", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Bodyside).HasColumnName("BODYSIDE");

                entity.Property(e => e.Comment)
                    .HasColumnName("COMMENT")
                    .HasColumnType("text");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Internalid).HasColumnName("INTERNALID");

                entity.Property(e => e.Location).HasColumnName("LOCATION");

                entity.Property(e => e.Recdate)
                    .HasColumnName("RECDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Severity).HasColumnName("SEVERITY");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.HasOne(d => d.Internal)
                    .WithMany(p => p.Pain)
                    .HasForeignKey(d => d.Internalid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PAIN__INTERNALID__47C69FAC");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Pain)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PAIN__USERID__48BAC3E5");
            });

            modelBuilder.Entity<Papresults>(entity =>
            {
                entity.HasKey(e => e.Papcode)
                    .HasName("PK__PAPRESULTS__7B5B524B");

                entity.ToTable("PAPRESULTS", "dbo");

                entity.Property(e => e.Papcode)
                    .HasColumnName("PAPCODE")
                    .ValueGeneratedNever();

                entity.Property(e => e.Display).HasColumnName("DISPLAY");

                entity.Property(e => e.Paptext)
                    .IsRequired()
                    .HasColumnName("PAPTEXT")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Termid).HasColumnName("TERMID");
            });

            modelBuilder.Entity<Papsmears>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__PAPSMEARS__4AA30C57");

                entity.ToTable("PAPSMEARS", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Comment)
                    .HasColumnName("COMMENT")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Cst).HasColumnName("CST");

                entity.Property(e => e.Endocervicalcells).HasColumnName("ENDOCERVICALCELLS");

                entity.Property(e => e.Hpv).HasColumnName("HPV");

                entity.Property(e => e.Hpv16).HasColumnName("HPV16");

                entity.Property(e => e.Hpv18).HasColumnName("HPV18");

                entity.Property(e => e.Hpvother).HasColumnName("HPVOTHER");

                entity.Property(e => e.Internalid).HasColumnName("INTERNALID");

                entity.Property(e => e.Papcode).HasColumnName("PAPCODE");

                entity.Property(e => e.Papdate)
                    .HasColumnName("PAPDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.HasOne(d => d.Internal)
                    .WithMany(p => p.Papsmears)
                    .HasForeignKey(d => d.Internalid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PAPSMEARS__INTER__4F67C174");

                entity.HasOne(d => d.PapcodeNavigation)
                    .WithMany(p => p.Papsmears)
                    .HasForeignKey(d => d.Papcode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PAPSMEARS__PAPCO__4E739D3B");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Papsmears)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PAPSMEARS__USERI__505BE5AD");
            });

            modelBuilder.Entity<Parameters>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__PARAMETERS__2B2A60FE");

                entity.ToTable("PARAMETERS", "dbo");

                entity.HasIndex(e => e.Datadate)
                    .HasName("PARAMETERS2");

                entity.HasIndex(e => e.Internalid)
                    .HasName("PARAMETERS1");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Datacode).HasColumnName("DATACODE");

                entity.Property(e => e.Datadate)
                    .HasColumnName("DATADATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dataname)
                    .IsRequired()
                    .HasColumnName("DATANAME")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Datatime).HasColumnName("DATATIME");

                entity.Property(e => e.Datavalue)
                    .IsRequired()
                    .HasColumnName("DATAVALUE")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Internalid).HasColumnName("INTERNALID");

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.HasOne(d => d.Internal)
                    .WithMany(p => p.Parameters)
                    .HasForeignKey(d => d.Internalid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PARAMETER__INTER__2E06CDA9");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Parameters)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PARAMETER__USERI__2EFAF1E2");
            });

            modelBuilder.Entity<Pasthistory>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__PASTHISTORY__278EDA44");

                entity.ToTable("PASTHISTORY", "dbo");

                entity.HasIndex(e => new { e.Recordstatus, e.Internalid, e.Itemcode })
                    .HasName("PASTHISTORY1");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Acutecode).HasColumnName("ACUTECODE");

                entity.Property(e => e.Comminuted).HasColumnName("COMMINUTED");

                entity.Property(e => e.Compound).HasColumnName("COMPOUND");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Day).HasColumnName("DAY");

                entity.Property(e => e.Descriptioncode).HasColumnName("DESCRIPTIONCODE");

                entity.Property(e => e.Details)
                    .HasColumnName("DETAILS")
                    .HasColumnType("text");

                entity.Property(e => e.Displaced).HasColumnName("DISPLACED");

                entity.Property(e => e.Fracture).HasColumnName("FRACTURE");

                entity.Property(e => e.Greenstick).HasColumnName("GREENSTICK");

                entity.Property(e => e.Internalid).HasColumnName("INTERNALID");

                entity.Property(e => e.Itemcode).HasColumnName("ITEMCODE");

                entity.Property(e => e.Itemtext)
                    .HasColumnName("ITEMTEXT")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Locationcode).HasColumnName("LOCATIONCODE");

                entity.Property(e => e.Mom)
                    .HasColumnName("MOM")
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Mompath)
                    .HasColumnName("MOMPATH")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Month).HasColumnName("MONTH");

                entity.Property(e => e.Pcehr).HasColumnName("PCEHR");

                entity.Property(e => e.Positioncode).HasColumnName("POSITIONCODE");

                entity.Property(e => e.Privacycode).HasColumnName("PRIVACYCODE");

                entity.Property(e => e.Provisional).HasColumnName("PROVISIONAL");

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Severitycode).HasColumnName("SEVERITYCODE");

                entity.Property(e => e.Spiral).HasColumnName("SPIRAL");

                entity.Property(e => e.Statuscode).HasColumnName("STATUSCODE");

                entity.Property(e => e.Summarycode).HasColumnName("SUMMARYCODE");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.Property(e => e.Year).HasColumnName("YEAR");

                entity.HasOne(d => d.Internal)
                    .WithMany(p => p.Pasthistory)
                    .HasForeignKey(d => d.Internalid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PASTHISTO__INTER__3AA1AEB8");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Pasthistory)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PASTHISTO__USERI__3B95D2F1");

                entity.HasOne(d => d.Visit)
                    .WithMany(p => p.Pasthistory)
                    .HasForeignKey(d => d.VisitId)
                    .HasConstraintName("FK__PASTHISTO__Visit__0C1C9550");
            });

            modelBuilder.Entity<Pastsmoking>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PASTSMOKING", "dbo");

                entity.Property(e => e.Pastsmokingcode).HasColumnName("PASTSMOKINGCODE");

                entity.Property(e => e.Pastsmokingtext)
                    .HasColumnName("PASTSMOKINGTEXT")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<PatientAppEnrolment>(entity =>
            {
                entity.HasKey(e => e.RecordId);

                entity.ToTable("PatientAppEnrolment", "dbo");

                entity.Property(e => e.RecordId).HasColumnName("RecordID");

                entity.Property(e => e.AppVersion).HasMaxLength(10);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.InternalId).HasColumnName("InternalID");

                entity.Property(e => e.LocationId).HasColumnName("LocationID");

                entity.Property(e => e.MobileNumber)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PatientAppUsername)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PatientPublicKey)
                    .IsRequired()
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.Updated).HasColumnType("datetime");
            });

            modelBuilder.Entity<PatientEnrolments>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__PATIENT___84D4D4F5F5E6D2EB");

                entity.ToTable("PATIENT_ENROLMENTS", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.ApplicationDate)
                    .HasColumnName("APPLICATION_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.AuthenticatedOrgid)
                    .HasColumnName("AUTHENTICATED_ORGID")
                    .HasMaxLength(255)
                    .IsFixedLength();

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Enddate)
                    .HasColumnName("ENDDATE")
                    .HasColumnType("date");

                entity.Property(e => e.EnrollingOrganisationId)
                    .HasColumnName("ENROLLING_ORGANISATION_ID")
                    .HasMaxLength(255);

                entity.Property(e => e.EnrollingOrganisationName)
                    .HasColumnName("ENROLLING_ORGANISATION_NAME")
                    .HasMaxLength(255)
                    .IsFixedLength();

                entity.Property(e => e.Enrolmentid).HasColumnName("ENROLMENTID");

                entity.Property(e => e.Expirydate)
                    .HasColumnName("EXPIRYDATE")
                    .HasColumnType("date");

                entity.Property(e => e.HealthServiceCode)
                    .HasColumnName("HEALTH_SERVICE_CODE")
                    .HasMaxLength(20);

                entity.Property(e => e.Internalid).HasColumnName("INTERNALID");

                entity.Property(e => e.LastEncounterDate)
                    .HasColumnName("LAST_ENCOUNTER_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.Localprocessingdate)
                    .HasColumnName("LOCALPROCESSINGDATE")
                    .HasColumnType("date");

                entity.Property(e => e.Mode)
                    .IsRequired()
                    .HasColumnName("MODE")
                    .HasMaxLength(20);

                entity.Property(e => e.Recordtype).HasColumnName("RECORDTYPE");

                entity.Property(e => e.ReenrolmentDate)
                    .HasColumnName("REENROLMENT_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.ServiceFacilityId)
                    .HasColumnName("SERVICE_FACILITY_ID")
                    .HasMaxLength(255)
                    .IsFixedLength();

                entity.Property(e => e.ServiceOrganisationId)
                    .HasColumnName("SERVICE_ORGANISATION_ID")
                    .HasMaxLength(255)
                    .IsFixedLength();

                entity.Property(e => e.ServicePractiionerName)
                    .HasColumnName("SERVICE_PRACTIIONER_NAME")
                    .HasMaxLength(255)
                    .IsFixedLength();

                entity.Property(e => e.ServicePractitionerCpn)
                    .HasColumnName("SERVICE_PRACTITIONER_CPN")
                    .HasMaxLength(255)
                    .IsFixedLength();

                entity.Property(e => e.Startdate)
                    .HasColumnName("STARTDATE")
                    .HasColumnType("date");

                entity.Property(e => e.Status).HasColumnName("STATUS");

                entity.Property(e => e.TerminationReasonCode)
                    .HasColumnName("TERMINATION_REASON_CODE")
                    .HasMaxLength(50);

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");
            });

            modelBuilder.Entity<PatientPatientgroup>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__PATIENT_PATIENTG__3DF31CAF");

                entity.ToTable("PATIENT_PATIENTGROUP", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Groupid).HasColumnName("GROUPID");

                entity.Property(e => e.Internalid).HasColumnName("INTERNALID");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.PatientPatientgroup)
                    .HasForeignKey(d => d.Groupid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PATIENT_P__GROUP__3EE740E8");

                entity.HasOne(d => d.Internal)
                    .WithMany(p => p.PatientPatientgroup)
                    .HasForeignKey(d => d.Internalid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PATIENT_P__INTER__3FDB6521");
            });

            modelBuilder.Entity<PatientPreferenceClass>(entity =>
            {
                entity.HasKey(e => e.RecordId);

                entity.ToTable("PATIENT_PREFERENCE_CLASS", "dbo");

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CillectionVersion)
                    .HasColumnName("[CillectionVersion")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.PereferenceCategoryCode)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.QuestionClass)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.QuestionText)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Updated).HasColumnType("datetime");
            });

            modelBuilder.Entity<PatientPreferences>(entity =>
            {
                entity.HasKey(e => e.RecordId);

                entity.ToTable("PATIENT_PREFERENCES", "dbo");

                entity.Property(e => e.RecordId)
                    .HasColumnName("RecordID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.FactValue)
                    .IsRequired()
                    .HasColumnName("FACT_VALUE")
                    .HasMaxLength(255);

                entity.Property(e => e.Internalid).HasColumnName("INTERNALID");

                entity.Property(e => e.PatientPrefrenceCode).HasColumnName("PATIENT_PREFRENCE_CODE");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");
            });

            modelBuilder.Entity<PatientPresence>(entity =>
            {
                entity.HasKey(e => e.RecordId)
                    .HasName("PK__PatientP__FBDF78C9158C0786");

                entity.ToTable("PatientPresence", "dbo");

                entity.Property(e => e.RecordId).HasColumnName("RecordID");

                entity.Property(e => e.AppointmentId).HasColumnName("AppointmentID");

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Updated).HasColumnType("datetime");

                entity.HasOne(d => d.Appointment)
                    .WithMany(p => p.PatientPresence)
                    .HasForeignKey(d => d.AppointmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PatientPr__Appoi__1A35AA7D");
            });

            modelBuilder.Entity<PatientWhitecoat>(entity =>
            {
                entity.HasKey(e => e.InternalId);

                entity.ToTable("PatientWhitecoat", "dbo");

                entity.Property(e => e.InternalId)
                    .HasColumnName("InternalID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Updated).HasColumnType("datetime");

                entity.Property(e => e.WhitecoatHasOshc).HasColumnName("WhitecoatHasOSHC");

                entity.Property(e => e.WhitecoatId).HasColumnName("WhitecoatID");

                entity.Property(e => e.WhitecoatInsurerName)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.WhitecoatPhone)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.WhitecoatPolicyNumber)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.HasOne(d => d.Internal)
                    .WithOne(p => p.PatientWhitecoat)
                    .HasForeignKey<PatientWhitecoat>(d => d.InternalId)
                    .HasConstraintName("FK_PatientWhitecoat_PATIENTS");
            });

            modelBuilder.Entity<Patientbankaccounts>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__PATIENTBANKACCOU__51900108");

                entity.ToTable("PATIENTBANKACCOUNTS", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Accountname)
                    .HasColumnName("ACCOUNTNAME")
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Accountnumber)
                    .HasColumnName("ACCOUNTNUMBER")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Bankid).HasColumnName("BANKID");

                entity.Property(e => e.Bsbnumber)
                    .HasColumnName("BSBNUMBER")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Internalid).HasColumnName("INTERNALID");

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");
            });

            modelBuilder.Entity<Patientclaims>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__PATIENTCLAIMS__5654B625");

                entity.ToTable("PATIENTCLAIMS", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Claimdate)
                    .HasColumnName("CLAIMDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Claimstatus).HasColumnName("CLAIMSTATUS");

                entity.Property(e => e.Claimtime)
                    .HasColumnName("CLAIMTIME")
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Internalid).HasColumnName("INTERNALID");

                entity.Property(e => e.Invoiceid).HasColumnName("INVOICEID");

                entity.Property(e => e.Paymentid).HasColumnName("PAYMENTID");

                entity.Property(e => e.PmsclaimNo)
                    .HasColumnName("PMSClaimNo")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Userid).HasColumnName("USERID");
            });

            modelBuilder.Entity<Patientethnicity>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__PATIENTE__84D4D4F569108419");

                entity.ToTable("PATIENTETHNICITY", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Ethniccode).HasColumnName("ETHNICCODE");

                entity.Property(e => e.Internalid).HasColumnName("INTERNALID");

                entity.Property(e => e.Priority).HasColumnName("PRIORITY");

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.HasOne(d => d.EthniccodeNavigation)
                    .WithMany(p => p.Patientethnicity)
                    .HasForeignKey(d => d.Ethniccode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PATIENTET__ETHNI__4A19C7C9");

                entity.HasOne(d => d.Internal)
                    .WithMany(p => p.Patientethnicity)
                    .HasForeignKey(d => d.Internalid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PATIENTET__INTER__4925A390");
            });

            modelBuilder.Entity<Patientgroups>(entity =>
            {
                entity.HasKey(e => e.Groupid)
                    .HasName("PK__PATIENTGROUPS__392E6792");

                entity.ToTable("PATIENTGROUPS", "dbo");

                entity.Property(e => e.Groupid).HasColumnName("GROUPID");

                entity.Property(e => e.Groupname)
                    .HasColumnName("GROUPNAME")
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Patientgroups)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PATIENTGR__USERI__3C0AD43D");
            });

            modelBuilder.Entity<Patientiwi>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__PATIENTI__84D4D4F5E67B201F");

                entity.ToTable("PATIENTIWI", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Internalid).HasColumnName("INTERNALID");

                entity.Property(e => e.Iwicode).HasColumnName("IWICODE");

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.HasOne(d => d.Internal)
                    .WithMany(p => p.Patientiwi)
                    .HasForeignKey(d => d.Internalid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PATIENTIW__INTER__4FD2A11F");
            });

            modelBuilder.Entity<Patientlogin>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__PATIENTL__84D4D4F50A9EF42E");

                entity.ToTable("PATIENTLOGIN", "dbo");

                entity.HasIndex(e => e.Username)
                    .HasName("UQ__PATIENTL__B15BE12E6516F264")
                    .IsUnique();

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Internalid).HasColumnName("INTERNALID");

                entity.Property(e => e.Logintype).HasColumnName("LOGINTYPE");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("PASSWORD")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("USERNAME")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Patientphoto>(entity =>
            {
                entity.HasKey(e => e.Photoid);

                entity.ToTable("PATIENTPHOTO", "dbo");

                entity.Property(e => e.Photoid).HasColumnName("PHOTOID");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Current).HasColumnName("CURRENT");

                entity.Property(e => e.Internalid).HasColumnName("INTERNALID");

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Stored).HasColumnName("STORED");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.HasOne(d => d.Internal)
                    .WithMany(p => p.Patientphoto)
                    .HasForeignKey(d => d.Internalid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PATIENTPHOTO_PATIENTPHOTO");
            });

            modelBuilder.Entity<Patients>(entity =>
            {
                entity.HasKey(e => e.Internalid)
                    .HasName("PK__PATIENTS__1B9317B3");

                entity.ToTable("PATIENTS", "dbo");

                entity.HasIndex(e => e.Externalid)
                    .HasName("PATIENTS3");

                entity.HasIndex(e => e.Firstname)
                    .HasName("PATIENTS2");

                entity.HasIndex(e => e.Internalid)
                    .HasName("PATIENTS_INT");

                entity.HasIndex(e => e.Medicareno)
                    .HasName("PATIENTS4");

                entity.HasIndex(e => e.Recordno)
                    .HasName("PATIENTS5");

                entity.HasIndex(e => e.Surname)
                    .HasName("PATIENTS1");

                entity.HasIndex(e => new { e.Headoffamilyid, e.Recordstatus, e.Internalid, e.Titlecode, e.Surname, e.Firstname })
                    .HasName("PATIENTS6");

                entity.HasIndex(e => new { e.Internalid, e.Externalid, e.Origin, e.Dateofdeath, e.Middlename, e.Preferredname, e.Address1, e.Address2, e.City, e.Postcode, e.Postaladdress, e.Postalcity, e.Postalpostcode, e.Dob, e.Sexcode, e.Ethniccode, e.Homephone, e.Workphone, e.Mobilephone, e.Medicareno, e.Medicarelineno, e.Medicareexpiry, e.Pensioncode, e.Pensionno, e.Pensionstart, e.Pensionexpiry, e.Dvacode, e.Dvano, e.Safetynetno, e.Recordno, e.Religion, e.Healthfundno, e.Healthfundname, e.Healthfundid, e.Healthfundexpiry, e.Accountcode, e.Userid, e.Denyaccess, e.Noreminders, e.Headoffamilyid, e.Nextofkinid, e.Referringdoctor, e.Referraldate, e.Referralcode, e.Othernotes, e.Created, e.Createdby, e.Updated, e.Updatedby, e.Surname, e.Firstname, e.Titlecode, e.Patientstatus, e.Recordstatus })
                    .HasName("PATIENTS7");

                entity.Property(e => e.Internalid).HasColumnName("INTERNALID");

                entity.Property(e => e.Accountcode).HasColumnName("ACCOUNTCODE");

                entity.Property(e => e.Address1)
                    .HasColumnName("ADDRESS1")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Address2)
                    .HasColumnName("ADDRESS2")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AddressDomicile).HasColumnName("ADDRESS_DOMICILE");

                entity.Property(e => e.AddressGeotag).HasColumnName("ADDRESS_GEOTAG");

                entity.Property(e => e.AddressNotvalidReason).HasColumnName("ADDRESS_NOTVALID_REASON");

                entity.Property(e => e.AddressSetid).HasColumnName("ADDRESS_SETID");

                entity.Property(e => e.AddressVersion).HasColumnName("ADDRESS_VERSION");

                entity.Property(e => e.Citizen).HasColumnName("CITIZEN");

                entity.Property(e => e.CitizenSource).HasColumnName("CITIZEN_SOURCE");

                entity.Property(e => e.City)
                    .HasColumnName("CITY")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Consentsmsreminder).HasColumnName("CONSENTSMSREMINDER");

                entity.Property(e => e.Contactmethod).HasColumnName("CONTACTMETHOD");

                entity.Property(e => e.CoreVersion).HasColumnName("CORE_VERSION");

                entity.Property(e => e.Country)
                    .HasColumnName("COUNTRY")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Countryofbirth).HasColumnName("COUNTRYOFBIRTH");

                entity.Property(e => e.CountryofbirthSource).HasColumnName("COUNTRYOFBIRTH_SOURCE");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Cscexpiry)
                    .HasColumnName("CSCExpiry")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cscholder).HasColumnName("CSCHolder");

                entity.Property(e => e.Cscnumber)
                    .HasColumnName("CSCNumber")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Cscvalid)
                    .HasColumnName("CSCValid")
                    .HasColumnType("datetime");

                entity.Property(e => e.Ctg).HasColumnName("CTG");

                entity.Property(e => e.Dateofdeath)
                    .HasColumnName("DATEOFDEATH")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dateofdeathsource).HasColumnName("DATEOFDEATHSOURCE");

                entity.Property(e => e.Defaultvisittype).HasColumnName("DEFAULTVISITTYPE");

                entity.Property(e => e.Denyaccess).HasColumnName("DENYACCESS");

                entity.Property(e => e.Dispense).HasColumnName("DISPENSE");

                entity.Property(e => e.Dob)
                    .HasColumnName("DOB")
                    .HasColumnType("datetime");

                entity.Property(e => e.DobSource).HasColumnName("DOB_SOURCE");

                entity.Property(e => e.Dvacode).HasColumnName("DVACODE");

                entity.Property(e => e.Dvano)
                    .HasColumnName("DVANO")
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EligiblePublicFunding)
                    .HasColumnName("ELIGIBLE_PUBLIC_FUNDING")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Emergencyid).HasColumnName("EMERGENCYID");

                entity.Property(e => e.Enrolmentcheck)
                    .HasColumnName("ENROLMENTCHECK")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Enrolmentid).HasColumnName("ENROLMENTID");

                entity.Property(e => e.Erx).HasColumnName("ERX");

                entity.Property(e => e.EsamChecked)
                    .HasColumnName("ESAM_CHECKED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Ethnic1code).HasColumnName("ETHNIC1CODE");

                entity.Property(e => e.Ethnic2code).HasColumnName("ETHNIC2CODE");

                entity.Property(e => e.Ethniccode).HasColumnName("ETHNICCODE");

                entity.Property(e => e.Externalid)
                    .HasColumnName("EXTERNALID")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Firstname)
                    .HasColumnName("FIRSTNAME")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Hchcurrent)
                    .HasColumnName("HCHCURRENT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Hchstarted)
                    .HasColumnName("HCHSTARTED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Hchtier).HasColumnName("HCHTIER");

                entity.Property(e => e.Headoffamilyid).HasColumnName("HEADOFFAMILYID");

                entity.Property(e => e.Healthfundexpiry)
                    .HasColumnName("HEALTHFUNDEXPIRY")
                    .HasColumnType("datetime");

                entity.Property(e => e.Healthfundid).HasColumnName("HEALTHFUNDID");

                entity.Property(e => e.Healthfundname)
                    .HasColumnName("HEALTHFUNDNAME")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Healthfundno)
                    .HasColumnName("HEALTHFUNDNO")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Homephone)
                    .HasColumnName("HOMEPHONE")
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Hucexpiry)
                    .HasColumnName("HUCExpiry")
                    .HasColumnType("datetime");

                entity.Property(e => e.Hucholder).HasColumnName("HUCHolder");

                entity.Property(e => e.Hucnumber)
                    .HasColumnName("HUCNumber")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Hucvalid)
                    .HasColumnName("HUCValid")
                    .HasColumnType("datetime");

                entity.Property(e => e.Ihi)
                    .HasColumnName("IHI")
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Ihirecordstatus).HasColumnName("IHIRECORDSTATUS");

                entity.Property(e => e.Ihisource).HasColumnName("IHISOURCE");

                entity.Property(e => e.Ihistatus).HasColumnName("IHISTATUS");

                entity.Property(e => e.Ihivalidated)
                    .HasColumnName("IHIVALIDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.IncSuppNumber)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Iwi).HasColumnName("IWI");

                entity.Property(e => e.Medicareexpiry)
                    .HasColumnName("MEDICAREEXPIRY")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Medicarelineno)
                    .HasColumnName("MEDICARELINENO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Medicareno)
                    .HasColumnName("MEDICARENO")
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Medview).HasColumnName("MEDVIEW");

                entity.Property(e => e.Middlename)
                    .HasColumnName("MIDDLENAME")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Mobilephone)
                    .HasColumnName("MOBILEPHONE")
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MohChecked)
                    .HasColumnName("MOH_CHECKED")
                    .HasColumnType("datetime");

                entity.Property(e => e.NameSetid).HasColumnName("NAME_SETID");

                entity.Property(e => e.NameSource).HasColumnName("NAME_SOURCE");

                entity.Property(e => e.NameType).HasColumnName("NAME_TYPE");

                entity.Property(e => e.NameVersion).HasColumnName("NAME_VERSION");

                entity.Property(e => e.Nextofkinid).HasColumnName("NEXTOFKINID");

                entity.Property(e => e.Noreminders).HasColumnName("NOREMINDERS");

                entity.Property(e => e.Origin).HasColumnName("ORIGIN");

                entity.Property(e => e.Othernotes)
                    .HasColumnName("OTHERNOTES")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.OverallPatientversion).HasColumnName("OVERALL_PATIENTVERSION");

                entity.Property(e => e.Patientstatus).HasColumnName("PATIENTSTATUS");

                entity.Property(e => e.Pendingmobilechange)
                    .HasColumnName("PENDINGMOBILECHANGE")
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Pensioncode).HasColumnName("PENSIONCODE");

                entity.Property(e => e.Pensionexpiry)
                    .HasColumnName("PENSIONEXPIRY")
                    .HasColumnType("datetime");

                entity.Property(e => e.Pensionno)
                    .HasColumnName("PENSIONNO")
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Pensionstart)
                    .HasColumnName("PENSIONSTART")
                    .HasColumnType("datetime");

                entity.Property(e => e.Pharmacyid).HasColumnName("PHARMACYID");

                entity.Property(e => e.Placeofbirth)
                    .HasColumnName("PLACEOFBIRTH")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PostalAddressDomicile).HasColumnName("POSTAL_ADDRESS_DOMICILE");

                entity.Property(e => e.PostalAddressGeotag).HasColumnName("POSTAL_ADDRESS_GEOTAG");

                entity.Property(e => e.PostalAddressNotvalidReason).HasColumnName("POSTAL_ADDRESS_NOTVALID_REASON");

                entity.Property(e => e.PostalEsamChecked)
                    .HasColumnName("POSTAL_ESAM_CHECKED")
                    .HasColumnType("datetime");

                entity.Property(e => e.PostalSuburb)
                    .HasColumnName("POSTAL_SUBURB")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Postaladdress)
                    .HasColumnName("POSTALADDRESS")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Postalcity)
                    .HasColumnName("POSTALCITY")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Postalcountry)
                    .HasColumnName("POSTALCOUNTRY")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Postalpostcode)
                    .HasColumnName("POSTALPOSTCODE")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Postcode)
                    .HasColumnName("POSTCODE")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Preferredname)
                    .HasColumnName("PREFERREDNAME")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Previoususerid).HasColumnName("PREVIOUSUSERID");

                entity.Property(e => e.Qed)
                    .HasColumnName("QED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Recordno)
                    .HasColumnName("RECORDNO")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Referralcode).HasColumnName("REFERRALCODE");

                entity.Property(e => e.Referraldate)
                    .HasColumnName("REFERRALDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Referringdoctor)
                    .HasColumnName("REFERRINGDOCTOR")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Registrationid).HasColumnName("REGISTRATIONID");

                entity.Property(e => e.Religion)
                    .HasColumnName("RELIGION")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Safetynetno)
                    .HasColumnName("SAFETYNETNO")
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sexcode).HasColumnName("SEXCODE");

                entity.Property(e => e.Surname)
                    .HasColumnName("SURNAME")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Titlecode).HasColumnName("TITLECODE");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.Property(e => e.Workphone)
                    .HasColumnName("WORKPHONE")
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.DvacodeNavigation)
                    .WithMany(p => p.Patients)
                    .HasForeignKey(d => d.Dvacode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PATIENTS__DVACOD__36470DEF");

                entity.HasOne(d => d.HchtierNavigation)
                    .WithMany(p => p.Patients)
                    .HasForeignKey(d => d.Hchtier)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PATIENTS__HCHTIE__4CC12A4A");

                entity.HasOne(d => d.Nextofkin)
                    .WithMany(p => p.Patients)
                    .HasForeignKey(d => d.Nextofkinid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PATIENTS__NEXTOF__39237A9A");

                entity.HasOne(d => d.PensioncodeNavigation)
                    .WithMany(p => p.Patients)
                    .HasForeignKey(d => d.Pensioncode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PATIENTS__PENSIO__373B3228");

                entity.HasOne(d => d.SexcodeNavigation)
                    .WithMany(p => p.Patients)
                    .HasForeignKey(d => d.Sexcode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PATIENTS__SEXCOD__3552E9B6");

                entity.HasOne(d => d.TitlecodeNavigation)
                    .WithMany(p => p.Patients)
                    .HasForeignKey(d => d.Titlecode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PATIENTS__TITLEC__3A179ED3");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Patients)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PATIENTS__USERID__382F5661");
            });

            modelBuilder.Entity<Patientstatus>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PATIENTSTATUS", "dbo");

                entity.Property(e => e.Statuscode).HasColumnName("STATUSCODE");

                entity.Property(e => e.Statustext)
                    .HasColumnName("STATUSTEXT")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Payer>(entity =>
            {
                entity.ToTable("PAYER", "dbo");

                entity.Property(e => e.Payerid).HasColumnName("PAYERID");

                entity.Property(e => e.Address1)
                    .HasColumnName("ADDRESS1")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Address2)
                    .HasColumnName("ADDRESS2")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.City)
                    .HasColumnName("CITY")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Email)
                    .HasColumnName("EMAIL")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasColumnName("FAX")
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Firstname)
                    .HasColumnName("FIRSTNAME")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Phone)
                    .HasColumnName("PHONE")
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Postcode)
                    .HasColumnName("POSTCODE")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Surname)
                    .HasColumnName("SURNAME")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Titlecode).HasColumnName("TITLECODE");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.HasOne(d => d.TitlecodeNavigation)
                    .WithMany(p => p.Payer)
                    .HasForeignKey(d => d.Titlecode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PAYER__TITLECODE__19AACF41");
            });

            modelBuilder.Entity<PaymentClaims>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__PaymentClaims__3BD5CA13");

                entity.ToTable("PaymentClaims", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Amountclaimed).HasColumnName("AMOUNTCLAIMED");

                entity.Property(e => e.Batchid).HasColumnName("BATCHID");

                entity.Property(e => e.Claimbenefitpaid).HasColumnName("CLAIMBENEFITPAID");

                entity.Property(e => e.Claimdate)
                    .HasColumnName("CLAIMDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Claimid)
                    .HasColumnName("CLAIMID")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Paymentrundate)
                    .HasColumnName("PAYMENTRUNDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Paymentrunid).HasColumnName("PAYMENTRUNID");

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");
            });

            modelBuilder.Entity<PaymentRuns>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__PaymentRuns__371114F6");

                entity.ToTable("PaymentRuns", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Bankaccountname)
                    .HasColumnName("BANKACCOUNTNAME")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Bankaccountnum)
                    .HasColumnName("BANKACCOUNTNUM")
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Bsbcode)
                    .HasColumnName("BSBCODE")
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Depositamount).HasColumnName("DEPOSITAMOUNT");

                entity.Property(e => e.Paymentrundate)
                    .HasColumnName("PAYMENTRUNDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Paymentrunnum).HasColumnName("PAYMENTRUNNUM");

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Userid).HasColumnName("USERID");
            });

            modelBuilder.Entity<PaymentService>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__PAYMENT_SERVICE__40106F4B");

                entity.ToTable("PAYMENT_SERVICE", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Amount).HasColumnName("AMOUNT");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Paymentid).HasColumnName("PAYMENTID");

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Serviceid).HasColumnName("SERVICEID");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");
            });

            modelBuilder.Entity<Paymentdeletereason>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__PAYMENTDELETEREA__68DD7AB4");

                entity.ToTable("PAYMENTDELETEREASON", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Paymentid).HasColumnName("PAYMENTID");

                entity.Property(e => e.Reason)
                    .HasColumnName("REASON")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");
            });

            modelBuilder.Entity<PaymentpartService>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__PAYMENTPART_SERV__45C948A1");

                entity.ToTable("PAYMENTPART_SERVICE", "dbo");

                entity.HasIndex(e => new { e.Amount, e.Serviceid })
                    .HasName("SERVICEID_AMOUNT");

                entity.HasIndex(e => new { e.Recordid, e.Paymentpartid, e.Serviceid, e.Amount, e.Recordstatus })
                    .HasName("RECORDSTATUS_ID_PPID_SID_AMOUNT");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Amount).HasColumnName("AMOUNT");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Paymentpartid).HasColumnName("PAYMENTPARTID");

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Serviceid).HasColumnName("SERVICEID");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");
            });

            modelBuilder.Entity<Paymentparts>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__PAYMENTPARTS__36870511");

                entity.ToTable("PAYMENTPARTS", "dbo");

                entity.HasIndex(e => new { e.Recordstatus, e.Banked, e.Paymenttype })
                    .HasName("PAYMENTPARTS1");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Accountid).HasColumnName("ACCOUNTID");

                entity.Property(e => e.Adjustmentlink).HasColumnName("ADJUSTMENTLINK");

                entity.Property(e => e.Amount).HasColumnName("AMOUNT");

                entity.Property(e => e.Bank)
                    .HasColumnName("BANK")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Bankbatch).HasColumnName("BANKBATCH");

                entity.Property(e => e.Bankdate)
                    .HasColumnName("BANKDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Banked).HasColumnName("BANKED");

                entity.Property(e => e.Branch)
                    .HasColumnName("BRANCH")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Cardtype).HasColumnName("CARDTYPE");

                entity.Property(e => e.Chequeno)
                    .HasColumnName("CHEQUENO")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Drawer)
                    .HasColumnName("DRAWER")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Paymentcode).HasColumnName("PAYMENTCODE");

                entity.Property(e => e.Paymentid).HasColumnName("PAYMENTID");

                entity.Property(e => e.Paymenttype).HasColumnName("PAYMENTTYPE");

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");
            });

            modelBuilder.Entity<Payments>(entity =>
            {
                entity.HasKey(e => e.Paymentid)
                    .HasName("PK__PAYMENTS__2EE5E349");

                entity.ToTable("PAYMENTS", "dbo");

                entity.HasIndex(e => e.Payercode)
                    .HasName("PAYMENTS2");

                entity.HasIndex(e => e.Paymentdate)
                    .HasName("PAYMENTS1");

                entity.Property(e => e.Paymentid).HasColumnName("PAYMENTID");

                entity.Property(e => e.Amount).HasColumnName("AMOUNT");

                entity.Property(e => e.Batchnumber)
                    .HasColumnName("BATCHNUMBER")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Detailid).HasColumnName("DETAILID");

                entity.Property(e => e.Locationid).HasColumnName("LOCATIONID");

                entity.Property(e => e.Payercode).HasColumnName("PAYERCODE");

                entity.Property(e => e.Payerid).HasColumnName("PAYERID");

                entity.Property(e => e.Paymentcode).HasColumnName("PAYMENTCODE");

                entity.Property(e => e.Paymentdate)
                    .HasColumnName("PAYMENTDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Paymentlinkid).HasColumnName("PAYMENTLINKID");

                entity.Property(e => e.Paymentrundate)
                    .HasColumnName("PAYMENTRUNDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Paymentrunnum).HasColumnName("PAYMENTRUNNUM");

                entity.Property(e => e.Prepayment).HasColumnName("PREPAYMENT");

                entity.Property(e => e.Providerno)
                    .HasColumnName("PROVIDERNO")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Reference)
                    .HasColumnName("REFERENCE")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");
            });

            modelBuilder.Entity<Paymenttypes>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PAYMENTTYPES", "dbo");

                entity.Property(e => e.Paymenttypecode).HasColumnName("PAYMENTTYPECODE");

                entity.Property(e => e.Paymenttypetext)
                    .IsRequired()
                    .HasColumnName("PAYMENTTYPETEXT")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Pcehraccess>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__PCEHRAccess__7345FA8E");

                entity.ToTable("PCEHRAccess", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Accessdate)
                    .HasColumnName("ACCESSDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Accesstime).HasColumnName("ACCESSTIME");

                entity.Property(e => e.Hofihi)
                    .HasColumnName("HOFIHI")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Hpii)
                    .IsRequired()
                    .HasColumnName("HPII")
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Hpio)
                    .IsRequired()
                    .HasColumnName("HPIO")
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Ihi)
                    .IsRequired()
                    .HasColumnName("IHI")
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Internalid).HasColumnName("INTERNALID");

                entity.Property(e => e.Locationid).HasColumnName("LOCATIONID");

                entity.Property(e => e.Result).HasColumnName("RESULT");

                entity.Property(e => e.Service).HasColumnName("SERVICE");

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.Pcehraccess)
                    .HasForeignKey(d => d.Locationid)
                    .HasConstraintName("FK__PCEHRAcce__LOCAT__4A4ED1F3");
            });

            modelBuilder.Entity<Pcehrdocuments>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__PCEHRDOCUMENTS__77168B72");

                entity.ToTable("PCEHRDOCUMENTS", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Documentdate)
                    .HasColumnName("DOCUMENTDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Documentid)
                    .IsRequired()
                    .HasColumnName("DOCUMENTID")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Documenttype).HasColumnName("DOCUMENTTYPE");

                entity.Property(e => e.Internalid).HasColumnName("INTERNALID");

                entity.Property(e => e.Locationid).HasColumnName("LOCATIONID");

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Stored).HasColumnName("STORED");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.HasOne(d => d.Internal)
                    .WithMany(p => p.Pcehrdocuments)
                    .HasForeignKey(d => d.Internalid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PCEHRDOCU__INTER__79F2F81D");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.Pcehrdocuments)
                    .HasForeignKey(d => d.Locationid)
                    .HasConstraintName("FK__PCEHRDOCU__LOCAT__4B42F62C");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Pcehrdocuments)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PCEHRDOCU__USERI__7AE71C56");
            });

            modelBuilder.Entity<Pedrec>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__PEDREC__72B0FDB1");

                entity.ToTable("PEDREC", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Category).HasColumnName("CATEGORY");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Internalid).HasColumnName("INTERNALID");

                entity.Property(e => e.Leaflet)
                    .HasColumnName("LEAFLET")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Peddate)
                    .HasColumnName("PEDDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Type)
                    .HasColumnName("TYPE")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.HasOne(d => d.Internal)
                    .WithMany(p => p.Pedrec)
                    .HasForeignKey(d => d.Internalid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PEDREC__INTERNAL__74994623");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Pedrec)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PEDREC__USERID__758D6A5C");
            });

            modelBuilder.Entity<PendingFiles>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__PendingF__84D4D4F525C91B1B");

                entity.ToTable("PendingFiles", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Content)
                    .HasColumnName("CONTENT")
                    .HasColumnType("text");

                entity.Property(e => e.Filedate)
                    .HasColumnName("FILEDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Filename)
                    .HasColumnName("FILENAME")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Pensiontype>(entity =>
            {
                entity.HasKey(e => e.Pensioncode)
                    .HasName("PK__PENSIONTYPE__5629CD9C");

                entity.ToTable("PENSIONTYPE", "dbo");

                entity.Property(e => e.Pensioncode)
                    .HasColumnName("PENSIONCODE")
                    .ValueGeneratedNever();

                entity.Property(e => e.Pensiontype1)
                    .IsRequired()
                    .HasColumnName("PENSIONTYPE")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Perineum>(entity =>
            {
                entity.HasKey(e => e.Perineumcode)
                    .HasName("PK__PERINEUM__0C85DE4D");

                entity.ToTable("PERINEUM", "dbo");

                entity.Property(e => e.Perineumcode)
                    .HasColumnName("PERINEUMCODE")
                    .ValueGeneratedNever();

                entity.Property(e => e.Perineumtext)
                    .IsRequired()
                    .HasColumnName("PERINEUMTEXT")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Permissions>(entity =>
            {
                entity.HasKey(e => e.Permissioncode)
                    .HasName("PK__PERMISSIONS__47A6A41B");

                entity.ToTable("PERMISSIONS", "dbo");

                entity.Property(e => e.Permissioncode)
                    .HasColumnName("PERMISSIONCODE")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Displayorder).HasColumnName("DISPLAYORDER");

                entity.Property(e => e.Permissionname)
                    .IsRequired()
                    .HasColumnName("PERMISSIONNAME")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Permissiontype).HasColumnName("PERMISSIONTYPE");
            });

            modelBuilder.Entity<Permissiontypes>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__PERMISSIONTYPES__4B7734FF");

                entity.ToTable("PERMISSIONTYPES", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Permissiontext)
                    .IsRequired()
                    .HasColumnName("PERMISSIONTEXT")
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Permissiontype).HasColumnName("PERMISSIONTYPE");

                entity.Property(e => e.Permissionvalue).HasColumnName("PERMISSIONVALUE");
            });

            modelBuilder.Entity<Pharmacy>(entity =>
            {
                entity.ToTable("PHARMACY", "dbo");

                entity.Property(e => e.Pharmacyid).HasColumnName("PHARMACYID");

                entity.Property(e => e.Address1)
                    .HasColumnName("ADDRESS1")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Address2)
                    .HasColumnName("ADDRESS2")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.City)
                    .HasColumnName("CITY")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Pharmacycode)
                    .HasColumnName("PHARMACYCODE")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Pharmacyname)
                    .HasColumnName("PHARMACYNAME")
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Phone)
                    .HasColumnName("PHONE")
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Postcode)
                    .HasColumnName("POSTCODE")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");
            });

            modelBuilder.Entity<Placenta>(entity =>
            {
                entity.HasKey(e => e.Placentacode)
                    .HasName("PK__PLACENTA__0E6E26BF");

                entity.ToTable("PLACENTA", "dbo");

                entity.Property(e => e.Placentacode)
                    .HasColumnName("PLACENTACODE")
                    .ValueGeneratedNever();

                entity.Property(e => e.Placentatext)
                    .IsRequired()
                    .HasColumnName("PLACENTATEXT")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Pmhfavourites>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__PMHFAVOURITES__0BE6BFCF");

                entity.ToTable("PMHFAVOURITES", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Termnameid).HasColumnName("TERMNAMEID");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Pmhfavourites)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PMHFAVOUR__USERI__0CDAE408");
            });

            modelBuilder.Entity<Popdetails>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__POPDETAILS__57E7F8DC");

                entity.ToTable("POPDETAILS", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Locationid).HasColumnName("LOCATIONID");

                entity.Property(e => e.Popserver)
                    .IsRequired()
                    .HasColumnName("POPSERVER")
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Popuserid)
                    .IsRequired()
                    .HasColumnName("POPUSERID")
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Popusername)
                    .IsRequired()
                    .HasColumnName("POPUSERNAME")
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Userid).HasColumnName("USERID");
            });

            modelBuilder.Entity<Practice>(entity =>
            {
                entity.ToTable("PRACTICE", "dbo");

                entity.Property(e => e.Practiceid).HasColumnName("PRACTICEID");

                entity.Property(e => e.Abn)
                    .HasColumnName("ABN")
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Accvendorhpi)
                    .HasColumnName("ACCVENDORHPI")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Argus).HasColumnName("ARGUS");

                entity.Property(e => e.BestHealthApiVersion)
                    .HasMaxLength(17)
                    .IsUnicode(false);

                entity.Property(e => e.Country).HasColumnName("COUNTRY");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Easyclaim).HasColumnName("EASYCLAIM");

                entity.Property(e => e.Gstnumber)
                    .HasColumnName("GSTNUMBER")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Hpio)
                    .HasColumnName("HPIO")
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Irdnumber)
                    .HasColumnName("IRDNUMBER")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Pcehr).HasColumnName("PCEHR");

                entity.Property(e => e.Pcehrcertificate)
                    .HasColumnName("PCEHRCERTIFICATE")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Pho).HasColumnName("PHO");

                entity.Property(e => e.Pipnumber)
                    .HasColumnName("PIPNUMBER")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Practicename)
                    .HasColumnName("PRACTICENAME")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Serialnumber)
                    .HasColumnName("SERIALNUMBER")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Tyro).HasColumnName("TYRO");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Vspnumber)
                    .HasColumnName("VSPNUMBER")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Pregnancies>(entity =>
            {
                entity.HasKey(e => e.Pregnancyid)
                    .HasName("PK__PREGNANCIES__7775B2CE");

                entity.ToTable("PREGNANCIES", "dbo");

                entity.Property(e => e.Pregnancyid).HasColumnName("PREGNANCYID");

                entity.Property(e => e.Actuallmp)
                    .HasColumnName("ACTUALLMP")
                    .HasColumnType("datetime");

                entity.Property(e => e.Analgesiacode).HasColumnName("ANALGESIACODE");

                entity.Property(e => e.AntiD).HasColumnName("ANTI_D");

                entity.Property(e => e.Augmentationcode).HasColumnName("AUGMENTATIONCODE");

                entity.Property(e => e.Bloodlosscode).HasColumnName("BLOODLOSSCODE");

                entity.Property(e => e.Certainty).HasColumnName("CERTAINTY");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Deliverycode).HasColumnName("DELIVERYCODE");

                entity.Property(e => e.Deliverynotes)
                    .HasColumnName("DELIVERYNOTES")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Eclampsia).HasColumnName("ECLAMPSIA");

                entity.Property(e => e.Edcbydate)
                    .HasColumnName("EDCBYDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Edcbyscan)
                    .HasColumnName("EDCBYSCAN")
                    .HasColumnType("datetime");

                entity.Property(e => e.Enddate)
                    .HasColumnName("ENDDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Feedingcode).HasColumnName("FEEDINGCODE");

                entity.Property(e => e.Gdm).HasColumnName("GDM");

                entity.Property(e => e.Gestationlength).HasColumnName("GESTATIONLENGTH");

                entity.Property(e => e.Hypertension).HasColumnName("HYPERTENSION");

                entity.Property(e => e.Internalid).HasColumnName("INTERNALID");

                entity.Property(e => e.Ivf).HasColumnName("IVF");

                entity.Property(e => e.Nominallmp)
                    .HasColumnName("NOMINALLMP")
                    .HasColumnType("datetime");

                entity.Property(e => e.Onsetcode).HasColumnName("ONSETCODE");

                entity.Property(e => e.Outcomecode).HasColumnName("OUTCOMECODE");

                entity.Property(e => e.Perineumcode).HasColumnName("PERINEUMCODE");

                entity.Property(e => e.Placentacode).HasColumnName("PLACENTACODE");

                entity.Property(e => e.Pnamenorrhoea).HasColumnName("PNAMENORRHOEA");

                entity.Property(e => e.Pnbleeding).HasColumnName("PNBLEEDING");

                entity.Property(e => e.Pncontraception).HasColumnName("PNCONTRACEPTION");

                entity.Property(e => e.Pncswound).HasColumnName("PNCSWOUND");

                entity.Property(e => e.Pndepression).HasColumnName("PNDEPRESSION");

                entity.Property(e => e.Pnperineum).HasColumnName("PNPERINEUM");

                entity.Property(e => e.Pnuterus).HasColumnName("PNUTERUS");

                entity.Property(e => e.Pnvisitnotes)
                    .HasColumnName("PNVISITNOTES")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Pregnancynumber).HasColumnName("PREGNANCYNUMBER");

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Renaldisease).HasColumnName("RENALDISEASE");

                entity.Property(e => e.Scandate)
                    .HasColumnName("SCANDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Scandays).HasColumnName("SCANDAYS");

                entity.Property(e => e.Scanweeks).HasColumnName("SCANWEEKS");

                entity.Property(e => e.Stage1labour)
                    .HasColumnName("STAGE1LABOUR")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Stage2labour)
                    .HasColumnName("STAGE2LABOUR")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Stage3labour)
                    .HasColumnName("STAGE3LABOUR")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.Property(e => e.Usescan).HasColumnName("USESCAN");

                entity.HasOne(d => d.AnalgesiacodeNavigation)
                    .WithMany(p => p.Pregnancies)
                    .HasForeignKey(d => d.Analgesiacode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PREGNANCI__ANALG__18D6A699");

                entity.HasOne(d => d.AugmentationcodeNavigation)
                    .WithMany(p => p.Pregnancies)
                    .HasForeignKey(d => d.Augmentationcode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PREGNANCI__AUGME__17E28260");

                entity.HasOne(d => d.BloodlosscodeNavigation)
                    .WithMany(p => p.Pregnancies)
                    .HasForeignKey(d => d.Bloodlosscode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PREGNANCI__BLOOD__1BB31344");

                entity.HasOne(d => d.DeliverycodeNavigation)
                    .WithMany(p => p.Pregnancies)
                    .HasForeignKey(d => d.Deliverycode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PREGNANCI__DELIV__16EE5E27");

                entity.HasOne(d => d.FeedingcodeNavigation)
                    .WithMany(p => p.Pregnancies)
                    .HasForeignKey(d => d.Feedingcode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PREGNANCI__FEEDI__1CA7377D");

                entity.HasOne(d => d.Internal)
                    .WithMany(p => p.Pregnancies)
                    .HasForeignKey(d => d.Internalid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PREGNANCI__INTER__1411F17C");

                entity.HasOne(d => d.OnsetcodeNavigation)
                    .WithMany(p => p.Pregnancies)
                    .HasForeignKey(d => d.Onsetcode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PREGNANCI__ONSET__15FA39EE");

                entity.HasOne(d => d.OutcomecodeNavigation)
                    .WithMany(p => p.Pregnancies)
                    .HasForeignKey(d => d.Outcomecode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PREGNANCI__OUTCO__150615B5");

                entity.HasOne(d => d.PerineumcodeNavigation)
                    .WithMany(p => p.Pregnancies)
                    .HasForeignKey(d => d.Perineumcode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PREGNANCI__PERIN__19CACAD2");

                entity.HasOne(d => d.PlacentacodeNavigation)
                    .WithMany(p => p.Pregnancies)
                    .HasForeignKey(d => d.Placentacode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PREGNANCI__PLACE__1ABEEF0B");
            });

            modelBuilder.Entity<Pregnancyimaging>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PREGNANCYIMAGING", "dbo");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Internalid).HasColumnName("INTERNALID");

                entity.Property(e => e.Pregnancyid).HasColumnName("PREGNANCYID");

                entity.Property(e => e.Recordid)
                    .HasColumnName("RECORDID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Resultid).HasColumnName("RESULTID");

                entity.Property(e => e.Sequence).HasColumnName("SEQUENCE");

                entity.Property(e => e.Testname)
                    .HasColumnName("TESTNAME")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.HasOne(d => d.Internal)
                    .WithMany(p => p.Pregnancyimaging)
                    .HasForeignKey(d => d.Internalid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PREGNANCY__INTER__31A25463");

                entity.HasOne(d => d.Pregnancy)
                    .WithMany(p => p.Pregnancyimaging)
                    .HasForeignKey(d => d.Pregnancyid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PREGNANCY__PREGN__3296789C");
            });

            modelBuilder.Entity<Pregnancyoutcome>(entity =>
            {
                entity.HasKey(e => e.Outcomecode)
                    .HasName("PK__PREGNANCYOUTCOME__02FC7413");

                entity.ToTable("PREGNANCYOUTCOME", "dbo");

                entity.Property(e => e.Outcomecode)
                    .HasColumnName("OUTCOMECODE")
                    .ValueGeneratedNever();

                entity.Property(e => e.Outcometext)
                    .IsRequired()
                    .HasColumnName("OUTCOMETEXT")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Pregnancyresults>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PREGNANCYRESULTS", "dbo");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Internalid).HasColumnName("INTERNALID");

                entity.Property(e => e.Pregnancyid).HasColumnName("PREGNANCYID");

                entity.Property(e => e.Recordid)
                    .HasColumnName("RECORDID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Resultid).HasColumnName("RESULTID");

                entity.Property(e => e.Sequence).HasColumnName("SEQUENCE");

                entity.Property(e => e.Testname)
                    .HasColumnName("TESTNAME")
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.HasOne(d => d.Internal)
                    .WithMany(p => p.Pregnancyresults)
                    .HasForeignKey(d => d.Internalid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PREGNANCY__INTER__2BE97B0D");

                entity.HasOne(d => d.Pregnancy)
                    .WithMany(p => p.Pregnancyresults)
                    .HasForeignKey(d => d.Pregnancyid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PREGNANCY__PREGN__2CDD9F46");
            });

            modelBuilder.Entity<Prescriptions>(entity =>
            {
                entity.HasKey(e => e.Scriptid)
                    .HasName("PK__PRESCRIPTIONS__3508D0F3");

                entity.ToTable("PRESCRIPTIONS", "dbo");

                entity.HasIndex(e => e.Internalid)
                    .HasName("PRESCRIPTIONS2");

                entity.HasIndex(e => e.Scriptdate)
                    .HasName("PRESCRIPTIONS3");

                entity.HasIndex(e => new { e.Scriptid, e.Recordstatus })
                    .HasName("PRESCRIPTIONS1");

                entity.HasIndex(e => new { e.Printstatus, e.Userid, e.Recordstatus, e.Scriptid })
                    .HasName("PRESCRIPTIONS4");

                entity.HasIndex(e => new { e.Recordstatus, e.Printstatus, e.Scriptid, e.Scriptdate })
                    .HasName("PRESCRIPTIONS5");

                entity.Property(e => e.Scriptid).HasColumnName("SCRIPTID");

                entity.Property(e => e.Allowsubstitution).HasColumnName("ALLOWSUBSTITUTION");

                entity.Property(e => e.Approvalnumber)
                    .HasColumnName("APPROVALNUMBER")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Authority).HasColumnName("AUTHORITY");

                entity.Property(e => e.Authoritynumber)
                    .HasColumnName("AUTHORITYNUMBER")
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Ctg)
                    .HasColumnName("CTG")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Deletiondate)
                    .HasColumnName("DELETIONDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deletionreason)
                    .HasColumnName("DELETIONREASON")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EStatus)
                    .HasColumnName("eStatus")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Internalid).HasColumnName("INTERNALID");

                entity.Property(e => e.Locationid).HasColumnName("LOCATIONID");

                entity.Property(e => e.Previousauthority).HasColumnName("PREVIOUSAUTHORITY");

                entity.Property(e => e.Printdate)
                    .HasColumnName("PRINTDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Printstatus).HasColumnName("PRINTSTATUS");

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Restrictioncode).HasColumnName("RESTRICTIONCODE");

                entity.Property(e => e.Scid)
                    .HasColumnName("SCID")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Scriptdate)
                    .HasColumnName("SCRIPTDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Sendtopatient).HasColumnName("SENDTOPATIENT");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.HasOne(d => d.Internal)
                    .WithMany(p => p.Prescriptions)
                    .HasForeignKey(d => d.Internalid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PRESCRIPT__INTER__3AC1AA49");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Prescriptions)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PRESCRIPT__USERI__3BB5CE82");

                entity.HasOne(d => d.Visit)
                    .WithMany(p => p.Prescriptions)
                    .HasForeignKey(d => d.VisitId)
                    .HasConstraintName("FK__PRESCRIPT__Visit__0B287117");
            });

            modelBuilder.Entity<Preventivehealth>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__PREVENTIVEHEALTH__355DD6AE");

                entity.ToTable("PREVENTIVEHEALTH", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Internalid).HasColumnName("INTERNALID");

                entity.Property(e => e.Itemid).HasColumnName("ITEMID");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");
            });

            modelBuilder.Entity<Printers>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__PRINTERS__2B3F6F97");

                entity.ToTable("PRINTERS", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Computer)
                    .IsRequired()
                    .HasColumnName("COMPUTER")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Landscape).HasColumnName("LANDSCAPE");

                entity.Property(e => e.Paperbin).HasColumnName("PAPERBIN");

                entity.Property(e => e.Paperbinname)
                    .HasColumnName("PAPERBINNAME")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Preview).HasColumnName("PREVIEW");

                entity.Property(e => e.Printer)
                    .IsRequired()
                    .HasColumnName("PRINTER")
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.Printercode).HasColumnName("PRINTERCODE");

                entity.Property(e => e.Prompt).HasColumnName("PROMPT");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Xadjust).HasColumnName("XADJUST");

                entity.Property(e => e.Yadjust).HasColumnName("YADJUST");
            });

            modelBuilder.Entity<ProcessReports>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__ProcessReports__2215F810");

                entity.ToTable("ProcessReports", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Batchid).HasColumnName("BATCHID");

                entity.Property(e => e.Bpserviceid).HasColumnName("BPSERVICEID");

                entity.Property(e => e.Chargeamount).HasColumnName("CHARGEAMOUNT");

                entity.Property(e => e.Claimbenefitpaid).HasColumnName("CLAIMBENEFITPAID");

                entity.Property(e => e.Claimchargeamount).HasColumnName("CLAIMCHARGEAMOUNT");

                entity.Property(e => e.Claimid)
                    .HasColumnName("CLAIMID")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Dateofservice)
                    .HasColumnName("DATEOFSERVICE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Explanationcode).HasColumnName("EXPLANATIONCODE");

                entity.Property(e => e.Internalid).HasColumnName("INTERNALID");

                entity.Property(e => e.Itemnum).HasColumnName("ITEMNUM");

                entity.Property(e => e.Medicarecardflag)
                    .HasColumnName("MEDICARECARDFLAG")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Noofpatientsseen).HasColumnName("NOOFPATIENTSSEEN");

                entity.Property(e => e.Patientfamilyname)
                    .HasColumnName("PATIENTFAMILYNAME")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Patientfirstname)
                    .HasColumnName("PATIENTFIRSTNAME")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Patientmedicarecardnum)
                    .HasColumnName("PATIENTMEDICARECARDNUM")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Patientreferencenum)
                    .HasColumnName("PATIENTREFERENCENUM")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Servicebenefitamount).HasColumnName("SERVICEBENEFITAMOUNT");

                entity.Property(e => e.Serviceid)
                    .HasColumnName("SERVICEID")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Servicingprovidernum)
                    .HasColumnName("SERVICINGPROVIDERNUM")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Userid).HasColumnName("USERID");
            });

            modelBuilder.Entity<ProductCombination>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__PRODUCT_COMBINAT__184C96B4");

                entity.ToTable("PRODUCT_COMBINATION", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Allowsubstitution).HasColumnName("ALLOWSUBSTITUTION");

                entity.Property(e => e.Combinationid).HasColumnName("COMBINATIONID");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Dose)
                    .HasColumnName("DOSE")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Dosesperday)
                    .HasColumnName("DOSESPERDAY")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Drugname)
                    .HasColumnName("DRUGNAME")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Food).HasColumnName("FOOD");

                entity.Property(e => e.Frequency).HasColumnName("FREQUENCY");

                entity.Property(e => e.Instructions)
                    .HasColumnName("INSTRUCTIONS")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Otherdetail).HasColumnName("OTHERDETAIL");

                entity.Property(e => e.Packid).HasColumnName("PACKID");

                entity.Property(e => e.Prn).HasColumnName("PRN");

                entity.Property(e => e.Productid).HasColumnName("PRODUCTID");

                entity.Property(e => e.Productunit)
                    .IsRequired()
                    .HasColumnName("PRODUCTUNIT")
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Quantity).HasColumnName("QUANTITY");

                entity.Property(e => e.Regulation24).HasColumnName("REGULATION24");

                entity.Property(e => e.Repeatinterval).HasColumnName("REPEATINTERVAL");

                entity.Property(e => e.Repeats).HasColumnName("REPEATS");

                entity.Property(e => e.Restrictioncode).HasColumnName("RESTRICTIONCODE");

                entity.Property(e => e.Route).HasColumnName("ROUTE");

                entity.Property(e => e.Rxstatus).HasColumnName("RXSTATUS");

                entity.Property(e => e.Tgpexempt).HasColumnName("TGPEXEMPT");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Usepbsquantity).HasColumnName("USEPBSQUANTITY");

                entity.HasOne(d => d.Combination)
                    .WithMany(p => p.ProductCombination)
                    .HasForeignKey(d => d.Combinationid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PRODUCT_C__COMBI__23BE4960");
            });

            modelBuilder.Entity<Prompt>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__PROMPT__222B06A9");

                entity.ToTable("PROMPT", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Internalid).HasColumnName("INTERNALID");

                entity.Property(e => e.Promptcode).HasColumnName("PROMPTCODE");

                entity.Property(e => e.Promptstatus).HasColumnName("PROMPTSTATUS");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.HasOne(d => d.Internal)
                    .WithMany(p => p.Prompt)
                    .HasForeignKey(d => d.Internalid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PROMPT__INTERNAL__231F2AE2");
            });

            modelBuilder.Entity<ProviderLocation>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__PROVIDER_LOCATIO__450A2E92");

                entity.ToTable("PROVIDER_LOCATION", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Erxid)
                    .HasColumnName("ERXID")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Locationid).HasColumnName("LOCATIONID");

                entity.Property(e => e.Providernumber)
                    .HasColumnName("PROVIDERNUMBER")
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Thumbprint)
                    .HasColumnName("THUMBPRINT")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.ProviderLocation)
                    .HasForeignKey(d => d.Locationid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PROVIDER___LOCAT__49CEE3AF");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ProviderLocation)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PROVIDER___USERI__48DABF76");
            });

            modelBuilder.Entity<Providerpayments>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__PROVIDERPAYMENTS__1F6E958F");

                entity.ToTable("PROVIDERPAYMENTS", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Payto)
                    .IsRequired()
                    .HasColumnName("PAYTO")
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProviderLocationid).HasColumnName("PROVIDER_LOCATIONID");

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Userid).HasColumnName("USERID");
            });

            modelBuilder.Entity<Psidetails>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__PSIDetails__5D6BC808");

                entity.ToTable("PSIDetails", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Computer)
                    .HasColumnName("COMPUTER")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Psipath)
                    .HasColumnName("PSIPATH")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Usage)
                    .HasColumnName("USAGE")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<QueueConfigurations>(entity =>
            {
                entity.HasKey(e => e.ConfigurationId);

                entity.ToTable("QueueConfigurations", "dbo");

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.HandlerName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MachineName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.QueueName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Updated).HasColumnType("datetime");
            });

            modelBuilder.Entity<Quoteitems>(entity =>
            {
                entity.HasKey(e => e.Quoteitemid)
                    .HasName("PK__QUOTEITEMS__20B7BF83");

                entity.ToTable("QUOTEITEMS", "dbo");

                entity.Property(e => e.Quoteitemid).HasColumnName("QUOTEITEMID");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Fee).HasColumnName("FEE");

                entity.Property(e => e.Gst).HasColumnName("GST");

                entity.Property(e => e.Practiceid).HasColumnName("PRACTICEID");

                entity.Property(e => e.Quoteitemcode)
                    .IsRequired()
                    .HasColumnName("QUOTEITEMCODE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Refund).HasColumnName("REFUND");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Userid).HasColumnName("USERID");
            });

            modelBuilder.Entity<Reactions>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__REACTIONS__25077354");

                entity.ToTable("REACTIONS", "dbo");

                entity.HasIndex(e => new { e.Recordid, e.Itemtype, e.Itemcode, e.Reactioncode, e.Reaction, e.Created, e.Createdby, e.Updated, e.Updatedby, e.Recordstatus, e.Internalid, e.Userid, e.Severity, e.Itemname })
                    .HasName("REACTIONS1");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Comment)
                    .HasColumnName("COMMENT")
                    .IsUnicode(false);

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Internalid).HasColumnName("INTERNALID");

                entity.Property(e => e.Itemcode).HasColumnName("ITEMCODE");

                entity.Property(e => e.Itemname)
                    .IsRequired()
                    .HasColumnName("ITEMNAME")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Itemtype).HasColumnName("ITEMTYPE");

                entity.Property(e => e.Reaction)
                    .IsRequired()
                    .HasColumnName("REACTION")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Reactioncode).HasColumnName("REACTIONCODE");

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Severity).HasColumnName("SEVERITY");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.HasOne(d => d.Internal)
                    .WithMany(p => p.Reactions)
                    .HasForeignKey(d => d.Internalid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__REACTIONS__INTER__26EFBBC6");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Reactions)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__REACTIONS__USERI__27E3DFFF");

                entity.HasOne(d => d.Visit)
                    .WithMany(p => p.Reactions)
                    .HasForeignKey(d => d.VisitId)
                    .HasConstraintName("FK__REACTIONS__Visit__0D10B989");
            });

            modelBuilder.Entity<Receipts>(entity =>
            {
                entity.HasKey(e => e.Receiptid)
                    .HasName("PK__RECEIPTS__4B8221F7");

                entity.ToTable("RECEIPTS", "dbo");

                entity.Property(e => e.Receiptid).HasColumnName("RECEIPTID");

                entity.Property(e => e.Amount).HasColumnName("AMOUNT");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Fee).HasColumnName("FEE");

                entity.Property(e => e.Gst).HasColumnName("GST");

                entity.Property(e => e.Itemid).HasColumnName("ITEMID");

                entity.Property(e => e.Mbsitem).HasColumnName("MBSITEM");

                entity.Property(e => e.Paid).HasColumnName("PAID");

                entity.Property(e => e.Paymentid).HasColumnName("PAYMENTID");

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");
            });

            modelBuilder.Entity<Referrals>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__REFERRALS__7AC720C5");

                entity.ToTable("REFERRALS", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Contactid).HasColumnName("CONTACTID");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Detailid).HasColumnName("DETAILID");

                entity.Property(e => e.Expirydate)
                    .HasColumnName("EXPIRYDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Firstvisit)
                    .HasColumnName("FIRSTVISIT")
                    .HasColumnType("datetime");

                entity.Property(e => e.Internalid).HasColumnName("INTERNALID");

                entity.Property(e => e.Months).HasColumnName("MONTHS");

                entity.Property(e => e.Previoususerid).HasColumnName("PREVIOUSUSERID");

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Referralcode).HasColumnName("REFERRALCODE");

                entity.Property(e => e.Referraldate)
                    .HasColumnName("REFERRALDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Specialist).HasColumnName("SPECIALIST");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.Referrals)
                    .HasForeignKey(d => d.Contactid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__REFERRALS__CONTA__01741E54");

                entity.HasOne(d => d.Internal)
                    .WithMany(p => p.Referrals)
                    .HasForeignKey(d => d.Internalid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__REFERRALS__INTER__7F8BD5E2");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Referrals)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__REFERRALS__USERI__007FFA1B");
            });

            modelBuilder.Entity<RegistrationStatus>(entity =>
            {
                entity.HasKey(e => e.RecordId)
                    .HasName("PK__REGISTRA__FBDF78C9B815E7ED");

                entity.ToTable("REGISTRATION_STATUS", "dbo");

                entity.HasIndex(e => e.Status)
                    .HasName("UQ__REGISTRA__3A15923F5149ED59")
                    .IsUnique();

                entity.Property(e => e.RecordId).HasColumnName("RecordID");

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(15);

                entity.Property(e => e.Updated).HasColumnType("datetime");
            });

            modelBuilder.Entity<Relations>(entity =>
            {
                entity.HasKey(e => e.Relationcode)
                    .HasName("PK__RELATIONS__5CD6CB2B");

                entity.ToTable("RELATIONS", "dbo");

                entity.Property(e => e.Relationcode)
                    .HasColumnName("RELATIONCODE")
                    .ValueGeneratedNever();

                entity.Property(e => e.Relationname)
                    .IsRequired()
                    .HasColumnName("RELATIONNAME")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Reminderbatch>(entity =>
            {
                entity.HasKey(e => e.Batchid)
                    .HasName("PK__REMINDERBATCH__2D9CB955");

                entity.ToTable("REMINDERBATCH", "dbo");

                entity.Property(e => e.Batchid).HasColumnName("BATCHID");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Sentby).HasColumnName("SENTBY");

                entity.Property(e => e.Sentdate)
                    .HasColumnName("SENTDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Senttime).HasColumnName("SENTTIME");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");
            });

            modelBuilder.Entity<Reminderlist>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("REMINDERLIST", "dbo");

                entity.Property(e => e.Fieldname)
                    .IsRequired()
                    .HasColumnName("FIELDNAME")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Fieldsize).HasColumnName("FIELDSIZE");

                entity.Property(e => e.Fieldsym)
                    .IsRequired()
                    .HasColumnName("FIELDSYM")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Reminderreasons>(entity =>
            {
                entity.HasKey(e => e.Reminderreasonid)
                    .HasName("PK__REMINDERREASONS__29CC2871");

                entity.ToTable("REMINDERREASONS", "dbo");

                entity.Property(e => e.Reminderreasonid).HasColumnName("REMINDERREASONID");

                entity.Property(e => e.Au).HasColumnName("AU");

                entity.Property(e => e.Clinicallysignificant).HasColumnName("CLINICALLYSIGNIFICANT");

                entity.Property(e => e.Defaultinterval).HasColumnName("DEFAULTINTERVAL");

                entity.Property(e => e.Displayorder).HasColumnName("DISPLAYORDER");

                entity.Property(e => e.Intervalcode).HasColumnName("INTERVALCODE");

                entity.Property(e => e.Nz).HasColumnName("NZ");

                entity.Property(e => e.Reasontext)
                    .IsRequired()
                    .HasColumnName("REASONTEXT")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Remindertypeid).HasColumnName("REMINDERTYPEID");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.Property(e => e.Userinterval).HasColumnName("USERINTERVAL");

                entity.Property(e => e.Userintervalcode).HasColumnName("USERINTERVALCODE");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Reminderreasons)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__REMINDERR__USERI__2BB470E3");
            });

            modelBuilder.Entity<Reminders>(entity =>
            {
                entity.HasKey(e => e.Reminderid)
                    .HasName("PK__REMINDERS__30792600");

                entity.ToTable("REMINDERS", "dbo");

                entity.HasIndex(e => e.Internalid)
                    .HasName("REMINDERS3");

                entity.HasIndex(e => e.Reminderdue)
                    .HasName("REMINDERS1");

                entity.HasIndex(e => e.Userid)
                    .HasName("REMINDERS2");

                entity.HasIndex(e => new { e.Reminderreasonid, e.Reminderdue })
                    .HasName("REMINDERS4");

                entity.HasIndex(e => new { e.Userid, e.Reminderreasonid, e.Reminderdue })
                    .HasName("REMINDERS5");

                entity.Property(e => e.Reminderid).HasColumnName("REMINDERID");

                entity.Property(e => e.Appointmentid).HasColumnName("APPOINTMENTID");

                entity.Property(e => e.Batchid).HasColumnName("BATCHID");

                entity.Property(e => e.Comments)
                    .HasColumnName("COMMENTS")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Internalid).HasColumnName("INTERNALID");

                entity.Property(e => e.Interval).HasColumnName("INTERVAL");

                entity.Property(e => e.Intervalcode).HasColumnName("INTERVALCODE");

                entity.Property(e => e.Locationid).HasColumnName("LOCATIONID");

                entity.Property(e => e.Previoususerid).HasColumnName("PREVIOUSUSERID");

                entity.Property(e => e.Reasontext)
                    .IsRequired()
                    .HasColumnName("REASONTEXT")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Remindercode).HasColumnName("REMINDERCODE");

                entity.Property(e => e.Reminderdue)
                    .HasColumnName("REMINDERDUE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Reminderreasonid).HasColumnName("REMINDERREASONID");

                entity.Property(e => e.Reminderstatus).HasColumnName("REMINDERSTATUS");

                entity.Property(e => e.Statustext)
                    .HasColumnName("STATUSTEXT")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.Property(e => e.Visitid).HasColumnName("VISITID");

                entity.HasOne(d => d.Batch)
                    .WithMany(p => p.Reminders)
                    .HasForeignKey(d => d.Batchid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__REMINDERS__BATCH__381A47C8");

                entity.HasOne(d => d.Internal)
                    .WithMany(p => p.Reminders)
                    .HasForeignKey(d => d.Internalid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__REMINDERS__INTER__3726238F");

                entity.HasOne(d => d.Reminderreason)
                    .WithMany(p => p.Reminders)
                    .HasForeignKey(d => d.Reminderreasonid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__REMINDERS__REMIN__390E6C01");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Reminders)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__REMINDERS__USERI__3A02903A");
            });

            modelBuilder.Entity<Reminderssent>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__REMINDERSSENT__3BEAD8AC");

                entity.ToTable("REMINDERSSENT", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Actionby).HasColumnName("ACTIONBY");

                entity.Property(e => e.Actioncode).HasColumnName("ACTIONCODE");

                entity.Property(e => e.Actiondate)
                    .HasColumnName("ACTIONDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Actiontext)
                    .HasColumnName("ACTIONTEXT")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Internalid).HasColumnName("INTERNALID");

                entity.Property(e => e.Locationid).HasColumnName("LOCATIONID");

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Reminderid).HasColumnName("REMINDERID");

                entity.Property(e => e.Sentby).HasColumnName("SENTBY");

                entity.Property(e => e.Sentcode).HasColumnName("SENTCODE");

                entity.Property(e => e.Sentdate)
                    .HasColumnName("SENTDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Templateid).HasColumnName("TEMPLATEID");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.HasOne(d => d.Internal)
                    .WithMany(p => p.Reminderssent)
                    .HasForeignKey(d => d.Internalid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__REMINDERS__INTER__4297D63B");

                entity.HasOne(d => d.Reminder)
                    .WithMany(p => p.Reminderssent)
                    .HasForeignKey(d => d.Reminderid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__REMINDERS__REMIN__438BFA74");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Reminderssent)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__REMINDERS__USERI__44801EAD");
            });

            modelBuilder.Entity<Reportcomments>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__REPORTCOMMENTS__7B264821");

                entity.ToTable("REPORTCOMMENTS", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Commenttext)
                    .HasColumnName("COMMENTTEXT")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Reportcomments)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__REPORTCOM__USERI__7E02B4CC");
            });

            modelBuilder.Entity<Reportextensions>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("REPORTEXTENSIONS", "dbo");

                entity.Property(e => e.Extension)
                    .IsRequired()
                    .HasColumnName("EXTENSION")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Reportoptions>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__REPORTOPTIONS__24927208");

                entity.ToTable("REPORTOPTIONS", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Computer)
                    .HasColumnName("COMPUTER")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Optionname)
                    .IsRequired()
                    .HasColumnName("OPTIONNAME")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Optiontext)
                    .HasColumnName("OPTIONTEXT")
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.Optionvalue).HasColumnName("OPTIONVALUE");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");
            });

            modelBuilder.Entity<Reportpaths>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__REPORTPATHS__22AA2996");

                entity.ToTable("REPORTPATHS", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Computer)
                    .IsRequired()
                    .HasColumnName("COMPUTER")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Invalidaccessattempts).HasColumnName("INVALIDACCESSATTEMPTS");

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Reportpath)
                    .HasColumnName("REPORTPATH")
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");
            });

            modelBuilder.Entity<Reportstore>(entity =>
            {
                entity.HasKey(e => e.Reportname)
                    .HasName("PK__REPORTSTORE__14270015");

                entity.ToTable("REPORTSTORE", "dbo");

                entity.Property(e => e.Reportname)
                    .HasColumnName("REPORTNAME")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Storagecode).HasColumnName("STORAGECODE");
            });

            modelBuilder.Entity<Reportvalues>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__REPORTVALUES__65570293");

                entity.ToTable("REPORTVALUES", "dbo");

                entity.HasIndex(e => e.Bpcode)
                    .HasName("REPORTVALUES3");

                entity.HasIndex(e => e.Internalid)
                    .HasName("REPORTVALUES1");

                entity.HasIndex(e => e.Reportid)
                    .HasName("REPORTVALUES2");

                entity.HasIndex(e => new { e.Internalid, e.Reportdate })
                    .HasName("REPORTVALUES4");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Abnormalflag)
                    .HasColumnName("ABNORMALFLAG")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Bpcode).HasColumnName("BPCODE");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Datatype)
                    .HasColumnName("DATATYPE")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Internalid).HasColumnName("INTERNALID");

                entity.Property(e => e.Loinccode)
                    .HasColumnName("LOINCCODE")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Range)
                    .HasColumnName("RANGE")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Reportdate)
                    .HasColumnName("REPORTDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Reportid).HasColumnName("REPORTID");

                entity.Property(e => e.Resultname)
                    .HasColumnName("RESULTNAME")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Resultvalue)
                    .HasColumnName("RESULTVALUE")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Units)
                    .HasColumnName("UNITS")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.HasOne(d => d.Internal)
                    .WithMany(p => p.Reportvalues)
                    .HasForeignKey(d => d.Internalid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__REPORTVAL__INTER__673F4B05");

                entity.HasOne(d => d.Report)
                    .WithMany(p => p.Reportvalues)
                    .HasForeignKey(d => d.Reportid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__REPORTVAL__REPOR__68336F3E");
            });

            modelBuilder.Entity<Requestedtests>(entity =>
            {
                entity.HasKey(e => e.Requestid)
                    .HasName("PK__REQUESTEDTESTS__742F31CF");

                entity.ToTable("REQUESTEDTESTS", "dbo");

                entity.HasIndex(e => e.Internalid)
                    .HasName("REQUESTEDTESTS3");

                entity.HasIndex(e => e.Requestdate)
                    .HasName("REQUESTEDTESTS1");

                entity.HasIndex(e => e.Userid)
                    .HasName("REQUESTEDTESTS2");

                entity.HasIndex(e => new { e.Internalid, e.Requestdate })
                    .HasName("REQUESTEDTESTS4");

                entity.HasIndex(e => new { e.Requeststatus, e.Requestdate })
                    .HasName("REQUESTEDTESTS5");

                entity.HasIndex(e => new { e.Requesttype, e.Requestdate, e.Providerid, e.Providername, e.Freetextitem, e.Fasting, e.Pregnant, e.Lmp, e.Edc, e.Urgent, e.Urgentby, e.Urgentphone, e.Urgentfax, e.Clinicaldetails, e.Smearsite, e.Cervix, e.Erosion, e.Ectropion, e.Postnatal, e.Postmenopausal, e.Ocp, e.Hrt, e.Hysterectomy, e.Radiorx, e.Iud, e.Bleeding, e.Copies, e.Billing, e.Papregister, e.Created, e.Createdby, e.Updated, e.Updatedby, e.Internalid, e.Recordstatus, e.Requeststatus, e.Requestid, e.Userid })
                    .HasName("REQUESTEDTESTS6");

                entity.Property(e => e.Requestid).HasColumnName("REQUESTID");

                entity.Property(e => e.Billing).HasColumnName("BILLING");

                entity.Property(e => e.Bleeding).HasColumnName("BLEEDING");

                entity.Property(e => e.Cervix).HasColumnName("CERVIX");

                entity.Property(e => e.Clinicaldetails)
                    .HasColumnName("CLINICALDETAILS")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Consent).HasColumnName("CONSENT");

                entity.Property(e => e.Copies)
                    .HasColumnName("COPIES")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Desexposure).HasColumnName("DESExposure");

                entity.Property(e => e.Ectropion).HasColumnName("ECTROPION");

                entity.Property(e => e.Edc)
                    .HasColumnName("EDC")
                    .HasColumnType("datetime");

                entity.Property(e => e.Erosion).HasColumnName("EROSION");

                entity.Property(e => e.Fasting).HasColumnName("FASTING");

                entity.Property(e => e.Freetextitem)
                    .HasColumnName("FREETEXTITEM")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Hrt).HasColumnName("HRT");

                entity.Property(e => e.Hysterectomy).HasColumnName("HYSTERECTOMY");

                entity.Property(e => e.Imbleeding).HasColumnName("IMBleeding");

                entity.Property(e => e.Internalid).HasColumnName("INTERNALID");

                entity.Property(e => e.Iud).HasColumnName("IUD");

                entity.Property(e => e.Labrequestid)
                    .HasColumnName("LABREQUESTID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Lmp)
                    .HasColumnName("LMP")
                    .HasColumnType("datetime");

                entity.Property(e => e.Locationid).HasColumnName("LOCATIONID");

                entity.Property(e => e.Modality).HasColumnName("MODALITY");

                entity.Property(e => e.Ocp).HasColumnName("OCP");

                entity.Property(e => e.Papregister).HasColumnName("PAPREGISTER");

                entity.Property(e => e.Pcbleeding).HasColumnName("PCBleeding");

                entity.Property(e => e.Pmbleeding).HasColumnName("PMBleeding");

                entity.Property(e => e.Postmenopausal).HasColumnName("POSTMENOPAUSAL");

                entity.Property(e => e.Postnatal).HasColumnName("POSTNATAL");

                entity.Property(e => e.Pregnant).HasColumnName("PREGNANT");

                entity.Property(e => e.PreviousAis).HasColumnName("PreviousAIS");

                entity.Property(e => e.Providerid).HasColumnName("PROVIDERID");

                entity.Property(e => e.Providername)
                    .HasColumnName("PROVIDERNAME")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Pvdischarge).HasColumnName("PVDischarge");

                entity.Property(e => e.Radiorx).HasColumnName("RADIORX");

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Requestdate)
                    .HasColumnName("REQUESTDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Requeststatus).HasColumnName("REQUESTSTATUS");

                entity.Property(e => e.Requesttype).HasColumnName("REQUESTTYPE");

                entity.Property(e => e.Smearsite).HasColumnName("SMEARSITE");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Urgent).HasColumnName("URGENT");

                entity.Property(e => e.Urgentby)
                    .HasColumnName("URGENTBY")
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Urgentfax)
                    .HasColumnName("URGENTFAX")
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Urgentphone)
                    .HasColumnName("URGENTPHONE")
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.HasOne(d => d.Internal)
                    .WithMany(p => p.Requestedtests)
                    .HasForeignKey(d => d.Internalid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__REQUESTED__INTER__08362A7C");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Requestedtests)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__REQUESTED__USERI__092A4EB5");

                entity.HasOne(d => d.Visit)
                    .WithMany(p => p.Requestedtests)
                    .HasForeignKey(d => d.VisitId)
                    .HasConstraintName("FK__REQUESTED__Visit__0EF901FB");
            });

            modelBuilder.Entity<Requestformatdetail>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__REQUESTFORMATDET__7993056A");

                entity.ToTable("REQUESTFORMATDETAIL", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Elementheight).HasColumnName("ELEMENTHEIGHT");

                entity.Property(e => e.Elementleft).HasColumnName("ELEMENTLEFT");

                entity.Property(e => e.Elementname)
                    .IsRequired()
                    .HasColumnName("ELEMENTNAME")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Elementtop).HasColumnName("ELEMENTTOP");

                entity.Property(e => e.Elementwidth).HasColumnName("ELEMENTWIDTH");

                entity.Property(e => e.Requestformat).HasColumnName("REQUESTFORMAT");

                entity.HasOne(d => d.RequestformatNavigation)
                    .WithMany(p => p.Requestformatdetail)
                    .HasForeignKey(d => d.Requestformat)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__REQUESTFO__REQUE__7E57BA87");
            });

            modelBuilder.Entity<Requestformats>(entity =>
            {
                entity.HasKey(e => e.Requestformat)
                    .HasName("PK__REQUESTFORMATS__76B698BF");

                entity.ToTable("REQUESTFORMATS", "dbo");

                entity.Property(e => e.Requestformat).HasColumnName("REQUESTFORMAT");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Formatname)
                    .HasColumnName("FORMATNAME")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");
            });

            modelBuilder.Entity<Reservedappointments>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__RESERVEDAPPOINTM__52EE3995");

                entity.ToTable("RESERVEDAPPOINTMENTS", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Appointmenttime).HasColumnName("APPOINTMENTTIME");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Dayofweek).HasColumnName("DAYOFWEEK");

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Userid).HasColumnName("USERID");
            });

            modelBuilder.Entity<Resultbatch>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__RESULTBATCH__0EE3280B");

                entity.ToTable("RESULTBATCH", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Batchid).HasColumnName("BATCHID");

                entity.Property(e => e.Batchtype).HasColumnName("BATCHTYPE");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Labname)
                    .IsRequired()
                    .HasColumnName("LABNAME")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Processdate)
                    .HasColumnName("PROCESSDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");
            });

            modelBuilder.Entity<Reversals>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__REVERSALS__08E035F2");

                entity.ToTable("REVERSALS", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Amount).HasColumnName("AMOUNT");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Paymentid).HasColumnName("PAYMENTID");

                entity.Property(e => e.Serviceid).HasColumnName("SERVICEID");
            });

            modelBuilder.Entity<Rh>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RH", "dbo");

                entity.Property(e => e.Rhcode).HasColumnName("RHCODE");

                entity.Property(e => e.Rhtext)
                    .HasColumnName("RHTEXT")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Rooms>(entity =>
            {
                entity.HasKey(e => e.Roomid)
                    .HasName("PK__ROOMS__0EAE1DE1");

                entity.ToTable("ROOMS", "dbo");

                entity.Property(e => e.Roomid).HasColumnName("ROOMID");

                entity.Property(e => e.Locationid).HasColumnName("LOCATIONID");

                entity.Property(e => e.Roomname)
                    .HasColumnName("ROOMNAME")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.Rooms)
                    .HasForeignKey(d => d.Locationid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ROOMS__LOCATIONI__0FA2421A");
            });

            modelBuilder.Entity<Scriptitems>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__SCRIPTITEMS__3D9E16F4");

                entity.ToTable("SCRIPTITEMS", "dbo");

                entity.HasIndex(e => e.Scriptid)
                    .HasName("SCRIPTITEMS3");

                entity.HasIndex(e => new { e.Internalid, e.Productid, e.Scriptid })
                    .HasName("SCRIPTITEMS2");

                entity.HasIndex(e => new { e.Internalid, e.Scriptid, e.Productname })
                    .HasName("SCRIPTITEMS1");

                entity.HasIndex(e => new { e.Internalid, e.Productid, e.Recordid, e.Scriptid })
                    .HasName("SCRIPTITEMS4");

                entity.HasIndex(e => new { e.Productid, e.Internalid, e.Recordid, e.Scriptid })
                    .HasName("SCRIPTITEMS5");

                entity.HasIndex(e => new { e.Userid, e.Recordstatus, e.Packid, e.Productname, e.Productdescription, e.Companyform, e.Formcode, e.Strength, e.Dose, e.Frequency, e.Food, e.Otherdetail, e.Prn, e.Route, e.Instructions, e.Quantity, e.Productunit, e.Repeats, e.Repeatinterval, e.Regulation24, e.Sahcno, e.Authorityindication, e.Created, e.Createdby, e.Updated, e.Updatedby, e.Internalid, e.Productid, e.Recordid, e.Scriptid })
                    .HasName("SCRIPTITEMS6");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Authorityindication)
                    .HasColumnName("AUTHORITYINDICATION")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Companyform)
                    .HasColumnName("COMPANYFORM")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Dose)
                    .HasColumnName("DOSE")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Food).HasColumnName("FOOD");

                entity.Property(e => e.Formcode).HasColumnName("FORMCODE");

                entity.Property(e => e.Frequency).HasColumnName("FREQUENCY");

                entity.Property(e => e.HieStatus)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Instructions)
                    .HasColumnName("INSTRUCTIONS")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Internalid).HasColumnName("INTERNALID");

                entity.Property(e => e.Npdrconsent).HasColumnName("NPDRCONSENT");

                entity.Property(e => e.Otherdetail).HasColumnName("OTHERDETAIL");

                entity.Property(e => e.Packid).HasColumnName("PACKID");

                entity.Property(e => e.Patientconsent).HasColumnName("PATIENTCONSENT");

                entity.Property(e => e.Prn).HasColumnName("PRN");

                entity.Property(e => e.Productdescription)
                    .HasColumnName("PRODUCTDESCRIPTION")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Productid).HasColumnName("PRODUCTID");

                entity.Property(e => e.Productname)
                    .HasColumnName("PRODUCTNAME")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Productunit)
                    .HasColumnName("PRODUCTUNIT")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Quantity).HasColumnName("QUANTITY");

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Regulation24).HasColumnName("REGULATION24");

                entity.Property(e => e.Repeatinterval).HasColumnName("REPEATINTERVAL");

                entity.Property(e => e.Repeats).HasColumnName("REPEATS");

                entity.Property(e => e.Route).HasColumnName("ROUTE");

                entity.Property(e => e.Rppa).HasColumnName("RPPA");

                entity.Property(e => e.Sahcno)
                    .HasColumnName("SAHCNO")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Scid)
                    .HasColumnName("SCID")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Scidno).HasColumnName("SCIDNO");

                entity.Property(e => e.Scriptid).HasColumnName("SCRIPTID");

                entity.Property(e => e.Strength)
                    .HasColumnName("STRENGTH")
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.HasOne(d => d.Internal)
                    .WithMany(p => p.Scriptitems)
                    .HasForeignKey(d => d.Internalid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SCRIPTITE__INTER__481BA567");

                entity.HasOne(d => d.Script)
                    .WithMany(p => p.Scriptitems)
                    .HasForeignKey(d => d.Scriptid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SCRIPTITE__SCRIP__4A03EDD9");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Scriptitems)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SCRIPTITE__USERI__490FC9A0");
            });

            modelBuilder.Entity<Servicelogin>(entity =>
            {
                entity.HasKey(e => e.ServiceCode)
                    .HasName("PK__SERVICEL__A01D74C8D83FD776");

                entity.ToTable("SERVICELOGIN", "dbo");

                entity.Property(e => e.ServiceCode).ValueGeneratedNever();

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.OrganisationId)
                    .HasColumnName("OrganisationID")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Updated).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Servicenotes>(entity =>
            {
                entity.HasKey(e => e.Servicenoteid)
                    .HasName("PK__SERVICENOTES__5011CCEA");

                entity.ToTable("SERVICENOTES", "dbo");

                entity.Property(e => e.Servicenoteid).HasColumnName("SERVICENOTEID");

                entity.Property(e => e.Serviceid).HasColumnName("SERVICEID");

                entity.Property(e => e.Servicenote)
                    .HasColumnName("SERVICENOTE")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Services>(entity =>
            {
                entity.HasKey(e => e.Serviceid)
                    .HasName("PK__SERVICES__1CC7330E");

                entity.ToTable("SERVICES", "dbo");

                entity.HasIndex(e => e.Invoiceid)
                    .HasName("SERVICES2");

                entity.HasIndex(e => e.Servicedate)
                    .HasName("SERVICES1");

                entity.HasIndex(e => e.Servicestatus)
                    .HasName("SERVICES3");

                entity.HasIndex(e => new { e.Recordstatus, e.Invoiceid, e.Serviceid, e.Servicedate, e.Servicestatus })
                    .HasName("SERVICES_RS_INVID_SRVID_SD_SS");

                entity.HasIndex(e => new { e.Servicestatus, e.Servicedate, e.Recordstatus, e.Invoiceid, e.Serviceid })
                    .HasName("SERVICES_SS_SD_RS_INVID_SRVID");

                entity.Property(e => e.Serviceid).HasColumnName("SERVICEID");

                entity.Property(e => e.Adjustment).HasColumnName("ADJUSTMENT");

                entity.Property(e => e.Adjustmentlinkid).HasColumnName("ADJUSTMENTLINKID");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Detailid).HasColumnName("DETAILID");

                entity.Property(e => e.Fee).HasColumnName("FEE");

                entity.Property(e => e.Gap).HasColumnName("GAP");

                entity.Property(e => e.Gst).HasColumnName("GST");

                entity.Property(e => e.Inhospital).HasColumnName("INHOSPITAL");

                entity.Property(e => e.Invoiceid).HasColumnName("INVOICEID");

                entity.Property(e => e.Itemcode).HasColumnName("ITEMCODE");

                entity.Property(e => e.Itemid).HasColumnName("ITEMID");

                entity.Property(e => e.Linkid).HasColumnName("LINKID");

                entity.Property(e => e.Locationid).HasColumnName("LOCATIONID");

                entity.Property(e => e.Mbsitem).HasColumnName("MBSITEM");

                entity.Property(e => e.Mpo).HasColumnName("MPO");

                entity.Property(e => e.Nds).HasColumnName("NDS");

                entity.Property(e => e.Nnac).HasColumnName("NNAC");

                entity.Property(e => e.Originalservicefee).HasColumnName("ORIGINALSERVICEFEE");

                entity.Property(e => e.Paid).HasColumnName("PAID");

                entity.Property(e => e.Patients).HasColumnName("PATIENTS");

                entity.Property(e => e.Payercode).HasColumnName("PAYERCODE");

                entity.Property(e => e.Payerid).HasColumnName("PAYERID");

                entity.Property(e => e.Previoususerid).HasColumnName("PREVIOUSUSERID");

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Restrictionoverride)
                    .HasColumnName("RESTRICTIONOVERRIDE")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Selfdeemed).HasColumnName("SELFDEEMED");

                entity.Property(e => e.Servicedate)
                    .HasColumnName("SERVICEDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Servicelinkid).HasColumnName("SERVICELINKID");

                entity.Property(e => e.Servicestatus).HasColumnName("SERVICESTATUS");

                entity.Property(e => e.Servicetext)
                    .HasColumnName("SERVICETEXT")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Servicetype).HasColumnName("SERVICETYPE");

                entity.Property(e => e.Totalfee).HasColumnName("TOTALFEE");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.Property(e => e.Visitid).HasColumnName("VISITID");
            });

            modelBuilder.Entity<Sessions>(entity =>
            {
                entity.HasKey(e => e.Sessionid)
                    .HasName("PK__SESSIONS__6C23FBB3");

                entity.ToTable("SESSIONS", "dbo");

                entity.Property(e => e.Sessionid).HasColumnName("SESSIONID");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Cycledate)
                    .HasColumnName("CYCLEDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cycleweek).HasColumnName("CYCLEWEEK");

                entity.Property(e => e.Dayofweek).HasColumnName("DAYOFWEEK");

                entity.Property(e => e.Enddate)
                    .HasColumnName("ENDDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Endtime).HasColumnName("ENDTIME");

                entity.Property(e => e.Label)
                    .HasColumnName("LABEL")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Length).HasColumnName("LENGTH");

                entity.Property(e => e.Locationid).HasColumnName("LOCATIONID");

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Rgb).HasColumnName("RGB");

                entity.Property(e => e.Special).HasColumnName("SPECIAL");

                entity.Property(e => e.Startdate)
                    .HasColumnName("STARTDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Starttime).HasColumnName("STARTTIME");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.Property(e => e.Weeks).HasColumnName("WEEKS");
            });

            modelBuilder.Entity<Setting>(entity =>
            {
                entity.HasKey(e => new { e.SettingType, e.SettingKey, e.SettingName });

                entity.ToTable("SETTING", "dbo");

                entity.Property(e => e.SettingName).HasMaxLength(255);

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.SettingValue).IsRequired();

                entity.Property(e => e.Updated).HasColumnType("datetime");
            });

            modelBuilder.Entity<Severitycodes>(entity =>
            {
                entity.HasKey(e => e.Severitycode)
                    .HasName("PK__SEVERITYCODES__4AB81AF0");

                entity.ToTable("SEVERITYCODES", "dbo");

                entity.Property(e => e.Severitycode)
                    .HasColumnName("SEVERITYCODE")
                    .ValueGeneratedNever();

                entity.Property(e => e.Severity)
                    .IsRequired()
                    .HasColumnName("SEVERITY")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Sex>(entity =>
            {
                entity.HasKey(e => e.Sexcode)
                    .HasName("PK__SEX__4E88ABD4");

                entity.ToTable("SEX", "dbo");

                entity.Property(e => e.Sexcode)
                    .HasColumnName("SEXCODE")
                    .ValueGeneratedNever();

                entity.Property(e => e.Sex1)
                    .IsRequired()
                    .HasColumnName("SEX")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Sexuality>(entity =>
            {
                entity.HasKey(e => e.Sexualitycode)
                    .HasName("PK__SEXUALITY__5070F446");

                entity.ToTable("SEXUALITY", "dbo");

                entity.Property(e => e.Sexualitycode)
                    .HasColumnName("SEXUALITYCODE")
                    .ValueGeneratedNever();

                entity.Property(e => e.Sexualityname)
                    .IsRequired()
                    .HasColumnName("SEXUALITYNAME")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Smokingstatus>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SMOKINGSTATUS", "dbo");

                entity.Property(e => e.Smokingcode).HasColumnName("SMOKINGCODE");

                entity.Property(e => e.Smokingtext)
                    .HasColumnName("SMOKINGTEXT")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Smokingtype>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SMOKINGTYPE", "dbo");

                entity.Property(e => e.Smokingtypecode).HasColumnName("SMOKINGTYPECODE");

                entity.Property(e => e.Smokingtypetext)
                    .HasColumnName("SMOKINGTYPETEXT")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Smscreditcodes>(entity =>
            {
                entity.HasKey(e => e.Codeid);

                entity.ToTable("SMSCREDITCODES", "dbo");

                entity.Property(e => e.Codeid).HasColumnName("CODEID");

                entity.Property(e => e.Creditcode)
                    .HasColumnName("CREDITCODE")
                    .HasMaxLength(41)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Smsmessageid>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SMSMESSAGEID", "dbo");

                entity.Property(e => e.Messageid).HasColumnName("MESSAGEID");
            });

            modelBuilder.Entity<Smsmessages>(entity =>
            {
                entity.HasKey(e => e.Smsid);

                entity.ToTable("SMSMESSAGES", "dbo");

                entity.Property(e => e.Smsid).HasColumnName("SMSID");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Deliverystatus).HasColumnName("DELIVERYSTATUS");

                entity.Property(e => e.Messageid)
                    .IsRequired()
                    .HasColumnName("MESSAGEID")
                    .HasMaxLength(50);

                entity.Property(e => e.Mobile)
                    .HasColumnName("MOBILE")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Replytext)
                    .HasColumnName("REPLYTEXT")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.Requirestatus).HasColumnName("REQUIRESTATUS");

                entity.Property(e => e.Senttext)
                    .HasColumnName("SENTTEXT")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");
            });

            modelBuilder.Entity<Smsreplies>(entity =>
            {
                entity.HasKey(e => e.SmsreplyId);

                entity.ToTable("SMSReplies", "dbo");

                entity.Property(e => e.SmsreplyId).HasColumnName("SMSReplyID");

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.MessageId)
                    .IsRequired()
                    .HasColumnName("MessageID")
                    .HasMaxLength(50);

                entity.Property(e => e.ReceivedReply).HasColumnType("datetime");

                entity.Property(e => e.ReplyText)
                    .IsRequired()
                    .HasMaxLength(4000);

                entity.Property(e => e.SmsmessageId).HasColumnName("SMSMessageID");

                entity.Property(e => e.Updated).HasColumnType("datetime");

                entity.HasOne(d => d.Smsmessage)
                    .WithMany(p => p.Smsreplies)
                    .HasForeignKey(d => d.SmsmessageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SMSReplies_SMSMessages");
            });

            modelBuilder.Entity<SmsreplyKeywords>(entity =>
            {
                entity.HasKey(e => e.RecordId);

                entity.ToTable("SMSReplyKeywords", "dbo");

                entity.Property(e => e.RecordId).HasColumnName("RecordID");

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Keyword)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Updated).HasColumnType("datetime");
            });

            modelBuilder.Entity<SmsscheduleAppttype>(entity =>
            {
                entity.HasKey(e => e.Recordid);

                entity.ToTable("SMSSCHEDULE_APPTTYPE", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Appointmentcode).HasColumnName("APPOINTMENTCODE");

                entity.Property(e => e.Scheduleid).HasColumnName("SCHEDULEID");

                entity.HasOne(d => d.AppointmentcodeNavigation)
                    .WithMany(p => p.SmsscheduleAppttype)
                    .HasForeignKey(d => d.Appointmentcode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SMSSCHEDULE_APPTTYPE_SMSSCHEDULE_APPTTYPE");

                entity.HasOne(d => d.Schedule)
                    .WithMany(p => p.SmsscheduleAppttype)
                    .HasForeignKey(d => d.Scheduleid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SMSSCHEDULE_APPTTYPE_SMSSCHEDULES");
            });

            modelBuilder.Entity<SmsscheduleLocation>(entity =>
            {
                entity.HasKey(e => e.RecordId);

                entity.ToTable("SMSSCHEDULE_LOCATION", "dbo");

                entity.Property(e => e.RecordId).HasColumnName("RecordID");

                entity.Property(e => e.LocationId).HasColumnName("LocationID");

                entity.Property(e => e.ScheduleId).HasColumnName("ScheduleID");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.SmsscheduleLocation)
                    .HasForeignKey(d => d.LocationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SMSSCHEDULE_LOCATION_LOCATIONS");

                entity.HasOne(d => d.Schedule)
                    .WithMany(p => p.SmsscheduleLocation)
                    .HasForeignKey(d => d.ScheduleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SMSSCHEDULE_LOCATION_SMSSCHEDULE");
            });

            modelBuilder.Entity<SmsscheduleUser>(entity =>
            {
                entity.HasKey(e => e.Recordid);

                entity.ToTable("SMSSCHEDULE_USER", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Scheduleid).HasColumnName("SCHEDULEID");

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.HasOne(d => d.Schedule)
                    .WithMany(p => p.SmsscheduleUser)
                    .HasForeignKey(d => d.Scheduleid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SMSSCHEDULE_USER_SMSSCHEDULES");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.SmsscheduleUser)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SMSSCHEDULE_USER_USERS");
            });

            modelBuilder.Entity<Smsschedules>(entity =>
            {
                entity.HasKey(e => e.Scheduleid);

                entity.ToTable("SMSSCHEDULES", "dbo");

                entity.Property(e => e.Scheduleid).HasColumnName("SCHEDULEID");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Datespan)
                    .IsRequired()
                    .HasColumnName("DATESPAN")
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.Daysahead).HasColumnName("DAYSAHEAD");

                entity.Property(e => e.Excludealreadysent).HasColumnName("EXCLUDEALREADYSENT");

                entity.Property(e => e.Excluderecent).HasColumnName("EXCLUDERECENT");

                entity.Property(e => e.Excluderecentdays).HasColumnName("EXCLUDERECENTDAYS");

                entity.Property(e => e.Schedule)
                    .IsRequired()
                    .HasColumnName("SCHEDULE")
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.Scheduleday)
                    .HasColumnName("SCHEDULEDAY")
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.Schedulemonth)
                    .HasColumnName("SCHEDULEMONTH")
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.Schedulename)
                    .IsRequired()
                    .HasColumnName("SCHEDULENAME")
                    .HasMaxLength(50);

                entity.Property(e => e.Searchbytime).HasColumnName("SEARCHBYTIME");

                entity.Property(e => e.Searchtimeend).HasColumnName("SEARCHTIMEEND");

                entity.Property(e => e.Searchtimestart).HasColumnName("SEARCHTIMESTART");

                entity.Property(e => e.Sendapp).HasColumnName("SENDAPP");

                entity.Property(e => e.Sendsms).HasColumnName("SENDSMS");

                entity.Property(e => e.Sendtime).HasColumnName("SENDTIME");

                entity.Property(e => e.Templateid).HasColumnName("TEMPLATEID");
            });

            modelBuilder.Entity<Smstemplate>(entity =>
            {
                entity.HasKey(e => e.Templateid);

                entity.ToTable("SMSTEMPLATE", "dbo");

                entity.Property(e => e.Templateid).HasColumnName("TEMPLATEID");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Defaulttemplate).HasColumnName("DEFAULTTEMPLATE");

                entity.Property(e => e.Editable).HasColumnName("EDITABLE");

                entity.Property(e => e.Messagetext)
                    .IsRequired()
                    .HasColumnName("MESSAGETEXT")
                    .HasMaxLength(1500);

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Subject)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Templatename)
                    .IsRequired()
                    .HasColumnName("TEMPLATENAME")
                    .HasMaxLength(50);

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Usedfor).HasColumnName("USEDFOR");
            });

            modelBuilder.Entity<Smtpdetails>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__SMTPDETAILS__550B8C31");

                entity.ToTable("SMTPDETAILS", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Locationid).HasColumnName("LOCATIONID");

                entity.Property(e => e.Smtpserver)
                    .IsRequired()
                    .HasColumnName("SMTPSERVER")
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Smtpuserid)
                    .IsRequired()
                    .HasColumnName("SMTPUSERID")
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Smtpusername)
                    .IsRequired()
                    .HasColumnName("SMTPUSERNAME")
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Userid).HasColumnName("USERID");
            });

            modelBuilder.Entity<Sonicdetails>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__SONICDETAILS__1C281490");

                entity.ToTable("SONICDETAILS", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Eorder).HasColumnName("EORDER");

                entity.Property(e => e.Nata).HasColumnName("NATA");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");
            });

            modelBuilder.Entity<Sonicpath>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__SONICPATH__1FF8A574");

                entity.ToTable("SONICPATH", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Computer)
                    .HasColumnName("COMPUTER")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Filepath)
                    .HasColumnName("FILEPATH")
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.Nata).HasColumnName("NATA");

                entity.Property(e => e.Pathtype).HasColumnName("PATHTYPE");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");
            });

            modelBuilder.Entity<Sonicrequest>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__SONICREQUEST__64A2D57C");

                entity.ToTable("SONICREQUEST", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Barcode)
                    .HasColumnName("BARCODE")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Requestid).HasColumnName("REQUESTID");
            });

            modelBuilder.Entity<Sterilisation>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__STERILISATION__30992191");

                entity.ToTable("STERILISATION", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Batchnumber)
                    .IsRequired()
                    .HasColumnName("BATCHNUMBER")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Datesterilised)
                    .HasColumnName("DATESTERILISED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dateused)
                    .HasColumnName("DATEUSED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Internalid).HasColumnName("INTERNALID");

                entity.Property(e => e.Packtype)
                    .HasColumnName("PACKTYPE")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Userid).HasColumnName("USERID");
            });

            modelBuilder.Entity<Suid>(entity =>
            {
                entity.HasKey(e => e.Internalid)
                    .HasName("PK__SUID__781FBE44");

                entity.ToTable("SUID", "dbo");

                entity.Property(e => e.Internalid)
                    .HasColumnName("INTERNALID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Richrecord).HasColumnName("RICHRECORD");

                entity.Property(e => e.Suid1)
                    .HasColumnName("SUID")
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.Internal)
                    .WithOne(p => p.Suid)
                    .HasForeignKey<Suid>(d => d.Internalid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SUID__INTERNALID__7AFC2AEF");
            });

            modelBuilder.Entity<Templatefaves>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__TEMPLATEFAVES__60E75331");

                entity.ToTable("TEMPLATEFAVES", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Templateid).HasColumnName("TEMPLATEID");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.HasOne(d => d.Template)
                    .WithMany(p => p.Templatefaves)
                    .HasForeignKey(d => d.Templateid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TEMPLATEF__TEMPL__61DB776A");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Templatefaves)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TEMPLATEF__USERI__62CF9BA3");
            });

            modelBuilder.Entity<Terminalreasons>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TERMINALREASONS", "dbo");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.TerminationReasonCode)
                    .HasColumnName("TERMINATION_REASON_CODE")
                    .HasMaxLength(25);

                entity.Property(e => e.Terminationreason)
                    .HasColumnName("TERMINATIONREASON")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Testitems>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__TESTITEMS__0B129727");

                entity.ToTable("TESTITEMS", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Requestid).HasColumnName("REQUESTID");

                entity.Property(e => e.Testcode)
                    .HasColumnName("TESTCODE")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Testname)
                    .HasColumnName("TESTNAME")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.HasOne(d => d.Request)
                    .WithMany(p => p.Testitems)
                    .HasForeignKey(d => d.Requestid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TESTITEMS__REQUE__0CFADF99");
            });

            modelBuilder.Entity<Titles>(entity =>
            {
                entity.HasKey(e => e.Titlecode)
                    .HasName("PK__TITLES__5EBF139D");

                entity.ToTable("TITLES", "dbo");

                entity.Property(e => e.Titlecode)
                    .HasColumnName("TITLECODE")
                    .ValueGeneratedNever();

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("TITLE")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Tobacco>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__TOBACCO__7CD98669");

                entity.ToTable("TOBACCO", "dbo");

                entity.HasIndex(e => new { e.Recordstatus, e.Internalid })
                    .HasName("TOBACCO1");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Advice).HasColumnName("ADVICE");

                entity.Property(e => e.Cessation).HasColumnName("CESSATION");

                entity.Property(e => e.Comment)
                    .HasColumnName("COMMENT")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Internalid).HasColumnName("INTERNALID");

                entity.Property(e => e.Medication).HasColumnName("MEDICATION");

                entity.Property(e => e.Pastsmokesperday).HasColumnName("PASTSMOKESPERDAY");

                entity.Property(e => e.Pastsmokingcode).HasColumnName("PASTSMOKINGCODE");

                entity.Property(e => e.Paststarted).HasColumnName("PASTSTARTED");

                entity.Property(e => e.Paststopped).HasColumnName("PASTSTOPPED");

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Referral).HasColumnName("REFERRAL");

                entity.Property(e => e.Smokesperday).HasColumnName("SMOKESPERDAY");

                entity.Property(e => e.Smokingcode).HasColumnName("SMOKINGCODE");

                entity.Property(e => e.Smokingtype).HasColumnName("SMOKINGTYPE");

                entity.Property(e => e.Support).HasColumnName("SUPPORT");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Yearstarted).HasColumnName("YEARSTARTED");

                entity.HasOne(d => d.Internal)
                    .WithMany(p => p.Tobacco)
                    .HasForeignKey(d => d.Internalid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TOBACCO__INTERNA__0662F0A3");
            });

            modelBuilder.Entity<Todolist>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__TODOLIST__3D690CCA");

                entity.ToTable("TODOLIST", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Duedate)
                    .HasColumnName("DUEDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Entrydate)
                    .HasColumnName("ENTRYDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Internalid).HasColumnName("INTERNALID");

                entity.Property(e => e.Previoususerid).HasColumnName("PREVIOUSUSERID");

                entity.Property(e => e.Priority).HasColumnName("PRIORITY");

                entity.Property(e => e.Subject)
                    .HasColumnName("SUBJECT")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Todostatus).HasColumnName("TODOSTATUS");

                entity.Property(e => e.Todotype).HasColumnName("TODOTYPE");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Todolist)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TODOLIST__USERID__4321E620");
            });

            modelBuilder.Entity<Transactions>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.ToTable("Transactions", "dbo");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Payload).IsRequired();

                entity.Property(e => e.Updated).HasColumnType("datetime");

                entity.HasOne(d => d.Payment)
                    .WithMany(p => p.Transactions)
                    .HasForeignKey(d => d.PaymentId)
                    .HasConstraintName("FK_Transactions_PAYMENTS");
            });

            modelBuilder.Entity<Transidentity>(entity =>
            {
                entity.HasKey(e => e.Recipientid)
                    .HasName("PK__TRANSIDENTITY__75E27017");

                entity.ToTable("TRANSIDENTITY", "dbo");

                entity.Property(e => e.Recipientid).HasColumnName("RECIPIENTID");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Recipientname)
                    .IsRequired()
                    .HasColumnName("RECIPIENTNAME")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("TYPE")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasColumnName("VALUE")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Transidentity)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TRANSIDEN__UPDAT__76D69450");
            });

            modelBuilder.Entity<Transmissions>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__TRANSMISSIONS__78BEDCC2");

                entity.ToTable("TRANSMISSIONS", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Ackcode).HasColumnName("ACKCODE");

                entity.Property(e => e.Ackdate)
                    .HasColumnName("ACKDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Content)
                    .HasColumnName("CONTENT")
                    .HasColumnType("text");

                entity.Property(e => e.Controlid)
                    .HasColumnName("CONTROLID")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Displaycode).HasColumnName("DISPLAYCODE");

                entity.Property(e => e.Internalid).HasColumnName("INTERNALID");

                entity.Property(e => e.Recipientid).HasColumnName("RECIPIENTID");

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Response)
                    .HasColumnName("RESPONSE")
                    .HasColumnType("text");

                entity.Property(e => e.Storeddate)
                    .HasColumnName("STOREDDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Transmitdate)
                    .HasColumnName("TRANSMITDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.HasOne(d => d.Internal)
                    .WithMany(p => p.Transmissions)
                    .HasForeignKey(d => d.Internalid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TRANSMISS__UPDAT__7C8F6DA6");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Transmissions)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TRANSMISS__USERI__7D8391DF");
            });

            modelBuilder.Entity<Tyroeftpayments>(entity =>
            {
                entity.HasKey(e => e.Recordid);

                entity.ToTable("TYROEFTPAYMENTS", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Paymentpartserviceid).HasColumnName("PAYMENTPARTSERVICEID");

                entity.Property(e => e.Serviceid).HasColumnName("SERVICEID");

                entity.Property(e => e.Tyroeftid).HasColumnName("TYROEFTID");

                entity.HasOne(d => d.Tyroeft)
                    .WithMany(p => p.Tyroeftpayments)
                    .HasForeignKey(d => d.Tyroeftid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TYROEFTPAYMENTS_TYROEFTTRANSACTIONS");
            });

            modelBuilder.Entity<Tyroefttransactions>(entity =>
            {
                entity.HasKey(e => e.Recordid);

                entity.ToTable("TYROEFTTRANSACTIONS", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Authno)
                    .IsRequired()
                    .HasColumnName("AUTHNO")
                    .HasMaxLength(50);

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Mid).HasColumnName("MID");

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Tid).HasColumnName("TID");

                entity.Property(e => e.Transactiondate)
                    .HasColumnName("TRANSACTIONDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Transactionerror)
                    .HasColumnName("TRANSACTIONERROR")
                    .HasMaxLength(500);

                entity.Property(e => e.Transactionref)
                    .IsRequired()
                    .HasColumnName("TRANSACTIONREF")
                    .HasMaxLength(10);

                entity.Property(e => e.Transactionresult)
                    .IsRequired()
                    .HasColumnName("TRANSACTIONRESULT")
                    .HasMaxLength(15);

                entity.Property(e => e.Transactionstatus)
                    .IsRequired()
                    .HasColumnName("TRANSACTIONSTATUS")
                    .HasMaxLength(15);

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");
            });

            modelBuilder.Entity<Udfnames>(entity =>
            {
                entity.HasKey(e => e.Udfid)
                    .HasName("PK__UDFNAMES__6A1BB7B0");

                entity.ToTable("UDFNAMES", "dbo");

                entity.Property(e => e.Udfid).HasColumnName("UDFID");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Udflength).HasColumnName("UDFLENGTH");

                entity.Property(e => e.Udfname)
                    .IsRequired()
                    .HasColumnName("UDFNAME")
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Udftype).HasColumnName("UDFTYPE");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");
            });

            modelBuilder.Entity<Udfvalues>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__UDFVALUES__6CF8245B");

                entity.ToTable("UDFVALUES", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Internalid).HasColumnName("INTERNALID");

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Udfid).HasColumnName("UDFID");

                entity.Property(e => e.Udfvalue)
                    .IsRequired()
                    .HasColumnName("UDFVALUE")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.HasOne(d => d.Internal)
                    .WithMany(p => p.Udfvalues)
                    .HasForeignKey(d => d.Internalid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__UDFVALUES__INTER__6EE06CCD");

                entity.HasOne(d => d.Udf)
                    .WithMany(p => p.Udfvalues)
                    .HasForeignKey(d => d.Udfid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__UDFVALUES__UDFID__6FD49106");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Udfvalues)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__UDFVALUES__USERI__70C8B53F");
            });

            modelBuilder.Entity<Uhganswer>(entity =>
            {
                entity.HasKey(e => e.Answerid)
                    .HasName("PK_UHGANSWER_1");

                entity.ToTable("UHGANSWER", "dbo");

                entity.Property(e => e.Answerid).HasColumnName("ANSWERID");

                entity.Property(e => e.Answer)
                    .IsRequired()
                    .HasColumnName("ANSWER")
                    .HasMaxLength(600);

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Questionid).HasColumnName("QUESTIONID");

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Reportid).HasColumnName("REPORTID");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.Uhganswer)
                    .HasForeignKey(d => d.Questionid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UHGANSWER_UHGQUESTION");

                entity.HasOne(d => d.Report)
                    .WithMany(p => p.Uhganswer)
                    .HasForeignKey(d => d.Reportid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UHGANSWER_UHGREPORT");
            });

            modelBuilder.Entity<Uhgquestion>(entity =>
            {
                entity.HasKey(e => e.Questionid);

                entity.ToTable("UHGQUESTION", "dbo");

                entity.Property(e => e.Questionid).HasColumnName("QUESTIONID");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Questiontext)
                    .IsRequired()
                    .HasColumnName("QUESTIONTEXT")
                    .HasMaxLength(1000);

                entity.Property(e => e.Uhgquestionid).HasColumnName("UHGQUESTIONID");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");
            });

            modelBuilder.Entity<Uhgreanswer>(entity =>
            {
                entity.ToTable("UHGREANSWER", "dbo");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Answer).HasColumnName("ANSWER");

                entity.Property(e => e.Reportid).HasColumnName("REPORTID");

                entity.HasOne(d => d.Report)
                    .WithMany(p => p.Uhgreanswer)
                    .HasForeignKey(d => d.Reportid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UHGREANSWER_UHGREPORT");
            });

            modelBuilder.Entity<Uhgreport>(entity =>
            {
                entity.HasKey(e => e.Reportid);

                entity.ToTable("UHGREPORT", "dbo");

                entity.Property(e => e.Reportid).HasColumnName("REPORTID");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Dateimported)
                    .HasColumnName("DATEIMPORTED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datesubmitted)
                    .HasColumnName("DATESUBMITTED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Incomingreportid).HasColumnName("INCOMINGREPORTID");

                entity.Property(e => e.Internalid).HasColumnName("INTERNALID");

                entity.Property(e => e.Previoususerid).HasColumnName("PREVIOUSUSERID");

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Reportfile)
                    .IsRequired()
                    .HasColumnName("REPORTFILE")
                    .HasColumnType("ntext");

                entity.Property(e => e.Status).HasColumnName("STATUS");

                entity.Property(e => e.Uhgid).HasColumnName("UHGID");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby)
                    .HasColumnName("UPDATEDBY")
                    .HasColumnType("datetime");

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.HasOne(d => d.Internal)
                    .WithMany(p => p.Uhgreport)
                    .HasForeignKey(d => d.Internalid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UHGREPORT_PATIENTS");
            });

            modelBuilder.Entity<Uhgreportsquestions>(entity =>
            {
                entity.HasKey(e => e.Reportquestionid);

                entity.ToTable("UHGREPORTSQUESTIONS", "dbo");

                entity.Property(e => e.Reportquestionid).HasColumnName("REPORTQUESTIONID");

                entity.Property(e => e.Questionid).HasColumnName("QUESTIONID");

                entity.Property(e => e.Reportid).HasColumnName("REPORTID");

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.Uhgreportsquestions)
                    .HasForeignKey(d => d.Questionid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UHGREPORTSQUESTIONS_UHGQUESTION");

                entity.HasOne(d => d.Report)
                    .WithMany(p => p.Uhgreportsquestions)
                    .HasForeignKey(d => d.Reportid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UHGREPORTSQUESTIONS_UHGREPORT");
            });

            modelBuilder.Entity<Uhgselectedinformation>(entity =>
            {
                entity.ToTable("UHGSELECTEDINFORMATION", "dbo");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Reportid).HasColumnName("REPORTID");

                entity.Property(e => e.Type).HasColumnName("TYPE");

                entity.HasOne(d => d.Report)
                    .WithMany(p => p.Uhgselectedinformation)
                    .HasForeignKey(d => d.Reportid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UHGSELECTEDINFORMATION_UHGREPORT");
            });

            modelBuilder.Entity<Unsentclaims>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__UNSENTCLAIMS__799DF262");

                entity.ToTable("UNSENTCLAIMS", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Eft).HasColumnName("EFT");

                entity.Property(e => e.Failedtransmission).HasColumnName("FAILEDTRANSMISSION");

                entity.Property(e => e.Internalid).HasColumnName("INTERNALID");

                entity.Property(e => e.Invoiceid).HasColumnName("INVOICEID");

                entity.Property(e => e.Paymentid).HasColumnName("PAYMENTID");

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Usebpaddress).HasColumnName("USEBPADDRESS");

                entity.Property(e => e.Userid).HasColumnName("USERID");
            });

            modelBuilder.Entity<Urine>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("URINE", "dbo");

                entity.Property(e => e.Urinecode).HasColumnName("URINECODE");

                entity.Property(e => e.Urinetext)
                    .HasColumnName("URINETEXT")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<UserNumbers>(entity =>
            {
                entity.HasKey(e => e.RecordId)
                    .HasName("PK__UserNumb__FBDF78C9D9834324");

                entity.ToTable("UserNumbers", "dbo");

                entity.Property(e => e.RecordId).HasColumnName("RecordID");

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.NumberValue)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Updated).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserNumbers)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__UserNumbe__UserI__1EFA5F9A");
            });

            modelBuilder.Entity<UserReportLocations>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("UserReportLocations", "dbo");

                entity.Property(e => e.LocationId).HasColumnName("LocationID");

                entity.Property(e => e.ReportId).HasColumnName("ReportID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.UserReportLocations)
                    .HasForeignKey(d => d.LocationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__UserRepor__Locat__6D78129F");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserReportLocations)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__UserRepor__UserI__6C83EE66");
            });

            modelBuilder.Entity<Useralias>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__USERALIAS__546180BB");

                entity.ToTable("USERALIAS", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Aliasname)
                    .HasColumnName("ALIASNAME")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Locationid).HasColumnName("LOCATIONID");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Useralias)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__USERALIAS__USERI__5555A4F4");
            });

            modelBuilder.Entity<Userdisplay>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("USERDISPLAY", "dbo");

                entity.Property(e => e.Displayid).HasColumnName("DISPLAYID");

                entity.Property(e => e.Userid).HasColumnName("USERID");
            });

            modelBuilder.Entity<Usergroups>(entity =>
            {
                entity.HasKey(e => e.Groupcode)
                    .HasName("PK__USERGROUPS__45BE5BA9");

                entity.ToTable("USERGROUPS", "dbo");

                entity.Property(e => e.Groupcode)
                    .HasColumnName("GROUPCODE")
                    .ValueGeneratedNever();

                entity.Property(e => e.Au).HasColumnName("AU");

                entity.Property(e => e.Groupname)
                    .IsRequired()
                    .HasColumnName("GROUPNAME")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Nz).HasColumnName("NZ");
            });

            modelBuilder.Entity<Userpermissions>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__USERPERMISSIONS__6EC0713C");

                entity.ToTable("USERPERMISSIONS", "dbo");

                entity.HasIndex(e => new { e.Recordid, e.Recordstatus, e.Permissionlevel, e.Created, e.Createdby, e.Updated, e.Updatedby, e.Userid, e.Permissioncode })
                    .HasName("USERPERMISSIONS1");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Permissioncode).HasColumnName("PERMISSIONCODE");

                entity.Property(e => e.Permissionlevel).HasColumnName("PERMISSIONLEVEL");

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Userpermissions)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__USERPERMI__USERI__73852659");
            });

            modelBuilder.Entity<Userpreferences>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__USERPREFERENCES__756D6ECB");

                entity.ToTable("USERPREFERENCES", "dbo");

                entity.HasIndex(e => new { e.Recordid, e.Recordstatus, e.Preferencename, e.Preferencevalue, e.Preferencetextvalue, e.Created, e.Createdby, e.Updated, e.Updatedby, e.Userid })
                    .HasName("USERPREFERENCES1");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Preferencename)
                    .IsRequired()
                    .HasColumnName("PREFERENCENAME")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Preferencetextvalue)
                    .HasColumnName("PREFERENCETEXTVALUE")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Preferencevalue).HasColumnName("PREFERENCEVALUE");

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Userpreferences)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__USERPREFE__USERI__793DFFAF");
            });

            modelBuilder.Entity<Userprocedures>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__USERPROCEDURES__2F3AE904");

                entity.ToTable("USERPROCEDURES", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Mbsitem).HasColumnName("MBSITEM");

                entity.Property(e => e.Procedurename)
                    .HasColumnName("PROCEDURENAME")
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Userid).HasColumnName("USERID");
            });

            modelBuilder.Entity<Userqualifications>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__USERQUALIFICATIO__69FBBC1F");

                entity.ToTable("USERQUALIFICATIONS", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Qualification)
                    .IsRequired()
                    .HasColumnName("QUALIFICATION")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Userqualifications)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__USERQUALI__USERI__6CD828CA");
            });

            modelBuilder.Entity<Userreports>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__USERREPORTS__0BF1ACC7");

                entity.ToTable("USERREPORTS", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.ReportId).HasColumnName("ReportID");

                entity.Property(e => e.Reportname)
                    .HasColumnName("REPORTNAME")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SavedEndDate).HasColumnType("datetime");

                entity.Property(e => e.SavedStartDate).HasColumnType("datetime");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Userreports)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__USERREPOR__USERI__0ECE1972");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.Userid)
                    .HasName("PK__USERS__55009F39");

                entity.ToTable("USERS", "dbo");

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.Property(e => e.Abn)
                    .HasColumnName("ABN")
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Accounts).HasColumnName("ACCOUNTS");

                entity.Property(e => e.Accpayeenumber)
                    .HasColumnName("ACCPAYEENUMBER")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Appointments).HasColumnName("APPOINTMENTS");

                entity.Property(e => e.Companyname)
                    .HasColumnName("COMPANYNAME")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Confidentialnotes).HasColumnName("CONFIDENTIALNOTES");

                entity.Property(e => e.Cpdno)
                    .HasColumnName("CPDNO")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Defaultaccount).HasColumnName("DEFAULTACCOUNT");

                entity.Property(e => e.Defaultitem)
                    .HasColumnName("DEFAULTITEM")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Email)
                    .HasColumnName("EMAIL")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Erxid)
                    .HasColumnName("ERXID")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Fax)
                    .HasColumnName("FAX")
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Firstname)
                    .IsRequired()
                    .HasColumnName("FIRSTNAME")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Gmspayeenumber)
                    .HasColumnName("GMSPAYEENUMBER")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Groupcode).HasColumnName("GROUPCODE");

                entity.Property(e => e.Homephone)
                    .HasColumnName("HOMEPHONE")
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Hpii)
                    .HasColumnName("HPII")
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Hpiivalidated)
                    .HasColumnName("HPIIVALIDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Inactivedate)
                    .HasColumnName("INACTIVEDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Lmo).HasColumnName("LMO");

                entity.Property(e => e.Locationid).HasColumnName("LOCATIONID");

                entity.Property(e => e.Medrefertoken)
                    .HasColumnName("MEDREFERTOKEN")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Mobilephone)
                    .HasColumnName("MOBILEPHONE")
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Needsreferral).HasColumnName("NEEDSREFERRAL");

                entity.Property(e => e.Nzmcnumber)
                    .HasColumnName("NZMCNUMBER")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Operations).HasColumnName("OPERATIONS");

                entity.Property(e => e.Pager)
                    .HasColumnName("PAGER")
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("PASSWORD")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Phone)
                    .HasColumnName("PHONE")
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Pkikey)
                    .HasColumnName("PKIKEY")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Prescriberno)
                    .HasColumnName("PRESCRIBERNO")
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Providerno)
                    .HasColumnName("PROVIDERNO")
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Registrationno)
                    .HasColumnName("REGISTRATIONNO")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Rei).HasColumnName("REI");

                entity.Property(e => e.Sendhel).HasColumnName("SENDHEL");

                entity.Property(e => e.Surname)
                    .IsRequired()
                    .HasColumnName("SURNAME")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Teddss).HasColumnName("TEDDSS");

                entity.Property(e => e.Thumbprint)
                    .HasColumnName("THUMBPRINT")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Titlecode).HasColumnName("TITLECODE");

                entity.Property(e => e.Toppocket).HasColumnName("TOPPOCKET");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Userstatus).HasColumnName("USERSTATUS");

                entity.Property(e => e.Vr).HasColumnName("VR");

                entity.HasOne(d => d.GroupcodeNavigation)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.Groupcode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__USERS__GROUPCODE__681373AD");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.Locationid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__USERS__LOCATIONI__671F4F74");

                entity.HasOne(d => d.TitlecodeNavigation)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.Titlecode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__USERS__TITLECODE__662B2B3B");
            });

            modelBuilder.Entity<Vaccinebatch>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__VACCINEBATCH__6B44E613");

                entity.ToTable("VACCINEBATCH", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Batchnumber)
                    .HasColumnName("BATCHNUMBER")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Expirydate)
                    .HasColumnName("EXPIRYDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Vaccineid).HasColumnName("VACCINEID");
            });

            modelBuilder.Entity<Vipdata>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__VIPDATA__84D4D4F5CFC86C0F");

                entity.ToTable("VIPDATA", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Fieldid).HasColumnName("FIELDID");

                entity.Property(e => e.Fieldvalue)
                    .IsRequired()
                    .HasColumnName("FIELDVALUE")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Internalid).HasColumnName("INTERNALID");

                entity.Property(e => e.Recorded)
                    .HasColumnName("RECORDED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.HasOne(d => d.Field)
                    .WithMany(p => p.Vipdata)
                    .HasForeignKey(d => d.Fieldid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__VIPDATA__FIELDID__703F70B1");

                entity.HasOne(d => d.Internal)
                    .WithMany(p => p.Vipdata)
                    .HasForeignKey(d => d.Internalid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__VIPDATA__INTERNA__713394EA");
            });

            modelBuilder.Entity<Vipfields>(entity =>
            {
                entity.HasKey(e => e.Fieldid)
                    .HasName("PK__VIPFIELD__7072680216202AC4");

                entity.ToTable("VIPFIELDS", "dbo");

                entity.Property(e => e.Fieldid).HasColumnName("FIELDID");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Fieldname)
                    .IsRequired()
                    .HasColumnName("FIELDNAME")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");
            });

            modelBuilder.Entity<Visitexamination>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__VISITEXAMINATION__4885B9BB");

                entity.ToTable("VISITEXAMINATION", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Internalid).HasColumnName("INTERNALID");

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Visitcode).HasColumnName("VISITCODE");

                entity.Property(e => e.Visitid).HasColumnName("VISITID");

                entity.Property(e => e.Visitvalue)
                    .HasColumnName("VISITVALUE")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.Internal)
                    .WithMany(p => p.Visitexamination)
                    .HasForeignKey(d => d.Internalid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__VISITEXAM__INTER__4A6E022D");

                entity.HasOne(d => d.Visit)
                    .WithMany(p => p.Visitexamination)
                    .HasForeignKey(d => d.Visitid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__VISITEXAM__VISIT__4B622666");
            });

            modelBuilder.Entity<Visithistory>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__VISITHISTORY__43C1049E");

                entity.ToTable("VISITHISTORY", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Internalid).HasColumnName("INTERNALID");

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Visitcode).HasColumnName("VISITCODE");

                entity.Property(e => e.Visitid).HasColumnName("VISITID");

                entity.Property(e => e.Visitvalue)
                    .HasColumnName("VISITVALUE")
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.Internal)
                    .WithMany(p => p.Visithistory)
                    .HasForeignKey(d => d.Internalid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__VISITHIST__INTER__45A94D10");

                entity.HasOne(d => d.Visit)
                    .WithMany(p => p.Visithistory)
                    .HasForeignKey(d => d.Visitid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__VISITHIST__VISIT__469D7149");
            });

            modelBuilder.Entity<Visitjoint>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__VISITJOINT__642DD430");

                entity.ToTable("VISITJOINT", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Crepitus).HasColumnName("CREPITUS");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Effusion).HasColumnName("EFFUSION");

                entity.Property(e => e.Extension).HasColumnName("EXTENSION");

                entity.Property(e => e.Extrotation).HasColumnName("EXTROTATION");

                entity.Property(e => e.Flexion).HasColumnName("FLEXION");

                entity.Property(e => e.Heat).HasColumnName("HEAT");

                entity.Property(e => e.Internalid).HasColumnName("INTERNALID");

                entity.Property(e => e.Introtation).HasColumnName("INTROTATION");

                entity.Property(e => e.Joint).HasColumnName("JOINT");

                entity.Property(e => e.Llatflexion).HasColumnName("LLATFLEXION");

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Redness).HasColumnName("REDNESS");

                entity.Property(e => e.Rlatflexion).HasColumnName("RLATFLEXION");

                entity.Property(e => e.Side).HasColumnName("SIDE");

                entity.Property(e => e.Stability).HasColumnName("STABILITY");

                entity.Property(e => e.Stiffness).HasColumnName("STIFFNESS");

                entity.Property(e => e.Tenderness).HasColumnName("TENDERNESS");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Visitid).HasColumnName("VISITID");

                entity.HasOne(d => d.Internal)
                    .WithMany(p => p.Visitjoint)
                    .HasForeignKey(d => d.Internalid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__VISITJOIN__INTER__74643BF9");

                entity.HasOne(d => d.Visit)
                    .WithMany(p => p.Visitjoint)
                    .HasForeignKey(d => d.Visitid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__VISITJOIN__VISIT__75586032");
            });

            modelBuilder.Entity<Visitlesion>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__VISITLESION__4D4A6ED8");

                entity.ToTable("VISITLESION", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Colour).HasColumnName("COLOUR");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Internalid).HasColumnName("INTERNALID");

                entity.Property(e => e.Length).HasColumnName("LENGTH");

                entity.Property(e => e.Location).HasColumnName("LOCATION");

                entity.Property(e => e.Nature).HasColumnName("NATURE");

                entity.Property(e => e.Raised).HasColumnName("RAISED");

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Side).HasColumnName("SIDE");

                entity.Property(e => e.Ulcerated).HasColumnName("ULCERATED");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Visitid).HasColumnName("VISITID");

                entity.Property(e => e.Width).HasColumnName("WIDTH");

                entity.HasOne(d => d.Internal)
                    .WithMany(p => p.Visitlesion)
                    .HasForeignKey(d => d.Internalid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__VISITLESI__INTER__56D3D912");

                entity.HasOne(d => d.Visit)
                    .WithMany(p => p.Visitlesion)
                    .HasForeignKey(d => d.Visitid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__VISITLESI__VISIT__57C7FD4B");
            });

            modelBuilder.Entity<Visitlock>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__VISITLOCK__049AA3C2");

                entity.ToTable("VISITLOCK", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Computer)
                    .HasColumnName("COMPUTER")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.Property(e => e.Visitid).HasColumnName("VISITID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Visitlock)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__VISITLOCK__USERI__058EC7FB");

                entity.HasOne(d => d.Visit)
                    .WithMany(p => p.Visitlock)
                    .HasForeignKey(d => d.Visitid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__VISITLOCK__VISIT__0682EC34");
            });

            modelBuilder.Entity<Visitlump>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__VISITLUMP__59B045BD");

                entity.ToTable("VISITLUMP", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Internalid).HasColumnName("INTERNALID");

                entity.Property(e => e.Length).HasColumnName("LENGTH");

                entity.Property(e => e.Location).HasColumnName("LOCATION");

                entity.Property(e => e.Mobility).HasColumnName("MOBILITY");

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Side).HasColumnName("SIDE");

                entity.Property(e => e.Texture).HasColumnName("TEXTURE");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Visitid).HasColumnName("VISITID");

                entity.Property(e => e.Width).HasColumnName("WIDTH");

                entity.HasOne(d => d.Internal)
                    .WithMany(p => p.Visitlump)
                    .HasForeignKey(d => d.Internalid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__VISITLUMP__INTER__61516785");

                entity.HasOne(d => d.Visit)
                    .WithMany(p => p.Visitlump)
                    .HasForeignKey(d => d.Visitid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__VISITLUMP__VISIT__62458BBE");
            });

            modelBuilder.Entity<Visitmbs>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__VISITMBS__7FD5EEA5");

                entity.ToTable("VISITMBS", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Internalid).HasColumnName("INTERNALID");

                entity.Property(e => e.Itemcode)
                    .HasColumnName("ITEMCODE")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Visitid).HasColumnName("VISITID");

                entity.HasOne(d => d.Internal)
                    .WithMany(p => p.Visitmbs)
                    .HasForeignKey(d => d.Internalid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__VISITMBS__INTERN__01BE3717");

                entity.HasOne(d => d.Visit)
                    .WithMany(p => p.Visitmbs)
                    .HasForeignKey(d => d.Visitid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__VISITMBS__VISITI__02B25B50");
            });

            modelBuilder.Entity<Visitparameters>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__VISITPARAMETERS__7740A8A4");

                entity.ToTable("VISITPARAMETERS", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Internalid).HasColumnName("INTERNALID");

                entity.Property(e => e.Parameterid).HasColumnName("PARAMETERID");

                entity.Property(e => e.Parametervalue).HasColumnName("PARAMETERVALUE");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Visitid).HasColumnName("VISITID");

                entity.HasOne(d => d.Internal)
                    .WithMany(p => p.Visitparameters)
                    .HasForeignKey(d => d.Internalid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__VISITPARA__INTER__7928F116");

                entity.HasOne(d => d.Visit)
                    .WithMany(p => p.Visitparameters)
                    .HasForeignKey(d => d.Visitid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__VISITPARA__VISIT__7A1D154F");
            });

            modelBuilder.Entity<Visitreason>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__VISITREASON__3EFC4F81");

                entity.ToTable("VISITREASON", "dbo");

                entity.HasIndex(e => new { e.Visitid, e.Recordstatus })
                    .HasName("VISITREASON1");

                entity.HasIndex(e => new { e.Recordstatus, e.Internalid, e.Visitid, e.Reason })
                    .HasName("VISITREASON2");

                entity.HasIndex(e => new { e.Reasoncode, e.Created, e.Createdby, e.Updated, e.Updatedby, e.Recordstatus, e.Internalid, e.Recordid, e.Visitid, e.Reason })
                    .HasName("VISITREASON3");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Acutecode).HasColumnName("ACUTECODE");

                entity.Property(e => e.Comminuted).HasColumnName("COMMINUTED");

                entity.Property(e => e.Compound).HasColumnName("COMPOUND");

                entity.Property(e => e.Condition)
                    .HasColumnName("CONDITION")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Descriptioncode).HasColumnName("DESCRIPTIONCODE");

                entity.Property(e => e.Displaced).HasColumnName("DISPLACED");

                entity.Property(e => e.Fracture).HasColumnName("FRACTURE");

                entity.Property(e => e.Greenstick).HasColumnName("GREENSTICK");

                entity.Property(e => e.Internalid).HasColumnName("INTERNALID");

                entity.Property(e => e.Locationcode).HasColumnName("LOCATIONCODE");

                entity.Property(e => e.Positioncode).HasColumnName("POSITIONCODE");

                entity.Property(e => e.Reason)
                    .HasColumnName("REASON")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Reasoncode)
                    .HasColumnName("REASONCODE")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Severitycode).HasColumnName("SEVERITYCODE");

                entity.Property(e => e.Spiral).HasColumnName("SPIRAL");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Visitid).HasColumnName("VISITID");

                entity.HasOne(d => d.Internal)
                    .WithMany(p => p.Visitreason)
                    .HasForeignKey(d => d.Internalid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__VISITREAS__INTER__40E497F3");

                entity.HasOne(d => d.Visit)
                    .WithMany(p => p.Visitreason)
                    .HasForeignKey(d => d.Visitid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__VISITREAS__VISIT__41D8BC2C");
            });

            modelBuilder.Entity<Visits>(entity =>
            {
                entity.HasKey(e => e.Visitid)
                    .HasName("PK__VISITS__347EC10E");

                entity.ToTable("VISITS", "dbo");

                entity.HasIndex(e => e.Internalid)
                    .HasName("VISITS2");

                entity.HasIndex(e => e.Visitdate)
                    .HasName("VISITS1");

                entity.HasIndex(e => new { e.Internalid, e.Recordstatus, e.Userid, e.Visitid, e.Visitdate, e.Starttime })
                    .HasName("VISITS3");

                entity.HasIndex(e => new { e.Visitcode, e.Drname, e.Recordeddate, e.Endtime, e.Duration, e.Reviewdate, e.Confidential, e.Internalid, e.Recordstatus, e.Userid, e.Visitid, e.Visitdate, e.Starttime })
                    .HasName("VISITS4");

                entity.Property(e => e.Visitid).HasColumnName("VISITID");

                entity.Property(e => e.Confidential).HasColumnName("CONFIDENTIAL");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Drname)
                    .HasColumnName("DRNAME")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Duration).HasColumnName("DURATION");

                entity.Property(e => e.Endtime).HasColumnName("ENDTIME");

                entity.Property(e => e.Exam)
                    .HasColumnName("EXAM")
                    .HasColumnType("text");

                entity.Property(e => e.History)
                    .HasColumnName("HISTORY")
                    .HasColumnType("text");

                entity.Property(e => e.Internalid).HasColumnName("INTERNALID");

                entity.Property(e => e.Location).HasColumnName("LOCATION");

                entity.Property(e => e.Previoususerid).HasColumnName("PREVIOUSUSERID");

                entity.Property(e => e.Recordeddate)
                    .HasColumnName("RECORDEDDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Reviewdate)
                    .HasColumnName("REVIEWDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Starttime).HasColumnName("STARTTIME");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.Property(e => e.Visitcode).HasColumnName("VISITCODE");

                entity.Property(e => e.Visitdate)
                    .HasColumnName("VISITDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Visitnotes)
                    .HasColumnName("VISITNOTES")
                    .HasColumnType("text");

                entity.HasOne(d => d.Internal)
                    .WithMany(p => p.Visits)
                    .HasForeignKey(d => d.Internalid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__VISITS__INTERNAL__3B2BBE9D");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Visits)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__VISITS__USERID__3D14070F");

                entity.HasOne(d => d.VisitcodeNavigation)
                    .WithMany(p => p.Visits)
                    .HasForeignKey(d => d.Visitcode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__VISITS__VISITCOD__3C1FE2D6");
            });

            modelBuilder.Entity<Visittext>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__VISITTEXT__7C055DC1");

                entity.ToTable("VISITTEXT", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Internalid).HasColumnName("INTERNALID");

                entity.Property(e => e.Parameterid).HasColumnName("PARAMETERID");

                entity.Property(e => e.Parametervalue)
                    .IsRequired()
                    .HasColumnName("PARAMETERVALUE")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Visitid).HasColumnName("VISITID");

                entity.HasOne(d => d.Internal)
                    .WithMany(p => p.Visittext)
                    .HasForeignKey(d => d.Internalid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__VISITTEXT__INTER__7CF981FA");

                entity.HasOne(d => d.Visit)
                    .WithMany(p => p.Visittext)
                    .HasForeignKey(d => d.Visitid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__VISITTEXT__VISIT__7DEDA633");
            });

            modelBuilder.Entity<Visittype>(entity =>
            {
                entity.HasKey(e => e.Visitcode)
                    .HasName("PK__VISITTYPE__75A278F5");

                entity.ToTable("VISITTYPE", "dbo");

                entity.Property(e => e.Visitcode)
                    .HasColumnName("VISITCODE")
                    .ValueGeneratedNever();

                entity.Property(e => e.Visittype1)
                    .IsRequired()
                    .HasColumnName("VISITTYPE")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<WindowsUserGroup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("WindowsUserGroup", "dbo");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WorkCoverQldproviderAccounts>(entity =>
            {
                entity.HasKey(e => e.Provideraccountid)
                    .HasName("PK_QLDWORKCOVERPROVIDERACCOUNTS");

                entity.ToTable("WorkCoverQLDProviderAccounts", "dbo");

                entity.Property(e => e.Provideraccountid).HasColumnName("PROVIDERACCOUNTID");

                entity.Property(e => e.Accountnumber)
                    .IsRequired()
                    .HasColumnName("ACCOUNTNUMBER")
                    .HasMaxLength(50);

                entity.Property(e => e.Providerid).HasColumnName("PROVIDERID");

                entity.Property(e => e.Providertypeid).HasColumnName("PROVIDERTYPEID");
            });

            modelBuilder.Entity<Workcover>(entity =>
            {
                entity.HasKey(e => e.Certificateid)
                    .HasName("PK__WORKCOVER__7F6BDA51");

                entity.ToTable("WORKCOVER", "dbo");

                entity.Property(e => e.Certificateid).HasColumnName("CERTIFICATEID");

                entity.Property(e => e.Certificatedate)
                    .HasColumnName("CERTIFICATEDATE")
                    .HasColumnType("datetime");

                entity.Property(e => e.Certificatetime)
                    .HasColumnName("CERTIFICATETIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.Claimid)
                    .HasColumnName("CLAIMID")
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Internalid).HasColumnName("INTERNALID");

                entity.Property(e => e.Pmc)
                    .HasColumnName("PMC")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Pmcid).HasColumnName("PMCID");

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.HasOne(d => d.Internal)
                    .WithMany(p => p.Workcover)
                    .HasForeignKey(d => d.Internalid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__WORKCOVER__INTER__024846FC");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Workcover)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__WORKCOVER__USERI__033C6B35");
            });

            modelBuilder.Entity<Workcoverdetails>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__WORKCOVERDETAILS__613C58EC");

                entity.ToTable("WORKCOVERDETAILS", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Accountname)
                    .HasColumnName("ACCOUNTNAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Address1)
                    .HasColumnName("ADDRESS1")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Address2)
                    .HasColumnName("ADDRESS2")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.City)
                    .HasColumnName("CITY")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Fax)
                    .HasColumnName("FAX")
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Firstname)
                    .HasColumnName("FIRSTNAME")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Phone)
                    .HasColumnName("PHONE")
                    .HasMaxLength(14)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Postcode)
                    .HasColumnName("POSTCODE")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.State).HasColumnName("STATE");

                entity.Property(e => e.Surname)
                    .HasColumnName("SURNAME")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Titlecode).HasColumnName("TITLECODE");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.HasOne(d => d.TitlecodeNavigation)
                    .WithMany(p => p.Workcoverdetails)
                    .HasForeignKey(d => d.Titlecode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__WORKCOVER__TITLE__6418C597");
            });

            modelBuilder.Entity<Workcoveritems>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__WORKCOVERITEMS__0524B3A7");

                entity.ToTable("WORKCOVERITEMS", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Certificateid).HasColumnName("CERTIFICATEID");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Internalid).HasColumnName("INTERNALID");

                entity.Property(e => e.Itemcode).HasColumnName("ITEMCODE");

                entity.Property(e => e.Itemvalue)
                    .IsRequired()
                    .HasColumnName("ITEMVALUE")
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.HasOne(d => d.Certificate)
                    .WithMany(p => p.Workcoveritems)
                    .HasForeignKey(d => d.Certificateid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__WORKCOVER__CERTI__08012052");

                entity.HasOne(d => d.Internal)
                    .WithMany(p => p.Workcoveritems)
                    .HasForeignKey(d => d.Internalid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__WORKCOVER__INTER__070CFC19");
            });

            modelBuilder.Entity<Workcovertext>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK__WORKCOVERTEXT__09E968C4");

                entity.ToTable("WORKCOVERTEXT", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Certificateid).HasColumnName("CERTIFICATEID");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Internalid).HasColumnName("INTERNALID");

                entity.Property(e => e.Itemcode).HasColumnName("ITEMCODE");

                entity.Property(e => e.Itemvalue)
                    .HasColumnName("ITEMVALUE")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.HasOne(d => d.Certificate)
                    .WithMany(p => p.Workcovertext)
                    .HasForeignKey(d => d.Certificateid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__WORKCOVER__CERTI__0CC5D56F");

                entity.HasOne(d => d.Internal)
                    .WithMany(p => p.Workcovertext)
                    .HasForeignKey(d => d.Internalid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__WORKCOVER__INTER__0BD1B136");
            });

            modelBuilder.Entity<Workcoverusersqld>(entity =>
            {
                entity.HasKey(e => e.Recordid)
                    .HasName("PK_WORKCOVERUSERS");

                entity.ToTable("WORKCOVERUSERSQLD", "dbo");

                entity.Property(e => e.Recordid).HasColumnName("RECORDID");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("PASSWORD")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("USERNAME")
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Wptemplates>(entity =>
            {
                entity.HasKey(e => e.Templateid)
                    .HasName("PK__WPTEMPLATES__5C229E14");

                entity.ToTable("WPTEMPLATES", "dbo");

                entity.Property(e => e.Templateid).HasColumnName("TEMPLATEID");

                entity.Property(e => e.Category).HasColumnName("CATEGORY");

                entity.Property(e => e.Content)
                    .HasColumnName("CONTENT")
                    .HasColumnType("text");

                entity.Property(e => e.Created)
                    .HasColumnName("CREATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");

                entity.Property(e => e.Pagesettings)
                    .HasColumnName("PAGESETTINGS")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Recordstatus).HasColumnName("RECORDSTATUS");

                entity.Property(e => e.State).HasColumnName("STATE");

                entity.Property(e => e.Supplied).HasColumnName("SUPPLIED");

                entity.Property(e => e.Templatename)
                    .HasColumnName("TEMPLATENAME")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Updated)
                    .HasColumnName("UPDATED")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby).HasColumnName("UPDATEDBY");

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Wptemplates)
                    .HasForeignKey(d => d.Userid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__WPTEMPLAT__USERI__5EFF0ABF");
            });

            modelBuilder.Entity<Yesno>(entity =>
            {
                entity.HasKey(e => e.Yesnocode)
                    .HasName("PK__YESNO__398D8EEE");

                entity.ToTable("YESNO", "dbo");

                entity.Property(e => e.Yesnocode)
                    .HasColumnName("YESNOCODE")
                    .ValueGeneratedNever();

                entity.Property(e => e.Yesnoword)
                    .IsRequired()
                    .HasColumnName("YESNOWORD")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Yesnoblank>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("YESNOBLANK", "dbo");

                entity.Property(e => e.Yesnocode).HasColumnName("YESNOCODE");

                entity.Property(e => e.Yesnoword)
                    .HasColumnName("YESNOWORD")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Yesnounknown>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("YESNOUNKNOWN", "dbo");

                entity.Property(e => e.Yesnocode).HasColumnName("YESNOCODE");

                entity.Property(e => e.Yesnoword)
                    .HasColumnName("YESNOWORD")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
