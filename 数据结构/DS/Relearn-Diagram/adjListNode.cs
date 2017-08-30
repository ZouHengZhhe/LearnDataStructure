using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relearn_Diagram
{
    //无向图邻接表的邻接表结点类
    public class adjListNode<T>
    {
        private int adjvex; //邻接顶点(在顶点类中的索引)
        private adjListNode<T> next; //下一个邻接表结点

        public int Adjvex
        {
            get { return adjvex; }
            set { adjvex = value; }
        }

        public adjListNode<T> Next
        {
            get { return next; }
            set { next = value; }
        }

        public adjListNode(int vex)
        {
            adjvex = vex;
            next = null;
        }

    }
}
