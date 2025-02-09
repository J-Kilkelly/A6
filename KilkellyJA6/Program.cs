using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;

namespace KilkellyJA6;
//John Kilkelly
//350439
//COP2360
//Assignment 6: SumPolygon

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("To calculate the sum of the internal angles of a polygon, enter a number of sides greater than 2.");
        bool success = int.TryParse(Console.ReadLine(), out int sideCount); 
    
        while (!success || sideCount < 3) //loop to be executed while success is false or sideCount is less than 3
        {
            Console.WriteLine("Input was not valid. Please input the side count as an integer greater than 2.");
            success = int.TryParse(Console.ReadLine(), out sideCount);
        }

        A6 geometry = new A6();
                int sum = geometry.SumPolygon(sideCount);
                Console.WriteLine($"The sum of the internal angles is {sum.ToString()} degrees.");
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
