using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice2_Tp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[10];
            int i, n, p = 0, val;
            Console.Write("\n\nAjouter une nouvelle valeur dans le tableau :\n");
            Console.Write("La taille de tableau : ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("inserer {0} les elements en discendant:\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("ajouter les elements : ");
             val = Convert.ToInt32(Console.ReadLine());
            Console.Write("la liste est :\n ");
            for (i = 0; i < n; i++)
                Console.Write("{0} ", arr1[i]);
            for (i = 0; i < n; i++)
                if (val < arr1[i])
                {
                    p = i;
                    break;
                }
            /* move all data at right side of the array */
            for (i = n; i >= p; i--)
                arr1[i] = arr1[i - 1];
            /* insert value at the proper position */
            arr1[p] = val;

            Console.Write("\n\naprés l insertion de la liste :\n ");
            for (i = 0; i <= n; i++)
                Console.Write("{0} ", arr1[i]);
            Console.Write("\n");
        }
    }
}

