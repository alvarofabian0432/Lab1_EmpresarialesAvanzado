using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Procedimientos y funciones";
            string option;
            do
            {
                Console.Clear();
                Console.WriteLine("(1) Suma de dos números");
                Console.WriteLine("(2) Imprimir la raíz cuadrada de los 10 primeros números enteros");
                Console.WriteLine("(3) Imprimir los 10 primeros números primos");
                Console.WriteLine("(4) Convertir Fahrenheit a Celsius");
                Console.WriteLine("(5) Convertir Celsius a Fahrenheit");
                Console.WriteLine("(0) Salir");
                Console.WriteLine("Ingrese una opción y presione ENTER");
                option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        Console.WriteLine("Porfavor ingrese el primer número");
                        int a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Porfavor ingrese el segundo número");
                        int b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La suma de {0} y {1} es {2}", a, b, Suma(a, b));
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.WriteLine("Resolviendo la raíz cuadrada de los 10 primeros números...");
                        Raiz();
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.WriteLine("Imprimiendo los 10 primeros números primos:");
                        Primos();
                        Console.ReadKey();
                        break;
                    case "4":
                        Console.WriteLine("Porfavor ingrese los grados Fahrenheit:");
                        int c = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("{0} grados Fahrenheit son equivalentes a aproximadamente {1} grados Celsius", c, ACelsius(c));
                        Console.ReadKey();
                        break;
                    case "5":
                        Console.WriteLine("Porfavor ingrese los grados Celsius:");
                        int d = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("{0} grados Celsius son equivalentes a aproximadamente {1} grados Fahrenheit", d, AFahrenheit(d));
                        Console.ReadKey();
                        break;
                }
            } while (!option.Equals("0"));

        }


        //Suma de 2 números
        static int Suma(int a, int b)
        {
            return a + b;
        }

        //Resta de 2 números
        static int Resta(int a, int b)
        {
            return a - b;
        }

        //Multiplicacion de 2 números
        static int Multiplicacion(int a, int b)
        {
            return a * b;
        }

        //División de 2 números
        static int Division(int a, int b)
        {
            return a / b;
        }

        static int ACelsius(int a)
        {
            int u = a - 32;
            int d = 5 * u;
            int t = d / 9;
            return t;
        }

        static int AFahrenheit(int a)
        {
            int u = a * 9;
            int d = u / 5;
            int t = d + 32;
            return t;
        }


        //Procedimiento que imprime la raíz cuadrada de los 10 primeros números
        static void Raiz()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("La raíz cuadrada de {0} es: {1}", i, Math.Sqrt(i));
            }
        }

        //Procedimiento que imprime los 10 primeros numeros primos
        static void Primos()
        {
            int contador = 0, cantidad = 0, a = 1, b = 1;
            while (cantidad < 10)
            {
                b = 1;
                contador = 0;
                while (b <= a)
                {
                    if (a % b == 0)
                        contador++;
                    b++;
                }
                if (contador == 2)
                {
                    Console.Write(a);
                    Console.Write(", ");
                    cantidad++;
                }
                a++;
            }
        }

    }
}
