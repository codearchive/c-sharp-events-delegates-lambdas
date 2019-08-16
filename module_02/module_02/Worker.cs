using System;

namespace module_02
{
    //public delegate int WorkPerformedHandler(object sender, WorkPerformedEventArgs e); // Comment #001 - First way to create custom EventArgs.

    public class Worker
    {
        //public event WorkPerformedHandler WorkPerformed; // Comment #001 - First way to create custom EventArgs.
        public event EventHandler<WorkPerformedEventArgs> WorkPerformed;
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

            // var del = WorkPerformed as WorkPerformedHandler; // Comment #001 - First way to create custom EventArgs.
            var del = WorkPerformed as EventHandler<WorkPerformedEventArgs>;
            if (del != null)
            {
                del(this, new WorkPerformedEventArgs(hours, workType));
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
