using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceCol
{
    class Program
    {
        static void Main(string[] args)
        {
            //PUNTO 3
            int[] numArray = { 0, 10, 32, 58, 45, 7, 26 };

            (int[] list, int countPair) orderedArray = orderArray(numArray); 

            Console.WriteLine("La cantidad total de números es: {0}, y están ordenados de mayor a menor de la siguiente manera: ", orderedArray.countPair);
            Array.ForEach(numArray, Console.WriteLine);
            Console.ReadLine();
        }

        private static (int[], int) orderArray(int[] numArray)
        {
                       
            Array.Sort(numArray);
            Array.Reverse(numArray);
            int totalCount = numArray.Count();
            return (numArray, totalCount);
        }
    }




}
