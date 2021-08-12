using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSTALGO_Lactao_n_Magpatoc
{
    class Stack
    {
        private object[] array;
        private int top;

        public Stack()
        {
            array = new object[5];
            top = -1;
                
        }

        public void Push(object item)
        {
            if(top < array.Length-1)
            {
                top++;
                array[top] = item;
            }
        }
    }
}
