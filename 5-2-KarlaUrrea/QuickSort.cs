using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_2_KarlaUrrea
{
    class QuickSort
    {
        public  QuickSort(){}
     
        

        public void Imprimir(double[] X)// imprime el arreglo ordenado
        {
            for (int i = 0; i < X.Length; i++)//imprime arreglo sin ordenar
            {
                Console.Write(X[i] + ", ");
            }
            quicksort(X, 0, X.Length - 1);//manda llamar funcion quicksort para ordenar
            Console.WriteLine("\nOrdenado");//imprime arreglo ordenado
            for (int j=0; j < X.Length; j++)
            {
                Console.Write("{0} ", X[j]);
            }
            Console.ReadLine();
        }
        public void quicksort(double[]arreglo, int primero, int ultimo)//ordena el arreglo y para eso pide el arreglo, el primer indice y el ultimo
        {
            int i = primero, j = ultimo;

            int indice = (primero+ultimo)/2;//se realiza un indice para utilizar como pivote

            double pivote = arreglo[indice];
            double auxiliar;//variable temporal
            do
            {
                while (arreglo[i] < pivote) { i++; }//recorre arreglo
                while (arreglo[j] > pivote) { j--; }//recorre arreglo

                if (i <= j)//cambia posiciones
                {
                    auxiliar = arreglo[j];
                    arreglo[j] = arreglo[i];
                    arreglo[i] = auxiliar;
                    i++;
                    j--;
                }

            } while (i <= j);

            if (primero < j) { quicksort(arreglo, primero, j); }
            if (ultimo > i) { quicksort(arreglo, i, ultimo); }

        }

        


    }
}
