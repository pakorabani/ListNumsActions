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
                        var index = int.Parse(cmd[1]);
                        var element = int.Parse(cmd[2]);
                        nums.Insert(index, element);
                        break;
                    case "del":
                        index = int.Parse(cmd[1]);
                        index = int.Parse(cmd[1]);
                        nums.RemoveAt(index);
                        break;
                    case "print":
                        Console.WriteLine(string.Join(" ", nums));
                        break;
                    case "print":
                        Console.WriteLine(string.Join(" ", nums));
                        break;
                    case "contains":
                        int el = int.Parse(cmd[1]);
                        if (nums.Contains(el))
                        {
                            Console.WriteLine("YES");
                        }
                        else
                        {
                            Console.WriteLine("NO");
                        }
                        break;
                    case "remove":
                       int index = int.Parse(cmd[1]);
                        nums.RemoveAt(index);
                        break;
                    case "cut":
                        index = int.Parse(cmd[1]);
                        if (index>=nums.Count)
                        {
                            nums.Clear();
                        }
                        else
                        {
                            for (int i = 0; i < index; i++)
                            {
                                nums.RemoveAt(0);
                            }
                        }
                       
                        break;
                    case "add":
                        index = int.Parse(cmd[1]);
                        element = int.Parse(cmd[2]);
                        int result = index + element;
                        nums.Add(result);
                        break;
                    case "countl":
                        int listel = int.Parse(cmd[1]);
                        List<int> CountList = nums.FindAll(x => x > listel);
                        Console.WriteLine(CountList.Count);
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
