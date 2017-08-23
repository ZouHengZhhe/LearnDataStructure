using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relearn1_String
{
    public class StringDS1
    {
        private char[] data;

        //索引器
        public char this[int index]
        {
            get { return data[index]; }
            set { data[index] = value; }
        }

        //构造
        public StringDS1(char[] arr)
        {
            data = new char[arr.Length];
            for (int i = 0; i < data.Length; i++)
            {
                data[i] = arr[i];
            }
        }

        public StringDS1(StringDS1 s)
        {
            
        }

        public StringDS1(int len)
        {
            data=new char[len];
        }

        //求串长
        public int GetLength()
        {
            return data.Length;
        }

        //串比较
        public int Compare(StringDS1 s)
        {
            int len = this.GetLength() <= s.GetLength() ? this.GetLength() : s.GetLength();

            int num = 0;
            for (int i = 0; i < len; i++)
            {
                if (this.data[i]!=s[i])
                {
                    num = i;
                    break;
                }
            }


            return 0;
        }

        //求子串

        //串连接

    }
}
