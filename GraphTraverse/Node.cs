using System;
using System.Collections.Generic;
using System.Text;

namespace GraphTraverse
{
    class Node<T> : IComparable<Node<T>>
    {
       String Name { get; }
          public Boolean Vistited{ get ; set; }
         public Node(String name)
        {
            Name = name;
            Arcs = new List<Arc<T>>();
            Vistited = false;
        }
       
        public List<Arc<T>> Arcs { get; set; }
        public Node<T> AddArc(Node<T> child,double weight)
        {
          Arcs.Add (new Arc<T>(this,child, weight));
            //if(!child.Arcs.Exists(a=>a.Child==this&&a.Parent==child))
            //{
            //    child.AddArc(this, weight);
            //}
            return this;
        }
        int IComparable<Node<T>>.CompareTo(Node<T> other)
        {
            throw new NotImplementedException();
        }
        public override string ToString()
        {
            return Name;
        }

    }

    //if(!child.Arcs.Exists(a=>a.Parent==child && a.Child==this))
    //{
    //    child.AddArc(this, weight);
    //}
}
