using System;
 
namespace TestAppl
{
    class Program
    {
        static void Main(String[] args)
        {
            var a = new Int32[4][];
 
            var random = new Random();
            for (var i = 0; i < a.Length; i++)
            {
                a[i] = new Int32[5];
                for (var j = 0; j < a[i].Length; j++)
                {
                    a[i][j] = random.Next(100);
                }
            }
            Print(a);
 
            GetStatistic(a);
 
            Console.WriteLine("");
            //сортируем
            foreach (Int32[] t in a)
                Array.Sort(t, ((i, i1) => i1.CompareTo(i)));
            Print(a);
            GetStatistic(a);
            Console.Read();
        }
 
        static void Print(Int32[][] a)
        {
            for (var i = 0; i < a.Length; i++, Console.WriteLine())
                for (var j = 0; j < a[i].Length; j++)
                {
                    Console.Write("{0,4}", a[i][j]);
                }
        }
 
        static void GetStatistic(Int32[][] a)
        {
            Console.WriteLine("========");
            Int32
                max = a[0][0],
                min = a[0][0],
                maxI = 0,
                maxJ = 0,
                minI = 0,
                minJ = 0;
 
            for (var i = 0; i < a.Length; i++)
                for (var j = 0; j < a[i].Length; j++)
                {
                    if (max < a[i][j])
                    {
                        max = a[i][j];
                        maxI = i;
                        maxJ = j;
                    }
                    if (min > a[i][j])
                    {
                        min = a[i][j];
                        minI = i;
                        minJ = j;
                    }
                }
            
        }
    }
}