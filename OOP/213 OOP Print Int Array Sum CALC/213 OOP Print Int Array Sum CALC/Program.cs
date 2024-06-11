using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _213_OOP_Print_Int_Array_Sum_CALC
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = { 10, 20, 30, 40, 50 };
            int[] nums2 = { 1, 20, 55, 13, 50 };
            Calc cSum = new Calc();
            cSum.PrintSumIntArray(nums1);
            Console.WriteLine(cSum.SumIntArray(nums2));
        }
    }
}
