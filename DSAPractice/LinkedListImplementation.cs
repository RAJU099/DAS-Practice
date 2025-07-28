using System;
using System.Collections.Generic;

namespace DSAPractice
{
	public class Node
	{
		public int data;
		public Node Next;

		public Node(int Data)
		{
			this.data = Data;
			this.Next = null;
		}
	}

	public class Operation
	{
		Node Head;
		Node Tail;

		public Operation()
		{
			this.Head = this.Tail = null;
		}

		public void PushFront(int val)
		{
			// create one node
			Node newNode = new Node(val);

			if (Head == null)
			{
				Head = Tail = newNode;
				return;
			}

			else
			{
				newNode.Next = Head;
				Head = newNode;
			}
		}

		public void PushEnd(int val)
		{
			Node newNode = new Node(val);

			if(Head == null)
			{
				Head = Tail = newNode;
				return;
			}

			else
			{
				Tail.Next = newNode;
				Tail = newNode;
			}

		}

		public void PopFront()
		{
			if(Head == null)
			{
				Console.WriteLine($"list is empty"); 
				return;
			}

			else
			{
				Node temp = Head;

				Head = Head.Next;
				temp.Next = null;
			}
		}

        public void PopBack()
        {
            if (Head == null)
            {
                Console.WriteLine($"list is empty");
                return;
            }

            else
            {
				Node temp = Head;

				while(temp.Next != Tail)
				{
					temp = temp.Next;
				}

				temp.Next = null;
				Tail = temp;
            }
        }

		public void Insert(int val, int pos)
		{
			Node newNode = new Node(val);
			if(pos <0)
			{
				Console.WriteLine($"Invalid position to insert");
			}

			if(pos == 0)
			{
				PushFront(val);
			}

			Node temp = Head;

			for(int i =0;i < pos-1; i++)
			{
				temp = temp.Next;
			}

			newNode.Next = temp.Next;
			temp.Next = newNode;
		}

        public void PrintList()
		{
			Node temp = Head;
			Console.WriteLine($"Element in ths list is :");

            while (temp != null)
			{
				Console.Write($"{temp.data} ->");
				temp = temp.Next;
			}
            Console.WriteLine($"null");
        }
    }
}

