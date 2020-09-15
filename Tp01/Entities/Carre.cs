using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp01.Entities
{
    public class Carre : Rectangle
    {
     

        public override int Largeur { get => base.Longueur; }

      
        public override string ToString()
        {
            return string.Format("Carré de côté {0} \nAire = {1}\nPérimètre = {2}\n", Longueur, Aire(), Perimetre());
        }
    }
}
