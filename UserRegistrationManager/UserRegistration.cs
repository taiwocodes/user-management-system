using System;
using System.Collections.Generic;

namespace UserManagementSystem
{
    public class UserRegistration
    {
        public static string Fullname;
        public static string Email;
        public static string PhoneNum;
        public static string FavoriteColor;
        public static string FavoriteFood;


        // get user details
        public static string RegisterUser()
        {
            System.Console.Write("Taiwo's user management system :\n");

            System.Console.WriteLine("Enter your fullname :");
            Fullname = Console.ReadLine();

            System.Console.WriteLine("Enter your email address:");
            Email = Console.ReadLine();

            System.Console.WriteLine("Enter your phone number:");
            PhoneNum = Console.ReadLine();

            System.Console.WriteLine("Enter your favorite color:");
            FavoriteColor = Console.ReadLine();

            System.Console.WriteLine("Enter your favorite food:");
            FavoriteFood = Console.ReadLine();

            return $"{Fullname}, {Email}, {PhoneNum}, {FavoriteColor}, {FavoriteFood}";
        }
    }
}


