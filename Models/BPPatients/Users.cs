using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Users
    {
        public Users()
        {
            Accident = new HashSet<Accident>();
            Actions = new HashSet<Actions>();
            Acupuncturevisits = new HashSet<Acupuncturevisits>();
            Adrac = new HashSet<Adrac>();
            Antenatalvisits = new HashSet<Antenatalvisits>();
            AppointmentsNavigation = new HashSet<Appointments>();
            Asthmaplan = new HashSet<Asthmaplan>();
            Auditc = new HashSet<Auditc>();
            Auditlog = new HashSet<Auditlog>();
            Autofill = new HashSet<Autofill>();
            Cancelledappointments = new HashSet<Cancelledappointments>();
            Complexinstructions = new HashSet<Complexinstructions>();
            ContactNotes = new HashSet<ContactNotes>();
            Correspondencein = new HashSet<Correspondencein>();
            Correspondenceout = new HashSet<Correspondenceout>();
            Customproductnames = new HashSet<Customproductnames>();
            Customproducts = new HashSet<Customproducts>();
            Customprompts = new HashSet<Customprompts>();
            Customtests = new HashSet<Customtests>();
            Defaultdose = new HashSet<Defaultdose>();
            DeletedappointmentlocksDeletedbyNavigation = new HashSet<Deletedappointmentlocks>();
            DeletedappointmentlocksUser = new HashSet<Deletedappointmentlocks>();
            DeletedinvoicelocksDeletedbyNavigation = new HashSet<Deletedinvoicelocks>();
            DeletedinvoicelocksUser = new HashSet<Deletedinvoicelocks>();
            DeletedmaolpaymentlocksDeletedbyNavigation = new HashSet<Deletedmaolpaymentlocks>();
            DeletedmaolpaymentlocksUser = new HashSet<Deletedmaolpaymentlocks>();
            DeletedvisitlocksDeletedbyNavigation = new HashSet<Deletedvisitlocks>();
            DeletedvisitlocksUser = new HashSet<Deletedvisitlocks>();
            Diabetes = new HashSet<Diabetes>();
            Drugcombinations = new HashSet<Drugcombinations>();
            Drugfavourites = new HashSet<Drugfavourites>();
            Educationleaflets = new HashSet<Educationleaflets>();
            Epcreports = new HashSet<Epcreports>();
            Epctext = new HashSet<Epctext>();
            Epcvalues = new HashSet<Epcvalues>();
            Ereferrals = new HashSet<Ereferrals>();
            Favouritetests = new HashSet<Favouritetests>();
            Fieldvalues = new HashSet<Fieldvalues>();
            Generatedtext = new HashSet<Generatedtext>();
            Gp2gpCreatedByNavigation = new HashSet<Gp2gp>();
            Gp2gpUpdatedByNavigation = new HashSet<Gp2gp>();
            Gp2gpUser = new HashSet<Gp2gp>();
            Healthlinkform = new HashSet<Healthlinkform>();
            Healthlinksession = new HashSet<Healthlinksession>();
            Hiaudit = new HashSet<Hiaudit>();
            Hierrors = new HashSet<Hierrors>();
            Immunisations = new HashSet<Immunisations>();
            Inrdetail = new HashSet<Inrdetail>();
            Inrvalues = new HashSet<Inrvalues>();
            Invoicelock = new HashSet<Invoicelock>();
            K10 = new HashSet<K10>();
            Labcodes = new HashSet<Labcodes>();
            Laboratories = new HashSet<Laboratories>();
            Leafletcategories = new HashSet<Leafletcategories>();
            Locations = new HashSet<Locations>();
            Login = new HashSet<Login>();
            Maolpaymentlock = new HashSet<Maolpaymentlock>();
            Medviewconsent = new HashSet<Medviewconsent>();
            Messagegroupusers = new HashSet<Messagegroupusers>();
            Messages = new HashSet<Messages>();
            Messagessent = new HashSet<Messagessent>();
            Mmse = new HashSet<Mmse>();
            Nirmessages = new HashSet<Nirmessages>();
            Notify = new HashSet<Notify>();
            Observations = new HashSet<Observations>();
            OperationsNavigation = new HashSet<Operations>();
            Opioid = new HashSet<Opioid>();
            Pain = new HashSet<Pain>();
            Papsmears = new HashSet<Papsmears>();
            Parameters = new HashSet<Parameters>();
            Pasthistory = new HashSet<Pasthistory>();
            Patientgroups = new HashSet<Patientgroups>();
            Patients = new HashSet<Patients>();
            Pcehrdocuments = new HashSet<Pcehrdocuments>();
            Pedrec = new HashSet<Pedrec>();
            Pmhfavourites = new HashSet<Pmhfavourites>();
            Prescriptions = new HashSet<Prescriptions>();
            ProviderLocation = new HashSet<ProviderLocation>();
            Reactions = new HashSet<Reactions>();
            Referrals = new HashSet<Referrals>();
            Reminderreasons = new HashSet<Reminderreasons>();
            Reminders = new HashSet<Reminders>();
            Reminderssent = new HashSet<Reminderssent>();
            Reportcomments = new HashSet<Reportcomments>();
            Requestedtests = new HashSet<Requestedtests>();
            Scriptitems = new HashSet<Scriptitems>();
            SmsscheduleUser = new HashSet<SmsscheduleUser>();
            Templatefaves = new HashSet<Templatefaves>();
            Todolist = new HashSet<Todolist>();
            Transidentity = new HashSet<Transidentity>();
            Transmissions = new HashSet<Transmissions>();
            Udfvalues = new HashSet<Udfvalues>();
            UserNumbers = new HashSet<UserNumbers>();
            UserReportLocations = new HashSet<UserReportLocations>();
            Useralias = new HashSet<Useralias>();
            Userpermissions = new HashSet<Userpermissions>();
            Userpreferences = new HashSet<Userpreferences>();
            Userqualifications = new HashSet<Userqualifications>();
            Userreports = new HashSet<Userreports>();
            Visitlock = new HashSet<Visitlock>();
            Visits = new HashSet<Visits>();
            Workcover = new HashSet<Workcover>();
            Wptemplates = new HashSet<Wptemplates>();
        }

        public int Userid { get; set; }
        public int Recordstatus { get; set; }
        public int Userstatus { get; set; }
        public int Locationid { get; set; }
        public string Hpii { get; set; }
        public int Groupcode { get; set; }
        public int Titlecode { get; set; }
        public string Surname { get; set; }
        public string Firstname { get; set; }
        public string Password { get; set; }
        public string Registrationno { get; set; }
        public string Cpdno { get; set; }
        public string Prescriberno { get; set; }
        public string Providerno { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Homephone { get; set; }
        public string Mobilephone { get; set; }
        public string Pager { get; set; }
        public string Email { get; set; }
        public string Abn { get; set; }
        public string Pkikey { get; set; }
        public int Toppocket { get; set; }
        public DateTime? Inactivedate { get; set; }
        public int Appointments { get; set; }
        public int Accounts { get; set; }
        public int Defaultaccount { get; set; }
        public string Defaultitem { get; set; }
        public int Vr { get; set; }
        public int Lmo { get; set; }
        public int Rei { get; set; }
        public int Sendhel { get; set; }
        public int Teddss { get; set; }
        public int Needsreferral { get; set; }
        public int Confidentialnotes { get; set; }
        public string Erxid { get; set; }
        public string Thumbprint { get; set; }
        public string Companyname { get; set; }
        public int Operations { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }
        public DateTime? Hpiivalidated { get; set; }
        public string Medrefertoken { get; set; }
        public string Nzmcnumber { get; set; }
        public string Accpayeenumber { get; set; }
        public string Gmspayeenumber { get; set; }

        public virtual Usergroups GroupcodeNavigation { get; set; }
        public virtual Locations Location { get; set; }
        public virtual Titles TitlecodeNavigation { get; set; }
        public virtual Authority Authority { get; set; }
        public virtual ICollection<Accident> Accident { get; set; }
        public virtual ICollection<Actions> Actions { get; set; }
        public virtual ICollection<Acupuncturevisits> Acupuncturevisits { get; set; }
        public virtual ICollection<Adrac> Adrac { get; set; }
        public virtual ICollection<Antenatalvisits> Antenatalvisits { get; set; }
        public virtual ICollection<Appointments> AppointmentsNavigation { get; set; }
        public virtual ICollection<Asthmaplan> Asthmaplan { get; set; }
        public virtual ICollection<Auditc> Auditc { get; set; }
        public virtual ICollection<Auditlog> Auditlog { get; set; }
        public virtual ICollection<Autofill> Autofill { get; set; }
        public virtual ICollection<Cancelledappointments> Cancelledappointments { get; set; }
        public virtual ICollection<Complexinstructions> Complexinstructions { get; set; }
        public virtual ICollection<ContactNotes> ContactNotes { get; set; }
        public virtual ICollection<Correspondencein> Correspondencein { get; set; }
        public virtual ICollection<Correspondenceout> Correspondenceout { get; set; }
        public virtual ICollection<Customproductnames> Customproductnames { get; set; }
        public virtual ICollection<Customproducts> Customproducts { get; set; }
        public virtual ICollection<Customprompts> Customprompts { get; set; }
        public virtual ICollection<Customtests> Customtests { get; set; }
        public virtual ICollection<Defaultdose> Defaultdose { get; set; }
        public virtual ICollection<Deletedappointmentlocks> DeletedappointmentlocksDeletedbyNavigation { get; set; }
        public virtual ICollection<Deletedappointmentlocks> DeletedappointmentlocksUser { get; set; }
        public virtual ICollection<Deletedinvoicelocks> DeletedinvoicelocksDeletedbyNavigation { get; set; }
        public virtual ICollection<Deletedinvoicelocks> DeletedinvoicelocksUser { get; set; }
        public virtual ICollection<Deletedmaolpaymentlocks> DeletedmaolpaymentlocksDeletedbyNavigation { get; set; }
        public virtual ICollection<Deletedmaolpaymentlocks> DeletedmaolpaymentlocksUser { get; set; }
        public virtual ICollection<Deletedvisitlocks> DeletedvisitlocksDeletedbyNavigation { get; set; }
        public virtual ICollection<Deletedvisitlocks> DeletedvisitlocksUser { get; set; }
        public virtual ICollection<Diabetes> Diabetes { get; set; }
        public virtual ICollection<Drugcombinations> Drugcombinations { get; set; }
        public virtual ICollection<Drugfavourites> Drugfavourites { get; set; }
        public virtual ICollection<Educationleaflets> Educationleaflets { get; set; }
        public virtual ICollection<Epcreports> Epcreports { get; set; }
        public virtual ICollection<Epctext> Epctext { get; set; }
        public virtual ICollection<Epcvalues> Epcvalues { get; set; }
        public virtual ICollection<Ereferrals> Ereferrals { get; set; }
        public virtual ICollection<Favouritetests> Favouritetests { get; set; }
        public virtual ICollection<Fieldvalues> Fieldvalues { get; set; }
        public virtual ICollection<Generatedtext> Generatedtext { get; set; }
        public virtual ICollection<Gp2gp> Gp2gpCreatedByNavigation { get; set; }
        public virtual ICollection<Gp2gp> Gp2gpUpdatedByNavigation { get; set; }
        public virtual ICollection<Gp2gp> Gp2gpUser { get; set; }
        public virtual ICollection<Healthlinkform> Healthlinkform { get; set; }
        public virtual ICollection<Healthlinksession> Healthlinksession { get; set; }
        public virtual ICollection<Hiaudit> Hiaudit { get; set; }
        public virtual ICollection<Hierrors> Hierrors { get; set; }
        public virtual ICollection<Immunisations> Immunisations { get; set; }
        public virtual ICollection<Inrdetail> Inrdetail { get; set; }
        public virtual ICollection<Inrvalues> Inrvalues { get; set; }
        public virtual ICollection<Invoicelock> Invoicelock { get; set; }
        public virtual ICollection<K10> K10 { get; set; }
        public virtual ICollection<Labcodes> Labcodes { get; set; }
        public virtual ICollection<Laboratories> Laboratories { get; set; }
        public virtual ICollection<Leafletcategories> Leafletcategories { get; set; }
        public virtual ICollection<Locations> Locations { get; set; }
        public virtual ICollection<Login> Login { get; set; }
        public virtual ICollection<Maolpaymentlock> Maolpaymentlock { get; set; }
        public virtual ICollection<Medviewconsent> Medviewconsent { get; set; }
        public virtual ICollection<Messagegroupusers> Messagegroupusers { get; set; }
        public virtual ICollection<Messages> Messages { get; set; }
        public virtual ICollection<Messagessent> Messagessent { get; set; }
        public virtual ICollection<Mmse> Mmse { get; set; }
        public virtual ICollection<Nirmessages> Nirmessages { get; set; }
        public virtual ICollection<Notify> Notify { get; set; }
        public virtual ICollection<Observations> Observations { get; set; }
        public virtual ICollection<Operations> OperationsNavigation { get; set; }
        public virtual ICollection<Opioid> Opioid { get; set; }
        public virtual ICollection<Pain> Pain { get; set; }
        public virtual ICollection<Papsmears> Papsmears { get; set; }
        public virtual ICollection<Parameters> Parameters { get; set; }
        public virtual ICollection<Pasthistory> Pasthistory { get; set; }
        public virtual ICollection<Patientgroups> Patientgroups { get; set; }
        public virtual ICollection<Patients> Patients { get; set; }
        public virtual ICollection<Pcehrdocuments> Pcehrdocuments { get; set; }
        public virtual ICollection<Pedrec> Pedrec { get; set; }
        public virtual ICollection<Pmhfavourites> Pmhfavourites { get; set; }
        public virtual ICollection<Prescriptions> Prescriptions { get; set; }
        public virtual ICollection<ProviderLocation> ProviderLocation { get; set; }
        public virtual ICollection<Reactions> Reactions { get; set; }
        public virtual ICollection<Referrals> Referrals { get; set; }
        public virtual ICollection<Reminderreasons> Reminderreasons { get; set; }
        public virtual ICollection<Reminders> Reminders { get; set; }
        public virtual ICollection<Reminderssent> Reminderssent { get; set; }
        public virtual ICollection<Reportcomments> Reportcomments { get; set; }
        public virtual ICollection<Requestedtests> Requestedtests { get; set; }
        public virtual ICollection<Scriptitems> Scriptitems { get; set; }
        public virtual ICollection<SmsscheduleUser> SmsscheduleUser { get; set; }
        public virtual ICollection<Templatefaves> Templatefaves { get; set; }
        public virtual ICollection<Todolist> Todolist { get; set; }
        public virtual ICollection<Transidentity> Transidentity { get; set; }
        public virtual ICollection<Transmissions> Transmissions { get; set; }
        public virtual ICollection<Udfvalues> Udfvalues { get; set; }
        public virtual ICollection<UserNumbers> UserNumbers { get; set; }
        public virtual ICollection<UserReportLocations> UserReportLocations { get; set; }
        public virtual ICollection<Useralias> Useralias { get; set; }
        public virtual ICollection<Userpermissions> Userpermissions { get; set; }
        public virtual ICollection<Userpreferences> Userpreferences { get; set; }
        public virtual ICollection<Userqualifications> Userqualifications { get; set; }
        public virtual ICollection<Userreports> Userreports { get; set; }
        public virtual ICollection<Visitlock> Visitlock { get; set; }
        public virtual ICollection<Visits> Visits { get; set; }
        public virtual ICollection<Workcover> Workcover { get; set; }
        public virtual ICollection<Wptemplates> Wptemplates { get; set; }
    }
}
