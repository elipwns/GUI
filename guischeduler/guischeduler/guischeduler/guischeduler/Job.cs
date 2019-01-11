using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace GUIScheduler
{
    public delegate void CounterUpdater(string jobname, int local, int global);
    public class Job
    {
        public static CounterUpdater CU = noop;
        static void noop(string jobname, int local, int global) { }
        static Random rnd = new Random();
        public static int global = 0;
        public static ManualResetEvent ScheduleBlock = new ManualResetEvent(true);
        public ManualResetEvent JobBlock = new ManualResetEvent(true);
        public int local;
        public Thread mythread;
        int max;
        string id;
        bool inc;
        
        public DateTime lastran;
        static TimeSpan interuptinterval = new TimeSpan(0, 0, 0, 0, 125);
        public Job(int max, string id, bool inc)
        {            
            this.inc = inc;
            this.id = id;
            local = 0;
            this.max = max;
            mythread = new Thread(DoJob);
            mythread.Priority = ThreadPriority.Lowest;
            mythread.Start();
        }
        public bool getinc()
        {
            return inc;
        }
        public void DoJob()
        {           
            while (local < max)
            {
                JobBlock.WaitOne();
                JobBlock.Reset();
                ScheduleBlock.WaitOne();
                ScheduleBlock.Reset();
                int preglobal = global;
                int prelocal = local;

                if (rnd.Next() % 2 == 1)
                {
                    DateTime start = DateTime.Now;
                    while (DateTime.Now.Subtract(start) < interuptinterval) ;
                }
                if (inc)
                {
                    global = preglobal + 1;
                    local = prelocal + 1;
                }
                else
                {
                    global = preglobal - 1;
                    local = prelocal + 1;
                }
                if (inc)
                    CU(id, local, global);
                else
                    CU(id, local * -1, global);
                ScheduleBlock.Set();
               // JobBlock.Set();
            }

        }
        
    }
}
