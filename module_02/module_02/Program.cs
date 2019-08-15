using System;

namespace module_02
{
    public delegate void WorkPerfomedHandler(int hours, WorkType workType);


    class Program
    {
        static void Main()
        {
            WorkPerfomedHandler del1 = new WorkPerfomedHandler(WorkPerformed1);
            WorkPerfomedHandler del2 = new WorkPerfomedHandler(WorkPerformed2);
            WorkPerfomedHandler del3 = new WorkPerfomedHandler(WorkPerformed3);

            //del1(5, WorkType.Golf);
            //del2(10, WorkType.GenerateReports);

            //DoWork(del1);

            del1 += del2 + del3; // invoke list -> del1, del2, del3 will be printed in that order

            del1(10, WorkType.GenerateReports);

            Console.ReadLine();
        }

        static void DoWork(WorkPerfomedHandler del)
        {
            del(5, WorkType.GoToMeetings);
        }

        static void WorkPerformed1(int hours, WorkType workType)
        {
            Console.WriteLine("WorkPerformed1 called " + hours.ToString());
        }

        static void WorkPerformed2(int hours, WorkType workType)
        {
            Console.WriteLine("WorkPerformed2 called " + hours.ToString());
        }

        static void WorkPerformed3(int hours, WorkType workType)
        {
            Console.WriteLine("WorkPerformed3 called " + hours.ToString());
        }
    }

    public enum WorkType
    {
        GoToMeetings,
        Golf,
        GenerateReports
    }
}
