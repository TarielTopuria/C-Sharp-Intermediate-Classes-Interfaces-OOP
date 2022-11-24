using System.Diagnostics;

namespace C_Sharp_Intermediate_Classes_Interfaces_OOP
{
    public class StopwatchCalculator
    {
        static readonly Stopwatch StopWatch = new();
        static TimeSpan timespan = new();
        public static void Start()
        {

            StopWatch.Start();
        }

        public static void Stop()
        {
            StopWatch.Stop();
        }

        public static string Value()
        {
            timespan = StopWatch.Elapsed;
            return timespan.ToString();
        }
    }
}