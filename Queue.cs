﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace attackServer
{
    internal class Queue<T>
    {
        private Node<T> _haed;
        private Node<T> _tail;
        private int _count;


        public Queue()
        {
            this.SetHead(null);
            this.SetTail(null);
            this.SetCount(0);
        }

        public void Enqueue(T value)
        {
            Node<T> newNode = new Node<T>(value);
            if (this.GetTail() != null)
            {
                Node<T> tail = this.GetTail();
                tail.SetNext(newNode);
                this.SetTail(newNode);
            }
            if (this.GetHead() == null)
            {
                this.SetHead(newNode);
                this.SetTail(newNode);
            }

            this.SetCount(this.GetCount() + 1);

        }

        public T Dequeue()
        {
            if (this.IsEmpty() == null)
            {
                throw new Exception("Queue is empty");
            }
            else
            {
                T value = this.GetHead().GetValue();
                this.SetHead(this.GetHead().GetNext());
                if (this.GetHead() == null)
                {
                    this.SetTail(null);
                }
                this.SetCount(this.GetCount() - 1);
                return value;
            }

        }

        private bool IsEmpty()
        {
            return this.GetHead() == null;
        }

        public void SetHead(Node<T> head)
        {
            _haed = head;
        }

        public void SetTail(Node<T> tail)
        {
            _tail = tail;
        }

        public Node<T> GetHead()
        {
            return _haed;
        }

        public Node<T> GetTail()
        {
            return this._tail;
        }

        public int GetCount()
        {
            return this._count;
        }
        public void SetCount(int count)
        {
            this._count = count;
        }
        public int Peek()
        {
            return this.Peek();
        }
    }
}
