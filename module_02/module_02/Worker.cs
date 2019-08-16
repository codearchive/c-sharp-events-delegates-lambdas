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
            for (int i = 0; i < hours; i++)
            {
                OnWorkPerformed(i + 1, workType);
            }

            OnWorkCompleted();
        }

        protected virtual void OnWorkPerformed(int hours, WorkType workType)
        {
            //if (WorkPerformed != null)
            //{
            //    WorkPerformed(hours, workType)
            //}

            var del = WorkPerformed as WorkPerfomedHandler;
            if (del != null)
            {
                del(hours, workType);
            }

        }

        protected virtual void OnWorkCompleted()
        {
            //if (WorkCompleted != null)
            //{
            //    WorkCompleted(hours, workType)
            //}

            var del = WorkCompleted as EventHandler;
            if (del != null)
            {
                del(this, EventArgs.Empty);
            }

        }
    }
}
