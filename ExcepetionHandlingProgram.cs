using System;

namespace ExceptionHandling
{
    class StackException : Exception
    {
        public StackException()
        {
            Console.WriteLine("Stack is full or Empty");
        }
    }
    class Stack
    {
        private int[] ele;
        private int top;
        private int max;
        public Stack(int size)
        {
            ele = new int[size];
            top = -1;
            max = size;
        }

        public void push(int item)
        {
            if (top == max - 1)
            {
                throw new StackException();
                /*Console.WriteLine("Stack Overflow");
                return;*/
            }
            else
            {
                ele[++top] = item;
            }
        }

        public int pop()
        {
            if (top == -1)
            {
                throw new StackException();
                /*Console.WriteLine("Stack Underflow");
                return -1;*/
            }
            else
            {
                Console.WriteLine("Poped element is: " + ele[top]);
                return ele[top--];
            }
        }

        public void printStack()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack is Empty");
                return;
            }
            else
            {
                for (int i = 0; i <= top; i++)
                {
                    Console.WriteLine("Item[" + (i + 1) + "]: " + ele[i]);
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Stack S = new Stack(5);
            try
            {
                S.push(10);
                S.push(20);
                S.push(30);
              //  S.push(40);
                S.push(50);
               // S.push(60);
                Console.WriteLine("Items are : ");
                S.printStack();

                S.pop();
                S.pop();
              //  S.pop();
               // S.pop();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
