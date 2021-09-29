using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Calc
    {
        private string codigo;
        private int cant;
        private double[] numeros;
        private double suma, rest, mult, div, poten;

        public void init()
        {
            do
            {
                Console.WriteLine("Calculadora. Seleccione la opcion a realizar");
                Console.WriteLine("A. Suma");
                Console.WriteLine("B. Resta");
                Console.WriteLine("C. Multiplicacion");
                Console.WriteLine("D. Division");
                Console.WriteLine("0. Para finalizar");
                codigo = Console.ReadLine();
                codigo = codigo.ToUpper();
                Console.WriteLine("Cantidad de numeros en la operacion: ");
                cant = int.Parse(Console.ReadLine());

                Console.Clear();
                Valores();


                switch (codigo)
                {
                    case "A":
                        Suma();
                        break;

                    case "B":
                        Resta();
                        break;

                    case "C":
                        Mult();
                        break;

                    case "D":
                        Div();
                        break;

                    default:
                        break;
                }

                Console.WriteLine("Toque alguna tecla para continuar.");
                Console.ReadKey();
                Console.Clear();


            } while (codigo != "0");
            
        }


        public void Valores()
        {
            numeros = new double[cant];

            for (int f = 0; f < cant; f++)
            {
                Console.WriteLine("Coloque el numero " + f + ": ");
                numeros[f] = double.Parse(Console.ReadLine());

            }

        }


        public void Suma()
        {
            suma = numeros[0];

            for (int f = 1; f < numeros.Length; f++)
            {
                suma += numeros[f];

            }

            Console.WriteLine("El resultado es: " + suma);

        }


        public void Resta()
        {
            rest = numeros[0];

            for (int f = 1; f < numeros.Length; f++)
            {
                rest -= numeros[f];

            }

            Console.WriteLine("El resultado es: " + rest);

        }


        public void Mult()
        {
            mult = numeros[0];

            for (int f = 1; f < numeros.Length; f++)
            {
                mult *= numeros[f];

            }

            Console.WriteLine("El resultado es: " + mult);

        }


        public void Div()
        {
            div = numeros[0];

            for (int f = 1; f < numeros.Length; f++)
            {
                div /= numeros[f];

            }

            Console.WriteLine("El resultado es: " + div);

        }


    }


    class Program
    {
        static void Main(string[] args)
        {
            Calc c1 = new Calc();
            c1.init();

            Console.ReadKey();

        }
    }
}
