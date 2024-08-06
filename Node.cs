using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace attackServer
{
    internal class Node<T>
    {
        private T _value;

        private Node<T> _next;


        public Node()
        {
            
        }

        public Node(T value,Node<T> next)
        {
            this.SetValue(value);
            this.SetNext(next);
        }

        public Node(T value)
        {

            this.SetValue(value);

        }
        public void SetValue(T value)
        {

            this._value = value;

        }

        public void SetNext(Node<T> node)
        {

            this._next = node;

        }
        public T GetValue()
        {

            return _value;

        }

        public  Node<T> GetNext()
        {

            return _next;

        }

        public string ToString()
        {
            if (_next == null)
            {
                return $"Node value is:{_value} and no next";
            }
            return $"Node value is:{_value} and has next";
        }
   
    
    
    
    
    }
}
