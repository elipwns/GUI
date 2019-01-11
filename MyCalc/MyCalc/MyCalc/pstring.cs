using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalc
{
    public class pstring
    {
        float number1;
        float number2;
        char operator1;
        char[] individuals;
        int index;
        public pstring()
        {
            number1 = 0;
            number2 = 0;
            operator1 = ' ';
            individuals = new char[35];
            index = 0;
        }
        public void delete()
        {
            if(index > 0)
                individuals[--index] = '\0';
        }
        public void push(int character)
        {
            number1 = 0;
            number2 = 0;
           
            bool operatorpassed = false;
            bool decimalpassed = false;
            bool signswitch1 = false;
            bool signswitch2 = false; 
            individuals[index++] = (char)character;
            for (int i = 0; i < index; i++)
            {
                if (individuals[i] == '.')
                    decimalpassed = true;
                else if (individuals[i] == '/' || individuals[i] == '*' || individuals[i] == '-' || individuals[i] == '+')
                {
                    operatorpassed = true;
                    operator1 = individuals[i];
                }
                else if (individuals[i] == '~')
                {
                    if (operatorpassed)
                        signswitch2 = true;
                    else
                        signswitch1 = true;
                }
                else if (individuals[i] == ' ')
                    throw new IndexOutOfRangeException("reading in space");
                else
                {
                    if (operatorpassed == false)
                    {
                        if (decimalpassed)
                        {
                            decimalpassed = false;
                            number1 += '.';
                        }

                        if (number1 >= 0)
                            number1 = 10 * number1 + individuals[i];
                        else
                            number1 = 10 * number1 - individuals[i];

                        if (signswitch1)
                            number1 = -number1;
                    }
                    else
                    {
                        if (decimalpassed)
                        {
                            decimalpassed = false;
                            number2 += '.';
                        }

                        if (number1 >= 0)
                            number2 = 10 * number2 + individuals[i];
                        else
                            number2 = 10 * number2 - individuals[i];
                        
                        if (signswitch2)
                            number2 = -number2;
                    }
                }
            }
        }

        public float compute(float num1, float num2, char op)
        {
            float result;
            switch (op)
            {
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num2 * num1;
                    break;
                case '/':
                    result = num1 / num2;
                    break;
                case '+':
                    result = num2 + num1;
                    break;
                default:
                    result = 0;
                    throw new FormatException("operand not found");                    
            }
            return result;
        }
        public void push(char notaNumber)
        {
            individuals[index++] = notaNumber;           
        }
        public float Getnumber1()
        {
            return number1;
        }
        public float Getnumber2()
        {
            return number2;
        }
        public char Getoperator()
        {
            return operator1;
        }

        public void Setnum1(float num1)
        {
            number1 = num1;
        }
        public void Setnum2(float num2)
        {
            number2 = num2;
        }
    }
}
