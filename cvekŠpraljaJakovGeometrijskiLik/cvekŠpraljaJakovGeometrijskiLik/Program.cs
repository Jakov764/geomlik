using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cvekŠpraljaJakovGeometrijskiLik
{
    class Program
    {
        static void Main(string[] args)
        {
            Trokut trokut = new Trokut();
            trokut.ucitajStranice();
            double opsegTrokuta = trokut.Opseg();
            Cetverokut cetverokut = new Cetverokut();
            cetverokut.ucitajStranice();
            double opsegCetverokuta = cetverokut.Opseg();
            Console.WriteLine("Opseg trokuta je: " + opsegTrokuta);
            Console.WriteLine("Opseg cetverokuta je: " + opsegCetverokuta);
            Console.ReadKey();
        }
    }
}
