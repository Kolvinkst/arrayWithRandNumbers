using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayWithRandNumbers
{
    internal class Program
    {
        static Random random = new Random();
        static void Main(string[] args)
        {
            int minValue = 1;
            int maxValue = 100;
            int arraySize = 15;
            int[] randomArray = new int[arraySize];
            int a = 0;
            
            for (int i = 0; i < arraySize; i++)
            {
                randomArray[i] = random.Next(minValue, maxValue + 1);
            }

            for (int j = 0; j < arraySize; j++)
            {
                a += randomArray[j];
            }
            var strOfArr = string.Join(",", randomArray);
            Console.WriteLine("Random array: " + strOfArr);
            Console.WriteLine("Sum of array is: " + a);
            Console.WriteLine("Number less than 45: ");
            for (int k = 0; k < arraySize; k++)
            {
                if (randomArray[k] < 45)
                {
                    Console.Write(randomArray[k] + ", ");
                }
            }
            Console.WriteLine("Press any key to exit");
            Console.ReadKey(true);
            
        }
    }
}
