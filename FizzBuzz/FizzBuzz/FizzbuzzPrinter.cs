using CiPFizzBuzz.Services;
using System;

namespace CiPFizzBuzz.Printers
{
    public class FizzBuzzPrinter
    {
        private readonly FizzBuzzService _service;

        public FizzBuzzPrinter(FizzBuzzService service)
        {
            _service = service;
        }

        public void PrintSeries(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                string result = _service.GetFizzbuzzValue(i);
                Console.WriteLine(result);
            }
        }
    }



}