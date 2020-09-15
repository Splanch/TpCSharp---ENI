using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp01.Entities
{
    public class Rectangle : Forme
    {
        private int longueur;
        private int largeur;
        // test commit sfsdf
        public virtual int Largeur { get => largeur; set => largeur = value; }
        public  int Longueur { get => longueur; set => longueur = value; }

        public override double Aire()
        {
            return Largeur*Longueur;
        }

        public override double Perimetre()
        {
            return (Largeur + Longueur)*2;
        }

        public override string ToString()
        {
            return string.Format("Rectangle de longueur {0} et largeur {1}, \nAire = {2}\nPérimètre = {3}\n", Longueur,largeur, Aire(), Perimetre());
        }
    }
}
