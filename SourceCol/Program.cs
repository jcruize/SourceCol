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
    }
}


