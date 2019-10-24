using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorMachine;

namespace Calctest
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator cal = new Calculator();
            Console.WriteLine("5 x 2 = {0}", cal.Perkalian(5, 2));
            Console.ReadKey();
                
        }
    }
}
