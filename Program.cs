using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PP_lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            var cancelTokenSource = new CancellationTokenSource();
            var token = cancelTokenSource.Token; 
            new Task(() =>
            {
                while (!token.IsCancellationRequested)
                {
                    Console.WriteLine("Отмена???");
                    Thread.Sleep(200);
                }
            }).Start();

            Thread.Sleep(1000);
            cancelTokenSource.Cancel();
            Console.WriteLine("Отмена");
            Console.ReadKey();
        }
    }
}