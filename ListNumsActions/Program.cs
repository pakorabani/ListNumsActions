using System;
using System.Collections.Generic;
using System.Linq;

namespace ListNumsActions
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            while (true)
            {
                string[] cmd = Console.ReadLine().Split().ToArray();
                string command = cmd[0];
                if (command.ToLower() == "finish")
                {
                    break;
                }
                switch (command)
                {
                    case "ins":
                        //TODO
                        break;
                    case "del":
                        var index = int.Parse(cmd[1]);
                        nums.RemoveAt(index);
                        break;
                    case "print":
                        Console.WriteLine(string.Join(" ", nums));
                        break;
                    case "contains":
                        //TODO
                        break;
                    case "remove":
                        //TODO
                        break;
                    case "large":
                        index = int.Parse(cmd[1]);
                        List<int> FilterList = nums.FindAll(x => x > index);
                        foreach (var num in FilterList)  
                        {  
                            Console.WriteLine(num);  
                        }   
                        break;
                    //TODO

                    default:
                        break;
                }
            }
        }
    }
}
