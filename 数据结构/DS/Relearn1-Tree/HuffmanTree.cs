using System;

namespace Relearn1_Tree
{
    public class HuffmanTree
    {
        private HuffmanNode[] data; //节点数组
        private int leafNum; //叶子节点数目

        //索引器
        public HuffmanNode this[int index]
        {
            get { return data[index]; }
            set { data[index] = value; }
        }

        public int LeafNum
        {
            get { return leafNum;}
            set { leafNum = value; }
        }
        
        /// <summary>
        /// 构造
        /// </summary>
        /// <param name="n">叶子节点数目</param>
        public HuffmanTree(int n)
        {
            leafNum = n;
            data=new HuffmanNode[2*n-1];
        }

        //创建哈夫曼树(有问题)
        public void Create()
        {
            int m1;
            int m2;
            int t1;
            int t2;

            //输入n个叶子节点的权值
            for (int i = 0; i < leafNum; i++)
            {
                data[i].Weight = Console.Read();
            }

            //处理n个叶子节点，建立哈夫曼树
            for (int i = 0; i < leafNum-1; i++)
            {
                m1 = m2 = Int32.MaxValue;
                t1 = t2 = 0;

                //在全部节点中找权值最小的两个节点
                for (int j = 0; j < leafNum+i; j++)
                {
                    if (data[i].Weight<m1&&data[i].Parent==-1)
                    {
                        m2 = m1;
                        t2 = t1;
                        t1 = j;
                        m1 = data[i].Weight;
                    }else if (data[i].Weight<m2&&data[i].Parent==-1)
                    {
                        m2 = data[i].Weight;
                        t2 = j;
                    }
                }

                data[t1].Parent = leafNum + i;
                data[this.leafNum + i].Weight = data[t1].Weight+ data[t2].Weight;
                data[this.leafNum + i].LChild = t1;
                data[this.leafNum + i].RChild = t2;

            }
        }

    }
}