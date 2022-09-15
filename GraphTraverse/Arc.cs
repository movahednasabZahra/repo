using System;
using System.Collections.Generic;
using System.Text;

namespace GraphTraverse
{
    internal class Arc<T>
    {
      public Node<T> Parent { get; }
        public Node<T> Child { get; }
        public double Weight { get; }
        public  Arc(Node<T> parent, Node<T>
            child,double weight)
        {
            Parent = parent;Child = child;Weight = weight;
        }
    }
}
