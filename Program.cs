using System;

namespace yafa
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] n= new int[5];
            Console.WriteLine("5 nums");
            for (int i = 0; i < n.Length; i++)
            {
                n[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 4; i < n.Length; i--)
            {
                Console.WriteLine(n[i]);
            }
           
            
        }
    }
}
