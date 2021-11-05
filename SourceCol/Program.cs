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
            //PUNTO 2
            //Se pide número a validar, por defecto se pone 1, aunque se podría validar ingreso del usuario
            Console.WriteLine("Ingrese un entero para validar si cumple con la sucesión de Fibonacci (1 por defecto): ");
            int num = int.TryParse(Console.ReadLine(), out num) ? num : 1;   
            
            string validateFibonacci = isFibonacci(num);
            Console.WriteLine(validateFibonacci);

            Console.ReadLine();

        }


        private static bool isPerfectSquare(int num)
        {
            
            double sq1 = Math.Sqrt(num);
            int sq2 = (int)Math.Sqrt(num);

            if (sq1 == sq2)
                return true;
            return false;

        }

        private static string isFibonacci(int num)
        {
            bool perfectSquare1 = isPerfectSquare(5 * num * num + 4);
            bool perfectSquare2 = isPerfectSquare(5 * num * num - 4);

            return perfectSquare1 || perfectSquare2  == true ? "Cumple con la sucesión de Fibonacci" : "No Cumple con la sucesión de Fibonacci";
           
        }

        
    }
}
