using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleAppRobot
{
    public class Messages
    {
        public void PrintL(string msj)
        {
            Thread.Sleep(300);
            Console.Write(msj);
        }

        public void PrintL300(string msj)
        {
            Thread.Sleep(300);
            Console.Write(msj);
        }

        public void Print(string msj)
        {
            Thread.Sleep(300);
            Console.WriteLine(msj);

        }

        public void PrintA()
        {
            Thread.Sleep(300);
            PrintE();
            Console.WriteLine("*******************************************************************************************************");
            PrintE();

        }

        public void PrintE()
        {
            Thread.Sleep(300);
            Console.WriteLine("");

        }
    }
}
