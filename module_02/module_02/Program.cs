using System;

namespace module_02
{
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

            del1 += del2 + del3; // invocation list -> del1, del2, del3 will be printed in that order

            int finalHours = del1(10, WorkType.GenerateReports);

            Console.WriteLine(finalHours);
        }

        static void DoWork(WorkPerfomedHandler del)
        {
            del(5, WorkType.GoToMeetings);
        }

        static int WorkPerformed1(int hours, WorkType workType)
        {
            Console.WriteLine("WorkPerformed1 called " + hours.ToString());
            return hours + 1;
        }

        static int WorkPerformed2(int hours, WorkType workType)
        {
            Console.WriteLine("WorkPerformed2 called " + hours.ToString());
            return hours + 2;
        }

        static int WorkPerformed3(int hours, WorkType workType)
        {
            Console.WriteLine("WorkPerformed3 called " + hours.ToString());
            return hours + 3;
        }
    }

    public enum WorkType
    {
        GoToMeetings,
        Golf,
        GenerateReports
    }
}
