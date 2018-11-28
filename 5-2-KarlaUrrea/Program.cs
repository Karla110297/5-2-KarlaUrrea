using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_2_KarlaUrrea
{
    class Program
    {
        static void Main(string[] args)
        {
            //arreglos a ordenar
            double[] A = { 11, 2, 3, 14, 18, 45, -3, -1, 6, 9 };
            double[] B = { 1, 3, 5, 7, 8, 3, 9, .7071, 16.5664, 12, 0, 10 };
            double[] C = { 3, 7, 15, 4.0/3.0, 155, 100, 15, Math.Sqrt(3), 5, 2, 3, 2 };//se uso la clase math para poder hacer la raiz y se tuvo que agregar decimales a la division
            double[] D = { 8, 19, 7, 3, 15, 23, 34, 27, 89, 101 };

            QuickSort qs = new QuickSort();//crea la clase            

            qs.Imprimir(A);//manda imprimir elementos de arreglo A
            Console.WriteLine();

            qs.Imprimir(B);//manda imprimir elementos de arreglo B
            Console.WriteLine()

            qs.Imprimir(C);//manda imprimir elementos de arreglo C
            Console.WriteLine();

            qs.Imprimir(D);//manda imprimir elementos de arreglo D



            Console.ReadLine();
            Console.ReadKey();
        }
    }
}
