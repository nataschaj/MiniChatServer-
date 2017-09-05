using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnEchoClientOPG
{
    class Program
    {
        static void Main(string[] args)
        {
            //In Main create an object of your Client-class and call the method 'Start()'.
            Client client = new Client();
            client.Start();

            Console.ReadLine();
        }
    }
}
