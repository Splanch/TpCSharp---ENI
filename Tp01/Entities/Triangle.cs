using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp01.Entities
{
    public class Triangle : Forme
    {
        private int A;
        private int B;
        private int C;

        public int A1 { get => A; set => A = value; }
        public int B1 { get => B; set => B = value; }
        public int C1 { get => C; set => C = value; }

        public override double Aire()
        {
            double p = this.Perimetre() / 2;
            return Math.Sqrt(p*(p-A1)*(p-B1)*(p-C1));
        }

        public override double Perimetre()
        {
            return A1+B1+C1;
        }

        public override string ToString()
        {
            return string.Format("Triangle de côté A = {0}, B = {1}, C = {2} \nAire = {3}\nPérimètre = {4}\n", A1,B1,C1, this.Aire(), this.Perimetre());
        }
    }
}
