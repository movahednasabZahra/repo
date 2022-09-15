using System;
using System.Collections.Generic;

namespace GraphTraverse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Graph<String> graph = new Graph<string>();
           Node<String> root= graph.CreateRoot("root");
            graph.root = root;
            Node<String> a = graph.CreateRoot("a");
            Node<String>b= graph.CreateRoot("b");
            Node<String> c = graph.CreateRoot("c");
            Node<String> d = graph.CreateRoot("d");
            Node<String> e = graph.CreateRoot("e");
            Node<String> f = graph.CreateRoot("f");
            root.AddArc(a, 00);
            a.AddArc(b, 1);
            a.AddArc(c, 2);
            b.AddArc(d, 1);
            b.AddArc(e, 2);
            b.AddArc(a, 1);
            d.AddArc(b, 1);
            e.AddArc(b, 2);
            e.AddArc(f, 2);
            f.AddArc(e, 2);
            c.AddArc(a, 2);
           List<Node<string>> list= graph.GetShortestPath(f,c);
            foreach (Node<string> item in list)
            {
                System.Console.WriteLine(item.ToString());
            }
            
        }
    }
}
