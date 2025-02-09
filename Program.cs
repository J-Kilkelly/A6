using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace KilkellyJA6;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("To calculate the sum of the internal angles of a polygon, enter a number of sides greater than 2.");
        string? stringSideCount = Console.ReadLine();
        int sideCount;
        bool success = int.TryParse(stringSideCount, out sideCount);

       if (success)
        {
            if (sideCount > 2)
            {
                A6 a6 = new A6();
                int sum = a6.SumPolygon(sideCount);
    
                Console.WriteLine($"The sum of the internal angles is {sum.ToString()}.");
            }
            else
            {
                Console.WriteLine("Input was not valid. Please input a number of sides greater than 2.");
            }
        }
        else
        {
            Console.WriteLine("Input was not an integer. Please input a number of sides greater than 2.");
        }
    }

    public class A6
    {
        public int SumPolygon(int sideCount)
        {
            int sumOfAngles = (sideCount-2) * 180;
            return sumOfAngles;
        }
        
    }
       
}
