using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers = new int[13]; This was my first attempt

            var numbers = new int[3] { 1, 2, 3 }; //corrected my syntax
            Console.WriteLine("max = {0} \nmin = {1}", numbers.Max(), numbers.Min());
        }
    }
}
