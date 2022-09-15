using System;
using System.Collections.Generic;
using System.Text;

namespace GraphTraverse
{
    class Graph<T>
    {
        public Node<T> root;
        List<Node<T>> BfsQueue = new List<Node<T>>();
        List<Node<T>> BfsQueueParents = new List<Node<T>>();
        List<Node<T>> listGraphNodes = new List<Node<T>>();
        public Node<T> CreateRoot(string name)
        {
           return CreateNode(name);
        }

        private Node<T> CreateNode(string name)
        {
            Node<T> node = new Node<T>(name);
            if(!listGraphNodes.Contains(node))
            listGraphNodes.Add(node);
            return node;
        }
        public List<Node<T>> GetShortestPath(Node<T> source,Node<T> destination=null)
        {
            BfsQueue.Add(source);
            List<Node<T>> listBfs= BFS(source, destination);
            List<Node<T>> path= GetPathFromBfsQueue(BfsQueueParents);
            path.Add(destination);
            return path;
        }
       private List<Node<T>> BFS(Node<T> node,Node<T> destination=null  )
        {
            if (destination == null || destination != node)
            {
                node.Vistited = true;
                
                foreach (Arc<T> arc in node.Arcs)
                {
                    if (!BfsQueue.Contains(arc.Child))
                    {
                        BfsQueueParents.Add(arc.Parent);
                        BfsQueue.Add(arc.Child);
                       
                    }
                }
                foreach (Arc<T> arc in node.Arcs)
                {
                   if(arc.Child.Vistited==false)
                    BFS(arc.Child,destination);
                   
                }

            }
                return BfsQueue;
        }
        public List<Node<T>> GetPathFromBfsQueue(List<Node<T>> bfsQueue)
        {
            List<Node<T>> result = new List<Node<T>>();
            for(int i=0;i< bfsQueue.Count;i++)
            {
                if (!result.Contains(bfsQueue[i]))
                    result.Add(bfsQueue[i]);
            }
            return result;
          }
    }
}
