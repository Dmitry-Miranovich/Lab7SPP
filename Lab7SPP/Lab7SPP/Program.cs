using System;
using System.Threading;
using System.Threading.Tasks;
using Lab1SPP.Elements;

namespace Lab7SPP
{
    class Program
    {
        static void Main(string[] args)
        {
            CParallel p = new CParallel();
            TaskDelegate[] mas = new TaskDelegate[]
            {
                new TaskDelegate(()=>{ Console.WriteLine("Task 1"); }),
                new TaskDelegate(()=>{ Console.WriteLine("Task 2"); }),
                new TaskDelegate(()=>{ Console.WriteLine("Task 3"); }),
                new TaskDelegate(()=>{ Console.WriteLine("Task 4"); }),
                new TaskDelegate(()=>{ Console.WriteLine("Task 5"); }),
                new TaskDelegate(()=>{ Console.WriteLine("Task 6");
                Thread.Sleep(5000); }),
                new TaskDelegate(()=>{ Console.WriteLine("Task 7"); }),
                new TaskDelegate(()=>{ Console.WriteLine("Task 8"); }),
                new TaskDelegate(()=>{ Console.WriteLine("Task 9"); })
            };

            p.WaitAll(mas);
            Console.WriteLine("Delegates are executed, if this message was printed last, then WaitAll work properly");
            Console.ReadKey();
        }
    }
}
