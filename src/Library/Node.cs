using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Node<T>
    {
        private T value;

        private List<Node<T>> children = new List<Node<T>>();

        public T Value {
            get
            {
                return this.value;
            }
        }

        public ReadOnlyCollection<Node<T>> Children {
            get
            {
                return this.children.AsReadOnly();
            }
        }

        public Node(T value)
        {
            this.value = value;
        }

        public void AddChildren(Node<T> n)
        {
            this.children.Add(n);
        }
        
        public void Accept(IVisitor<T> visitor)
        {
            visitor.Visit(this);
            foreach (var child in children)
            {
                child.Accept(visitor);
            }
        }
    }
}
