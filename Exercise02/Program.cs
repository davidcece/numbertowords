using Exercise01;
using System.Numerics;

namespace Exercise02
{
    public class Program
    {
       
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter a Number to convert to words");
                    string number = Console.ReadLine();
                    number=number.Replace(",", "");

                    bool validNum = BigInteger.TryParse(number, out BigInteger num);
                    if (!validNum)
                    {
                        Console.WriteLine("Invalid Number");
                        continue;
                    }

                    Console.WriteLine(num.ToWords());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}