using System.Collections.Generic;

namespace WindowsFormsApp1
{
    /// <summary>
    /// Очередь, у которой есть максимальное количество элементов
    /// </summary>
    /// <typeparam name="T">Тип данных, который будет храниться в очереди</typeparam>
    public class QueueLimited<T> : Queue<T>
    {
        /// <summary>
        /// Максимальное количество элементов
        /// </summary>
        public int Capacity { get; private set; }

        public QueueLimited(int maxSize) : base(maxSize)
        {
            Capacity = maxSize;
        }

        public QueueLimited() : base()
        {
            Capacity = 32;
        }

        /// <summary>
        /// Проверяет при добавлении на переполнение; если есть лишний элемент удаляет его
        /// </summary>
        /// <param name="element">Элемент, который добавляется в очередь</param>
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
