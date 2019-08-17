using System;

namespace module_04
{
    class Program
    {
        static void Main()
        {
            var worker = new Worker();
            worker.WorkPerformed += (s, e) =>
            {
                Console.WriteLine($"Hours worked: {e.Hours} {e.WorkType}");
                Console.WriteLine($"Test lambda {e.Hours}"); // Testing opportunities to add multiple lines of code.
            }; 
            worker.WorkCompleted += (s, e) => Console.WriteLine("Worker is done");

            worker.DoWork(4, WorkType.GenerateReports);
        }

        //static void Worker_WorkCompleted(object sender, EventArgs e)
        //{
        //    Console.WriteLine("Worker is done");
        //}

        //static void Worker_WorkPerformed(object sender, WorkPerformedEventArgs e)
        //{
        //    Console.WriteLine($"Hours worked: {e.Hours} {e.WorkType}");
        //}
    }
}
