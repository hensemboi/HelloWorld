using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            String _name;
            IHandler io = new IHandler();
            Console.WriteLine("Hello World!");
            Message mesej = new Message("hahahaha");
            mesej.print();
            do
            {
                _name = io.input("Who are you?").ToLower();
                switch (_name)
                {
                    case "karen":
                        mesej.ptext = ("Oh no, not Karen :(");
                        break;
                    case "ali":
                        mesej.ptext = ("OH, the famous guy in Japan! The one people will call whenever they receive ssomething!");
                        break;
                    case "mary":
                        mesej.ptext = ("had a little lamb, little lamp, little lame");
                        break;
                    case "will":
                        mesej.ptext = ("You front will or back will?");
                        break;
                    case "yu":
                        mesej.ptext = ("no, not me but you.");
                        break;
                    default:
                        mesej.ptext = ("Rejected.");
                        break;
                };       
                mesej.print(); 
            }while (_name == "yu");
                
        }
    }
}
