using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSTALGO_Lactao_n_Magpatoc;
using System.Globalization;


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

        public void Sort() // bug* still needs work. itemInto cannot be null but queue has null slots
        {
            
            string[][] tempArray = GetArray(); 

            for (int i = 1; i < tempArray.Length; i++)
            {
                DateTime hoursInto = new DateTime();
                DateTime hoursTemp = new DateTime();
                string format = "hhmmtt";
                string itemInto = tempArray[i][1];
                hoursInto = DateTime.ParseExact(itemInto, format, CultureInfo.InvariantCulture);
                int j;
                for (j = i; j > 0; j--)
                {
                    hoursTemp = DateTime.ParseExact(tempArray[j][1], format, CultureInfo.InvariantCulture);

                    if (hoursInto.CompareTo(hoursTemp) == -1)
                    {
                        tempArray[j][1] = tempArray[j - 1][1];
                    }
                    else break;
                }
                tempArray[j][1] = itemInto;
            }
            array = tempArray;

            //int lowerB = 0;
            //int upperB = index;
            //int midIndex;
            //while (lowerB <= upperB)
            //{
            //    midIndex = (lowerB + upperB) / 2;
            //    if (item == int.Parse(array[midIndex][0]))
            //    {
            //        return midIndex;

            //    }
            //    else if (item < int.Parse(array[midIndex][0]))
            //    {
            //        upperB = midIndex - 1;
            //    }
            //    else if (item > int.Parse(array[midIndex][0]))
            //    {
            //        lowerB = midIndex + 1;
            //    }
            //}
            //return -1;

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
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write("\t" + array[index][i]);
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                index = (index + 1) % array.Length;
                counter--;
            }

        }

        public string[][] GetArray()
        {
            int counter = count;
            string[][] tempArr = new string[counter][];
            for (int i = 0; i < tempArr.Length; i++)
            {
                tempArr[i] = array[i];
            }
            return tempArr;
        }

        public string[] GetListArray(int dim)
        {
            string[] tempArr = array[dim];
            return tempArr;
        }

    }
}
