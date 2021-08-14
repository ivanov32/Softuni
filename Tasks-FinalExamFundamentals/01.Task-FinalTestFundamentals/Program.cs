using System;

namespace _01.Task_FinalTestFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Sign up")
                {
                    break;
                }
                string[] data = input.Split();
                string task = data[0];
                if (task == "Case")
                {
                    string upperOrLower = data[1];
                    if (upperOrLower == "lower")
                    {
                        username = username.ToLower();
                    }
                    else if (upperOrLower == "upper")
                    {
                        username = username.ToUpper();
                    }
                    Console.WriteLine(username);
                }
                else if (task == "Reverse")
                {
                    int startIndex = int.Parse(data[1]);
                    int endIndex = int.Parse(data[2]);
                    if (startIndex < username.Length && endIndex < username.Length && startIndex >= 0 && endIndex > startIndex)
                    {
                        string substring = username.Substring(startIndex, endIndex);
                        for (int i = substring.Length - 1; i >= 0; i--)
                        {
                            Console.Write(substring[i]);
                        }
                        Console.WriteLine("");
                    }
                    else
                    {
                        Console.WriteLine("");
                        break;
                    }
                }
                else if (task == "Cut")
                {
                    string givenSubstring = data[1];
                    int indexOfGivenSubstring = username.IndexOf(givenSubstring);
                    if (indexOfGivenSubstring != -1)
                    {
                        username = username.Remove(indexOfGivenSubstring, givenSubstring.Length);
                        Console.WriteLine(username);
                    }
                    else
                    {
                        Console.WriteLine($"The word {username} doesn't contain {givenSubstring}.");
                    }
                }
                else if (task == "Replace")
                {
                    string charToReplace = data[1];
                    while (true)
                    {
                        int indexOfChar = username.IndexOf(charToReplace);
                        if (indexOfChar < 0)
                        {
                            break;
                        }
                        username = username.Replace(charToReplace, "*");
                    }
                    Console.WriteLine(username);
                }
                else if (task == "Check")
                {
                    string neededChar = data[1];
                    int indexOfNeededChar = username.IndexOf(neededChar);
                    if (indexOfNeededChar != -1)
                    {
                        Console.WriteLine("Valid");
                    }
                    else
                    {
                        Console.WriteLine($"Your username must contain {neededChar}.");
                    }
                }
            }
        }
    }
}
