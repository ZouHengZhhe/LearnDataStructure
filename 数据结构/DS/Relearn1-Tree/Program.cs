using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relearn1_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            BiTree<int> bt=new BiTree<int>(1);
            bt.InsertL(2,bt.Root());
            bt.InsertR(3,bt.Root());

            Node<int> p = bt.Root().LChild;
            Node<int> p1 = bt.Root().RChild;

            bt.InsertL(4, p);
            bt.InsertR(5, p);

            Node<int> p2 = p.LChild;
            Node<int> p3 = p.RChild;

            bt.InsertL(6,p2);
            bt.InsertR(7,p2);

            bt.InsertL(8,p3);

            bt.InsertL(9,p1);
            bt.InsertR(10,p1);

            //bt.PreOrder(bt.Root());
            //bt.InOrder(bt.Root());
            //bt.PostOrder(bt.Root());
            bt.LevelNode(bt.Root());

            Console.ReadKey();

        }
    }
}
