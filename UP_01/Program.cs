using System;

namespace UP_01
{
    class Program
    {
        static void Main(string[] args)
        {
            string q = Console.ReadLine();
            switch (q)
            {
                case "1":
                    Izdelie M = new Izdelie();
                    M.SetInfo();
                    Console.WriteLine("");
                    M.GetInfo();
                    
                    break;
            }
            Console.ReadLine();
        }
    }
}
