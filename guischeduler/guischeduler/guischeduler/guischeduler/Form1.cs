using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace GUIScheduler
{
    public partial class Form1 : Form
    {
        Scheduler s1;
        int tasks = 0;
        public Form1()
        {
            InitializeComponent();
            s1 = new Scheduler();
            
        }

        private void textboxGlobalCounter_TextChanged(object sender, EventArgs e)
        {

        }
        private void AddTask(int priority)
        {
            s1.AddTask(priority, string.Format("task {0}", ++tasks),10 , 10, checkBox1.Checked);
        }
        private void buttonAddHighest_Click(object sender, EventArgs e)
        {
            AddTask(1);
        }

        private void buttonAddAboveNormal_Click(object sender, EventArgs e)
        {
            AddTask(2);
        }

        private void buttonAddNormal_Click(object sender, EventArgs e)
        {
            AddTask(3);
        }

        private void buttonAddBelowNormal_Click(object sender, EventArgs e)
        {
            AddTask(4);
        }

        private void buttonAddLowest_Click(object sender, EventArgs e)
        {
            AddTask(5);
        }

        private void textboxLocalCounter_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonWrapUp_Click(object sender, EventArgs e)
        {
            buttonAddAboveNormal.Enabled = false;
            buttonAddBelowNormal.Enabled = false;
            buttonAddHighest.Enabled = false;
            buttonAddLowest.Enabled = false;
            buttonAddNormal.Enabled = false;
            textboxGlobalCounter.Text = Job.global.ToString();
            textboxLocalCounter.Text = s1.AddLocals().ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            s1.sm += logg;
            Thread.CurrentThread.Priority = ThreadPriority.Highest;
        }
        private void logg(string message)
        {
            try
            {
                this.Invoke((MethodInvoker)delegate
                {
                    loggerTextBox.Text = message + Environment.NewLine + loggerTextBox.Text;
                }
                );
            }
            catch (Exception)
            {
            }
        }

        private void FinishJobBy_TextChanged(object sender, EventArgs e)
        {
            s1.Settimeouttime(new TimeSpan(0, 0, 0, Convert.ToInt32(FinishJobBy.Text.ToString())));
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
