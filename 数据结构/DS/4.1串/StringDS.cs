using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._1串
{
    public class StringDS
    {
        private char[] data;

        //索引器
        public char this[int index]
        {
            get { return data[index]; }
        }

        //构造
        public StringDS(char[] arr)
        {
            data = new char[arr.Length];
            for(int i = 0; i < arr.Length; i++)
            {
                data[i] = arr[i];
            }
        }

        public StringDS(StringDS s)
        {
            data = new char[s.data.Length];
            for(int i = 0; i < data.Length; i++)
            {
                data[i] = s[i];
            }
        }

        public StringDS(int len)
        {
            char[] arr = new char[len];
            data = arr;
        }

        //求串长
        public int GetLength()
        {
            return data.Length;
        }

        //串比较
        public int Compare(StringDS s)
        {
            int len = (this.GetLength() <= s.GetLength()) ? this.GetLength() : s.GetLength();
            int i = 0;
            for(int j = 0; j < len; j++)
            {
                if (this[j] != s[j])
                {
                    i = j;
                    break;
                }
            }
            if (i<len)
            {
                if (this[i]<s[i])
                {
                    return -1;
                }
                else if (this[i]>s[i])
                {
                    return 1;
                }
            }
            else if (this.GetLength()==s.GetLength())
            {
                return 0;
            }
            else if (this.GetLength()<s.GetLength())
            {
                return -1;
            }
            return 1;
        }

        //求子串
        public StringDS SubString(int index,int len)
        {
            if ((index<0)||index>this.GetLength()-1}||)
            {
                
            }
        }

        //串连接

        //串插入

        //串删除

        //串定位   
    }
}
