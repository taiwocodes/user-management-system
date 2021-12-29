using System;

namespace QueueManager
{
        public class QueueUsers<T>
        {

            public QueueNode<T> Head { get; set; }
            public QueueNode<T> Tail { get; set; }
            public int Count { get; set; }

            // user built in enqueue method
            public QueueNode<T> Enqueue(T value)
            {
                QueueNode<T> node = new QueueNode<T>(value);

                if (this.Head == null)
                {
                    Head = Tail = node;
                    this.Count++;
                    return node;
                }

                this.Tail.Next = node;
                this.Tail = node;
                this.Count++;
                return node;
            }


            // user built in dequeue method
            public T Dequeue()
            {
                if (Head == null)
                {
                    throw new InvalidOperationException("This Queue is empty");
                }

                T value = this.Head.Value;
                this.Head = this.Head.Next;
                this.Count--;
                return value;
            }

            //getting data in queue
            public void Print()
            {
                var temp = Head;
                while (temp != null)
                {
                    System.Console.WriteLine(temp.Value);
                    temp = temp.Next;
                }
            }

        }
 }
