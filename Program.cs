using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace Numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> frutas = new List<string>();
            frutas.Add("Manzana");
            frutas.Add("Banana");
            frutas.Add("Mora");
            frutas.Add("Melon");
            frutas.Add("Sandia");
            frutas.Add("Naranja");
            frutas.Add("Mandarina");
            frutas.Add("Pera");
            frutas.Add("uva");
            frutas.Add("kiwi");
            frutas.Add("Mango");
            frutas.Add("Piña");


            Console.WriteLine("Imprimiendo la lista\n");

            var stopWatch = Stopwatch.StartNew();
            foreach (string fruit in frutas)
            {
                Console.WriteLine("Nombre de Frutas: {0}, hilo Id= {1}",
                    frutas, Thread.CurrentThread.ManagedThreadId);
            }
            Console.WriteLine("tiempo de ejecucion = {0} segundos\n",
                stopWatch.Elapsed.TotalSeconds);
            Console.WriteLine("imprimiendo lista usuando paralelismo");


            stopWatch = Stopwatch.StartNew();
            Parallel.ForEach(frutas, frutas =>
            {
                Console.WriteLine("Nombre de Frutas: {0}, Hilo Id= {1}",
                    frutas, Thread.CurrentThread.ManagedThreadId);

            }
            );
            Console.WriteLine("ForEach() tiempo de ejecucion= {0}" +
                " segundos", stopWatch.Elapsed.TotalSeconds);
            Console.Read();
        }
    }
}
