﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._1._3图
{
    //无向图邻接表的顶点结点类
    public class VexNode<T>
    {
        private Node<T> data; //图的顶点
        private AdjListNode<T> firstAdj; //邻接表的第1个结点

        //图的顶点属性
        public Node<T> Data
        {
            get { return data; }
            set { data = value; }
        }

        //邻接表的第1个结点属性
        public AdjListNode<T> FirstAdj
        {
            get { return firstAdj; }
            set { firstAdj = value; }
        }

        //构造器
        public VexNode()
        {
            data = null;
            firstAdj = null;
        }
        //构造器
        public VexNode(Node<T> nd)
        {
            data = nd;
            firstAdj = null;
        }
        //构造器
        public VexNode(Node<T> nd, AdjListNode<T> alNode)
        {
            data = nd;
            firstAdj = alNode;
        }

    }
}
