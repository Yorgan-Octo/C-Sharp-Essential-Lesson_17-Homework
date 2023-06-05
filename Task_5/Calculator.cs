using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    public class Calculator
    {

        public dynamic Add(dynamic operand1, dynamic operand2) => operand1 + operand2;
        public dynamic Sum(dynamic operand1, dynamic operand2) => operand1 - operand2;
        public dynamic Mul(dynamic operand1, dynamic operand2) => operand1 * operand2;
        public dynamic Div(dynamic operand1, dynamic operand2)
        {
            dynamic sum = default;
            try
            {
                if (operand1 != 0 && operand2 != 0)
                    sum = operand1 / operand2;
                else
                    throw new DivideByZeroException("На нуль ділити не можна! Спробуйте ще раз!");
            }
            catch (DivideByZeroException ex)
            {
                sum = null;
                UserInterface.ShowError(ex.Message);
            }

            return sum;

        }


    }
}
