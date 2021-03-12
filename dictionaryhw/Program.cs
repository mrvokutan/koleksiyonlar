using System;
using System.Collections.Generic;

namespace dictionaryhw
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] urunler = new string[] {"masa", "kalem", "defter" };
            Console.WriteLine(urunler[0]);
            Console.WriteLine(urunler[1]);
            Console.WriteLine(urunler[2]);

            List<string> urunler2 = new List<string>() { "masa", "kalem", "defter" };
            Console.WriteLine(urunler[0]);
            Console.WriteLine(urunler[1]);
            Console.WriteLine(urunler[2]);
            
            urunler2.Add("silgi");
            Console.WriteLine(urunler2[3]);
            

        }
    }
}
