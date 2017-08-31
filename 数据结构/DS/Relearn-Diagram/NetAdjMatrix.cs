using System;

namespace Relearn_Diagram
{
    //无向网邻接矩阵类
    public class NetAdjMatrix<T> : IGraph<T>
    {
        private Node<T>[] nodes;  //顶点数组
        private int numEdges;     //边的数目
        private int[,] matrix;    //邻接矩阵数组

        //边的数目属性
        public int NumEdges
        {
            get
            {
                return numEdges;
            }
            set
            {
                numEdges = value;
            }
        }

        //构造
        public NetAdjMatrix(int n)
        {
            nodes = new Node<T>[n];
            matrix = new int[n, n];
            numEdges = 0;
        }

        //获取索引为index的顶点的信息
        public Node<T> GetNode(int index)
        {
            return nodes[index];
        }

        //设置索引为index的顶点的信息
        public void SetNode(int index, Node<T> v)
        {
            nodes[index] = v;
        }

        //获取matrix[index1, index2]的值
        public int GetMatrix(int index1, int index2)
        {
            return matrix[index1, index2];
        }

        //设置matrix[index1, index2]的值
        public void SetMatrix(int index1, int index2, int v)
        {
            matrix[index1, index2] = v;
        }

        //获取顶点的数目
        public int GetNumOfVertex()
        {
            return nodes.Length;
        }

        //获取边的数目
        public int GetNumOfEdge()
        {
            return numEdges;
        }

        //v是否是无向网的顶点
        public bool IsNode(Node<T> p)
        {
            //遍历顶点数组
            for (int i = 0; i < nodes.Length; i++)
            {
                if (nodes[i].Equals(p))
                {
                    return true;
                }
            }
            return false;
        }

        //获得顶点v在顶点数组中的索引
        public int GetIndex(Node<T> p)
        {
            int index = -1;
            for (int i = 0; i < nodes.Length; i++)
            {
                if (nodes[i].Equals(p))
                {
                    return i;
                }
            }
            return index;
        }

        //在顶点v1、v2之间添加权值为v的边
        public void SetEdge(Node<T> v1, Node<T> v2, int v)
        {
            if (!IsNode(v1) || !IsNode(v2))
            {
                Console.WriteLine("Node is not belong to Graph!");
                return;
            }

            matrix[GetIndex(v1), GetIndex(v2)] = v;
            matrix[GetIndex(v2), GetIndex(v1)] = v;
            numEdges++;
        }

        //删除v1和v2之间的边
        public void DelEdge(Node<T> v1, Node<T> v2)
        {
            if (!IsNode(v1) || !IsNode(v2))
            {
                Console.WriteLine("Node is not belong to Graph!");
                return;
            }

            if (IsEdge(v1, v2))
            {
                matrix[GetIndex(v1), GetIndex(v2)] = int.MaxValue;
                matrix[GetIndex(v2), GetIndex(v1)] = int.MaxValue;
                numEdges--;
            }
        }

        //判断v1和v2之间是否存在边
        public bool IsEdge(Node<T> v1, Node<T> v2)
        {
            if (!IsNode(v1) || !IsNode(v2))
            {
                Console.WriteLine("Node is not belong to Graph!");
                return false;
            }

            if (matrix[GetIndex(v1), GetIndex(v2)] != int.MaxValue)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //普利姆算法（构建最小生成树）
        public int[] Prim()
        {
            int[] lowcost = new int[nodes.Length];   //权值数组
            int[] closevex = new int[nodes.Length];  //顶点数组
            int mincost = int.MaxValue;            //最小权值  (此处应该有问题)

            //辅助数组初始化
            for (int i = 0; i < nodes.Length; i++)
            {
                lowcost[i] = matrix[i, 0];
                closevex[i] = 0;
            }

            //某个顶点加入集合U
            lowcost[0] = 0;
            closevex[0] = 0;

            for (int i = 0; i < nodes.Length; i++)
            {
                int k = 1;
                int j = 1;

                //选取权值最小的边和相应的顶点
                while (j < nodes.Length)
                {
                    if (lowcost[j] < mincost && lowcost[j] != 0)
                    {
                        k = j;
                    }
                    k++;
                }

                //新顶点加入集合U
                lowcost[k] = 0;

                //重新计算该顶点到其余顶点的边的权值
                for (j = 1; j < nodes.Length; ++j)
                {
                    if (matrix[k, j] < lowcost[j])
                    {
                        lowcost[j] = matrix[k, j];
                        closevex[j] = k;
                    }
                }
            }
            return closevex;
        }
    }
}