using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EventsIntroduction
{
    internal class Program
    {
        //Delegate
        public delegate string MessageDelegate(string msg);
        //Event
        public static event MessageDelegate MessageEvent;

        public event EventHandler TheName;
        static void Main(string[] args)
        {
            //register an event
            MessageEvent += GetMessage;
            string output = MessageEvent("Hello World");
            Console.WriteLine(output);

        }

        static string GetMessage(string message)
        {

            return message;
        }

    }
}
