using System;
using System.Collections.Generic;
using System.Linq;

namespace module_04
{
    public delegate int BizRulesDelegate(int x, int y);

    class Program
    {
        static void Main()
        {
            // Unit [4.1, 4.8]

            //BizRulesDelegate addDel = (x, y) => x + y;
            //BizRulesDelegate multiplyDel = (x, y) => x * y;

            //var data = new ProcessData();
            //data.Process(2, 3, multiplyDel);

            //// Action<T>

            //Action<int, int> myAction = (x, y) => Console.WriteLine(x + y);
            //Action<int, int> myMultiplyAction = (x, y) => Console.WriteLine(x * y);
            //data.ProcessAction(5, 7, myMultiplyAction);

            //// Func<T, TRes>

            //Func<int, int, int> funcAddDel = (x, y) => x + y;
            //Func<int, int, int> funcMultiplyDel = (x, y) => x * y;
            //data.ProcessFunc(2, 3, funcAddDel);

            var custs = new List<Customer>
            {
                new Customer { City = "Phoenix", FirstName = "John", LastName = "Doe", ID = 1},
                new Customer { City = "Phoenix", FirstName = "Jane", LastName = "Doe", ID = 500},
                new Customer { City = "Seattle", FirstName = "Suki", LastName = "Pizzoro", ID = 3},
                new Customer { City = "New York City", FirstName = "Michelle", LastName = "Smith", ID = 4},
            };

            var phxCusts = custs
                .Where(c => c.City == "Phoenix" && c.ID < 500)
                .OrderBy(c => c.FirstName);

            foreach (var cust in phxCusts)
            {
                Console.WriteLine($"{cust.FirstName}, {cust.LastName}");
            }

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
