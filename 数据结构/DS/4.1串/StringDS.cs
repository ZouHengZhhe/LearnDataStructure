using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
            if ((index<0)||index>this.GetLength()-1||(len<0)||(len>this.GetLength()-index))
            {
                Console.WriteLine("Position or Length id error!");
                return null;
            }
            StringDS s =new StringDS(len);

            for (int i = 0; i < len; i++)
            {
                s.data[i] = this[i + index - 1];
            }
            return s;
        }

        //串连接
        public StringDS Concat(StringDS s)
        {
            StringDS s1=new StringDS(this.GetLength()+s.GetLength());
            for (int i = 0; i < this.GetLength(); i++)
            {
                s1.data[i] = this[i];
            }
            for (int j = 0; j < s.GetLength(); j++)
            {
                s1.data[this.GetLength()+j] = s.data[j];
            }
            return s1;
        }

        //串插入
        public StringDS Insert(int index,StringDS s)
        {
            int len = s.GetLength();
            int len2 = len + this.GetLength();
            StringDS s1=new StringDS(len2);
            if (index<0||index>this.GetLength()-1)
            {
                Console.WriteLine("Position is error");
                return null;
            }

            for (int i = 0; i < index; ++i)
            {
                s1.data[i] = this[i];
            }
            for (int i = index; i < index + len; ++i)
            {
                s1.data[i] = s[i - index];
            }
            for (int i = index + len; i < len2; ++i)
            {
                s1.data[i] = this[i - len];
            }
            return s1;
        }

        //串删除
        public StringDS Delete(int index,int len)
        {
            if ((index < 0) || (index > this.GetLength() - 1)
|| (len < 0) || (len > this.GetLength() - index))
            {
                Console.WriteLine("Position or Length is error!");
                return null;
            }
            StringDS s = new StringDS(this.GetLength() - len);
            for (int i = 0; i < index; ++i)
            {
                s.data[i] = this[i];
            }
            for (int i = index + len; i < this.GetLength(); ++i)
            {
                s.data[i] = this[i];
            }
            return s;
        }

        //串定位   
        public int Index(StringDS s)
        {
            if (this.GetLength()<s.GetLength())
            {
                Console.WriteLine("There is not string s!");
                return -1;
            }

            int i = 0;
            int len = this.GetLength() - s.GetLength();
            while (i<len)
            {
                if (this.Compare(s)==0)
                {
                    break;
                }
            }
            if (i<=len)
            {
                return i;
            }
            if (i<=len)
            {
                return i;
            }
            return -1;
        }
    }
}
