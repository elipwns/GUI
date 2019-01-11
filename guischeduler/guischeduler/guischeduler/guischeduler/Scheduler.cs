using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace GUIScheduler
{
    public delegate void Schedulermessage(string message);

    class Scheduler
    {
        static void noop(string message) { }
        public Schedulermessage sm = noop;
        
        Queue<Job> Highest;
        Queue<Job> AboveNormal;
        Queue<Job> Normal;
        Queue<Job> BelowNormal;
        Queue<Job> Lowest;
        Job Currentjob = null;
        Queue<Job> currentjobqueue = null;
        Queue<Job> DeadItems = new Queue<Job>();
        TimeSpan timeouttime = TimeSpan.FromSeconds(30);
        Thread schedulerthread;
        TimeSpan timespan = TimeSpan.FromSeconds(10); // starve threshold 
        public Scheduler()
        {
            schedulerthread = new Thread(schedule);
            schedulerthread.Priority = ThreadPriority.AboveNormal;
            Highest = new Queue<Job>();
            AboveNormal = new Queue<Job>();
            Normal = new Queue<Job>();
            BelowNormal = new Queue<Job>();
            Lowest = new Queue<Job>();
            schedulerthread.Start();
            Job.CU += CounterUpdater;
        }
        public int AddLocals()
        {
            int x = 0;
            /*foreach( Job j1 in DeadItems)
            {
                if (j1.getinc())
                    x += j1.local;
                else
                    x -= j1.local;
            }*/
            foreach (Job j1 in Highest)
            {
                if (j1.getinc())
                    x += j1.local;
                else
                    x -= j1.local;
            }
            foreach (Job j1 in AboveNormal)
            {
                if (j1.getinc())
                    x += j1.local;
                else
                    x -= j1.local;
            }
            foreach (Job j1 in Normal)
            {
                if (j1.getinc())
                    x += j1.local;
                else
                    x -= j1.local;
            }
            foreach (Job j1 in BelowNormal)
            {
                if (j1.getinc())
                    x += j1.local;
                else
                    x -= j1.local;
            }
            foreach (Job j1 in Lowest)
            {
                if (j1.getinc())
                    x += j1.local;
                else
                    x -= j1.local;
            }
            /*foreach (Job j1 in currentjobqueue)
            {
                x += j1.local;
            }*/
            return x;
        }
        public void Settimeouttime(TimeSpan t1)
        {
            timeouttime = t1;
        }
        void CounterUpdater(string jobname, int local, int global)
        {
            sm(string.Format("{0} = jobname, {1} = local, {2} = global", jobname, local, global));
        }
        bool check4starve(Queue<Job> jobqueue)
        {
            bool ret = false;
            if (jobqueue.Count != 0)
            {
                TimeSpan now = DateTime.Now.Subtract(jobqueue.First().lastran);
                ret = (now > timespan);
                if (ret)
                {
                    currentjobqueue = jobqueue;
                    Currentjob = currentjobqueue.Dequeue();
                }
            }
            return ret;
        }
        bool FindHighest()
        {
            bool ret = false;
            if (Highest.Count != 0)
            {
                ret = true;
                currentjobqueue = Highest;
                Currentjob = currentjobqueue.Dequeue();
            }
            else if (AboveNormal.Count != 0)
            {
                ret = true;
                currentjobqueue = AboveNormal;
                Currentjob = currentjobqueue.Dequeue();
            }
            else if (Normal.Count != 0)
            {
                ret = true;
                currentjobqueue = Normal;
                Currentjob = currentjobqueue.Dequeue();
            }
            else if (BelowNormal.Count != 0)
            {
                ret = true;
                currentjobqueue = BelowNormal;
                Currentjob = currentjobqueue.Dequeue();
            }
            else if (Lowest.Count != 0)
            {
                ret = true;
                currentjobqueue = Lowest;
                Currentjob = currentjobqueue.Dequeue();
            }
            return ret;
        }
        void schedule()
        {
            while (true != false)
            {
                //check for starved
                //if found a job, the current job list to the list that job was found in
                //take job out of referenced list 
                if (check4starve(Highest))
                {
                }
                else if (check4starve(AboveNormal))
                {
                }
                else if (check4starve(Normal))
                {
                }
                else if (check4starve(BelowNormal))
                {
                }
                else if (check4starve(Lowest))
                {
                }
                //if not starved get the next highest priority job
                else if(FindHighest())
                {

                }
                //start it, with blocking
                if (Currentjob != null)
                {
                    if (Currentjob.mythread.IsAlive)
                    {
                        
                        Currentjob.mythread.Priority = ThreadPriority.Normal;
                        Currentjob.lastran = DateTime.Now;
                        Job.ScheduleBlock.Set();
                        Currentjob.JobBlock.Set();
                        
                    }
                   
                }
                //put scheduler to sleep 
                Thread.Sleep(1000);

                if (Currentjob != null)
                {
                    Currentjob.JobBlock.Reset();
                    Job.ScheduleBlock.WaitOne();
                    TimeSpan totalcputime = DateTime.Now.Subtract(Currentjob.lastran);
                    Currentjob.lastran = DateTime.Now;

                    //check if thread is timeed out , if so abort it
                    if (totalcputime > timeouttime)
                    {
                        Currentjob.mythread.Abort();
                        DeadItems.Enqueue(Currentjob);
                    }
                    else
                    {
                        currentjobqueue.Enqueue(Currentjob);
                    }
                    //set refrence back to null
                    currentjobqueue = null;
                    Currentjob = null;
                }


               

                //when scheduler wakes, block job from entering the critical again

                //wait for job to leave critical region 

                //check if job finished 

                //if its alive put back in refrenced que, else put in ded que


                //take a datetime of now to update the jobs last ran time

                
            }
        }
        public void AddTask(int priority, string ID, uint passes, uint timeout,  bool isIncrementer)
        {
            sm(String.Format("{0} has been added", ID));
            Job j1 = new Job((int)passes, ID, isIncrementer);
            switch (priority)
            {
                case 1:
                    Highest.Enqueue(j1);
                    break;
                case 2:
                    AboveNormal.Enqueue(j1);
                    break;
                case 3:
                    Normal.Enqueue(j1);
                    break;
                case 4:
                    BelowNormal.Enqueue(j1);
                    break;
                case 5:
                    Lowest.Enqueue(j1);
                    break;
                default:
                    throw new IndexOutOfRangeException("dun goofed up priority index");

            }
        }
        
        
    }
}
