using System;

namespace genericIntroo
{
    class Program
    {
        static void Main(string[] args)
        {
            MyListt<string> isimler = new MyListt<string>();
            isimler.Add("engin");

            Console.WriteLine(isimler.Length);



        }
    }
}
