using System;
using System.Collections;
using System.Collections.Generic;


namespace DSTALGO_Lactao_n_Magpatoc
{
    class Program
    {
        static void Main(string[] args)
        {
            var headsUpCustomer = new Dictionary<string, string>();
            headsUpCustomer.Add("1000AM", " ");
            headsUpCustomer.Add("1100AM", " ");
            headsUpCustomer.Add("0100PM", " ");
            headsUpCustomer.Add("0200PM", " ");
            headsUpCustomer.Add("0300PM", " ");
            headsUpCustomer.Add("0400PM", " ");
            headsUpCustomer.Add("0500PM", " ");
            headsUpCustomer.Add("0600PM", " ");

            Console.WriteLine("----------------------------------");
            Console.WriteLine("            HEADS UP!");
            Console.WriteLine("    A salon appointment program  ");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("\n\t[1]-Customer" + "\n\t[2]-Salon Staff");
            
           
            Console.Write("\nLogin as : ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            int user = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Gray;

            if (user == 1)
            {
               while (true)
                {
                    Console.WriteLine("What are you here for?");

                    while (true)
                    {
                        Console.WriteLine("\t[1]-Book an appointment" + "\n\t[2]-View appointment schedules" +
                        "\n\t[3]-Request a specific Salon Staff");
                        Console.Write("\nEnter operation: ");
                        Console.ForegroundColor = ConsoleColor.Yellow;
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

                            if (service == 1)
                            {
                                Console.Write("What time do you like? ");

                                string time = Convert.ToString(Console.ReadLine());
                                if (headsUpCustomer.ContainsKey(time))
                                {
                                    Console.Write("Name of customer : ");
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    string custName = Convert.ToString(Console.ReadLine());
                                    headsUpCustomer[time] = custName;
                                    Console.ForegroundColor = ConsoleColor.Gray;

                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.Write("\nUpdating record...");
                                    Console.WriteLine("\nAppointment has been made! See you at the salon!");
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("\nTime selected is not available");
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                }
                                Console.ReadKey();
                            }
                            if (service == 2)
                            {
                                Console.Write("What time do you like? ");
                                string time = Convert.ToString(Console.ReadLine());
                                if (headsUpCustomer.ContainsKey(time))
                                {
                                    Console.Write("Name of customer : ");
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    string custName = Convert.ToString(Console.ReadLine());
                                    headsUpCustomer[time] = custName;
                                    Console.ForegroundColor = ConsoleColor.Gray;

                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.Write("\nUpdating record...");
                                    Console.WriteLine("\nAppointment has been made! See you at the salon!");
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("\nTime selected is not available");
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                }
                                Console.ReadKey();
                            }
                        }
                        if (choice == 2)
                        {
                            Console.WriteLine("\nTime       Customer Name");
                            foreach (KeyValuePair<string, string> items in headsUpCustomer)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine(items.Key + " : " + items.Value);
                                Console.ForegroundColor = ConsoleColor.Gray;
                            }
                            Console.ReadKey();
                        }
                        if (choice == 3)
                        {
                            Console.ReadKey();
                        }
                        if (choice == 4)
                        {
                            Console.ReadKey();
                        }
                    }

                }
            }

            if (user == 2)
            {
                Console.Write("\nUsername : ");
                string uname = Convert.ToString(Console.ReadLine());
                Console.Write("Password : ");
                string pwd = Convert.ToString(Console.ReadLine());
                if (uname.Equals("Admin") && pwd.Equals("Admin"))
                {
                    Console.WriteLine("\t[1]-View appointments" + "\n\t[2]-Search appointment");
                    Console.Write("What are you here for? ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    int choice = Convert.ToInt32(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.Gray;

                    if (choice == 1)
                    {
                        Console.WriteLine("\nTime       Customer Name");
                        foreach (KeyValuePair<string, string> items in headsUpCustomer)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine(items.Key + " : " + items.Value);
                            Console.ForegroundColor = ConsoleColor.Gray;
                        }
                    }
                    if (choice == 2)
                    {
                        Console.Write("Search customer name : ");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        string custName = Convert.ToString(Console.ReadLine());
                        Console.ForegroundColor = ConsoleColor.Gray;
                        string time;
                        if (headsUpCustomer.TryGetValue(custName, out time))
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("One appointment found : " + time);
                            Console.ForegroundColor = ConsoleColor.Gray;

                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nNo appointment found");
                            Console.ForegroundColor = ConsoleColor.Gray;

                        }
                    }
                }
                else 
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid Username/Password");
                Console.ForegroundColor = ConsoleColor.Gray;

            }
        }
    }
}
