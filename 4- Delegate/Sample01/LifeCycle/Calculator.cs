using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample01.LifeCycle
{
    public class Calculator
    {
        #region [- ctor -]
        public Calculator(int number1 , int number2)
        {
            Calculate(number1, number2);
        }
        #endregion

        #region [-Methods-]
        public void Sum(int x, int y)
        {
            Console.WriteLine(x + y);
        }
        public void Multiply(int x, int y)
        {
            Console.WriteLine(x * y);
        }
        public void Divide(int x, int y)
        {
            Console.WriteLine(x / y);
        }
        public void Minus(int x, int y)
        {
            Console.WriteLine(x - y);
        }
        #endregion

        public Framework.CalculatorDelegate calculatorDelegate;

        #region [- Bind_CalculatorDelegate() -]
        private void Bind_CalculatorDelegate()
        {
            calculatorDelegate = new Framework.CalculatorDelegate(Sum);
            calculatorDelegate += new Framework.CalculatorDelegate(Multiply);
            calculatorDelegate += new Framework.CalculatorDelegate(Divide);
            calculatorDelegate += new Framework.CalculatorDelegate(Minus);
        }
        #endregion

        #region [-Calculate(int number1, int number2)-]
        private void Calculate(int number1, int number2)
        {
            Bind_CalculatorDelegate();
            calculatorDelegate(number1, number2);
        }
        #endregion
    }
}
