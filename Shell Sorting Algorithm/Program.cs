using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shell_Sorting_Algorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { 1, 5, 9, 3, 5, 7 };
            int[] ints2 = ShellSorting(ints, 6);
            for(int i = 0; i < ints2.Length; i++)
            {
                Console.WriteLine(ints2[i]);
            }
            Console.ReadLine();
        }
        public static int[] ShellSorting(int[] A ,int N)
        {
            for(int gap = N/2; gap > 0; gap = gap/2)
            {
                for(int i = gap; i<N; i++)
                {
                    int gvalue = A[i];
                    int j = i - gap;
                    while(j>=0 && A[j] > gvalue)
                    {
                        A[j+gap] = A[j];
                        j = j - gap;

                    }
                    A[j+gap]= gvalue;
                }

            }
            return A;
        }
    }
}
