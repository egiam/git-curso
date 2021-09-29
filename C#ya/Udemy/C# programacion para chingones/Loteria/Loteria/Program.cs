using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loteria
{
    class Program
    {
        static void Main(string[] args)
        {
            //Juego de loteria

            int[] mis_numeros = new int[6]; 
            int[] numeros_aleatorios = new int[6];

            for (int cont = 0; cont < mis_numeros.Length; cont++)
            {
                int num;
                string txtnum;
                bool esNum;

                do
                {
                    int numA = cont + 1;
                    Console.WriteLine("Ingresa tu " + numA + "° numero que sea entre 1 y 50");
                    txtnum = Console.ReadLine();
                    esNum = int.TryParse(txtnum, out num);

                } while (esNum == false || num < 1 || num > 50);

                mis_numeros[cont] = num;

            }


            for (int cont = 0; cont < numeros_aleatorios.Length; cont++)
            { 
                Random random = new Random();
                int num_aleatorio = random.Next(1, 51);

                numeros_aleatorios[cont] = num_aleatorio;

            }

            //Random r1 = new Random();
            //Random r2 = new Random();
            //Random r3 = new Random();
            //Random r4 = new Random();
            //Random r5 = new Random();
            //Random r6 = new Random();

            //numeros_aleatorios[0] = r1.Next(1, 51);
            //numeros_aleatorios[1] = r2.Next(1, 51);
            //numeros_aleatorios[2] = r3.Next(1, 51);
            //numeros_aleatorios[3] = r4.Next(1, 51);
            //numeros_aleatorios[4] = r5.Next(1, 51);
            //numeros_aleatorios[5] = r6.Next(1, 51);


            int contador_num_igual = 0;

            for (int cont = 0; cont < numeros_aleatorios.Length; cont++)
            {
                if (mis_numeros[cont] == numeros_aleatorios[cont])
                {
                    contador_num_igual += 1;

                }

            }

            Console.Clear();

            Console.WriteLine("Tus numeros con los que jugaste son: ");

            for(int cont=0; cont < mis_numeros.Length; cont++)
            {
                Console.WriteLine(mis_numeros[cont] + " ");

            }

            Console.WriteLine("\nLos numeros ganadores de la loteria son: ");

            for (int cont = 0; cont < numeros_aleatorios.Length; cont++)
            {
                Console.WriteLine(numeros_aleatorios[cont] + " ");

            }

            Console.WriteLine("\nCoincidiste en " + contador_num_igual + " numeros.");

            switch (contador_num_igual)
            {
                case 6:
                    Console.WriteLine("Eres el ganador del primer premio por $2.000.000 de pesos!!");
                    break;

                case 5:
                    Console.WriteLine("Eres el ganador del segundo premio por $1.000.000 de pesos!!");
                    break;

                case 4:
                    Console.WriteLine("Eres el ganador del tercer premio por $500.000 de pesos!!");
                    break;

                default:
                    Console.WriteLine("No ganaste la loteria");
                    break;
            }

            Console.ReadKey();


        }
    }
}
