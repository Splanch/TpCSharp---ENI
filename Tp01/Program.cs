using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tp01.Entities;

namespace Tp01
{
    public class Program
    {
        public static void Main(string[] args)

        {

            var formes = new List<Forme>();

            formes.Add(new Cercle { Rayon = 3 });

            formes.Add(new Rectangle { Largeur = 3, Longueur = 4 });

            formes.Add(new Carre { Longueur = 3 });

            formes.Add(new Triangle { A1 = 4, B1 = 5, C1 = 6 });



            foreach (var forme in formes)

            {

                Console.WriteLine(forme);

            }

            Console.ReadKey();

        }
    }
}
