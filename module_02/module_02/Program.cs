using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module_02
{
    public delegate void WorkPerfomedHandler(int hours, WorkType workType);


    class Program
    {
        static void Main(string[] args)
        {
            WorkPerfomedHandler del1 = new WorkPerfomedHandler(WorkPerformed1);
            WorkPerfomedHandler del2 = new WorkPerfomedHandler(WorkPerformed2);

            //del1(5, WorkType.Golf);
            //del2(10, WorkType.GenerateReports);

            DoWork(del1);

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
    }

    public enum WorkType
    {
        GoToMeetings,
        Golf,
        GenerateReports
    }
}
