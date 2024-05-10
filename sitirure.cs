using System;
using System.Threading;

class Program
{
    static void Main()
    {
        // Create a new thread (this will call the RunThread method)
        Thread newThread = new Thread(new ThreadStart(RunThread));

        // Start the thread
        newThread.Start();

        // Optionally, join the thread to wait for it to finish
        newThread.Join();

        Console.WriteLine("Main thread has finished executing.");
    }

    // This method will be run on the new thread
    static void RunThread()
    {
        Console.WriteLine("Thread is running.");
        // Perform thread tasks here
    }
}
