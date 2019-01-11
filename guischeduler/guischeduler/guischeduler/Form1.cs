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
        bool wrapup;
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
            s1.AddTask(priority, string.Format("task {0}", ++tasks),500 , 10, checkBox1.Checked);
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
    }
}
