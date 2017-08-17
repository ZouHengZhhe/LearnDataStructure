using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Relearn1_List
{
    public class SeqList<T>:IListDS<T>
    {
        private int maxsize; //顺序表的容量
        private T[] data;    //数组，用于存储顺序表中的数据元素
        private int last;    //指示顺序表最后一个元素的位置(索引),如果顺序表为空，last=-1

        //索引器
        public T this[int index]
        {
            get { return data[index]; }
            set { data[index] = value; }
        }

        //最后一个数据元素位置属性,只读属性
        public int Last
        {
            get { return last; }
        }

        //容量属性
        public int Maxsize
        {
            get { return maxsize; }
            set { maxsize = value; }
        }

        //构造器
        public SeqList(int size)
        {
            maxsize = 0;
            data=new T[size];
            last = -1;
        }

        //求顺序表的长度
        public int GetLength()
        {
            return last+1;
        }

        //清空顺序表
        public void Clear()
        {
            last = -1;
        }

        //判断顺序表是否为空
        public bool IsEmpty()
        {
            if (last==-1)
            {
                return true;
            }
            return false;
        }

        //判断顺序表是否为满
        public bool IsFull()
        {
            if (last==maxsize-1)
            {
                return true;
            }
            return false;
        }

        //在顺序表的末尾添加新元素
        public void Append(T item)
        {
            if (last==maxsize-1)
            {
                Console.WriteLine("线性表已满，无法再添加元素!");
                return;
            }
            last++;
            data[last] = item;
        }

        //在顺序表的第i个数据元素的位置插入一个数据元素
        public void Insert(T item,int index)
        {
            if (last == maxsize - 1)
            {
                Console.WriteLine("线性表已满，无法再插入元素!");
                return;
            }

            if (index>last+1)
            {
                Console.WriteLine("插入位置非法！");
                return;
            }

            for (int j = last; j >= index; j--)
            {
                data[j + 1] = data[j];
            }
            data[index] = item;
            last++;

        }

        //删除顺序表的第i个数据元素
        public void Delete(int index)
        {
            if (last==-1)
            {
                Console.WriteLine("线性表为空，不能进行删除操作！");
                return;
            }

            if (index<0&&index>last)
            {
                Console.WriteLine("输入的删除位置为非法！");
                return;
            }
            for (int i = index; i < last; i++)
            {
                data[i] = data[i + 1];
            }
            last--;
        }

        //获得顺序表的第i个数据元素
        public T GetElem(int index)
        {
            if (IsEmpty())
            {
                Console.WriteLine("该数组为空！");
                return default(T);
            }

            if (index<0||index>last)
            {
                Console.WriteLine("输入的位置错误!");
                return default(T);
            }
            return data[index];
        }

        //在顺序表中查找值为value的数据元素
        public int Locate(T value)
        {
            if (IsEmpty())
            {
                Console.WriteLine("该数组为空");
                return -1;
            }

            for (int i = 0; i < last+1; i++)
            {
                if (value.Equals(data[i])&&i<last)
                {
                    return i;
                }
            }
            return -1;
        }

        //倒置算法
        public void ReversSeqList(SeqList<T> l )
        {
            ////O(2n)
            //int len = l.GetLength();
            //T[] temp=new T[len];
            //for (int i = 0; i < len; i++)
            //{
            //    temp[i] = l[len - 1 - i];
            //}
            //for (int i = 0; i < len; i++)
            //{
            //    l[i] = temp[i];
            //}

            //O(n/2)
            T tmp;
            int len = l.GetLength();
            for (int i = 0; i <= len / 2; ++i)
            {
                tmp =l[i];
                l[i] = l[len - i];
                l[len - i] = tmp;
            }
        }
    }
}
