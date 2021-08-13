using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSTALGO_Lactao_n_Magpatoc
{
    class ListAppointments
    {
        private string[][] array;

        private int index;

        public ListAppointments()
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
            index = -1;
        }
        public void Add(string[] item)
        {
            index++;
            if (index < array.Length)
            {
                array[index] = item;
            }
            else
            {
                index--;
                DoubleNoRows();
                Add(item);
            }
        }

        public void Insert(int index, string[] item)
        {
            if (index > -1 && index <= this.index)
            {
                for (int i = this.index; i >= index; i--)
                {
                    array[i + 1] = array[i];
                }
                array[index] = item;
                this.index++;
            }
            else
                throw new Exception("Index out of range");
        }

        public void RemoveAt(int index)
        {
            if (index > -1 && index <= this.index)
            {
                for (int i = this.index; i >= index; i--)
                {
                    array[i] = array[i + 1];
                }
                this.index--;
            }
            else
                throw new Exception("Index out of range");
        }

        private void DoubleNoRows()
        {
            string[][] newArr = new string[array.Length * 2][];
            for (int i = 0; i < array.Length; i++)
            {
                newArr[i] = array[i];
            }
            array = newArr;
        }


        public string[][] GetListArray()
        {
            string[][] tempArr = new string[index + 1][];
            for (int i = 0; i < tempArr.Length; i++)
            {
                tempArr[i] = array[i];
            }
            return tempArr;
        }

        public void PrintList(string[][] list)
        {

            foreach (string[] record in list)
            {
                Console.Write("\n");
                foreach (string item in record)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write("\t" + item);
                    Console.ForegroundColor = ConsoleColor.Gray;
                }

            }
        }

    }
}
