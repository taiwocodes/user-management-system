using System;
using System.Collections.Generic;
using QueueManager;
using UserRegistrationManager;

namespace UserManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            bool startApp = true;
            while (startApp)
            {
                Console.Write("Welcome user :");
                Console.WriteLine("Enter: ");
                Console.WriteLine("1 to Register a User");
                Console.WriteLine("2 to Delete a User");
                Console.WriteLine("3 to Get all User Details");
                Console.WriteLine("4 to Clear the screen");
                Console.WriteLine("0 to Exit");

                Queue<string> myQueue = new Queue<string>();
                string begin = Console.ReadLine();

                switch (begin)
                {
                    case "1":
                        try
                        {
                            // create the user details file & add details to file as user is registered
                            UserFileManager.CreateFile();

                            Console.ReadKey();
                            Console.Clear();
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;
                    case "2":
                        try
                        {
                            myQueue.Dequeue();
                            Console.ReadKey();
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;
                    case "3":
                        try
                        {
                            UserFileManager.GetUserDetails(); // get user details from file

                            // expected user detail to output from queue
                            Console.ReadKey();
                            Console.Clear();
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;

                    case "4":
                        Console.Clear();
                        break;
                    case "0":
                        startApp = false;
                        break;
                    default:
                        Console.Clear();
                        break;
                }
            }
        }
    }
}
