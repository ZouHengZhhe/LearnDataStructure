using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._2._4_二叉链表存储结构
{
    //哈夫曼树节点类
    public class HuffmanNode
    {
        private int weight; //节点权值,用于存放该结点的权值；
        private int lChild; //左孩子节点,用于存放该结点的左孩子结点在数组中的序号；
        private int rChild; //右孩子节点,用于存放该结点的右孩子结点在数组中的序号；
        private int parent; //父节点,用于判定该结点是否已加入哈夫曼树中。

        //节点权值属性
        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        //左孩子属性
        public int LChild
        {
            get { return lChild; }
            set { lChild = value; }
        }

        //右孩子属性
        public int RChild
        {
            get { return rChild; }
            set { rChild = value; }
        }

        //父节点属性
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

        public HuffmanNode(int w, int lc, int rc, int p)
        {
            weight = w;
            lChild = lc;
            rChild = rc;
            parent = p;
        }

    }
}
