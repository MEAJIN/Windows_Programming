﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es05_09
{
    interface IOperation
    {
        void Insert(string str);
        string Delete();
        bool Search(string str);
        string GetCurrentElt();
        int NumOfElements();
    }

    class Stack : IOperation
    {
        private string[] stack; // 스택
        private int top, size; // 스택 top과 스택의 최대 크기

        public Stack(int size) // 생성자
        {
            stack = new string[size];
            this.size = size;
            top = -1;
        }

        public void Insert(string str) // 푸쉬
        {
            if (top < size - 1)
            {
                top++;
                stack[top] = str;
            }
            else
                Console.WriteLine("Error : Stack is full!!");
        }

        public string Delete() // 팝
        {
            string str;
            if (top < 0)
            {
                Console.WriteLine("Error : Stack is empty!!");
                str = null;
            }
            else
            {
                str = stack[top];
                top--;
            }
            return str;
        }

        public bool Search(string str)  // 탐색
        {
            foreach (string s in stack)
                if (s == str)
                    return true;
            return false;
        }

        public string GetCurrentElt() // 스택 top의 원소 보기
        {
            if (top < 0)
            {
                Console.WriteLine("Error : Stack is empty!!");
                return null;
            }
            else
                return stack[top];
        }

        public int NumOfElements() // 스택의 총 원소의 개수
        {
            return top + 1;
        }
    }

    class Queue : IOperation
    {
        private string[] queue;
        private int size;
        private int rear;

        public Queue(int size) // 생성자
        {
            queue = new string[size];
            this.size = size;
            rear = -1;
        }

        public void Insert(string str) // 큐에 원소 추가
        {
            if (rear < size - 1)
            {
                rear++;
                queue[rear] = str;
            }
            else
                Console.WriteLine("Error : Queue is full!!");
        }

        public string Delete() // 큐의 원소 반환
        {
            string str;
            if (rear < 0)
            {
                Console.WriteLine("Error : Queue is empty!!");
                str = null;
            }
            else
            {
                str = queue[0];
                for (int i = 0; i < rear; i++)
                    queue[i] = queue[i + 1];
                rear--;
            }
            return str;
        }

        public bool Search(string str) // 큐에서 스트링 검색
        {
            foreach (string s in queue)
                if (s == str)
                    return true;
            return false;
        }

        public string GetCurrentElt() // 큐의 front의 원소 보기
        {
            if (rear < 0)
            {
                Console.WriteLine("Error : Stack is empty!!");
                return null;
            }
            else
                return queue[0];
        }

        public int NumOfElements() // 큐의 원소 개수
        {
            return rear + 1;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // 스택 테스트
            Stack stack = new Stack(100);

            stack.Insert("String A");
            stack.Insert("String B");
            stack.Insert("String C");
            Console.WriteLine("====== Stack Test ======");
            Console.WriteLine(stack.Delete());
            Console.WriteLine(stack.Search("String A"));
            Console.WriteLine(stack.GetCurrentElt());
            Console.WriteLine(stack.NumOfElements());


            // 큐 테스트
            Queue queue = new Queue(100);

            queue.Insert("String A");
            queue.Insert("String B");
            queue.Insert("String C");
            Console.WriteLine("====== Queue Test ======");
            Console.WriteLine(queue.Delete());
            Console.WriteLine(queue.Search("String A"));
            Console.WriteLine(queue.GetCurrentElt());
            Console.WriteLine(queue.NumOfElements());
        }
    }
}
