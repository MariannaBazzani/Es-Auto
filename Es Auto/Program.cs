using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_Auto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Auto a1= new Auto();
            a1.Modello = "Ferrari";
            Console.WriteLine(a1.Modello);

            Auto a2 = a1;
            Console.WriteLine(a2.Modello);

            Auto a3 = new Auto();
            a1 = a3;
            Console.WriteLine(a1.Modello);
        }
    }
}
