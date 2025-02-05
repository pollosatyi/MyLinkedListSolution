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
            var current = head;
            if (index == 0)
            {
                newNode.Next = current; head = newNode;
            }
            else
            {
                for (int i = 0; i < index-1; i++)
                {
                    current= current.Next;
                }
                newNode.Next = current.Next;
                current.Next = newNode;


            }
            
            Count++;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            var current = head;
            for (int i = 0; i < Count; i++)
            {
                stringBuilder.Append(current.Value.ToString() + ",");
                current = current.Next;
            }

            return stringBuilder.ToString();
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
