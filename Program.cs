using System;

namespace Exercise1Question2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please insert the lenght of your room in cm: ");
            double lenght = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please insert the width of your room in cm: ");
            double width = Convert.ToDouble(Console.ReadLine());

            //price of carpet per square meter = £30.00

            double price;
            double area;
            double l = lenght/100;
            double w = width/100;

            area = l * w;
            price = l * w * 30;

            Console.WriteLine("\nBedroom area is: " + area);
            Console.WriteLine("Bedroom carpet cost: " + price);
        }
    }
}
