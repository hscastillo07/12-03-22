using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios12_03_22.Logica
{
    internal class Dificiles
    {
        int[,] matriz = new int[3, 3];


        public void diagonal()
        {
            Console.WriteLine("Digite los datos de una matriz para obtener los valores de su diagonal superior.");
            Console.WriteLine("Datos de la matriz:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.SetCursorPosition(22 + (j * 4), 7 + (i * 2)); matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("diagonal");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (i <= j)
                    {
                        Console.SetCursorPosition(45 + (j * 4), 7 + (i * 2)); Console.Write(matriz[i, j]);
                    }
                }
            }
            Console.ReadKey();
        }



        private int[,] serie;
        public void CargarSerie()
        {
            Console.WriteLine("Matriz fija de 6x5 de ceros y unos.");
            serie = new int[10, 10];
            for (int i = 1; i <= 6; i++)
            {
                for (int j = 1; j <= 6; j++)
                {
                    if (j % 2 == 0)
                    {
                        serie[i, j] = 0;
                    }
                    else
                    {
                        serie[i, j] = 1;
                    }
                }
            }
            for (int i = 1; i <= 5; i++)
            {
                Console.Write("\n");
                for (int j = 1; j <= 6; j++)
                {
                    Console.Write(serie[i, j] + " ");
                }
            }
            Console.ReadKey();
        }
        public void SumaColumnas()
        {
            int[,] matriz = new int[3, 3];
            int[] sum = new int[3];
            int temp = 0; int azar;
            Random num = new Random();

            Console.WriteLine("\t\t**SUMA DE COLUMNAS DE UNA MATRIZ**");
            Console.WriteLine("Se suman las columnas de una matriz 3x3 con datos aleatorios\n");

            for (int i = 0; i < 3; i++)
            {
                temp = 0;
                for (int j = 0; j < 3; j++)
                {
                    azar = num.Next(0, 10);
                    matriz[i, j] = azar;
                    temp += matriz[i, j];
                }
                sum[i] = temp;
            }

            for (int i = 0; i < 3; i++)
            {
                Console.Write("\t[");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.Write("]\n");
            }

            Console.WriteLine("\nLa matriz resultante de la suma de las columnas es: ");
            Console.Write("\n\t[");
            for (int i = 0; i < 3; i++)
            {
                Console.Write(sum[i] + " ");
            }
            Console.Write("]\n");
            Console.Write("\nEjercicio finalizado, presione cualquier tecla para volver: ");
            Console.ReadKey();

        }
        public void Multiplicar()
        {
            Console.WriteLine("Determine el tamaño de dos matrices, después digite los valores\n" +
                "correspondientes para cada indice de cada matriz para realizar una multiplicación");
            Console.WriteLine("Matriz A.");
            Console.Write("Inserte el Nº de Filas: ");
            int fila1 = int.Parse(Console.ReadLine());
            Console.Write("Inserte el Nº de Columnas: ");
            int columna1 = int.Parse(Console.ReadLine());                                                  
            Console.WriteLine("\nMatriz B.");
            Console.Write("Inserte el Nº de Filas: ");
            int fila2 = int.Parse(Console.ReadLine());
            Console.Write("Inserte el Nº de Columnas: ");
            int columna2 = int.Parse(Console.ReadLine());

            int[,] Matriz1 = new int[fila1 + 1, columna1 + 1];
            int[,] Matriz2 = new int[fila2 + 1, columna2 + 1]; 
            int[,] Multiplicacion = new int[fila1 + 1, columna2 + 1];

            if (columna1 == fila2)
            {
      
                Console.WriteLine(" \n Datos [Matriz 1]: ");
                for (int i = 1; i <= fila1; i++)
                {
                    for (int j = 1; j <= columna1; j++)
                    {
                        Console.Write("Ingresa Dato (Fila: {0} - Columna: {1}): ", i, j); Matriz1[i, j] = int.Parse(Console.ReadLine());
                    }
                } 
                Console.WriteLine("Datos [Matriz 2]: ");
                for (int i = 1; i <= fila2; i++)
                {
                    for (int j = 1; j <= columna2; j++)
                    {
                        Console.Write("Ingresa Dato (Fila: {0} - Columna: {1}): ", i, j);
                        Matriz2[i, j] = int.Parse(Console.ReadLine());
                    }
                } 
                for (int i = 1; i <= fila1; i++)
                {
                    for (int j = 1; j <= columna2; j++)
                    {
                        Multiplicacion[i, j] = 0;
                        for (int z = 1; z <= columna1; z++)
                        {
                            Multiplicacion[i, j] = Matriz1[i, z] * Matriz2[z, j] + Multiplicacion[i, j];
                        }
                    }
                }
                Console.WriteLine("Multiplicacion de 2 Matrices");
                for (int i = 1; i <= fila1; i++)
                {
                    for (int j = 1; j <= columna2; j++)
                    {
                        Console.Write("{0} ", Multiplicacion[i, j]);
                        //Muestra el resultado total
                    }
                    Console.WriteLine(); //Si la columna de la matriz 1 no es igual al numero de filas de la matriz 2 no se puede multiplicar
                }
            }
            else
            {
                Console.WriteLine("Error: No se puede multiplicar las matrices" + " Columnas: {0}! = Filas: {1}", columna1, fila2);
            }
            Console.Read();
        }
        public void PromedioMatriz()
        {
            Console.WriteLine("\t\t***PROMEDIO MATRIZ***");
            Console.WriteLine("Calculamos promedio de una matriz 5x5 generada aleatoriamente\n");

            int[,] matriz = new int[5, 5];
            Random num = new Random();
            int azar;
            float sum = 0;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    azar = num.Next(0, 10);
                    matriz[i, j] = azar;
                    sum += matriz[i, j];
                }
            }

            for (int i = 0; i < 5; i++)
            {
                Console.Write("\t[");
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(matriz[i, j] + " ");

                }
                Console.Write("]\n");
            }
            double prom = sum / 25;
            Console.WriteLine("\nLa suma de todos los elementos es: " + sum);
            Console.WriteLine("El promedio es: " + prom);
            Console.Write("\nEjercicio finalizado, presione cualquier tecla para volver: ");
            Console.ReadKey();
        }

    }
}
