using System;

namespace QueueManager
{
        public class QueueNode<T>
        {
            public QueueNode(T value)
            {
                this.Value = value;
            }
            public T Value { get; set; }
            public QueueNode<T> Next { get; set; }
        }
}