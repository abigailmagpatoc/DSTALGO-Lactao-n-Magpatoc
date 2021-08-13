using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSTALGO_Lactao_n_Magpatoc
{
    class Appointments
    {

        List<string> headsUpCustomer = new List<string>();

        public void BookAppoint(int treatment)
        {

            if (treatment == 1)
            {
                Console.Write("Enter name: ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                string custName = Convert.ToString(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.Gray;
                headsUpCustomer.Add(custName);

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nAppointment has been made! See you at the salon!");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            else if (treatment == 2)
            {
                Console.Write("Enter name: ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                string custName = Convert.ToString(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.Gray;
                headsUpCustomer.Add(custName);

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nAppointment has been made! See you at the salon!");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
        }

        public void ViewAppoint()
        {
            foreach (string items in headsUpCustomer)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("\t" + items + "\n\t");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
        }


    }
}
