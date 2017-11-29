using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDataStructure
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            SeqList<int> list = new SeqList<int>(10);
            list.Append(1);
            list.Append(2);
            list.Append(3);
            list.Append(4);
            list.Append(5);
            list.Append(6);
            list.Append(7);
            list.Append(8);
            list.Append(9);
            list.Append(10);

            //list.Clear();
            list.Delete(5);
            //list.Append(1616);
            list.Insert(5161, 3);
            Console.WriteLine("线性表中索引为2的元素为：" + list.GetElement(2));
            Console.WriteLine(list.Locate(9));
            Console.WriteLine("线性表的容量为：" + list.GetLength());
            for (int i = 0; i < list.GetLength(); i++)
            {
                Console.Write(list[i] + "  ");
            }
            Console.ReadKey();
        }
    }
}