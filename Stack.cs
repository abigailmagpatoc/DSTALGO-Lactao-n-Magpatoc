using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSTALGO_Lactao_n_Magpatoc
{
    class Stack
    {
        private string[] array;
        private int top;

        public Stack()
        {
            array = new string[5];
            top = -1;
                
        }

        public void Push(string item)
        {
            if(top < array.Length-1)
            {
                top++;
                array[top] = item;
            }
        }
    }
}
