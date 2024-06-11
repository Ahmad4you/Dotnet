using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _214_OOP_Calc_Two_Arrays_CALC_Class
{
    class Calc
    {
        public Calc(double number1 = 0, double number2 = 0)        // minimum Values, u can max values use in Construktor or don't use any value
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

        public int[] GetCalcTwoArrays(int[] Arr1, int[] Arr2, char ope)
        {
            if(Arr1.Count() != Arr2.Count())
            {
                Console.WriteLine("Error: Array1 Count Not Equal Array2!");
                //int[] i = { 0 };
                //return i;
                return new int[] { 0};
            }
            else
            {
                int[] ArrResult = new int[Arr1.Count()];
                for(int i = 0; i < ArrResult.Count(); i += 1)
                {
                    if (ope == '+')
                        ArrResult[i] = Arr1[i] + Arr2[i];
                    else if(ope == '-')
                        ArrResult[i] = Arr1[i] - Arr2[i];
                    else if(ope =='*')
                        ArrResult[i] = Arr1[i] * Arr2[i];
                    else if(ope == '/')
                    {
                        if (Arr2[i] == 0) Arr2[i] = 1;
                        ArrResult[i] = Arr1[i] / Arr2[i];
                    }
                    else 
                    {
                        if (Arr2[i] == 0) Arr2[i] = 1;
                        ArrResult[i] = Arr1[i] % Arr2[i];
                    }

                }
            return ArrResult;
            }
        }
        public void PrintCalcTwoArrays(int[] Arr1, int[] Arr2, char ope)
        {
            int[] Arr3 = GetCalcTwoArrays(Arr1, Arr2, ope);
            foreach(int i in Arr3)
            {
                Console.WriteLine(i);
            }
        }
    }
}
