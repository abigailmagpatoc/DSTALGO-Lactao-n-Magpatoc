using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSTALGO_Lactao_n_Magpatoc
{
    class StackAppoint
    {
        //for undo button? -> allow customer user to undo/pop recent appointment

        private object[] array;

        //
        private int top;

        public StackAppoint()
        {
            array = new object[6];
            //6 time slots? 
            top = -1;
                
        }

        public void Push(object item)
        {
            if(top < array.Length-1)
            {
                top++;
                array[top] = item;
            }
            else
            {
                throw new Exception("Stack Overflow");
            }
        }

        public object Pop()
        {
            if(top > -1)
            {
                object item = array[top];
                top--;
                return item;
            }
            else
            {
                throw new Exception("Stack Empty");
            }
        }


        public object Peek()
        {
            if (top > -1)
            {
                object item = array[top];
                return item;
            }
            else
            {
                throw new Exception("Stack Empty");
            }
        }

        public void Clear()
        {
            top = -1;
        }

        public void ViewStack()
        {
            for (int i = top; i >= 0; i--)
            {
                Console.WriteLine(array[i]);
            }
        }



    }
}
