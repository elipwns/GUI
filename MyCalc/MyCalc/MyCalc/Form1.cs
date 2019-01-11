using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCalc
{
    public partial class Form1 : Form
    {
        calcmem mem;
        pstring ps;
        public Form1()
        {
            mem = new calcmem();
            ps = new pstring();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ps.push(2);
            textBox1.Text += "2";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void MC_Click(object sender, EventArgs e)
        {
            mem.Clear();
            memview.Text = mem.Getmem().ToString();
        }

        private void MR_Click(object sender, EventArgs e)
        {
            textBox1.Text = mem.Getmem().ToString();
            if (ps.Getoperator() == ' ')
            {
                ps.Setnum1(mem.Getmem());
            }
            else
            {
                ps.Setnum2(mem.Getmem());
            }
        }

        private void MS_Click(object sender, EventArgs e)
        {
            if (ps.Getoperator() == ' ')
            {
                //remember 1st num
                mem.Setmem(ps.Getnumber1());
                ps.Setnum1(0);
                memview.Text = mem.Getmem().ToString();
            }
            else
            {
                //remember 2nd num
                mem.Setmem(ps.Getnumber2());
                ps.Setnum2(0);
                memview.Text = mem.Getmem().ToString();
            }

        }

        private void Memplus_Click(object sender, EventArgs e)
        {

        }

        private void Memminus_Click(object sender, EventArgs e)
        {

        }

        private void backspace_Click(object sender, EventArgs e)
        {
            string text = "";
            for (int i = 0; i < textBox1.Text.Length - 1; i++)
            {
                text += textBox1.Text[i];
            }
            textBox1.Text = text;

            //needs to actually delete numbers not just not show them
            ps.delete();
        }

        private void CE_Click(object sender, EventArgs e)
        {
            //should only clear the number you are currently entering 
            //needs fixing
            textBox1.Clear();
            leftTest.Clear();
            RightTest.Clear();
            operatorTest.Clear();
        }

        private void E_Click(object sender, EventArgs e)
        {
            //clears everything
            textBox1.Clear();
            leftTest.Clear();
            RightTest.Clear();
            operatorTest.Clear();
        }

        private void SignSwitch_Click(object sender, EventArgs e)
        {
            ps.push('~');
            textBox1.Text += '~';
        }

        private void leftparen_Click(object sender, EventArgs e)
        {

        }

        private void rightparen_Click(object sender, EventArgs e)
        {

        }

        private void sqrt_Click(object sender, EventArgs e)
        {

        }

        private void percentbutton_Click(object sender, EventArgs e)
        {

        }

        private void div_Click(object sender, EventArgs e)
        {
            textBox1.Text += '/';
            ps.push('/');
        }

        private void num9_Click(object sender, EventArgs e)
        {
            ps.push(9);
            textBox1.Text += '9';
        }

        private void num8_Click(object sender, EventArgs e)
        {
            ps.push(8);
            textBox1.Text += '8';
        }

        private void num7_Click(object sender, EventArgs e)
        {
            ps.push(7);
            textBox1.Text += '7';
        }

        private void num4_Click(object sender, EventArgs e)
        {
            ps.push(4);
            textBox1.Text += '4';
        }

        private void num5_Click(object sender, EventArgs e)
        {
            ps.push(5);
            textBox1.Text += '5';
        }

        private void num6_Click(object sender, EventArgs e)
        {
            ps.push(6);
            textBox1.Text += '6';
        }

        private void mult_Click(object sender, EventArgs e)
        {
            ps.push('*');
            textBox1.Text += '*';
        }

        private void oneoverbutton_Click(object sender, EventArgs e)
        {

        }

        private void butequal_Click(object sender, EventArgs e)
        {
            leftTest.Text = ps.Getnumber1().ToString();
            RightTest.Text = ps.Getnumber2().ToString();
            operatorTest.Text = ps.Getoperator().ToString();
            textBox1.Text = ps.compute(ps.Getnumber1(), ps.Getnumber2(), ps.Getoperator()).ToString();
        }

        private void sub_Click(object sender, EventArgs e)
        {
            ps.push('-');
            textBox1.Text += '-';
        }

        private void plus_Click(object sender, EventArgs e)
        {
            ps.push('+');
            textBox1.Text += '+';
        }

        private void num3_Click(object sender, EventArgs e)
        {
            ps.push(3);
            textBox1.Text += '3';
        }

        private void butdot_Click(object sender, EventArgs e)
        {
            ps.push('.');
            textBox1.Text += '.';

        }

        private void num0_Click(object sender, EventArgs e)
        {
            ps.push(0);
            textBox1.Text += '0';
        }

        private void num1_Click(object sender, EventArgs e)
        {
            ps.push(1);
            textBox1.Text += '1';
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void operatorTest_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
