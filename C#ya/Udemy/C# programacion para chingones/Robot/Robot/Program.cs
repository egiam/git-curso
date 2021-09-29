using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola soy Hermabot, estoy aqui para hacerte un par de preguntas...");
            Console.WriteLine("\nComo te llamas?");
            string nombre = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Un placer conocerte " + nombre);
            Console.WriteLine("Cuantos años tienes?");

            int edad = int.Parse(Console.ReadLine());

            if (edad >= 18)
            {
                if (edad >= 50)
                {
                    Console.WriteLine("Nunca es tarde para aprender");

                }
                else
                {
                    Console.WriteLine("Un placer tenerte aqui");

                }

            }
            else
            {
                Console.WriteLine("Es genial que estes programando tan joven");

            }

            Console.WriteLine("\nComo estass?");
            string resp3 = Console.ReadLine().ToLower();
            
            if (resp3.Contains("bien"))
            {
                Console.WriteLine("Me alegra mucho que estes bien");

            } 
            else if (resp3.Contains("mal"))
            {
                Console.WriteLine("Puedes acudir a mi para mejorar la situacion");

            }
            else
            {
                Console.WriteLine("Tomare eso como un mas o menos");

            }


        }
    }
}
