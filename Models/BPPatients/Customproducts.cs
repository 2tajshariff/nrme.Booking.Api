using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Customproducts
    {
        public int Productid { get; set; }
        public int Productnameid { get; set; }
        public int Recordstatus { get; set; }
        public int Userid { get; set; }
        public string Strength { get; set; }
        public int Listorder { get; set; }
        public int Formcode { get; set; }
        public string Form { get; set; }
        public string Productdescription { get; set; }
        public string Companyform { get; set; }
        public string Dosage { get; set; }
        public int Glutencode { get; set; }
        public int Breastcode { get; set; }
        public int Sportcode { get; set; }
        public int Pregnancycode { get; set; }
        public int Intcheck { get; set; }
        public int Diseasecheck { get; set; }
        public int Noteid { get; set; }
        public int Picode { get; set; }
        public int Cmicode { get; set; }
        public int Mimsbmcode { get; set; }
        public int Routeid { get; set; }
        public string Route { get; set; }
        public int Ean { get; set; }
        public int Usestrength { get; set; }
        public string Genericname { get; set; }
        public int Companyid { get; set; }
        public string Companyname { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }

        public virtual Users User { get; set; }
    }
}
