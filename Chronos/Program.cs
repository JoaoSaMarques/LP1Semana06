using System;
using System.Diagnostics;
using System.Threading;
class Program
{
    static void Main(string[] args)
    {
        Stopwatch crono1 = new Stopwatch();
        Stopwatch crono2 = new Stopwatch();

        // Start timer for crono1 and count 0.5 seconds
        crono1.Start();
        Thread.Sleep(500);

        // Start timer for crono2 and count 0.25 seconds
        crono2.Start();
        Thread.Sleep(250);

        // Stop time for both stopwatches
        crono2.Stop();
        crono1.Stop();

        Stopwatch stopWatch = new Stopwatch();
        stopWatch.Start();
        Thread.Sleep(10000);
        stopWatch.Stop();
        // Get the elapsed time as a TimeSpan value.
        TimeSpan ts = stopWatch.Elapsed;

        // Format and display the TimeSpan value.
        string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts.Hours, ts.Minutes, ts.Seconds,
            ts.Milliseconds / 10);
        Console.WriteLine("RunTime " + elapsedTime);
    }
}