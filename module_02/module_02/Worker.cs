using System;

namespace module_02
{
    public delegate int WorkPerfomedHandler(int hours, WorkType workType);

    public class Worker
    {
        public event WorkPerfomedHandler WorkPerformed;
        public event EventHandler WorkCompleted;

        public void DoWork(int hours, WorkType workType)
        {

        }
    }
}
