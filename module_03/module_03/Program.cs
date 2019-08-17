using System;

namespace module_03
{
    class Program
    {
        static void Main()
        {
            //WorkPerformedHandler del1 = new WorkPerformedHandler(WorkPerformed1);
            //WorkPerformedHandler del2 = new WorkPerformedHandler(WorkPerformed2);
            //WorkPerformedHandler del3 = new WorkPerformedHandler(WorkPerformed3);

            //del1(5, WorkType.Golf);
            //del2(10, WorkType.GenerateReports);

            //DoWork(del1);

            //del1 += del2 + del3; // invocation list -> del1, del2, del3 will be printed in that order

            //int finalHours = del1(10, WorkType.GenerateReports);

            var worker = new Worker();
            worker.WorkPerformed += new EventHandler<WorkPerformedEventArgs>(worker_WorkPerformed);
            worker.WorkCompleted += new EventHandler(worker_WorkCompleted);
            worker.DoWork(8, WorkType.GenerateReports);
            //Console.WriteLine(finalHours);
        }

        static void worker_WorkPerformed(object sender, WorkPerformedEventArgs e)
        {
            Console.WriteLine($"Hours worked: {e.Hours} {e.WorkType}");
        }

        static void worker_WorkCompleted(object sender, EventArgs e)
        {
            Console.WriteLine("Worker is done");
        }

        //static void DoWork(WorkPerformedHandler del)
        //{
        //    del(5, WorkType.GoToMeetings);
        //}

        //static int WorkPerformed1(int hours, WorkType workType)
        //{
        //    Console.WriteLine("WorkPerformed1 called " + hours.ToString());
        //    return hours + 1;
        //}

        //static int WorkPerformed2(int hours, WorkType workType)
        //{
        //    Console.WriteLine("WorkPerformed2 called " + hours.ToString());
        //    return hours + 2;
        //}

        //static int WorkPerformed3(int hours, WorkType workType)
        //{
        //    Console.WriteLine("WorkPerformed3 called " + hours.ToString());
        //    return hours + 3;
        //}
    }

    public enum WorkType
    {
        GoToMeetings,
        Golf,
        GenerateReports
    }
}
