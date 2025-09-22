using System;
using CiPFizzBuzz.Services;
using CiPFizzBuzz.Printers;


namespace CiPFizzBuzz
{
    class Program
    {
        static void Main()
        {

            var FizzBuzzService = new FizzBuzzService();
            var Printer = new FizzBuzzPrinter(FizzBuzzService);
            Console.WriteLine("Välj alternativ:");
            Console.WriteLine("1: Del 1 - Skriv ut FizzBuzz från 1 till 100");
            Console.WriteLine("2: Del 2 - Räkna antal Fizz och Buzz för N");
            var choice = Console.ReadLine();

            if (choice == "1")
            {
                Printer.PrintSeries(1, 100);
            }
            else if (choice == "2")
            {
                Console.WriteLine("Ange N:");
                if (long.TryParse(Console.ReadLine(), out long n) && n > 0)
                {
                    var (fizz, buzz) = FizzBuzzService.TallyFizzBuzz(n);
                    Console.WriteLine($"Tally for n = {n}");
                    Console.WriteLine($"Fizz: {fizz}");
                    Console.WriteLine($"Buzz: {buzz}");
                }
                else
                {
                    Console.WriteLine("Ogiltigt nummer. Vänligen ange ett positivt heltal.");
                }
            }
            else
            {
                Console.WriteLine("Ogiltigt val. Vänligen välj 1 eller 2.");
            }
        }
    }
}