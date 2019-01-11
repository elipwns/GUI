using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace CalcultorDll
{
    public partial class CalculatorStates 
    {
        public class OperandState : AbstractCalculatorState
        {
            public OperandState(CalculatorStates Calculator)
                : base(Calculator)
            {

            }
            public override void AddOperand()
            {
                
            }
            public override void AddOpenParen()
            {
                ++mState.mOpenParentheses;
            }
            public override void AddUnaryOperator()
            {
                mState.mState = mState.mUnaryOperatorState;
            }
            public override void AddBinaryOperator()
            {
                mState.mState = mState.mOperandState;
            }
        }
        public class ClosedParenState : AbstractCalculatorState
        {
            public ClosedParenState(CalculatorStates Calculator)
                : base(Calculator)
            {
                    
            }
            public override void AddBinaryOperator()
            {
                mState.mState = mState.mOperandState;
            }
            public override void AddUnaryOperator()
            {
                mState.mState = mState.mUnaryOperatorState;
            }
            public override void AddCloseParen()
            {
                if (mState.mOpenParentheses == 0)
                    throw new InvalidOperationException("Unable to close parentheses.");
                else
                    --mState.mOpenParentheses;
            }
            //public override void 
        }
        public class BinaryOperatorState : AbstractCalculatorState
        {
            public BinaryOperatorState(CalculatorStates Calculator)
                : base(Calculator)
            {

            }
        }
        public class UnaryOperatorState : AbstractCalculatorState
        {
            public UnaryOperatorState(CalculatorStates Calculator)
                : base(Calculator)
            {

            }

        }
        public class EquateState : AbstractCalculatorState
        {
            public EquateState(CalculatorStates Calculator)
                : base(Calculator)
            {

            }
        }
    }
}
