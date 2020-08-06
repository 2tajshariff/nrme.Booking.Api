using System;
using System.Collections.Generic;

namespace nrme.Booking.Api.Models.BPPatients
{
    public partial class Drugsheets
    {
        public int Recordid { get; set; }
        public int Recordstatus { get; set; }
        public string Sheetname { get; set; }
        public string Sheettitle { get; set; }
        public int Portrait { get; set; }
        public int Haslines { get; set; }
        public int Drugsperpage { get; set; }
        public int Daysperpage { get; set; }
        public int Timesperday { get; set; }
        public int Topmargin { get; set; }
        public int Leftmargin { get; set; }
        public int Bottommargin { get; set; }
        public int Rightmargin { get; set; }
        public int Titletop { get; set; }
        public int Titleleft { get; set; }
        public int Nametop { get; set; }
        public int Nameleft { get; set; }
        public int Addresstop { get; set; }
        public int Addressleft { get; set; }
        public int Doctortop { get; set; }
        public int Doctorleft { get; set; }
        public int Dobtop { get; set; }
        public int Dobleft { get; set; }
        public int Medicaretop { get; set; }
        public int Medicareleft { get; set; }
        public int Allergiestop { get; set; }
        public int Allergiesleft { get; set; }
        public int Datetop { get; set; }
        public int Dateleft { get; set; }
        public int Recordtop { get; set; }
        public int Recordleft { get; set; }
        public int Drugstop { get; set; }
        public int Drugsleft { get; set; }
        public int Prnseparate { get; set; }
        public int Generic { get; set; }
        public DateTime Created { get; set; }
        public int Createdby { get; set; }
        public DateTime? Updated { get; set; }
        public int? Updatedby { get; set; }
    }
}
