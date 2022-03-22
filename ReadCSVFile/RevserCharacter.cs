using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReadCSVFile
{
    public class RevserCharacter
    {

    }
    //store a Queue entry
    //A linked list node to
    public class QNode
    {
        public int Key;
        public QNode next;

        //constructor to create 
        //a new linked list node
        public QNode(int key)
        {
            this.Key = key;
            this.next = null;
        }
    }
    // A class to represent a queue The queue, 
    // front stores the front node of LL and 
    // rear stores the last node of LL 
    class Queue
    {
        QNode front, rear;

        public Queue()
        {
            this.front = this.rear = null;
        }

        // Method to add an key to the queue. 
        public void enqueue(int key)
        {

            // Create a new LL node 
            QNode temp = new QNode(key);

            // If queue is empty, then new 
            // node is front and rear both 
            if (this.rear == null)
            {
                this.front = this.rear = temp;
                return;
            }

            // Add the new node at the 
            // end of queue and change rear 
            this.rear.next = temp;
            this.rear = temp;
        }

        // Method to remove an key from queue. 
        public void dequeue()
        {
            // If queue is empty, return NULL. 
            if (this.front == null)
                return;

            // Store previous front and 
            // move front one node ahead 
            QNode temp = this.front;
            this.front = this.front.next;

            // If front becomes NULL, 
            // then change rear also as NULL 
            if (this.front == null)
                this.rear = null;
        }
    }

    public class Test
    {
        void Main(String[] args)
        {
            Queue q = new Queue();
            q.enqueue(10);
            q.enqueue(20);
            q.dequeue();
            q.dequeue();
            q.enqueue(30);
            q.enqueue(40);
            q.enqueue(50);
            q.dequeue();
            Console.WriteLine("Queue Front : " + q);
            Console.WriteLine("Queue Rear : " + q);
        }
    }
}



