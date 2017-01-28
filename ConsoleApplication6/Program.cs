using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {   public static int check (int a)
        {
            for (int i = 2; i < Math.Round(Math.Sqrt(a)); ++i)
            {
                if (a % i == 0) return 0;
            }
            return 1;
        }
        static int Main(string[] args)
        {
            int[] a = new int [args.Length];
            for (int i=0; i<args.Length; ++i)
            {
                a[i] = int.Parse(args[i]);
                if (check(a[i]) == 1) {Console.WriteLine(a[i]); return 0; }
            }
            return 0;
        }
    }
}
