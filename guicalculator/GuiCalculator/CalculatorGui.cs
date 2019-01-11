using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Numerics;
using CalcultorDll;
namespace GuiCalculator
{
    public partial class CalculatorGui : Form
    {
        //private Calculator mCalculator;
        public String Equation
        {
            get { return EquationTextBox.Text; }
            set
            {
                EquationTextBox.Text = value;
            }
        }
        Double Memory;
        Boolean computed = false;
        Double Sign;
        Double mEntry;
        public Double Entry
        {
            get { return Sign * mEntry; }
            set
            {
                mEntry = Math.Abs(value);
                Sign = (value < 0.0) ? -1.0 : 1.0;
                NumberTextBox.Text = Entry.ToString();
            }
        }

        void addEntryToEqu()
        {
            Equation += (Entry).ToString();
            Entry = 0.0;
        }
        public CalculatorGui()
        {
            //mCalculator = new Calculator();
            Memory = 0.0;
            Sign = 1.0;
            mEntry = 0.0;
            InitializeComponent();
        }
        Boolean EntryHasDecimal()
        {
            return NumberTextBox.Text.Contains(".");
        }
        void Clear()
        {
            Equation = String.Empty;
            EquationTextBox.Text = String.Empty;
            ClearEntry();
        }
        void ClearEntry()
        {
            Sign = 1.0;
            Entry = 0.0;
            NumberTextBox.Text = "0";
        }
        private void CalculatorGui_Load(object sender, EventArgs e)
        {

        }

        private void BackspaceButton_Click(object sender, EventArgs e)
        {
            String entryString = NumberTextBox.Text;
            int length = entryString.Length;
            int cmpLength = length;
            String Default = "0";
            if(Entry < 0.0)
            {
                --cmpLength;
                Default = "-0";
            }

            if (cmpLength <= 1)
            {
                entryString = Default;
            }
            else
            {
                entryString = entryString.Substring(0, length - 1);
            }
            Entry = Convert.ToDouble(entryString);
            NumberTextBox.Text = entryString;
        }

        private void ClearEntryButton_Click(object sender, EventArgs e)
        {
            ClearEntry();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            Clear();
            EquationTextBox.BackColor = Color.White;
            computed = false;
        }

        private void MemoryClearButton_Click(object sender, EventArgs e)
        {
            Memory = 0.0;
        }

        private void MemoryRecallButton_Click(object sender, EventArgs e)
        {
            Entry = Memory;
        }

        private void MemoryStoreButton_Click(object sender, EventArgs e)
        {
            Memory = Entry;
        }

        private void MemoryAddButton_Click(object sender, EventArgs e)
        {
            Memory += Entry;

        }
        private void Number0Button_Click(object sender, EventArgs e)
        {
            insertKey('0');
        }
        private void Number1Button_Click(object sender, EventArgs e)
        {
            insertKey('1');
        }
        private void Number2Button_Click(object sender, EventArgs e)
        {
            insertKey('2');
        }
        private void Number3Button_Click(object sender, EventArgs e)
        {
            insertKey('3');
        }
        private void Number4Button_Click(object sender, EventArgs e)
        {
            insertKey('4');
        }
        private void Number5Button_Click(object sender, EventArgs e)
        {
            insertKey('5');
        }
        private void Number6Button_Click(object sender, EventArgs e)
        {
            insertKey('6');
        }
        private void Number7Button_Click(object sender, EventArgs e)
        {
            insertKey('7');
        }

        private void Number8Button_Click(object sender, EventArgs e)
        {
            insertKey('8');
        }
        
        private void Number9Button_Click(object sender, EventArgs e)
        {
            insertKey('9');
        }

        private void SignButton_Click(object sender, EventArgs e)
        {
            changeSign();
        }

        private void DecimalButton_Click(object sender, EventArgs e)
        {
            insertKey('.');
        }

        private void changeSign()
        {
            Sign *= (-1.0);
            NumberTextBox.Text = (Entry).ToString();
        }
        //inserts a chatacter into the Number Text box if it is valid.
        private void insertKey(char key)
        {
            if (isDigitKey(key))
            {
                if (computed)
                {
                    Clear();
                    computed = false;
                }
                if (Entry == 0 && EntryHasDecimal() == false)
                {
                    NumberTextBox.Text = String.Empty;
                    NumberTextBox.Text += key;
                }
                else
                {
                    NumberTextBox.Text += key;
                }
                NumberTextBox.Text = (Math.Abs(Convert.ToDouble(NumberTextBox.Text)) * Sign).ToString();
                Entry = (Double)Convert.ToDouble(NumberTextBox.Text);
            }
            else if (key == '.' && EntryHasDecimal() == false)
            {
                if (computed)
                    Clear();
                NumberTextBox.Text += key;
            }
        }
        private Boolean isDigitKey(Char key)
        {
            return (key >= '0' && key <= '9');
        }
        private void KeyControl(object sender, KeyPressEventArgs e)
        {
            insertKey(e.KeyChar);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (computed)
                Equation = String.Empty;
            if(Equation.Length == 0 || Equation.Last() != ')')
                addEntryToEqu();
            Equation +=" + ";
            ClearEntry();
            computed = false;
        }

        private void SubtractButton_Click(object sender, EventArgs e)
        {
            if (computed)
                Equation = String.Empty;
            if (Equation.Length == 0 || Equation.Last() != ')')
                addEntryToEqu();
            Equation += " - ";
            ClearEntry();
            computed = false;
        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            if (computed)
                Equation = String.Empty;
            if (Equation.Length == 0 || Equation.Last() != ')')
                addEntryToEqu();
            Equation += " * ";
            ClearEntry();
            computed = false;
        }

        private void DivideButton_Click(object sender, EventArgs e)
        {
            if (computed)
                Equation = String.Empty;
            if (Equation.Length == 0 || Equation.Last() != ')')
                addEntryToEqu();
            Equation += " / ";
            ClearEntry();
            computed = false;
        }

        private void PercentButton_Click(object sender, EventArgs e)
        {
            if (Equation.Length - 3 > 0)
            {
                DataTable dt = new DataTable();
                if (isProperInfix(Equation.Substring(0, Equation.Length - 3)))
                {
                    var ans = dt.Compute(Equation.Substring(0, Equation.Length - 3), "");
                    Entry = Convert.ToDouble(ans)*(Entry/100.0);
                }
            }
        }

        private void ReciprocalButton_Click(object sender, EventArgs e)
        {
            Entry = 1.0 / Entry;
        }
        
        private void EquateButton_Click(object sender, EventArgs e)
        {
            Equate();
        }
        void Equate()
        {
            if (computed)
                Equation = String.Empty;
            if (Equation.Length == 0 || Entry != 0.0)
                addEntryToEqu();
            if (isProperInfix(Equation))
            {
                DataTable dt = new DataTable();
                var ans = dt.Compute(Equation, "");
                ClearEntry();
                Entry = Convert.ToDouble(ans.ToString());
                NumberTextBox.Text = ans.ToString();
                computed = true;
            }
        }
        Boolean isProperInfix(String Equ)
        {
            
            Boolean returnVal = true;
            try
            {
                DataTable dt = new DataTable();
                Double ans = Convert.ToDouble(dt.Compute(Equ, ""));
                EquationTextBox.BackColor = Color.White;
            }
            catch (Exception etc)
            {
                EquationTextBox.BackColor = Color.Red;
                returnVal = false;
            }
            return returnVal;
        }

        private void SquareRootButton_Click(object sender, EventArgs e)
        {
            Entry = Math.Sqrt(Entry);
        }

        private void OpenParenButton_Click(object sender, EventArgs e)
        {
            if (computed)
                Equation = String.Empty;
            Equation += " ( ";
            computed = false;
        }

        private void ClosedParenButton_Click(object sender, EventArgs e)
        {
            if(Entry == 0)
                Equation += " ) ";
            else
                Equation += Entry + " ) ";
            ClearEntry();
        }
    }
}
