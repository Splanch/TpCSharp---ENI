using BODojo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP1_Mod6_Dojo.Models
{
    public class SamouraiVM
    {
        public Samourai Samourai { get; set; }
        public List<Arme> Armes { get; set; }
        public int? ArmeId { get; set; }

        public List<ArtMartial> ArtMartialsVM { get; set; } = new List<ArtMartial>();

        public List<int> ArtMartialsIds { get; set; } = new List<int>();
    }
}