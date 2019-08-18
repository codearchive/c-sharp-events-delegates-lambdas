using System;

namespace module_04
{
    public delegate int BizRulesDelegate(int x, int y);

    class Program
    {
        static void Main()
        {
            BizRulesDelegate addDel = (x, y) => x + y;
            BizRulesDelegate multiplyDel = (x, y) => x * y;

            var data = new ProcessData();
            data.Process(2, 3, multiplyDel);

            Action<int, int> myAction = (x, y) => Console.WriteLine(x + y);
            Action<int, int> myMultiplyAction = (x, y) => Console.WriteLine(x * y);
            data.ProcessAction(5, 7, myMultiplyAction);

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
