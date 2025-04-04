﻿using System;
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

        // Display elapsed time in seconds with four decimal places
        Console.WriteLine($"Crono1: {crono1.Elapsed.TotalSeconds:F4} segundos");
        Console.WriteLine($"Crono2: {crono2.Elapsed.TotalSeconds:F4} segundos");
    }
}