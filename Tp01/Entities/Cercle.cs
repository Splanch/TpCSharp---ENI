using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp01.Entities
{
    public class Cercle : Forme
    {
        private int rayon;

        public int Rayon { get => rayon; set => rayon = value; }

        public override double Aire()
        {
            return Rayon*Rayon*Math.PI;
        }

        public override double Perimetre()
        {
            return Rayon*2*Math.PI;
        }

        public override string ToString()
        {
           return string.Format("Cercle de rayon {0} \nAire = {1}\nPérimètre = {2}\n",Rayon,Aire(),Perimetre());
        }

       
    }


}
