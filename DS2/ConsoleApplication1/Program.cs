using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums=new int[100000];
            BuildArray(nums);
            //TimeSpan duration;
            //DisplayNums(nums);
            //DisplayNums(nums);
            //DisplayNums(nums);
            //duration = Process.GetCurrentProcess().TotalProcessorTime;
            //Console.WriteLine("Time: " + duration.TotalSeconds);

            Timing t=new Timing();
            t.StartTime();
            DisplayNums(nums);
            DisplayNums(nums);
            DisplayNums(nums);
            t.StopTime();
            Console.WriteLine("time (.NET): " + t.Result().TotalSeconds);

            Console.ReadKey();
        }

        static void BuildArray(int[] arr)
        {
            for (int i = 0; i <= 99999; i++)
            {
                arr[i] = i;
            }
        }

        static void DisplayNums(int[] arr)
        {
            for (int i = 0; i <= arr.GetUpperBound(0); i++)
            {
                Console.Write(arr[i] + " ");
            }
        }

    }
}
