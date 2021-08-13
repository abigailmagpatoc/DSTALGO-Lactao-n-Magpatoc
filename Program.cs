using System;
using System.Collections;
using System.Collections.Generic;
using DSTALGO_Lactao_n_Magpatoc;


namespace DSTALGO_Lactao_n_Magpatoc
{
    class Program 
    {
        

        static void Main(string[] args)
        {
            HeadsUp headsUp = new HeadsUp();
            Appointments appm = new Appointments();

            Console.WriteLine("-------------------------------");
            Console.WriteLine("   Welcome to Heads Up Salon");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("\n\t[1]-Customer" + "\n\t[2]-Salon Staff");
            Console.Write("\nLogin as : ");
            Console.ForegroundColor = ConsoleColor.Green;
            int user = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Gray;

            if (user == 1)
            {
                //Customer();

                Console.WriteLine("What are you here for?");
                Console.WriteLine("\t[1]-Book an appointment" + "\n\t[2]-View appointment schedules" +
                    "\n\t[3]-Request a specific Salon Staff" + "\n\tPress any key to exit");
                Console.Write("\nEnter your choice: ");
                Console.ForegroundColor = ConsoleColor.Green;
                int choice = Convert.ToInt32(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.Gray;

                if (choice == 1)
                {
                    Console.WriteLine("Which service would like to book?");
                    Console.WriteLine("\t[1]-Hair Traitment" + "\n\t[2]-Nail Treatment");
                    Console.Write("\nEnter your choice: ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    int service = Convert.ToInt32(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.Gray;
                    appm.BookAppoint(service);

                }
                if (choice == 2)
                {
                   
                }
                if (choice == 3)
                {

                }
                if (choice == 4)
                {

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\nThank you for using this application");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.ReadKey();
                }

            }
            else if (user == 2)
            {
                Console.WriteLine("What are you here for?");
                Console.WriteLine("\t[1]-View appointments" + "\n\t[2]-Search appointment");
                Console.ForegroundColor = ConsoleColor.Green;
                int choice = Convert.ToInt32(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.Gray;

                if (choice == 1)
                {
                    //foreach (string items in headsUpCustomer)
                    //{
                    //    Console.ForegroundColor = ConsoleColor.Yellow;
                    //    Console.Write("\t" + items + "\n\t");
                    //    Console.ForegroundColor = ConsoleColor.Gray;
                    //}
                    appm.ViewAppoint();

                }
                if (choice == 2)
                {

                }
            }
            Console.ReadKey();
        }

        public static void Customer()
        {

            
        }
        public void Staff()
        {
            
        }


        public class HeadsUp
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
   

}
