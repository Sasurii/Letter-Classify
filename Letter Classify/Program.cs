using FluentAssertions;
using Xunit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Letter_Classify
{
    class Program
    {
        static void Main(string[] args)
        {
        
            Console.WriteLine("Briefmaße eingeben");
            Console.WriteLine();
            Console.WriteLine("Länge in mm: ");
            string length = Console.ReadLine();
            Console.WriteLine("Breite in mm: ");
            string width = Console.ReadLine();
            Console.WriteLine("Höhe in mm: ");
            string height = Console.ReadLine();
            Console.WriteLine("Gewicht in g: ");
            string weight = Console.ReadLine();
            int lengthvalue = Convert.ToInt32(length);
            int widthvalue = Convert.ToInt32(width);
            int heightvalue = Convert.ToInt32(height);
            int weightvalue = Convert.ToInt32(weight);

            if (lengthvalue >= 140 && lengthvalue <= 235 && widthvalue >= 90 && widthvalue <= 125 &&
                heightvalue <= 5 && weightvalue <= 20)
            {
                Console.WriteLine("Standardbrief");
            }
            else if (lengthvalue >= 100 && lengthvalue <= 235 && widthvalue >= 70 && widthvalue <= 125 &&
                heightvalue <= 10 && weightvalue <= 50)
            {
                Console.WriteLine("Kompaktbrief");
            }
            else if (lengthvalue >= 100 && lengthvalue <= 335 && widthvalue >= 70 && widthvalue <= 250 &&
                heightvalue <= 20 && weightvalue <= 500)
            {
                Console.WriteLine("Großbrief");
            }
            else if (lengthvalue >= 100 && lengthvalue <= 335 && widthvalue >= 70 && widthvalue <= 250 &&
                heightvalue <= 50 && weightvalue <= 1000)
            {
                Console.WriteLine("Maxibrief");
            }
            else if (lengthvalue >= 100 && lengthvalue <= 600 && widthvalue >= 70 && widthvalue <= 300 &&
                heightvalue <= 150 && weightvalue <= 2000)
            {
                Console.WriteLine("Maxibrief Plus");
            }
            else if ((lengthvalue+widthvalue+heightvalue) == 900 && lengthvalue <= 600 && widthvalue <= 600 &&
                heightvalue <= 600 && weightvalue <= 2000)
            {
                Console.WriteLine("Maxibrief Plus");
            }
            else
            {
                Console.WriteLine("Ungültig!");
            }
            Console.ReadLine();



        }
    }
}
