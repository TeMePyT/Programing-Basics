using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Longest_Increasing_Subsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int[] len = new int[numbers.Count];
            int[] prev = new int[numbers.Count];

            for (int i = 0; i < numbers.Count; i++)
            {
                
                int biggestLen = 0;
                int biggestIndex = -1;
                
                for (int j = i; j >= 0; j--)
                {
                    if (numbers[j] < numbers[i] && len[j]>=biggestLen)
                    {
                        biggestLen = len[j];
                        biggestIndex = j;
                       
                    }

                }
                prev[i] = biggestIndex;
                len[i] = GetLen(i, numbers, prev);
            }

            int index = len.ToList().FindIndex(l => l == len.Max());
            List<int> sequence = GetSequence(index, numbers, prev);
            Console.WriteLine(string.Join(" ", sequence));
        }

        private static List<int> GetSequence(int index, List<int> numbers, int[] prev)
        {
            if(prev[index]<0)
            {
                
                return new List<int> { numbers[index] } ;
            }
            else
            {
               List<int> list = GetSequence(prev[index], numbers, prev);
                list.Add(numbers[index]);
                return list;
            }
        }

        private static int GetLen(int i, List<int> numbers, int[] prev)
        {
            if (prev[i]<0)
            {
                return 1;
            }
            else
            {
                int a = GetLen(prev[i], numbers, prev);
                return a + 1;
            }
        }
    }
}
