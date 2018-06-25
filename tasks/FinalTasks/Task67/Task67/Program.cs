using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Threading;


namespace Task67
{
    class Program
    {
        public static IEnumerable<int> IntegerNumbers()
        {
            int i = 1;
            while (true) yield return i++;
        }

        public static async Task<int> SimpleTest()
        {
            await Task.Delay(500);
            Console.WriteLine("Simple Async-Test");
            return 1;
        }

        static void Main(string[] args)
        {
            //Task 6.1

            var durch2 = new Subject<int>();

            durch2
            .Where(x => x % 2 == 0)
            .StartWith(1000)
            .Subscribe(x => Console.WriteLine($"{x} ist durch 2 teilbar"));

            var t = new Thread(() =>
            {
                var i = 1;
                while (i < 20)
                {
                    Thread.Sleep(150);
                    durch2.OnNext(i);
                    i++;
                }
            });
            t.Start();


            //Task 7.1

            var ys = new[] { 0, 1, 2, 3 };
            var tasks = new List<Task<int>>();

            foreach (var y in ys)
            {
                var task1 = Task.Run(() =>
                {
                    return y + y;
                });

                tasks.Add(task1);
            }

            var task2 = new List<Task<int>>();

            foreach (var task1 in tasks)
            {
                task2.Add(
                    task1.ContinueWith(r => { Console.WriteLine($"The result is {r.Result}"); return r.Result; }));
            }

            var task3 = SimpleTest();
        }
    }
}
