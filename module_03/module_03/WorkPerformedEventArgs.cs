using System;

namespace module_03
{
    public enum WorkType
    {
        GoToMeetings,
        Golf,
        GenerateReports
    }

    public class WorkPerformedEventArgs : EventArgs
    {
        public WorkPerformedEventArgs(int hours, WorkType workType)
        {
            Hours = hours;
            WorkType = workType;
        }

        public int Hours { get; set; }
        public WorkType WorkType { get; set; }
    }
}
