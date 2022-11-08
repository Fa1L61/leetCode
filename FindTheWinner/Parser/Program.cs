using System;
using System.Collections.Generic;
using System.Linq;

namespace Parser
{
    class Program
    {
        static int GetWinner(int[] arr, int k)
        {
            List<int> arr2 = arr.ToList();
            int cnt = 0;

            for (int i = 0; i < arr2.Count - 1; i++)
            {
                if (arr2[i] > arr2[i + 1])
                {
                    arr2.Add(arr2[i + 1]);
                    arr2.RemoveAt(i + 1);
                    cnt++;
                    i = -1;

                    if (cnt == k)
                    {
                        i++;
                        return arr2[i];
                    }
                }
                else
                {
                    arr2.Add(arr2[i]);
                    arr2.RemoveAt(i);
                    cnt = 1;
                    i = -1;
                }
            }
            return 0;
        }
    

        static void Main(string[] args)
        {
            string[] arrStr = Console.ReadLine().Replace("[","").Replace("]","").Split(",");

            

            int[] arr = arrStr.Select(int.Parse).ToArray();
            int k = int.Parse(Console.ReadLine());

            Console.WriteLine(GetWinner(arr, k));
        }
    }
}
