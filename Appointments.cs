using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace DSTALGO_Lactao_n_Magpatoc
{
    class Appointments
    {

        //List<string> headsUpCustomer = new List<string>();

        //ArrayList headsUpCustomer = new ArrayList();

        string[][] allAppoints = new string[7][]; //7 time slots, 3 -> id/key, name, treatment 
        string[] allAppoints1 = new string[3];

        int id = 100;

        public void BookAppoint(int treatment)
        {
            //queue 

            string[] headsUpCustomer = new string[3];

            if (treatment == 1) //hair treatment
            {
                Console.Write("Enter name: ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                id++;
                string custName = Convert.ToString(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.Gray;
                headsUpCustomer[0] = id.ToString();
                headsUpCustomer[1] = custName;
                headsUpCustomer[3] = "Hair Treatment";


                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nAppointment has been made! See you at the salon!");
                Console.ForegroundColor = ConsoleColor.Gray;

            }
            else if (treatment == 2) //nail treatment
            {
                Console.Write("Enter name: ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                id++;
                string custName = Convert.ToString(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.Gray;
                headsUpCustomer[0] = id.ToString();
                headsUpCustomer[1] = custName;
                headsUpCustomer[3] = "Nail Treatment";

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nAppointment has been made! See you at the salon!");
                Console.ForegroundColor = ConsoleColor.Gray;
            }

            allAppoints1 = headsUpCustomer;

        }

        public void ViewAppoint()
        {
            //foreach (string items in allAppoints)
            //{
            //    Console.ForegroundColor = ConsoleColor.Yellow;
            //    Console.Write("\t" + items + "\n\t");
            //    Console.ForegroundColor = ConsoleColor.Gray;
            //}

            for (int i = 0; i < allAppoints.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(i + 1);
                Console.ForegroundColor = ConsoleColor.Gray;

                for (int j = 0; j < allAppoints[i].Length; j++)
                {
                    Console.Write("\t" + allAppoints[i][j]);
                }
                Console.WriteLine();

            }
            Console.ReadKey();
        }


    }
}
