using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klasaStringZadatak2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string s1;

            Console.WriteLine("Unesite niz znakova");
            s1 = Console.ReadLine();

            Console.WriteLine(s1.Replace(" ", "_"));


            Console.ReadKey();
        }
    }
}
