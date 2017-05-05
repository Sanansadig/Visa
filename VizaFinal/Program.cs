using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VizaFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vizani Daxil Et");
            int viza = Convert.ToInt32(Console.ReadLine());
            Console.Write("Finali Daxil Et");
            int final = Convert.ToInt32(Console.ReadLine());
            double netice = Convert.ToDouble(final)*0.6 + Convert.ToDouble(viza)*0.4; 

            if (netice>=45)
            {
                Console.WriteLine(netice + "Kecdiniz");

            }
            else
            {
                Console.WriteLine(netice + "Kesildiz");
            }
        }
    }
}
