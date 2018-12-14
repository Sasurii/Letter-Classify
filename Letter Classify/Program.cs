using FluentAssertions;
using Xunit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Letter_Classify
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Briefmaße eingeben");
            Console.WriteLine();
            Console.WriteLine("Länge in mm: ");
            string length = Console.ReadLine();
            if(length == "")
            {
                Console.WriteLine("Ungültig!");
                Console.ReadLine();
                return;
            }
            Console.WriteLine("Breite in mm: ");
            string width = Console.ReadLine();
            if (width == "")
            {
                Console.WriteLine("Ungültig!");
                Console.ReadLine();
                return;
            }
            Console.WriteLine("Höhe in mm: ") ;
            string height = Console.ReadLine();
            if (height == "")
            {
                Console.WriteLine("Ungültig!");
                Console.ReadLine();
                return;
            }
            Console.WriteLine("Gewicht in g: ");
            string weight = Console.ReadLine();
            if (weight == "")
            {
                Console.WriteLine("Ungültig!");
                Console.ReadLine();
                return;
            }
            int lengthvalue = Convert.ToInt32(length);
            int widthvalue = Convert.ToInt32(width);
            int heightvalue = Convert.ToInt32(height);
            int weightvalue = Convert.ToInt32(weight);

            string output = Classifier(lengthvalue, widthvalue, heightvalue, weightvalue);
            Console.WriteLine(output);
            Console.ReadLine();
        }

        public static string Classifier(int lengthvalue, int widthvalue, int heightvalue, int weightvalue)
        {
            if (lengthvalue >= 140 && lengthvalue <= 235 && widthvalue >= 90 && widthvalue <= 125 &&
                heightvalue <= 5 && weightvalue <= 20)
            {
                return("Standardbrief");
            }
            else if (lengthvalue >= 100 && lengthvalue <= 235 && widthvalue >= 70 && widthvalue <= 125 &&
                heightvalue <= 10 && weightvalue <= 50)
            {
                return("Kompaktbrief");
            }
            else if (lengthvalue >= 100 && lengthvalue <= 335 && widthvalue >= 70 && widthvalue <= 250 &&
                heightvalue <= 20 && weightvalue <= 500)
            {
                return("Großbrief");
            }
            else if (lengthvalue >= 100 && lengthvalue <= 335 && widthvalue >= 70 && widthvalue <= 250 &&
                heightvalue <= 50 && weightvalue <= 1000)
            {
                return("Maxibrief");
            }
            else if (lengthvalue >= 100 && lengthvalue <= 600 && widthvalue >= 70 && widthvalue <= 300 &&
                heightvalue <= 150 && weightvalue <= 2000)
            {
                return("Maxibrief Plus");
            }
            else if ((lengthvalue + widthvalue + heightvalue) == 900 && lengthvalue <= 600 && widthvalue <= 600 &&
                heightvalue <= 600 && weightvalue <= 2000)
            {
                return("Maxibrief Plus");
            }
            else
            {
                return("Ungültig!");
            }
        }
    }
}
