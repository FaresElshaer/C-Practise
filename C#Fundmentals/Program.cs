using System;
using System.Collections;

namespace CSharpFundamentals
{
    class Program
    {
        private static readonly Dictionary<string, string> PasswordEntries = new();
        static void Main(string[] args)
        {
            Readpassword();
            while (true)
            {
                Console.WriteLine("Please select an option:");
                Console.WriteLine("1:List All Passwords");
                Console.WriteLine("2:Add/Change Password");
                Console.WriteLine("3:Get Password");
                Console.WriteLine("4:Delete Password");
                var selectedOption = Console.ReadLine();
                if (selectedOption == "1")
                {
                    ListAllPasswords();
                }
                else if (selectedOption == "2")
                {
                    AddOrChangePassword();
                }
                else if (selectedOption == "3")
                {
                    GetPassword();
                }
                else if (selectedOption == "4")
                {
                    DeletePassword();
                }
                else
                {
                    Console.WriteLine("Invalid option selected.");
                }
                Console.WriteLine("-------------------------------");
            }
        }

        private static void Readpassword()
        {

        }

        private static void DeletePassword()
        {
            Console.WriteLine("Please enter password:");
            var password = Console.ReadLine();
            if (PasswordEntries.ContainsValue(password))
            {

                PasswordEntries.Remove(appName);
                Console.WriteLine("Password deleted.");
            }
            else
            {
                Console.WriteLine("Password not found.");
            }
        }

        private static void GetPassword()
        {
            Console.WriteLine("Please enter password:");
            var password = Console.ReadLine();
            if (PasswordEntries.ContainsValue(password))
            {
                Console.WriteLine("Password found.");
            }
            else
            {
                Console.WriteLine("Password not found.");
            }
        }

        private static void ListAllPasswords()
        {
            foreach (var entry in PasswordEntries)
            { Console.WriteLine($"{entry.Key}={entry.Value}"); }
        }

        private static void AddOrChangePassword()
        {
            Console.WriteLine("Please enter website/App Name:");
            var appName = Console.ReadLine();
            Console.WriteLine("Please enter password:");
            var password = Console.ReadLine();
            if (PasswordEntries.ContainsKey(appName))
            {
                PasswordEntries[appName] = password;
                Console.WriteLine($"Password for {appName} updated.");
            }
            else
            {
                PasswordEntries.Add(appName, password);
                Console.WriteLine($"Password for {appName} added.");
            }
        }
    }