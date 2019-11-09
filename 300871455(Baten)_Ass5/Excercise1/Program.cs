using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise1
{
    class Program
    {
        static void Main(string[] args)
        {
           
                              IEnumerable<int> primes = Enumerable.Range(2, Int32.MaxValue - 1).Where(number =>
                              Enumerable.Range(2, (int)Math.Sqrt(number) - 1)
                              .All(divisor => number % divisor != 0));


                           


            primeOf_10();
            primeOf_100();
            primeOf_500();
            primeOf_1000();
            primeOf_5000();
            primeOf_7500();
            primeOf_10000();
            primeOf_20000();
            primeOf_50000();
            primeOf_100000();
            primeOf_150000();



            void primeOf_10() {

                Console.WriteLine("Checking excution time of 10");
                var stopwatch = Stopwatch.StartNew();

                primes.AsParallel().WithDegreeOfParallelism(4).Take(10)
         .ToList()
         .Select(x => x);

                stopwatch.Stop();
                Console.WriteLine("Parallel " + stopwatch.ElapsedMilliseconds);





                var stopwatchparallel = Stopwatch.StartNew();
                primes
                .Take(10)
             .ToList()
               .Select(x=>x);
                stopwatch.Stop();
                Console.WriteLine("Sequential "+stopwatchparallel.ElapsedMilliseconds);
           
            }

            void primeOf_100()
            {
                Console.WriteLine("Checking excution time of 100");

                var stopwatch = Stopwatch.StartNew();

                primes.AsParallel().WithDegreeOfParallelism(4).Take(100)
         .ToList()
         .Select(x => x);

                stopwatch.Stop();
                Console.WriteLine("parallel " + stopwatch.ElapsedMilliseconds);





                var stopwatchparallel = Stopwatch.StartNew();
                primes
                .Take(100)
             .ToList()
               .Select(x => x);
                stopwatch.Stop();
                Console.WriteLine("Sequential "+stopwatchparallel.ElapsedMilliseconds);

            }

            void primeOf_1000()
            {

                Console.WriteLine("Checking excution time of 1000");
                var stopwatch = Stopwatch.StartNew();

                primes.AsParallel().WithDegreeOfParallelism(4).Take(1000)
         .ToList()
         .Select(x => x);

                stopwatch.Stop();
                Console.WriteLine("parallel " + stopwatch.ElapsedMilliseconds);





                var stopwatchparallel = Stopwatch.StartNew();
                primes
                .Take(1000)
             .ToList()
               .Select(x => x);
                stopwatch.Stop();
                Console.WriteLine("Sequential " + stopwatchparallel.ElapsedMilliseconds);

            }




            void primeOf_500()
            {
                Console.WriteLine("Checking excution time of 500");
                var stopwatch = Stopwatch.StartNew();

                primes.AsParallel().WithDegreeOfParallelism(4).Take(500)
         .ToList()
         .Select(x => x);

                stopwatch.Stop();
                Console.WriteLine("parallel " + stopwatch.ElapsedMilliseconds);





                var stopwatchparallel = Stopwatch.StartNew();
                primes
                .Take(500)
             .ToList()
               .Select(x => x);
                stopwatch.Stop();
                Console.WriteLine("Sequential " + stopwatchparallel.ElapsedMilliseconds);

            }

            void primeOf_5000()
            {
                Console.WriteLine("Checking excution time of 5000");

                var stopwatch = Stopwatch.StartNew();

                primes.AsParallel().WithDegreeOfParallelism(4).Take(5000)
         .ToList()
         .Select(x => x);

                stopwatch.Stop();
                Console.WriteLine("parallel " + stopwatch.ElapsedMilliseconds);





                var stopwatchparallel = Stopwatch.StartNew();
                primes
                .Take(5000)
             .ToList()
               .Select(x => x);
                stopwatch.Stop();
                Console.WriteLine("Sequential " + stopwatchparallel.ElapsedMilliseconds);

            }

            void primeOf_7500()
            {
                Console.WriteLine("Checking excution time of 7500");

                var stopwatch = Stopwatch.StartNew();

                primes.AsParallel().WithDegreeOfParallelism(4).Take(7500)
         .ToList()
         .Select(x => x);

                stopwatch.Stop();
                Console.WriteLine("parallel " + stopwatch.ElapsedMilliseconds);





                var stopwatchparallel = Stopwatch.StartNew();
                primes
                .Take(7500)
             .ToList()
               .Select(x => x);
                stopwatch.Stop();
                Console.WriteLine("Sequential " + stopwatchparallel.ElapsedMilliseconds);

            }






            void primeOf_10000()
            {
                Console.WriteLine("Checking excution time of 10000");

                var stopwatch = Stopwatch.StartNew();

                primes.AsParallel().WithDegreeOfParallelism(4).Take(10000)
         .ToList()
         .Select(x => x);

                stopwatch.Stop();
                Console.WriteLine("parallel " + stopwatch.ElapsedMilliseconds);





                var stopwatchparallel = Stopwatch.StartNew();
                primes
                .Take(10000)
             .ToList()
               .Select(x => x);
                stopwatch.Stop();
                Console.WriteLine("Sequential " + stopwatchparallel.ElapsedMilliseconds);
            }


            void primeOf_20000()
            {
                Console.WriteLine("Checking excution time of 20000");

                var stopwatch = Stopwatch.StartNew();

                primes.AsParallel().WithDegreeOfParallelism(4).Take(20000)
         .ToList()
         .Select(x => x);

                stopwatch.Stop();
                Console.WriteLine("parallel " + stopwatch.ElapsedMilliseconds);





                var stopwatchparallel = Stopwatch.StartNew();
                primes
                .Take(20000)
             .ToList()
               .Select(x => x);
                stopwatch.Stop();
                Console.WriteLine("Sequential " + stopwatchparallel.ElapsedMilliseconds);

            }

            void primeOf_50000()
            {
                Console.WriteLine("Checking excution time of 50000");

                var stopwatch = Stopwatch.StartNew();

                primes.AsParallel().WithDegreeOfParallelism(4).Take(50000)
         .ToList()
         .Select(x => x);

                stopwatch.Stop();
                Console.WriteLine("parallel " + stopwatch.ElapsedMilliseconds);





                var stopwatchparallel = Stopwatch.StartNew();
                primes
                .Take(50000)
             .ToList()
               .Select(x => x);
                stopwatch.Stop();
                Console.WriteLine("Sequential " + stopwatchparallel.ElapsedMilliseconds);

            }


            void primeOf_100000()
            {
                Console.WriteLine("Checking excution time of 100000");
                var stopwatch = Stopwatch.StartNew();

                primes.AsParallel().WithDegreeOfParallelism(4).Take(100000)
         .ToList()
         .Select(x => x);

                stopwatch.Stop();
                Console.WriteLine("parallel " + stopwatch.ElapsedMilliseconds);





                var stopwatchparallel = Stopwatch.StartNew();
                primes
                .Take(100000)
             .ToList()
               .Select(x => x);
                stopwatch.Stop();
                Console.WriteLine("Sequential " + stopwatchparallel.ElapsedMilliseconds);

            }

            void primeOf_150000()
            {
                Console.WriteLine("Checking excution time of 150000");
                var stopwatch = Stopwatch.StartNew();

                primes.AsParallel().WithDegreeOfParallelism(4).Take(150000).ToList()
         
         .Select(x => x);

                stopwatch.Stop();
                Console.WriteLine("parallel " + stopwatch.ElapsedMilliseconds);





                var stopwatchparallel = Stopwatch.StartNew();
                primes
                .Take(150000).ToList()
               .Select(x => x);
                stopwatch.Stop();
                Console.WriteLine("Sequential " + stopwatchparallel.ElapsedMilliseconds);
            }




























            Console.ReadLine();
        }
    }
}
