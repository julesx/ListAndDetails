using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListAndDetails
{
    public enum WorkSessionType { Break, Work }

    public class WorkSessionVm
    {
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public WorkSessionType WorkSessionType { get; set; }

        public WorkSessionVm(string startTime, string endTime, WorkSessionType workSessionType)
        {
            StartTime = startTime;
            EndTime = endTime;
            WorkSessionType = workSessionType;
        }
    }
}
