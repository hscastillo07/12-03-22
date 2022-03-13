using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios12_03_22.Logica
{
    internal class Intermedios
    {

        public int[] A;//Declaramos un vector A
        public int[] B;//Declaramos un vector B
        public int[] C;//Declaramos un vector C
        public void CargarSuma()
        {
            Console.WriteLine("Suma de dos vectores.");
            Console.Write("Ingrese la longitud de los vectores a sumar: ");
            string linea;
            linea = Console.ReadLine();
            int n = int.Parse(linea);
            A = new int[n];
            B = new int[n];
            C = new int[n];

            Console.WriteLine("Ingresando valores al vector A");
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write("Ingrese componente [" + (i + 1) + "]: ");
                linea = Console.ReadLine();
                A[i] = int.Parse(linea);
            }
            Console.WriteLine("Ingresando valores al vector B");
            for (int j = 0; j < B.Length; j++)
            {
                Console.Write("Ingrese componente [" + (j + 1) + "]: ");
                linea = Console.ReadLine();
                B[j] = int.Parse(linea);
                for (int i = 0; i < A.Length; i++)
                {
                    C[i] = A[i] + B[i];
                }
            }
            Console.WriteLine("Resultado: ");
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write(" " + C[i] + " ");
            }
            Console.ReadLine();
        }
        public void CargarResta()
        {
            Console.WriteLine("Resta de dos vectores.");
            Console.Write("Ingrese la longitud de los vectores a sumar: ");
            string linea;
            linea = Console.ReadLine();
            int n = int.Parse(linea);
            A = new int[n];
            B = new int[n];
            C = new int[n];

            Console.WriteLine("Ingresando valores al vector A");
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write("Ingrese componente [" + (i + 1) + "]: ");
                linea = Console.ReadLine();
                A[i] = int.Parse(linea);
            }
            Console.WriteLine("Ingresando valores al vector B");
            for (int j = 0; j < B.Length; j++)
            {
                Console.Write("Ingrese componente [" + (j + 1) + "]: ");
                linea = Console.ReadLine();
                B[j] = int.Parse(linea);
                for (int i = 0; i < A.Length; i++)
                {
                    C[i] = A[i] - B[i];
                }
            }
            Console.WriteLine("Resultado: ");
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write(" " + C[i] + " ");
            }
            Console.ReadLine();
        }
        public void CuadradoCubo()
        {
            Console.WriteLine("\t\t***CUADRADO Y CUBO DE UN VECTOR***");
            Console.WriteLine("Generar cuadrado y cubo de un vector");
            int[] lista = new int[5];

            for (int i = 0; i < lista.Length; i++)
            {
                Console.Write("\nIngrese numero entero posición(" + (i + 1) + "): ");
                lista[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("\nEl vector resultante es: \n[");
            for (int i = 0; i < lista.Length; i++)
            {
                Console.Write(lista[i] + ", ");
            }
            Console.Write("]\n");

            Console.Write("\nEl cuadrado de los elementos del vector son: \n[");
            for (int i = 0; i < lista.Length; i++)
            {
                Console.Write((Math.Pow(lista[i], 2)) + ", ");
            }
            Console.Write("]");

            Console.Write("\n\nEl cubo de los elementos del vector son: \n[");
            for (int i = 0; i < lista.Length; i++)
            {
                Console.Write((Math.Pow(lista[i], 3)) + ", ");
            }
            Console.Write("]");

            Console.Write("\nEjercicio finalizado, presione cualquier tecla para volver: ");
            Console.ReadKey();
        }

        public void OrdenarVector()
        {
            Console.WriteLine("\t\t***ORDENAR VECTOR***");
            Console.WriteLine("Ordenar vector ingresado por teclado");

            int[] lista = new int[5];
            int temp;

            for (int i = 0; i < lista.Length; i++)
            {
                Console.Write("\nIngrese numero entero en posición(" + (i + 1) + "): ");
                lista[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("\nEl vector resultante es: \n[");
            for (int i = 0; i < lista.Length; i++)
            {
                Console.Write(lista[i] + ", ");
            }
            Console.Write("]\n");


            for (int i = 1; i < 5 - 1; i++)
            {
                for (int j = 0; j >= 5 - 1 - i; j++)
                {
                    if (lista[j] > lista[j + 1])
                    {
                        temp = lista[j];
                        lista[j] = lista[j + 1];
                        lista[j + 1] = temp;
                    }
                }

            }

            Console.Write("\nEl vector ordenado es: \n[");
            for (int i = 0; i < lista.Length; i++)
            {
                Console.Write(lista[i] + ", ");
            }
            Console.Write("]\n");

            Console.Write("\nEjercicio finalizado, presione cualquier tecla para volver: ");
            Console.ReadKey();
        }

        public string[] nombres;
        public int[] edades;

        public void MayoresEdad()
        {
            nombres = new string[5];
            edades = new int[5];
            Console.WriteLine("Ingrese los nombres y edades de 5 personas para determinar quienes son mayores de edad.");
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Ingrese nombre " + (i + 1) + ": ");
                nombres[i] = Console.ReadLine();
                Console.Write("Ingrese edad " + (i + 1) + ": ");
                string linea;
                linea = Console.ReadLine();
                edades[i] = int.Parse(linea);
            }
            Console.WriteLine("Personas mayores de edad.");
            for (int j = 0; j < nombres.Length; j++)
            {
                if (edades[j] >= 18)
                {
                    Console.WriteLine(nombres[j]);
                }
            }
            Console.ReadKey();
        }
    }
}
