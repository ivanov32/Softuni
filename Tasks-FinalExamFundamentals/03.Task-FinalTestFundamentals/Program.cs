using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;


namespace _03.Task_FinalTestFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> followers = new Dictionary<string, List<int>>();
            int followersCount = 0;
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Log out")
                {
                    break;
                }
                string[] data = input.Split(":", StringSplitOptions.RemoveEmptyEntries);
                string task = data[0];
                int likes = 0;
                int comments = 0;
                if (task == "New follower")
                {
                    string name = data[1];
                    if (!followers.ContainsKey(name))
                    {
                        followersCount++;
                        followers.Add(name, new List<int> {likes,comments});
                    }
                }
                else if (task == "Like")
                {
                    string name = data[1];
                    int likesCount = int.Parse(data[2]);
                    if (!followers.ContainsKey(name))
                    {
                        followersCount++;
                        followers.Add(name, new List<int> { likes, comments });
                        followers[name][0] += likesCount;
                    }
                    else
                    {
                        followers[name][0] += likesCount;
                    }
                }
                else if (task == "Comment")
                {
                    string name = data[1];
                   
                    if (!followers.ContainsKey(name))
                    {
                        followersCount++;
                        followers.Add(name, new List<int> { likes, comments });
                        followers[name][1] += 1 ;
                    }
                    else
                    {
                        followers[name][1] += 1;
                    }
                }
                else if (task == "Blocked")
                {
                    string name = data[1];
                    if (followers.ContainsKey(name))
                    {
                        followersCount-=1;
                        followers.Remove(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} doesn't exist.");
                    }
                }

            }
            Dictionary<string, int> followersWithSummedCommentsAndLikes = new Dictionary<string, int>();
            Console.WriteLine($"{followersCount} followers");
            foreach (var item in followers)
            {
                string name = item.Key;
                int sum = item.Value[0] + item.Value[1];
                followersWithSummedCommentsAndLikes.Add(name, sum);
            }
            foreach (var item in followersWithSummedCommentsAndLikes.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
