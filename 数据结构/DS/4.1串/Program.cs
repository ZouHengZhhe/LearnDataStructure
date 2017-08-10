using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._1串
{
    class Program
    {
        static void Main(string[] args)
        {
            StringDS s=new StringDS(new char[]{'a','b','c'});
            StringDS s2=new StringDS(new char[]{'a','b'});
            StringDS s1=new StringDS(new char[]{'a','b','c', 'd' });
            int i=s.Compare(s2);
            Console.WriteLine(i);

            String a = "kdgahhfiusaf";
            Console.WriteLine(a.Substring(3, 2));
            Console.ReadKey();
        }
    }
}
