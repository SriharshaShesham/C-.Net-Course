using System;
using System.Collections.Generic;

namespace _4._1.Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> numQueue=new Queue<int>();
            //Add
            //Remove
            //Clear
            //Contains

            numQueue.Enqueue(1);
            numQueue.Enqueue(2);
            numQueue.Enqueue(3);
            numQueue.Enqueue(4);
            numQueue.Enqueue(5);
            numQueue.Enqueue(6);

            PrintTheQueue(numQueue);


            System.Console.WriteLine("Number being DeQueued is "+numQueue.Dequeue());;

            PrintTheQueue(numQueue);

        }
        static void PrintTheQueue(Queue<int> QueueToPrint)
        {
            System.Console.WriteLine("Printing");
            foreach(int num in QueueToPrint)
                System.Console.Write(num+"   |   ");
        }
    }

    class MyQueue
    {
        List<int> myQueue= new List<int>();

        public void Add(int number)
        {
            myQueue.Add(number);
        }

        public int Delete()
        {
            int numberToBeDeleted= myQueue[0];
            myQueue.RemoveAt(0);
            return numberToBeDeleted;
        }
    }
    
}
