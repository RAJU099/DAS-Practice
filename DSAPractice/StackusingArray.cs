using System;
namespace DSAPractice
{
	public class StackusingArray
	{
		private int top;
		private int capacity;
		private int[] stack;

		public StackusingArray(int size)
		{
			capacity = size;
			top = -1;
			stack = new int[size];
		}

		public void Push(int v)
		{
			if(top == capacity-1)
			{
				Console.WriteLine($"stack overflows");
			}

			stack[++top] = v;
        }

        public int Pop()
		{
			if(IsEmpty())
			{
                Console.WriteLine("Stack Underflow");
                return -1;
            }
			return stack[top--];
		}

		public int Peek()
		{
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty");
                return -1;
            }

			return stack[top];
        }

		public bool IsEmpty()
		{
			return top == -1;
		}

		public void PrintStack()
		{
			if(IsEmpty())
			{
				Console.WriteLine($"stack is empty");
			}

			for(int i = top; i>=0; i--)
			{
				Console.WriteLine(stack[i]);
			}
		}

    }
}

