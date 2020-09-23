using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BODojo
{
    public class Samourai : Dojo
    {
        public int Force { get; set; }
        public string Nom { get; set; }
        public virtual Arme Arme { get; set; }

        [Display(Name = "Arts martiaux Maitrisés ", Description = "Art Martiaux maitrisés")]
        public virtual List<ArtMartial> ArtMartials { get; set; } = new List<ArtMartial>();
        
        public int Potentiel { get { return (Force + (Arme != null ? Arme.Degats : 0)) * (ArtMartials.Count + 1); } }
   

    }
}
