using System;

namespace Progect_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("are are ~~~");
            int[] Fuck = new int[] { 1, 2, 3, 5, 6, 10 };
            ShowArray(Fuck);
            double[] f2 = new double[] { 2, 3, 4, 7, 8, 676 };
            PoshelNahu(f2);
        }
        
        public static void ShowArray(int[] arr)
        {
            Console.WriteLine();
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Fuck[" + i + "] = " + arr[i]);
            }
        }

        public static void  PoshelNahu(double[] f2)
        {
            foreach (var h in f2)
            {
                Console.WriteLine(h);
            }
        }
    }
}
