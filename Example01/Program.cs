using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarLibrary.DATA;

namespace Example01
{
    class Program
    {
        static void Main(string[] args)
        {
            CAR ccCar = new CAR();
            Owner ccOwner = new Owner();

            ccCar.SetName("AXeme");
            int year = int.Parse(Console.ReadLine());

            ccCar.SetYear(year);
            Console.WriteLine(ccCar.GetYear());

            ccCar.Year = year;
            Console.WriteLine(ccCar.Year);
        
        
        }
    }
}
