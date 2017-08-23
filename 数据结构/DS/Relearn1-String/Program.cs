using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relearn1_String
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder s=new StringBuilder("ZouHeng");
            s.Append("   Kobe");
            Console.WriteLine(s.Capacity);
            Console.WriteLine(s.Length);
            Console.WriteLine(s.MaxCapacity);
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
