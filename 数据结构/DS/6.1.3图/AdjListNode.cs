using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._1._3图
{
    //无向图邻接表的邻接表结点类
    public class AdjListNode<T>
    {
        private int adjVert;           //临接顶点,实际上就是邻接顶点在顶点数组中的序号；
        private AdjListNode<T> next;   //下一个邻接表节点

        //临接顶点属性
        public int AdjVert
        {
            get { return adjVert;}
            set { adjVert = value; }
        }

        //下一个邻接表节点属性
        public AdjListNode<T> Next
        {
            get { return next; }
            set { next = value; }
        }

        //构造器
        public AdjListNode(int vex)
        {
            adjVert = vex;
            next = null;
        }

    }
}
