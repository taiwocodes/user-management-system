using System;
using System.IO;
using UserManagementSystem;

namespace UserRegistrationManager
{
    public class UserFileManager
    {
        //creating the text file to write to while making it globally accessible field
        public static string path = @"../UserFileManager/UserDetails.txt";
        public static void CreateFile()
        {
            //create the text file to write to string path
            if (!File.Exists(path))
            {
                using StreamWriter sw = File.CreateText(path);
            }


            // write to created file
            using (StreamWriter streamWriter = File.AppendText(path))
            {
                // add user details upon registration
                streamWriter.WriteLine(UserRegistration.RegisterUser());
            }

        }

        //reading and getting the datas in the vreated file
        public static void GetUserDetails()
        {
            using (StreamReader streamReader = File.OpenText(path))
            {
                var read = streamReader.ReadToEnd();
                read = read.TrimEnd();
                var users = read.Split(Environment.NewLine);
                var last = users[^1];
                foreach (var item in users)
                {
                    var user = item.Split(',');
                    System.Console.WriteLine(item);

                }
            }
        }
    }
}

