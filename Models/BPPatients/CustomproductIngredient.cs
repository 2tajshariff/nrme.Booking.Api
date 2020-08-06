using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class CustomproductIngredient
    {
        public int Recordid { get; set; }
        public int Productid { get; set; }
        public int Ingredientid { get; set; }
        public string Ingredientname { get; set; }
        public string Strength { get; set; }
        public string Strengthunit { get; set; }
    }
}
