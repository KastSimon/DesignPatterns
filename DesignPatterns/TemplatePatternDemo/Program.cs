using System;
using System.Data.SqlTypes;
using DesignPatterns.Template;

namespace TemplatePatternDemo
{
    class Program
    {
        private static Sale sale;
        static void Main(string[] args)
        {
            Console.WriteLine("Want buy something for 100Sfr. \r\n");

            Console.WriteLine("Use 80% discount");
            sale = new EightyPercentDiscount();
            Console.WriteLine(sale.GetTotal(100.0m)+"\r\n");

            Console.WriteLine("Use 60% discount");
            sale = new SixtyPercentDiscount();
            Console.WriteLine(sale.GetTotal(100.0m));
            Console.ReadLine();
        }
    }
}
