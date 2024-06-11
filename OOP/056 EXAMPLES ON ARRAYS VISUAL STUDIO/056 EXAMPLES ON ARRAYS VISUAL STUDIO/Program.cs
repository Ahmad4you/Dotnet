using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _056_EXAMPLES_ON_ARRAYS_VISUAL_STUDIO
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] strNames = new string[5];

            //strNames[0] = "Ahmad";

            //Console.WriteLine(strNames[0]);
            //Console.WriteLine(strNames[1]);
            //Console.WriteLine(strNames[2]);
            //Console.WriteLine(strNames[3]);
            //Console.WriteLine(strNames[4]);

            //int[] nums = new int[4];
            //nums[0] = 122;
            //nums[1] = 2;
            //nums[2] = nums[0] * nums[1];

            //Console.WriteLine(nums[0]);
            //Console.WriteLine(nums[1]); 
            //Console.WriteLine(nums[2]);
            //Console.WriteLine(nums[3]);

            object[] data = new object[4];
            data[0] = "Ahmad";
            data[1] = 555;
            data[2] = true;
            Console.WriteLine(data[0]);
            Console.WriteLine(data[1]);
            Console.WriteLine(data[2]);
            Console.WriteLine(data[3]);
        }
    }
}
