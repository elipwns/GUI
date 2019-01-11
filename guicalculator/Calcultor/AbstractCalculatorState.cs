using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Diagnostics;
namespace CalcultorDll
{
    public enum ItemType
    {
        BinaryOperator,
        UnaryOperator,
        Operand,
        OpenParentheses,
        ClosedParentheses
    }
    public class Item
    {
        public Item(String Value, ItemType type )
        {
            mValue = Value;
            mType = type;
        }
        String mValue;
        ItemType mType;
        public ItemType Type
        {
            get { return mType; }
            set { mType = value; }
        }
        public String Value
        {
            get { return mValue; }
            set { mValue = value; }
        }
    }

    public class AbstractCalculatorState
    {
        protected CalculatorStates mState;
        public AbstractCalculatorState(CalculatorStates state)
        {
            this.mState = state;
        }
        virtual public void AddOpenParen()
        {
            throw new InvalidOperationException("Unable to add an Open Parentheses");   
        }
        virtual public void AddCloseParen()
        {
            throw new InvalidOperationException("Unable to add a Close Parentheses");
        }
        virtual public void AddOperand()
        {
            throw new InvalidOperationException("Unable to add an operand");
        }
        virtual public void AddBinaryOperator()
        {
            throw new InvalidOperationException("Unable to add an BinaryOperator");
        }
        virtual public void AddUnaryOperator()
        {
            throw new InvalidOperationException("Unable to add an Close Parentheses");
        }
    }
}
