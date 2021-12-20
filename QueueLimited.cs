using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class QueueLimited<T> : Queue<T>
    {
        public int Capacity { get; private set; }
        public QueueLimited(int maxSize) : base(maxSize)
        {
            Capacity = maxSize;
        }

        public QueueLimited() : base()
        {
            Capacity = 32;
        }

        public void Add(T element)
        {
            if (Count >= Capacity)
            {
                Dequeue();
            }
            Enqueue(element);
        }
    }
}
