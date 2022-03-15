using System;

namespace HelloWorld
{

    public class Message
    {
        string _text;
        IHandler io = new IHandler();

        public string ptext
        {
            set{ _text = value;}
        }
        public Message(string txt) // Property
        {
            _text = txt;
        }

        public void print()
        {
            Console.WriteLine(_text);
        }
    }
}