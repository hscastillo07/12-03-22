using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios12_03_22.Logica
{
    internal class Faciles
    {
        public void Circunferencia()
        {
            double pi = 3.1416;
            Console.WriteLine("\t\t***CIRCUNFERENCIA***");
            Console.WriteLine("Calcular perímetro y área de una circunferencia");

            Console.Write("\nIngrese el radio: ");
            double r = double.Parse(Console.ReadLine()); //Radio

            double p = (2 * pi * r); //Perímetro
            double a = (pi * r * r); //Area

            Console.WriteLine("\nEl area es: " + a + "\nEl perímetro es: " + p);
            Console.Write("\nEjercicio finalizado, presione cualquier tecla para volver: ");
            Console.ReadKey();
        }

        public void PosivNegav()
        {
            Console.WriteLine("\t\t***SUMA POSITIVA O NEGATIVA***");
            Console.WriteLine("Determinar si el resultado de la suma es positivo o negativo");

            Console.Write("\nIngrese un número entero: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro número entero: ");
            int b = int.Parse(Console.ReadLine());

            int c = a + b;

            if (c < 0)
            {
                Console.WriteLine(c + " es negativo.");
            }
            else if (c > 0)
            {
                Console.WriteLine(c + " es positivo.");
            }
            else
            {
                Console.WriteLine("\nEl resultado es 0");
            }
            Console.Write("\nEjercicio finalizado, presione cualquier tecla para volver: ");
            Console.ReadKey();
        }

        public void Conversor()
        {
            Console.WriteLine("\t\t***CONVERSOR DE DOLAR A PESO***");
            Console.WriteLine("Convertir de dolar estadounidense a peso colombiano");
            Console.WriteLine("El dólar tiene un valor de $3.800 cop");
            Console.Write("\n\nIngrese cuántos dólares va a convertir: ");
            int us = int.Parse(Console.ReadLine());

            int cop = us * 3800;

            Console.WriteLine("\n$" + us + "US equivale a $" + cop + "COP.");
            Console.Write("\nEjercicio finalizado, presione cualquier tecla para volver: ");
            Console.ReadKey();
        }

        public void MayorDe()
        {
            int n1, n2, n3;
            Console.WriteLine("\t\t***MAYOR DE TRES NÚMEROS***");
            Console.WriteLine("Determinar cuál número es mayor, menor o si son iguales");

            Console.Write("\nIngrese un número entero: ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese otro número: ");
            n2 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese un último número: ");
            n3 = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            if (n1 > n2 && n1 > n3)
                Console.WriteLine(n1 + " es el mayor de los tres números");
            else if (n2 > n1 && n2 > n3)
                Console.WriteLine(n2 + " es el mayor de los tres números");
            else if (n3 > n1 && n3 > n2)
                Console.WriteLine(n3 + " es el mayor de los tres números");
            else
                Console.WriteLine("Los números son iguales");

            Console.Write("\nEjercicio finalizado, presione cualquier tecla para volver: ");
            Console.ReadKey();
        }

        public void EdadMadre()
        {
            Console.WriteLine("\t\t***EDAD DE UNA MADRE CUANDO DIÓ A LUZ***");
            Console.WriteLine("Calcular la edad que tuvo una madre cuando dió a luz un hijo");

            Console.Write("\nIngresa la edad de tu madre: ");
            int edadM = int.Parse(Console.ReadLine());
            Console.Write("\nIngresa tu edad: ");
            int edadH = int.Parse(Console.ReadLine());

            int edadL = edadM - edadH;

            Console.WriteLine("Tu madre te tuvo a los " + edadL + " aproximadamente");

            Console.Write("\nEjercicio finalizado, presione cualquier tecla para volver: ");
            Console.ReadKey();
        }
    }
}
