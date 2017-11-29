using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDataStructure
{
    /// <summary>
    /// 顺序表（线性表顺序存储结构）
    /// </summary>
    public class SeqList<T> : IListDS<T>
    {
        private int maxsize;     //表示线性表的长度（非存储线性表元素数组的长度）
        private T[] data;           //存储线性表元素的数组
        private int lastIndex;    //线性表元素的最大索引(线性表为空时为-1)

        /// <summary>
        /// 构造，实例化时，必须规定该线性表的最大容量
        /// </summary>
        /// <param name="length"></param>
        public SeqList(int length)
        {
            data = new T[length];
            maxsize = 0;
            lastIndex = -1;
        }

        //索引器
        public T this[int index]
        {
            get { return data[index]; }
            set { data[index] = value; }
        }

        public int GetLength()
        {
            return maxsize;
        }

        public void Clear()
        {
            maxsize = 0;
            lastIndex = -1;
        }

        public bool IsEmpty()
        {
            if (lastIndex == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Append(T item)
        {
            if (maxsize < data.Length)
            {
                data[lastIndex + 1] = item;
                lastIndex++;
                maxsize++;
            }
            else
            {
                Console.WriteLine("线性表已满，无法继续添加元素！");
            }
        }

        public void Insert(T item, int index)
        {
            if (maxsize < data.Length)
            {
                if (index < maxsize)
                {
                    for (int i = maxsize - 1; i >= index; i--)
                    {
                        data[i + 1] = data[i];
                    }
                    data[index] = item;
                    maxsize++;
                    lastIndex++;
                }
                else
                {
                    Console.WriteLine("插入位置超出线性表最大索引，请重新选择插入位置！");
                }
            }
            else
            {
                Console.WriteLine("线性表已满，无法继续插入元素!");
            }
        }

        public void Delete(int index)
        {
            if (index < maxsize && maxsize != 0)
            {
                for (int i = index; i < maxsize - 1; i++)
                {
                    data[i] = data[i + 1];
                }
                maxsize--;
                lastIndex--;
            }
            else
            {
                Console.WriteLine("删除有误！");
            }
        }

        public T GetElement(int index)
        {
            return data[index];
        }

        public int Locate(T item)
        {
            int num = -1;
            for (int i = 0; i < maxsize; i++)
            {
                if (data[i].Equals(item))
                {
                    num = i;
                    return num;
                }
            }
            return num;
        }
    }
}