using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cvekŠpraljaJakovGeometrijskiLik
{
    class GeometrijskiLik
    {
        public int brojStranica;
        public double[] stranice = new double [10];
        public void ucitajStranice()
        {
            Console.WriteLine("Upisite duzinu stranica:");
            for(int i = 0; i< brojStranica; i++)
            {
                stranice[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        public double Opseg()
        {
            double opseg = 0;
            for (int i = 0; i < brojStranica; i++)
            {
                opseg = opseg + stranice[i];
            }
            return opseg;
        }
    }
}
