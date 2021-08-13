using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSTALGO_Lactao_n_Magpatoc;

namespace DSTALGO_Lactao_n_Magpatoc
{
    class CircularQueue
    {
        private string[][] array;

        private int count, front, rear;

        public CircularQueue()
        {
            array = new string[8][];
            array[0] = new string[4];
            array[1] = new string[4];
            array[2] = new string[4];
            array[3] = new string[4];
            array[4] = new string[4];
            array[5] = new string[4];
            array[6] = new string[4];
            array[7] = new string[4];
            count = 0; front = 0; rear = -1;
        }
        public int Count
        {
            get { return count; }
        }
        public void Enqueue(string[] arr)
        {
            if (count < array.Length) //bug* object reference?
            {
                rear++;
                array[rear] = arr;
                //for (int i = 0; i < array[rear].Length; i++)
                //{
                //    array[rear][i] = arr;
                //}
                count++;
            }
            else
            {
                throw new Exception("Queue is full");
            }
        }

        public string Dequeue()
        {
            if (count > 0)
            {
                string item = array[front][0];
                front++;
                count--;
                return item;
            }
            else
            {
                throw new Exception("Queue is empty");
            }
        }

        public string Peek()
        {
            if (count > 0)
            {
                string item = array[front][0];
                return item;
            }
            else
            {
                throw new Exception("Queue is empty");
            }
        }

        public void ViewQAppoints()
        {
            int counter = count;
            int index = front;
            while(counter > 0)
            {
                //Console.WriteLine(array[index]);
                for (int i = index; i < array[index].Length; i++)
                {
                    Console.Write("\t" + array[index][i]);
                }
                index = (index + 1) % array.Length;
                counter--;
            }

        }

        public string[][] GetArray()
        {
            return array;
        }

    }
}
