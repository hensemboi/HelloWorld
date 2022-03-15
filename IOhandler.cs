using System;

namespace HelloWorld
{
    public class IHandler
    {
        public string input(string txt)
        {
            Console.WriteLine(txt);
            return Console.ReadLine();
        }
    }
}