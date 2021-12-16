using System;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter integer number 'q' to quit: ");
                    var input = Console.ReadLine();

                    if (input == "q")
                        break;

                    var result = FizzBuzz.CheckInteger(input);
                    Console.WriteLine(result);
                }
                catch(InvalidOperationException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    break;
                }                
            }            
        }
    }
}
