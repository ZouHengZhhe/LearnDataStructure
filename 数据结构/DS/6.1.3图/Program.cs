using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._1._3图
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = Get();
            Console.WriteLine(i);
            Console.ReadKey();

        }

        static int Get()
        {
            int i = -1;
            for (int j = 0; j < 100; j++)
            {
                if (j == 10)
                {
                    return j;
                }
            }
            return i;
        }

    }
}
