using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;


namespace _02.Task_FinalTestFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputs = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < inputs; i++)
            {
                string passwordAndName = Console.ReadLine();
                Regex regex = new Regex(@"U\$(?<username>[A-Z][a-z][a-z]+)U\$P@\$(?<password>[A-Za-z][A-Za-z][A-Za-z][A-Za-z][A-Za-z]+[1-9]+)P@\$");
                Match match = regex.Match(passwordAndName);
                if (match.Success)
                {
                    Console.WriteLine("Registration was successful");
                    Console.WriteLine($"Username: {match.Groups["username"]}, Password: {match.Groups["password"]}");
                    count++;
                }
                else
                {
                    Console.WriteLine($"Invalid username or password");
                }
            }
            Console.WriteLine($"Successful registrations: {count}");


        }
    }
}
