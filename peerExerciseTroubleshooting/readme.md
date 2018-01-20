The following code has many errors at both the compile level and the runtime level. Copy the code into Visual Studio and correct as many errors as you can find. Keep track of and list the errors you find. We will discuss this when you most are finished. Upload a list of the errors you found.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        private const double PI = 3.14;
        private double radius = 0;
        static void Main(string[] args)
        {
            Program p = new Program();
            p.GetMeasurements()
            p.DisplayMeasurements();
            p.Console.ReadKey();
        }

        private double calculateArea()
        {
            return radius * radius * PI;
        }

        private double calculateCircumferance()
        {
            return radius * 2 * PI;
        }

        private void GetMeasurements()
        {
            Console.WriteLine("Enter the radius of the circle");
            double radius = double.Parse(Console.ReadLine());
        }

        private void DisplayMeasurements()
        {
            Console.WriteLine("the circumforence is {0}", calculateCircumferance);
            Console.WriteLine("the area is {1}", calculateArea());
        }


    }
}
