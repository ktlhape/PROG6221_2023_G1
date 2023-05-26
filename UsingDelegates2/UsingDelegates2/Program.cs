using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingDelegates2
{
    internal class Program
    {
        delegate void PrintDelegate(string msg);
        static void Main(string[] args)
        {
            ConnectToDB(PrintToConsole);
            ConnectToDB(PrintToFile);
        }
        static void PrintToConsole(string message)
        {
            Console.WriteLine(message);
        }
        static void PrintToFile(string message)
        {
            //logic to print to file
        }
        static void ConnectToDB(PrintDelegate logFile )
        {
            //logic to connect to database
            logFile("Connected to DB");
        }
    }
}
