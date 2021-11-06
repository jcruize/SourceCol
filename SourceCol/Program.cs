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

            //PUNTO 2
            //Se pide número a validar, por defecto se pone 1, aunque se podría validar ingreso del usuario
            Console.WriteLine("Ingrese un entero para validar si cumple con la sucesión de Fibonacci (1 por defecto): ");
            int num = int.TryParse(Console.ReadLine(), out num) ? num : 1;   
            
            string validateFibonacci = isFibonacci(num);
            Console.WriteLine(validateFibonacci);

            Console.ReadLine();


            // PUNTO 1
            // Se pide al usuario la cadena de texto
            Console.WriteLine("Ingrese una cadena de texto: ");
            string completeText = Console.ReadLine();

            // Se solicita la cántidad máxima de caracteres para realizar el recorte, si no se da ningún valor, por defect es 20
            Console.WriteLine("Ingrese una cantidad máxima de caracteres(20 por defecto): ");                    
            int maxChars = int.TryParse(Console.ReadLine(), out maxChars) ? maxChars : 20;

            string trimText = TrimString(completeText, maxChars);
            Console.WriteLine(trimText);


            

            Console.ReadLine();

        }

        private static string TrimString(string completeText, int maxChars)
        {
            return completeText.Length <= maxChars ? completeText : completeText.Substring(0, maxChars) + "...";


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


