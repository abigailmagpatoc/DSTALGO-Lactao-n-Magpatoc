using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSTALGO_Lactao_n_Magpatoc;

namespace DSTALGO_Lactao_n_Magpatoc
{
    class CircularQueue<T>
    {
        private T[] array;

        private int count, front, rear;

        public CircularQueue()
        {
            array = new T[8];
            count = 0; front = 0; rear = -1;
        }
        public int Count
        {
            get { return count; }
        }
        public void Enqueue(T item)
        {
            if (count < array.Length)
            {
                rear++;
                array[rear] = item;
                count++;
            }
            else
            {
                throw new Exception("Queue is full");
            }
        }

        public T Dequeue()
        {
            if (count > 0)
            {
                T item = array[front];
                front++;
                count--;
                return item;
            }
            else
            {
                throw new Exception("Queue is empty");
            }
        }

        public T Peek()
        {
            if (count > 0)
            {
                T item = array[front];
                return item;
            }
            else
            {
                throw new Exception("Queue is empty");
            }
        }

        public void viewQAppoints()
        {
            int counter = count;
            int index = front;
            while(counter > 0)
            {
                Console.WriteLine(array[index]);
                index++;
                counter--;
            }

        }

    }
}
