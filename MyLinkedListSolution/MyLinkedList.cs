using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLinkedListSolution
{
    public class MyLinkedList
    {
        private Node head;

        public int Count { get; set; }

        public void Add(int value)
        {
            var newNode = new Node(value);
            if (head == null) head = newNode;
            else
            {
                var current = head;
                while (current.Next != null)
                {
                    current = current.Next;

                }
                current.Next = newNode;
            }
            Count++;
        }

        public void Add(int index, int value)
        {
            if (index > Count || index < 0) throw new IndexOutOfRangeException();
            var newNode = new Node(value);
            var counter = 0;
            var current = head;
            if (index == 0)
            {
                newNode.Next = current; head = newNode;
            }
            while (counter < index)
            {
                if (index - 1 == counter)
                {
                    newNode.Next = current.Next;
                    current.Next = newNode;
                    counter++;
                    continue;
                }
                current = current.Next;
                counter++;
            }
            Count++;
        }

        public int Get(int index)
        {
            if (index >= Count || index < 0)
            {
                throw new IndexOutOfRangeException();
            }

            var counter = 0;
            var current = head;
            while (counter != index)
            {
                current = current.Next;
                counter++;
            }
            return current.Value;
        }

        public int this[int index]
        {
            get
            {
                if (index >= Count || index < 0) throw new IndexOutOfRangeException();
                var counter = 0;
                var current = head;
                while (counter != index)
                {
                    current = current.Next;
                    counter++;
                }
                return current.Value;
            }
            set
            {
                if (index >= Count || index < 0) throw new IndexOutOfRangeException();
                var counter = 0;
                var current = head;
                while (counter != index)
                {
                    current = current.Next;
                    counter++;
                }
                current.Value = value;

            }
        }
    }
}
