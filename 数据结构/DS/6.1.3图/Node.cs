using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._1._3图
{
    //图中的定点类
    public class Node<T>
    {
        private T data;  //数据域

        //构造
        public Node(T v)
        {
            data = v;
        }

        //数据域属性
        public T Data
        {
            get { return data; }
            set { data = value; }
        }

    }
}
