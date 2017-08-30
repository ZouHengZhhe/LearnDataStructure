using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relearn_Diagram
{
    public class Node<T>
    {
        private T data;  //数据域

        public T Data
        {
            get { return data; }
            set { data = value; }
        }

        //构造
        public Node(T val)
        {
            data = val;
        }

    }
}
