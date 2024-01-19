using System;
using System.Diagnostics;

namespace TraceDemo
{
    public class TraceExample
    {
        public static void RunLengthyMethod()
        {
            var stopWatch = Stopwatch.StartNew();
            Trace.WriteLine($"{DateTime.Now} - RunLengthyMethod Start.");
            for (var i = 0; i < 10; i++)
            {
                WaitForMe(i);
                Trace.WriteLine($"{stopWatch.Elapsed} - WaitForMe({i}).");
            }
            stopWatch.Stop();
            Trace.WriteLine($"{stopWatch.Elapsed} - RunLengthyMethod Duration.");
            Trace.WriteLine($"{DateTime.Now} - RunLengthyMethod End.");
            Console.WriteLine("The END");
        }

        private static void WaitForMe(double duration)
        {
            var currentTime = DateTime.Now;
            while (DateTime.Now < currentTime.Add(TimeSpan.FromSeconds(duration)))
            {
                var x = 0;
                x = x + 1;
            }
            Console.WriteLine($"Thanks for waiting {duration} seconds again.");
        }
    }
}