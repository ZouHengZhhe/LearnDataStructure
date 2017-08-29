using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relearn1_Tree
{
    public class HuffmanNode
    {
        private int weight;  //结点权值
        private int lChild;  //左孩子结点
        private int rChild;  //右孩子结点
        private int parent;  //父结点

        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public int LChild
        {
            get { return lChild;}
            set { lChild = value; }
        }

        public int RChild
        {
            get { return rChild;}
            set { rChild = value; }
        }

        public int Parent
        {
            get { return parent; }
            set { parent = value; }
        }

        //构造
        public HuffmanNode()
        {
            weight = 0;
            lChild = -1;
            rChild = -1;
            parent = -1;
        }

        public HuffmanNode(int w,int lc,int rc,int p)
        {
            weight = w;
            lChild = lc;
            rChild = rc;
            parent = p;
        }

    }
}
