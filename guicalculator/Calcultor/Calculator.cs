using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalcultorDll
{
    public partial class CalculatorStates
    {
        protected AbstractCalculatorState mState;
        protected int mOpenParentheses;
        protected Stack<Item> mEquation;
        protected AbstractCalculatorState mOperandState;
        protected AbstractCalculatorState mUnaryOperatorState;
        protected AbstractCalculatorState mBinaryOperatorState;
        protected AbstractCalculatorState mOpenParenthesesState;
        protected AbstractCalculatorState mCloseParenthesesState;
        protected AbstractCalculatorState mEquateState;
        public CalculatorStates()
        {
            //initialize Calculator Input States.
            mOperandState = new OperandState(this);
            mUnaryOperatorState = new UnaryOperatorState(this);
            mBinaryOperatorState = new BinaryOperatorState(this);
            //mOpenParenthesesState = new OpenParenState(this);
            mCloseParenthesesState = new ClosedParenState(this);
            mEquateState = new EquateState(this);
            //initialize the current state.
            mState = mOperandState;
        }
    }
}
