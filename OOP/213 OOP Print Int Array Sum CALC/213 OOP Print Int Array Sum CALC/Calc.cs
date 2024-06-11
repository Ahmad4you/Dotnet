using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _213_OOP_Print_Int_Array_Sum_CALC
{
    class Calc
    {
        public Calc(double number1= 0, double number2= 0)        // minimum Values, u can max values use in Construktor or don't use any value
        {
            this.number1 = number1;
            this.number2 = number2;
        }
        double number1 = 0;
        double number2 = 0;

        public double Add()
        {
            return number1 + number2;
        }
        public void PrintAdd()
        {
            Console.WriteLine(Add());
        }
        public double Sub()
        {
            return number1 - number2;
        }
        public void PrintSub()
        {
            Console.WriteLine(Sub());
        }
        public double Multi()
        {
            return number1 * number2;
        }
        public void PrintMulti()
        {
            Console.WriteLine(Multi());
        }
        public double Div()
        {
            //if (number2 == 0) number2 = 1;
            if (number2 == 0)
            {
                number2 = 1;
            }
            return number1 / number2;
        }
        public void PrintDiv()
        {
            Console.WriteLine(Div());
        }
        public int Modulo()
        {
            if (number2 == 0) number2 = 1;
            return (int)(number2 % number1);
        }
        public void PrintModulo()
        {
            Console.WriteLine(Modulo());
        }

        public int SumIntArray(int[] numbers)
        {
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            return sum;
        }
           public void PrintSumIntArray(int[] numbers)
        {
            Console.WriteLine(SumIntArray(numbers));
        }
    }
}
