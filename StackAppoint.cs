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

        private object[] array; //needs jagged array?

        private int top;

        public StackAppoint()
        {
            array = new object[7]; //7 time slots? (1)9am-10am, (2)10am-11am, (2)11am-12nn, (3)1pm-2pm, (4)2pm-3pm, (5)3pm-4pm, (6)4pm-5pm, (7)5pm-6pm

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
