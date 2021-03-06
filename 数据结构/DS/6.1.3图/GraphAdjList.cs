﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3._2_队列;

namespace _6._1._3图
{
    //无向图邻接表类
    public class GraphAdjList<T> : IGraph<T>
    {
        //邻接表数组
        private VexNode<T>[] adjList;
        private int[] visited;

        //索引器
        public VexNode<T> this[int index]
        {
            get
            {
                return adjList[index];
            }
            set
            {
                adjList[index] = value;
            }
        }

        //构造器
        public GraphAdjList(Node<T>[] nodes)
        {
            adjList = new VexNode<T>[nodes.Length];
            for (int i = 0; i < nodes.Length; ++i)
            {
                adjList[i].Data = nodes[i];
                adjList[i].FirstAdj = null;
            }

            visited=new int[adjList.Length];
            for (int i = 0; i < visited.Length; i++)
            {
                visited[i] = 0;
            }

        }

        //获取顶点的数目
        public int GetNumOfVertex()
        {
            return adjList.Length;
        }

        //获取边的数目
        public int GetNumOfEdge()
        {
            int i = 0;

            //遍历邻接表数组
            foreach (var nd in adjList)
            {
                AdjListNode<T> p = nd.FirstAdj;

                while (p != null)
                {
                    ++i;
                    p = p.Next;
                }
            }
            return i / 2;
        }

        //判断v是否是图的顶点
        public bool IsNode(Node<T> v)
        {
            //遍历邻接表数组
            foreach (VexNode<T> nd in adjList)
            {
                //如果v等于nd的data，则v是图中的顶点，返回true
                if (v.Equals(nd.Data))
                {
                    return true;
                }
            }
            return false;
        }

        //获取顶点v在邻接表数组中的索引
        public int GetIndex(Node<T> v)
        {
            int i = -1;
            //遍历邻接表数组
            for (i = 0; i < adjList.Length; ++i)
            {
                //邻接表数组第i项的data值等于v，则顶点v的索引为i
                if (adjList[i].Data.Equals(v))
                {
                    return i;
                }
            }
            return i;
        }

        //在顶点v1和v2之间添加权值为v的边
        public void SetEdge(Node<T> v1, Node<T> v2, int v)
        {
            //v1或v2不是图的顶点或者v1和v2之间存在边
            if (!IsNode(v1) || !IsNode(v2) || IsEdge(v1, v2))
            {
                Console.WriteLine("Node is not belong to Graph!");
                return;
            }

            //权值不对
            if (v != 1)
            {
                Console.WriteLine("Weight is not right!");
                return;
            }

            //处理顶点v1的邻接表
            AdjListNode<T> p = new AdjListNode<T>(GetIndex(v2));
            //顶点v1没有邻接顶点
            if (adjList[GetIndex(v1)].FirstAdj == null)
            {
                adjList[GetIndex(v1)].FirstAdj = p;
            }
            //顶点v1有邻接顶点
            else
            {
                p.Next = adjList[GetIndex(v1)].FirstAdj;
                adjList[GetIndex(v1)].FirstAdj = p;
            }

            //处理顶点v2的邻接表
            p = new AdjListNode<T>(GetIndex(v1));
            //顶点v2没有邻接顶点
            if (adjList[GetIndex(v2)].FirstAdj == null)
            {
                adjList[GetIndex(v2)].FirstAdj = p;
            }
            //顶点v1有邻接顶点
            else
            {
                p.Next = adjList[GetIndex(v2)].FirstAdj;
                adjList[GetIndex(v2)].FirstAdj = p;
            }

        }

        //删除顶点v1和v2之间的边
        public void DeleteEdge(Node<T> v1, Node<T> v2)
        {
            //v1或v2不是图的顶点
            if (!IsNode(v1) || !IsNode(v2))
            {
                Console.WriteLine("Node is not belong to Graph!");
                return;
            }
            //顶点v1与v2之间有边
            if (IsEdge(v1, v2))
            {
                //处理顶点v1的邻接表中的顶点v2的邻接表结点
                AdjListNode<T> p = adjList[GetIndex(v1)].FirstAdj;
                AdjListNode<T> pre = null;
                while (p != null)
                {
                    if (p.AdjVert != GetIndex(v2))
                    {
                        pre = p;
                        p = p.Next;
                    }
                }
                pre.Next = p.Next;
                //处理顶点v2的邻接表中的顶点v1的邻接表结点
                p = adjList[GetIndex(v2)].FirstAdj;
                pre = null;
                while (p != null)
                {
                    if (p.AdjVert != GetIndex(v1))
                    {
                        pre = p;
                        p = p.Next;
                    }
                }
                pre.Next = p.Next;
            }
        }
        
        //判断v1和v2之间是否存在边
        public bool IsEdge(Node<T> v1, Node<T> v2)
        {
            //v1或v2不是图的顶点
            if (!IsNode(v1) || !IsNode(v2))
            {
                Console.WriteLine("Node is not belong to Graph!");
                return false;
            }
            AdjListNode<T> p = adjList[GetIndex(v1)].FirstAdj;
            while (p != null)
            {
                if (p.AdjVert == GetIndex(v2))
                {
                    return true;
                }
                p = p.Next;
            }
            return false;
        }

        //无向图的深度优先遍历算法的实现如下：
        public void DFS()
        {
            for (int i = 0; i < visited.Length; i++)
            {
                if (visited[i]==0)
                {
                    DFSAL(i);
                }
            }
        }

        //从某个顶点出发进行深度优先遍历
        public void DFSAL(int i)
        {
            visited[i] = 1;
            AdjListNode<T> p = adjList[i].FirstAdj;

            while (p!=null)
            {
                if (visited[p.AdjVert]==0)
                {
                    DFSAL(p.AdjVert);
                }
                p = p.Next;
            }
        }

        public void BFS()
        {
            for (int i = 0; i < visited.Length; i++)
            {
                if (visited[i] == 0)
                {
                    BFSAL(i);
                }
            }
        }

        //从某个顶点出发进行广度优先遍历
        public void BFSAL(int i)
        {
            visited[i] = 1;
            CSeqQueue<int> cq=new CSeqQueue<int>(visited.Length);
            cq.In(i);

            while (!cq.IsEmpty())
            {
                int k = cq.Out();
                AdjListNode<T> p = adjList[k].FirstAdj;

                while (p!=null)
                {
                    if (visited[p.AdjVert]==0)
                    {
                        visited[p.AdjVert] = 1;
                        cq.In(p.AdjVert);
                    }
                    p = p.Next;
                }
            }
        }

        
    }

}
